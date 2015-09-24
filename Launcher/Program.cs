using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Globalization;
using System.IO;
using AuthLogic;
using System.Windows;

namespace Launcher
{
    public class Program : System.Windows.Application
    {
        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;

#line 5 "..\..\App.xaml"
            

#line default
#line hidden
            System.Uri resourceLocater = new System.Uri("/Launcher;component/app.xaml", System.UriKind.Relative);

#line 1 "..\..\App.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
//#line hidden
        }
        public static AuthWindow aw;
        public static RegWindow rw;
        public static MainWindow mw;
        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [System.STAThreadAttribute()]
        //[System.Diagnostics.DebuggerNonUserCodeAttribute()]
        //[System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public static void Main()
        {
            Program app = new Program();
            app.InitializeComponent();
            // Launcher.App app = new Launcher.App();
            // app.InitializeComponent();
            // app.Run();
            
            aw = new AuthWindow();
            rw = new RegWindow();
            mw = new MainWindow();
            Auth auth = new Auth();
            IMessageService service = new MessageService();
            MainPresenter mainPresenter = new MainPresenter(auth, aw, service, rw, mw);

            app.Run(mw);
        }
       
    }
    
}
