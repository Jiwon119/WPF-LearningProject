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
    /// News_List.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class News_List : UserControl
    {
        public string BtnName;
        public List<string> Imglist = new List<string>();
        public List<string> Textlist = new List<string>();

        public News_List(string Btn)
        {
            InitializeComponent();

            BtnName = Btn;
            SetData(BtnName);
        }

        public void SetData(string BtnName)
        {
            switch (BtnName)
            {
                case "HotNews":
                    Imglist.Add("HotNews/1.jpg");
                    Imglist.Add("HotNews/2.jpg");
                    Imglist.Add("HotNews/3.jpg");
                    Imglist.Add("HotNews/4.jpg");

                    Textlist.Add("오픈월드 신작 '타워 오브 판타지', 11일 정식 출시\r\n게임뉴스");
                    Textlist.Add("넥슨게임즈 '퍼스트 디센던트' 신규 ..\r\n게임뉴스");
                    Textlist.Add("'대항해시대 오리진' 8월 23일 출시\r\n게임뉴스");
                    Textlist.Add("넥슨-크래프톤, 유럽 최대 게임 게임..\r\n게임뉴스");

                    SetPage(Imglist, Textlist);
                    break;

                case "IssueCheck":
                    Imglist.Add("IssueCheck/1.jpg");
                    Imglist.Add("IssueCheck/2.jpg");
                    Imglist.Add("IssueCheck/3.jpg");
                    Imglist.Add("IssueCheck/4.jpg");

                    Textlist.Add("이상헌 의원 \"프로모션 계정 선제조치 권고\"\r\n게임뉴스");
                    Textlist.Add("조승래 의원 \"윤 대통령, 게임 공약..\r\n게임뉴스");
                    Textlist.Add("2022 롤드컵, 9월 29일 개막...LCK 시..\r\n게임뉴스");
                    Textlist.Add("고가 아이템 대거 풀린 카스 온라인,..\r\n게임뉴스");

                    SetPage(Imglist, Textlist);
                    break;

                case "Trend":
                    Imglist.Add("Trend/1.png");
                    Imglist.Add("Trend/2.jpg");
                    Imglist.Add("Trend/3.png");
                    Imglist.Add("Trend/4.png");

                    Textlist.Add("\"신작 성과 기대치 미흡\" 넷마블 2분기 영업손실 347억 원 기록\r\n게임뉴스");
                    Textlist.Add("네오위즈 2022년 2분기 당기순이익 2..\r\n게임뉴스");
                    Textlist.Add("데브시스터즈 2분기 매출 533억 원, ..\r\n게임뉴스");
                    Textlist.Add("펄어비스 \"붉은사막, 파트너사에 검증.. \r\n게임뉴스");

                    SetPage(Imglist, Textlist);
                    break;

                case "Metabus":
                    Imglist.Add("Metabus/1.jpg");
                    Imglist.Add("Metabus/2.jpg");
                    Imglist.Add("Metabus/3.png");
                    Imglist.Add("Metabus/4.jpg");

                    Textlist.Add("\"위믹스, 3년이면 스팀 넘어서는 블록체인 플랫폼 된다\"\r\n게임뉴스");
                    Textlist.Add("핸드 트래킹, 이제 스마트폰으로도 된.. \r\n게임뉴스");
                    Textlist.Add("지금 살까? 메타 퀘스트2 8월부터 10..\r\n게임뉴스");
                    Textlist.Add("'PS VR2', 외부 카메라에 방송 기능 ..\r\n게임뉴스");

                    SetPage(Imglist, Textlist);
                    break;

                case "NewVideo":
                    Imglist.Add("NewVideo/1.png");
                    Imglist.Add("NewVideo/2.png");
                    Imglist.Add("NewVideo/3.jpg");
                    Imglist.Add("NewVideo/4.png");

                    Textlist.Add("'폴가이즈'에 바람돌이 소닉이 찾아왔다\r\n동영상");
                    Textlist.Add("이브 온라인 공식 플랫폼 eveonline...\r\n동영상");
                    Textlist.Add("내가 고든 프리맨? VR로 재탄생한 '하.. \r\n동영상");
                    Textlist.Add("롤러스케이팅 액션 '롤러드롬', 개발..\r\n동영상");

                    SetPage(Imglist, Textlist);
                    break;

                case "Cospre":
                    Imglist.Add("Cospre/1.jpg");
                    Imglist.Add("Cospre/2.jpg");
                    Imglist.Add("Cospre/3.jpg");
                    Imglist.Add("Cospre/4.jpg");

                    Textlist.Add("카케구루이 - 쟈바미 유메코 外\r\n에이크라운 - 아자");
                    Textlist.Add("승리의 여신: 니케 - 앨리스\r\nVVCOS - 자몽");
                    Textlist.Add("페이트/그랜드 오더 - 슈텐도지\r\n에이크라운 - 햇냥");
                    Textlist.Add("명일방주 - 샤이닝\r\n에이크라운 - 웰");

                    SetPage(Imglist, Textlist);
                    break;

                case "Forum":
                    Imglist.Add("Forum/1.jpg");
                    Imglist.Add("Forum/2.jpg");
                    Imglist.Add("Forum/3.jpg");
                    Imglist.Add("Forum/4.jpg");

                    Textlist.Add("생존자 여러분을 환영합니다!\r\n이터널 리턴 루미아 썸머 카페 풍경기\r\n이터널 리턴");
                    Textlist.Add("이 맛은 늘 먹던 니폰이치의 맛...에.. \r\n리뷰");
                    Textlist.Add("단 1킬 차이, 기적적인 우승 차지한 ..\r\n이터널 리턴");
                    Textlist.Add("혁신이 아닌 훌륭한 '확장', 선브레이..\r\n리뷰");

                    SetPage(Imglist, Textlist);
                    break;

                default:
                    Imglist.Add("HotNews/1.jpg");
                    Imglist.Add("HotNews/2.jpg");
                    Imglist.Add("HotNews/3.jpg");
                    Imglist.Add("HotNews/4.jpg");

                    Textlist.Add("오픈월드 신작 '타워 오브 판타지', 11일 정식 출시\r\n게임뉴스");
                    Textlist.Add("넥슨게임즈 '퍼스트 디센던트' 신규 ..\r\n게임뉴스");
                    Textlist.Add("'대항해시대 오리진' 8월 23일 출시\r\n게임뉴스");
                    Textlist.Add("넥슨-크래프톤, 유럽 최대 게임 게임..\r\n게임뉴스");

                    SetPage(Imglist, Textlist);

                    break;

            }

        }

        public void SetPage(List<string> img, List<string> text)
        {
            List<string> uriFullString = new List<string>();

            List<BitmapImage> bit = new List<BitmapImage>();

            foreach (string item in img)
            {
                uriFullString.Add("C:/Users/KimJiwon/source/repos/inven/inven/img/UC3/" + item);
            }

            for (int i = 0; i < 4; i++)
            {
                Uri uri = new Uri(uriFullString[i]);
                BitmapImage bitmapImage = new BitmapImage(uri);
                bit.Add(bitmapImage);
            }

            Img_1.Source = bit[0];
            Img_2.Source = bit[1];
            Img_3.Source = bit[2];
            Img_4.Source = bit[3];

            Content_1.Text = text[0];
            Content_2.Text = text[1];
            Content_3.Text = text[2];
            Content_4.Text = text[3];

        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button con = e.Source as Button;
            string buttonName = BtnName + "_" + con.Name;
            con.Name = buttonName;
            ((MainWindow)System.Windows.Application.Current.MainWindow).goUrl_click(sender, e);


        }

    }
}
