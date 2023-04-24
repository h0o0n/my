using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace HellWorld2
{
    class MainWindow : Application
    {
        [STAThread]
        public static void Main()
        {
            MainWindow app = new MainWindow();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Window mainWindow = new Window();   
            mainWindow.Title = "WPF Sample(Main)";
            mainWindow.MouseDown += WinMouseDown;
            mainWindow.Show();

            for(int i=0; i<2; i++)
            {
                Window win = new Window();
                win.Title = "Extra Window No." + (i+1);
                win.Show();
            }
        }

        void WinMouseDown(object sender, MouseEventArgs e)
        {
            Window win = new Window();
            win.Title = "Model Dialog Box";
            win.Width = 400; win.Height = 200;

            Button b = new Button();
            b.Content = "Click Me!";
            b.Click += Button_Click;  

            win.Content = b;
            win.ShowDialog();

        }

        void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Click!", sender.ToString());
        }
    }
}
