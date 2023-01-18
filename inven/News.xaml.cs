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
    /// UC3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class News : UserControl
    {
        public News()
        {
            InitializeComponent();
            News_Content.Children.Clear();
            News_Content.Children.Add(new News_List(""));
        }

        void OnMouseEnterHandler(object sender, MouseEventArgs e)
        {
            Button con = e.Source as Button;

            News_Content.Children.Clear();
            News_Content.Children.Add(new News_List(con.Name));
        }
    }
}
