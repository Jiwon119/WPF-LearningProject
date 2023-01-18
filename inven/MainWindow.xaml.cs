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
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CenterTopAd_Area.Children.Clear();
            CenterTopAd_Area.Children.Add(new CenterTopAd());

            HotIssue_Area.Children.Clear();
            HotIssue_Area.Children.Add(new HotIssue());

            News_Area.Children.Clear();
            News_Area.Children.Add(new News());

            CenterTopRightAd_Area.Children.Clear();
            CenterTopRightAd_Area.Children.Add(new CenterTopRightAd());

            HotSite_Area.Children.Clear();
            HotSite_Area.Children.Add(new HotSite());

            CenterBottomRightAd_Area.Children.Clear();
            CenterBottomRightAd_Area.Children.Add(new CenterBottomRightAd());
        }

        public void goUrl_click(object sender, RoutedEventArgs e)
        {

            //MainWin.Children.Clear();
            //MainWin.Children.Add(new WebBrowser(GetAddress(((Button)sender).Name)));

            MainWin.Visibility = Visibility.Collapsed;
            browserPanel.Visibility = Visibility.Visible;
            browser.Address = GetAddress(((Button)sender).Name);


            //browser.Address = address;
            //switch (((Button)sender).Name)
            //{
            //    case
            //}
        }

        public string GetAddress(string name)
        {
            Dictionary<string, string> address = new Dictionary<string, string>()
            {
                { "TopAd", "https://lineagew.plaync.com/kr/update/2022/220726_update?locale=ko"},
                { "TopBar_MobileInven", "https://m.inven.co.kr/" },
                { "TopBar_webzine", "https://www.inven.co.kr/" },
                { "TopBar_console", "https://console.inven.co.kr/" },
                { "TopBar_it", "https://it.inven.co.kr/" },
                { "TopBar_indie", "https://indie.inven.co.kr/" },
                { "TopBar_esports", "https://esports.inven.co.kr/" },
                { "TopBar_vr", "https://vr.inven.co.kr/" },
                { "TopBar_pick", "https://pick.inven.co.kr/" },
                { "TopBar_friends", "https://friends.inven.co.kr/" },
                { "TopBar_enchant", "https://www.enchantenter.co.kr/" },
                { "TopBar_imart", "https://imart.inven.co.kr/" },
                { "TopBar_marketinven", "https://www.marketinven.com/" },
                { "TopBar_join", "https://member.inven.co.kr/user/aquarius/join/" },
                { "TopBar_login", "https://member.inven.co.kr/user/scorpio/mlogin" },
                { "Header_News", "https://www.inven.co.kr/webzine/news/" },
                { "Header_Platform", "https://www.inven.co.kr/webzine/platform/?nplatform=1" },
                { "Header_Review", "https://www.inven.co.kr/webzine/news/?sclass=12&platform=gamereview" },
                { "Header_Special", "https://www.inven.co.kr/webzine/special/gameshow.php" },
                { "Header_Gamer", "https://www.inven.co.kr/webzine/zone/gamer/" },
                { "Header_IGC", "https://igc.inven.co.kr/" },
                { "Header_Youtube", "https://www.youtube.com/user/InvenMovieA/featured" },
                { "Header_Facebook", "https://www.facebook.com/invennews/" },
                { "Header_Twitter", "https://twitter.com/inventeam" },
                { "Header_Metacritic", "https://www.metacritic.com/publication/inven?filter=games" },
                { "Header_Opencritic", "https://opencritic.com/outlet/805/inven" },
                //{ "Header_Search", "" },
                { "SideLeft_Ad", "https://lineage.plaync.com/promo/lineage/220810_season?utm_source=inven&utm_medium=display&utm_campaign=2022_lineage1_3q&utm_content=banner__pc-backskin_season" },
                { "SideRight_Ad", "https://lineage.plaync.com/promo/lineage/220810_season?utm_source=inven&utm_medium=display&utm_campaign=2022_lineage1_3q&utm_content=banner__pc-backskin_season" },
                { "CenterTop_Ad", "https://summonerswar.com/ko/chronicles/pre_register?r=p76&utm_source=inven&utm_medium=da&utm_campaign=phase3_top&utm_content=releasedateA" },
                { "CenterTopRight_Ad", "https://summonerswar.com/ko/chronicles/pcDownload?utm_source=DA&utm_medium=display&utm_campaign=220815-kr-all-traffic&utm_content=aug-da-inven&shortlink=tcfroume&c=hq-220816-kr-DA_inven&pid=DA&af_xp=app&af_channel=inven" },
                { "CenterBottomRight_Ad1", "https://www.bigameshow.com/" },
                { "CenterBottomRight_Ad2", "https://minimap.net/rating/platform" },
                { "HotIssue_Lable1", "https://www.inven.co.kr/webzine/news/?news=275209" },
                { "HotIssue_Lable2", "https://www.inven.co.kr/webzine/news/?news=275122" },
                { "HotIssue_Lable3", "https://www.inven.co.kr/webzine/news/?news=275029" },
                { "HotIssue_Lable4", "https://www.inven.co.kr/webzine/news/?news=275122" },
                { "HotIssue_Lable5", "https://www.inven.co.kr/webzine/news/?news=275153" },
                { "HotIssue_Lable6", "https://www.inven.co.kr/webzine/news/?news=275119" },
                { "HotIssue_Lable7", "https://www.inven.co.kr/webzine/news/?news=275082" },
                { "HotSite_Blackdesert", "https://black.inven.co.kr/" },
                { "HotSite_Diablo", "https://diablo2.inven.co.kr/" },
                { "HotSite_Lostark", "https://lostark.inven.co.kr/" },
                { "HotSite_LeagueOfLegends", "https://lol.inven.co.kr/" },
                { "HotSite_LineageM", "https://lineagem.inven.co.kr/" },
                { "HotSite_Monsterhunter", "https://mhf.inven.co.kr/" },
                { "HotSite_Maplestory", "https://maple.inven.co.kr/" },
                { "HotSite_Umamusume", "https://uma.inven.co.kr/" },
                { "HotSite_WoW", "https://wow.inven.co.kr/" },
                { "HotSite_FifaOnline4", "https://fifaonline4.inven.co.kr/" },
                { "HotSite_senaRevolution", "https://skr.inven.co.kr/" },
                { "HotSite_TowerOfFantasy", "https://tof.inven.co.kr/" },
                { "HotNews_News1", "https://www.inven.co.kr/webzine/news/?news=275217" },
                { "HotNews_News2", "https://www.inven.co.kr/webzine/news/?news=275100" },
                { "HotNews_News3", "https://www.inven.co.kr/webzine/news/?news=275117" },
                { "HotNews_News4", "https://minimap.net/magazine/newsletter-0810" },
                { "IssueCheck_News1", "https://www.inven.co.kr/webzine/news/?news=275069" },
                { "IssueCheck_News2", "https://www.inven.co.kr/webzine/news/?news=274694" },
                { "IssueCheck_News3", "https://www.inven.co.kr/webzine/news/?news=274370" },
                { "IssueCheck_News4", "https://www.inven.co.kr/webzine/news/?news=274198" },
                { "Trend_News1", "https://www.inven.co.kr/webzine/news/?news=275246" },
                { "Trend_News2", "https://www.inven.co.kr/webzine/news/?news=275239" },
                { "Trend_News3", "https://www.inven.co.kr/webzine/news/?news=275238" },
                { "Trend_News4", "https://www.inven.co.kr/webzine/news/?news=275216" },
                { "Metabus_News1", "https://www.inven.co.kr/webzine/news/?news=275120" },
                { "Metabus_News2", "https://www.inven.co.kr/webzine/news/?news=274585" },
                { "Metabus_News3", "https://www.inven.co.kr/webzine/news/?news=274570" },
                { "Metabus_News4", "https://www.inven.co.kr/webzine/news/?news=274569" },
                { "NewVideo_News1", "https://www.inven.co.kr/webzine/news/?news=275274" },
                { "NewVideo_News2", "https://www.inven.co.kr/webzine/news/?news=275219" },
                { "NewVideo_News3", "https://www.inven.co.kr/webzine/news/?news=275175" },
                { "NewVideo_News4", "https://www.inven.co.kr/webzine/news/?news=275164" },
                { "Cospre_News1", "https://www.inven.co.kr/board/webzine/2898/2185" },
                { "Cospre_News2", "https://www.inven.co.kr/board/webzine/2898/2182" },
                { "Cospre_News3", "https://www.inven.co.kr/board/webzine/2898/2183" },
                { "Cospre_News4", "https://www.inven.co.kr/board/webzine/2898/2182" },
                {"Forum_News1", "https://www.inven.co.kr/webzine/news/?news=274480&site=er" },
                {"Forum_News2", "https://www.inven.co.kr/webzine/news/?news=274273" },
                {"Forum_News3", "https://www.inven.co.kr/webzine/news/?news=274195&site=er" },
                {"Forum_News4", "https://www.inven.co.kr/webzine/news/?news=273821" }
            };


            if (address.ContainsKey(name))
            {
                return address[name];
            }
            else
            {
                Application.Current.MainWindow.Show();
                return "";
            }

        }

        public void home_click(object sender, RoutedEventArgs e)
        {
            browserPanel.Visibility = Visibility.Collapsed;
            MainWin.Visibility = Visibility.Visible;
        }
    }
}
