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
    /// Interaction logic for Window1.xaml
    /// </summary>
    /// 

    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, RoutedEventArgs e)
        {
            /*
            Process p = new Process();
            p.StartInfo.FileName = "rundll32.exe"; //Run the uninstall executable with the uninstall string
            p.StartInfo.Arguments = "dfshim.dll,ShArpMaintain QBoxClient.application, Culture=en, PublicKeyToken=c7c5fb3875c039a3, processorArchitecture=x86";
            p.Start();
            p.WaitForExit();
            */
            if (Process.GetProcessesByName("QboxClient").Length > 0)
            {
                /*
                Process[] proc = Process.GetProcessesByName("QboxClient");
                proc[0].WaitForExit();
                MessageBox.Show("Please Exit Qbox before uninstalling.");
                */
                Window4 exitQboxWindow = new Window4();
                exitQboxWindow.Show();
                this.Close();
            }
            else { 
                globals.QboxAppState = false;
                processes p = new processes();
                p.run();
                this.Close();
            }
            /*
            if (Process.GetProcessesByName("QboxClient").Length > 0)
            {
                MessageBox.Show("Qbox is still running");
            }
            */
                /*
                processes p = new processes();
                p.run();
                
            Process p = new Process();
            p.StartInfo.FileName = "rundll32.exe"; //uninstall executable with the uninstall string
            p.StartInfo.Arguments = "dfshim.dll,ShArpMaintain QBoxClient.application, Culture=en, PublicKeyToken=c7c5fb3875c039a3, processorArchitecture=x86";
            p.Start(); //Run windows uninstall
            p.WaitForExit();
            */
            /*
            if (System.IO.File.Exists(@"C:\Users\"+ globals.user + @"\Desktop\Qbox Client.appref-ms"))
            {
                MessageBox.Show("Please close all files using Qbox to uninstall and try again"); //if the uninstall did not work, it resets to the main window
                //Application.Current.MainWindow.Show();
                Application.Current.Shutdown();
            }
            */
        }

        private void no_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
        }
    }
}
