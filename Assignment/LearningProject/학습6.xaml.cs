using System.Collections.Generic;
using System.Windows.Controls;

namespace LearningProject
{
    /// <summary>
    /// 학습6.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class 학습6 : UserControl
    {
        public 학습6()
        {
            InitializeComponent();

            List<Info6> InfoList = new List<Info6>();
            InfoList.Add(new Info6 { Name = "이름1", Phon = "010-1234-0001", Area = "안양" });
            InfoList.Add(new Info6 { Name = "이름2", Phon = "010-1234-0002", Area = "의왕" });
            InfoList.Add(new Info6 { Name = "이름3", Phon = "010-1234-0003", Area = "수원" });
            InfoList.Add(new Info6 { Name = "이름4", Phon = "010-1234-0004", Area = "용인" });

            InfoListView.ItemsSource = InfoList;
        }
    }

    public class Info6
    {
        public string Name { get; set; }
        public string Area { get; set; }
        public string Phon { get; set; }
    }

}
