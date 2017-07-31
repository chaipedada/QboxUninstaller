using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;

namespace UninstallerTest
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, RoutedEventArgs e)
        {
            if (Process.GetProcessesByName("QboxClient").Length > 0)
            {
                Window4 exitQboxWindow = new Window4();
                exitQboxWindow.Show();
                this.Close();
                /*
                foreach (Process proc in Process.GetProcessesByName("QboxClient"))
                {
                    proc.Kill();
                }
                */
            }
            else
            {
                globals.QboxAppState = false;
                processes p = new processes();
                p.run();
                this.Close();
            }
            /*
            Process p = new Process();
            p.StartInfo.FileName = "rundll32.exe"; //uninstall executable with the uninstall string
            p.StartInfo.Arguments = "dfshim.dll,ShArpMaintain QBoxClient.application, Culture=en, PublicKeyToken=c7c5fb3875c039a3, processorArchitecture=x86";
            p.Start(); //Run windows uninstall
            p.WaitForExit(); 
            if (System.IO.File.Exists(@"C:\Users\Chaitanya\Desktop\Qbox Client.appref-ms"))
            {
                MessageBox.Show("Please close all files using Qbox to uninstall and try again"); //if the uninstall fails, resets to the main window
                Application.Current.MainWindow.Show();
                this.Close();
                return;
            }
            string[] s = System.IO.Directory.GetDirectories(@"C:\Users\", "*"); //Delete the system data files
            foreach (string str in s)
            {
                string test = str + @"\AppData\Local\CoralTree"; //adds the rest of the path to the user found via wildcard
                if (System.IO.Directory.Exists(@test))
                {
                    try
                    {
                        System.IO.Directory.Delete(@test, true);
                    }

                    catch (System.IO.IOException a)
                    {
                        Console.WriteLine(a.Message);
                    }
                }
            }
            
            Window3 openWindow = new Window3();
            openWindow.Show();
            this.Close();
            */
        }

        private void no_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
        }
        
    }
}
