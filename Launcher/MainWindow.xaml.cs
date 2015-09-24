using System;
using System.Collections.Generic;
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
    public interface IMainWindow
    {
        event EventHandler ToggleLogInClick; //mainPresenter
        event EventHandler Dota2lsButtonClick; //mainWindowPresenter
        event EventHandler AgeBotButtonClick;
        event EventHandler PerfectBotButtonClick;

        string toggleContent { set; }
    }
	public partial class MainWindow : Window,IMainWindow
	{
		public MainWindow()
		{
			this.InitializeComponent();

            ToggleLogIn.Click += ToggleLogIn_Click;
            Dota2lsButtonClick += MainWindow_Dota2lsButtonClick;
            AgeBotButtonClick += MainWindow_AgeBotButtonClick;
            PerfectBotButtonClick += MainWindow_PerfectBotButtonClick;
		}

        private void MainWindow_PerfectBotButtonClick(object sender, EventArgs e)
        {
            if (PerfectBotButtonClick != null) PerfectBotButtonClick(this, EventArgs.Empty);
        }

        private void MainWindow_AgeBotButtonClick(object sender, EventArgs e)
        {
            if (AgeBotButtonClick != null) AgeBotButtonClick(this, EventArgs.Empty);
        }

        private void MainWindow_Dota2lsButtonClick(object sender, EventArgs e)
        {
            if (Dota2lsButtonClick != null) Dota2lsButtonClick(this, EventArgs.Empty);
        }

        private void ToggleLogIn_Click(object sender, RoutedEventArgs e)
        { 
            if (ToggleLogInClick != null) ToggleLogInClick(this,EventArgs.Empty);
        }
        public event EventHandler ToggleLogInClick;
        public event EventHandler Dota2lsButtonClick;
        public event EventHandler AgeBotButtonClick;
        public event EventHandler PerfectBotButtonClick;
        public string toggleContent
        {
            set { ToggleLogIn.Content = value; }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ExitButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

    }
}