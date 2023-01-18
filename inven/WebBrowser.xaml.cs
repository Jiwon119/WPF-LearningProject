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

namespace inven
{
    /// <summary>
    /// WebBrowser.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WebBrowser : UserControl
    {
        public WebBrowser(string address)
        {
            InitializeComponent();
            browser.Address = address;
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newWindow = new MainWindow();
            Application.Current.MainWindow = newWindow;

            newWindow.Show();

            //((MainWindow)System.Windows.Application.Current.MainWindow).Refresh();

        }
    }
}
