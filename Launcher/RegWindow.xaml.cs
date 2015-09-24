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
    public interface IRegWindow
    {
        string login { get; }
        string pass1 { get; }
        string pass2 { get; }
        string key { get; }
        int regProgresBarValue { set; }
        double left { get; set; }
        double top { get; set; }
        
        Point Position { get; set; }
        void hide();
        void showDialog();
        event EventHandler OkButtonClick;
        event EventHandler BackButtonClick;
    }
    public partial class RegWindow : Window, IRegWindow
	{
		public RegWindow()
		{
			this.InitializeComponent();

            OkButton.Click += new RoutedEventHandler(OkButton_Click);
            BackButton.Click += new RoutedEventHandler(BackButton_Click);
		}
        void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (BackButtonClick != null) BackButtonClick(this, EventArgs.Empty);
        }
        void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (OkButtonClick != null) OkButtonClick(this, EventArgs.Empty);
        }
        public string login
        {
            get { return LoginTextBox.Text; }
        }
        public string pass1
        {
            get { return PasswordTextBox1.Password; }
        }
        public string pass2
        {
            get { return PasswordTextBox2.Password; }
        }
        public string key
        {
            get { return PasswordTextBox2.Password; }
        }
        public int regProgresBarValue
        {
            set { RegProgresBar.Value = value; }
        }
        public Point Position
        {
            get { return this.Position; }
            set { this.Left = value.X - this.Width-Program.aw.Width; this.Top = value.Y-this.Height; }
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
        public void showDialog()
        {
            this.ShowDialog();
        }
        public event EventHandler OkButtonClick;
        public event EventHandler BackButtonClick;

        public void hide()
        {
            this.Hide();
        }

        
        
        
	}
}