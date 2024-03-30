using System.Windows;

namespace LearningProject
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            panel_selectList.Visibility = Visibility.Collapsed;
            grid1.Children.Add(new 김지원());
        }

    }
}
