using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Launcher
{
    public interface IAuthWindow
    {
        string login { get; }
        string password { get; }
        int progressBarValue { set; }
        void progressBarVisible(bool visible);
        event EventHandler logInButtonClick;
        event EventHandler singUpButtonClick;
        void hide();
        void showDialog();
        Point Position { get; set; }
        double left { get; set; }
        double top { get; set; }

    }

    public partial class AuthWindow : Window , IAuthWindow
    {
       
        public AuthWindow()
        {
            InitializeComponent();
            LogInButton.Click += new RoutedEventHandler(LogInButton_Click);
            SingUpButton.Click += new RoutedEventHandler(SingUpButton_Click);
            
        }
        void SingUpButton_Click(object sender, RoutedEventArgs e)
        {
            if (singUpButtonClick != null) singUpButtonClick(this, EventArgs.Empty);
        }
        void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            
                if (logInButtonClick!=null) logInButtonClick(this, RoutedEventArgs.Empty);
        }
        public string login
        {
            get { return LoginTextBox.Text; }
        }
        public string password
        {
            get { return PasswordTextBox.Password; }
        }
        public int progressBarValue
        {
            set { LoginProgressBar.Value = value; }
        }
        public void progressBarVisible(bool visible)
        {
            if (visible)
            {
                LoginProgressBar.Visibility = Visibility.Visible;
            }
            else { LoginProgressBar.Visibility = Visibility.Hidden; }
        }

        public event EventHandler logInButtonClick;
        public event EventHandler singUpButtonClick;
        public void hide() 
        { 
            this.Hide();
        }
        public void showDialog()
        {
            this.ShowDialog();
        }

        public Point Position
        {
            get { return this.Position; }
            set { this.Left = value.X-this.Width;this.Top = value.Y+10 ; }
        }
        public double left
        {
            get { return this.Left; }
            set { this.Left = value; }
        }
        public double top
        {
            get { return this.Top; }
            set { this.Top = value; }
        }
        private void ExitButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // System.Diagnostics.Process.GetCurrentProcess().Kill();
            this.Hide();
        }

        private void window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }


        
    }
}
