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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void proceed_Click(object sender, RoutedEventArgs e)
        {
            if (Process.GetProcessesByName("QboxClient").Length > 0)
            {
                MessageBox.Show("Waiting for Qbox Client to be exited");
            }
            else {
                globals.QboxAppState = false;
                processes p = new processes();
                p.run();
                this.Close();
            }
            /*
            Process[] proc = Process.GetProcessesByName("QboxClient");
            proc[0].WaitForExit();
            */
        }
    }
}
