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
    /// UC2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class HotIssue : UserControl
    {
        public HotIssue()
        {
            InitializeComponent();
        }

        void OnMouseEnterHandler(object sender, MouseEventArgs e)
        {
            Label con = e.Source as Label;

            if (Label1.Foreground == Brushes.White || Label2.Foreground == Brushes.White
                || Label3.Foreground == Brushes.White || Label4.Foreground == Brushes.White
                || Label5.Foreground == Brushes.White || Label6.Foreground == Brushes.White
                || Label7.Foreground == Brushes.White)
            {
                Label1.Foreground = Brushes.Gray;
                Label2.Foreground = Brushes.Gray;
                Label3.Foreground = Brushes.Gray;
                Label4.Foreground = Brushes.Gray;
                Label5.Foreground = Brushes.Gray;
                Label6.Foreground = Brushes.Gray;
                Label7.Foreground = Brushes.Gray;
            }
            con.Foreground = Brushes.White;

            switch (con.Name)
            {
                case "Label1":
                    setPage("C:/Users/KimJiwon/source/repos/inven/inven/img/UC2/1.jpg", "3주년을 앞두고 1:1 거래 추가를 예고한 V4, 또다른 비전은?");
                    break;
                case "Label2":
                    setPage("C:/Users/KimJiwon/source/repos/inven/inven/img/UC2/2.jpg", "[리뷰] 더 넓어진 뉴욕, 더 화사해진 거미 남자");
                    break;
                case "Label3":
                    setPage("C:/Users/KimJiwon/source/repos/inven/inven/img/UC2/3.jpg", "[인터뷰] 타워 오브 판타지, 국내 출시 전 궁금한 점 16가지");
                    break;
                case "Label4":
                    setPage("C:/Users/KimJiwon/source/repos/inven/inven/img/UC2/4.webp", "니케, 1차 CBT 체험기");
                    break;
                case "Label5":
                    setPage("C:/Users/KimJiwon/source/repos/inven/inven/img/UC2/5.jpg", "몬헌 선브레이크, 신규 몬스터 4종과 '괴이 연성' 나온다.");
                    break;
                case "Label6":
                    setPage("C:/Users/KimJiwon/source/repos/inven/inven/img/UC2/6.jpg", "한국 정식 서비스는 8월23일! 대항해시대 오리진 온랑니 간담회");
                    break;
                case "Label7":
                    setPage("C:/Users/KimJiwon/source/repos/inven/inven/img/UC2/7.jpg", "[순위분석]신규 스킨, 이벤트로 식을 틈 없는 '폴가이즈'의 열기");
                    break;

            }
        }

        public void setPage(string Background, string text)
        {
            Uri uri = new Uri(Background);

            BitmapImage bitmapImage = new BitmapImage(uri);
            ImageBrush imageBrush = new ImageBrush();
            
            imageBrush.ImageSource = bitmapImage;
            panel.Background = imageBrush;
            LabelText.Content = text;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button con = e.Source as Button;
            con.Name = "Lable1";
            if (Label1.Foreground == Brushes.White)
            {
                con.Name = "HotIssue_Lable1";
                ((MainWindow)System.Windows.Application.Current.MainWindow).goUrl_click(sender, e);
            }
            else if (Label2.Foreground == Brushes.White)
            {
                con.Name = "HotIssue_Lable2";
                ((MainWindow)System.Windows.Application.Current.MainWindow).goUrl_click(sender, e);

            }
            else if (Label3.Foreground == Brushes.White)
            {
                con.Name = "HotIssue_Lable3";
                ((MainWindow)System.Windows.Application.Current.MainWindow).goUrl_click(sender, e);

            }
            else if (Label4.Foreground == Brushes.White)
            {
                con.Name = "HotIssue_Lable4";
                ((MainWindow)System.Windows.Application.Current.MainWindow).goUrl_click(sender, e);

            }
            else if (Label5.Foreground == Brushes.White)
            {
                con.Name = "HotIssue_Lable5";
                ((MainWindow)System.Windows.Application.Current.MainWindow).goUrl_click(sender, e);

            }
            else if (Label6.Foreground == Brushes.White)
            {
                con.Name = "HotIssue_Lable6";
                ((MainWindow)System.Windows.Application.Current.MainWindow).goUrl_click(sender, e);

            }
            else if (Label7.Foreground == Brushes.White)
            {
                con.Name = "HotIssue_Lable7";
                ((MainWindow)System.Windows.Application.Current.MainWindow).goUrl_click(sender, e);

            }

            //new System.Linq.SystemCore_EnumerableDebugView(((System.Windows.Controls.Panel)((System.Windows.Controls.ContentControl)e.Source).Content).Children).Items[0]

        }
    }
}