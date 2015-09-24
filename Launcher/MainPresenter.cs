using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using AuthLogic;
using Launcher_FTP;

namespace Launcher
{
    class MainPresenter
    {
        private readonly IAuth _authLogic;
        private readonly IAuthWindow _authWindow;
        private readonly IMessageService _service;
        private readonly IRegWindow _regWindow;
        private readonly IMainWindow _mainWindow;
        private readonly IFtpClient ftpClient;

        #region GetCursorPosition
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);
        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            //bool success = User32.GetCursorPos(out lpPoint);
            // if (!success)

            return lpPoint;
        }
        #endregion

        public MainPresenter(IAuth authLogic, IAuthWindow authWindow,IMessageService service , IRegWindow regWindow,IMainWindow mainWindow)
        {
            ///передача переменных в класс
            _authLogic = authLogic;
            _authWindow = authWindow;
            _service = service;
            _regWindow = regWindow;
            _mainWindow = mainWindow;

            _authWindow.logInButtonClick += new EventHandler(_authWindow_logInButtonClick); //Кнопка для проверки существующей пары логин\пароль
            _authWindow.singUpButtonClick += new EventHandler(_authWindow_singUpButtonClick); //кнопка для открытия окна регистриции
            _regWindow.OkButtonClick += new EventHandler(_regWindow_OkButtonClick);// кнопка завершения регистрации
            _regWindow.BackButtonClick += new EventHandler(_regWindow_BackButtonClick);//кнопка отмены регистрации
            _mainWindow.ToggleLogInClick += _mainWindow_ToggleLogInClick;//кнопка открытия окна авторизации (трей)
        }

        private void _mainWindow_ToggleLogInClick(object sender, EventArgs e)
        {
            int posX = Convert.ToInt32(GetCursorPosition().X);
            int posY = Convert.ToInt32(GetCursorPosition().Y);
            _authWindow.Position = new Point(posX, posY);
            _authWindow.showDialog();
        }

        void _regWindow_BackButtonClick(object sender, EventArgs e)
        {
           _regWindow.hide();
           _authWindow.showDialog();     
        }

        void _regWindow_OkButtonClick(object sender, EventArgs e)
        {
            if (_regWindow.pass1.Length > 6)
            {
                if (_regWindow.pass1 == _regWindow.pass2)
                {
                    _regWindow.regProgresBarValue = 0;
                    _authLogic.OpenConnection(@"Data Source=|DataDirectory|\Database1.sdf");
                    _regWindow.regProgresBarValue = 50;
                    _authLogic.AuthSingUp(_regWindow.login, _regWindow.pass1, _regWindow.key);
                    _authLogic.CloseConnection();
                    _regWindow.regProgresBarValue = 100;

                    _regWindow.hide();
                    _authWindow.showDialog();

                }
                else _service.ShowError("Пароли не совпадают");
            }
            else _service.ShowError("Пароль должен содержать больше 6 символов");
        }

        void _authWindow_singUpButtonClick(object sender, EventArgs e)
        {
           _authWindow.hide();
            _regWindow.left = _authWindow.left;
            _regWindow.top = _authWindow.top;
            _regWindow.showDialog();
            
        } 
        
        void _authWindow_logInButtonClick(object sender, EventArgs e)
        {
            
            _authWindow.progressBarValue = 0;
            _authWindow.progressBarVisible(true);
            _authLogic.OpenConnection(@"Data Source=|DataDirectory|\Database1.sdf");
            _authWindow.progressBarValue = 50;


            if (_authLogic.AuthLogIn(_authWindow.login, _authWindow.password))
            {
                _authWindow.progressBarValue = 100;

                _mainWindow.toggleContent = _authWindow.login;
                Program.aw.Hide();
                _authLogic.CloseConnection();

            }
            else _service.ShowError("Пользователь не найден");

            _authWindow.progressBarVisible(false);
        }
    }
}
