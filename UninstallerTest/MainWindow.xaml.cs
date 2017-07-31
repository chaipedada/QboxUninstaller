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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UninstallerTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            if (uninstallClient.IsChecked == true)
            {
                Window1 openWindow = new Window1(); //only uninstall Qbox Client program
                openWindow.Show();
            }
            if (uninstallAll.IsChecked == true)
            {
                globals.systemDataUninstall = true;
                Window2 openWindow = new Window2(); //uninstall Qbox Client program and system data files
                openWindow.Show();
            }
            this.Close();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
        }
    }
    
}
