using System.Windows;
using System.Windows.Controls;

namespace LearningProject
{
    /// <summary>
    /// 김지원.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class 김지원 : UserControl
    {
        public 김지원()
        {
            InitializeComponent();
            //button2.Click += (sender, e) =>
            //{
            //    MessageBox.Show("버튼 클릭");
            //};
        }


        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            col.Visibility = Visibility.Collapsed;
            grid1.Children.Add(new 학습1());
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            col.Visibility = Visibility.Collapsed;
            grid1.Children.Add(new 학습2());
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            col.Visibility = Visibility.Collapsed;
            grid1.Children.Add(new 학습3());
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            col.Visibility = Visibility.Collapsed;
            grid1.Children.Add(new 학습4());
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            col.Visibility = Visibility.Collapsed;
            grid1.Children.Add(new 학습5());
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            col.Visibility = Visibility.Collapsed;
            grid1.Children.Add(new 학습6());
        }
    }
}