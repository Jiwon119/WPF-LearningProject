using System.Windows;
using System.Windows.Controls;

namespace LearningProject
{
    /// <summary>
    /// 학습3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class 학습3 : UserControl
    {
        public 학습3()
        {
            InitializeComponent();
            button1.Click += (sender, e) =>
            {
                Button btn = sender as Button;
                MessageBox.Show($"{btn.Content} 버튼 클릭");
            };
        }
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show($"{btn.Content} 버튼 클릭");

        }

        private void init_Click(object sender, RoutedEventArgs e)
        {
            col.Visibility = Visibility.Collapsed;
            g.Children.Add(new 김지원());
        }
    }
}
