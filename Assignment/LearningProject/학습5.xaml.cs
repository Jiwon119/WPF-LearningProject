using System.Data.Entity;
using System.Windows.Controls;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Collections.Generic;
using System;



namespace LearningProject
{


    /// <summary>
    /// 학습5.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class 학습5 : UserControl
    {

        public 학습5()
        {
            InitializeComponent();
            InfoList.ItemsSource = GetData();
            penel.Children.Add(new 학습5_상세정보("", "", "", "", 0));

        }
        public List<Info> GetData()
        {
            List<Info> list = new List<Info>();

            using (User ui = new User())
            {
                var OraLINQ1 = from e in ui.INFO
                               select e;
                foreach (var a in OraLINQ1)
                {
                    list.Add(new Info()
                    {
                        Name = a.USER_NAME,
                        Phon = a.USER_PHON,
                        Area = a.USER_AREA,
                        CreDate = a.CRE_DATE.ToString(),
                        ID = a.USER_ID
                    });
                }
            }
            return list;
        }

        private void Change(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 0)
                return;
            if (sender == InfoList)
            {
                Info info = e.AddedItems[0] as Info;
                penel.Children.Clear();
                penel.Children.Add(new 학습5_상세정보(info.Name, info.Phon, info.Area, info.CreDate, info.ID));
            }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            InfoList.ItemsSource = GetData();
        }
    }

    public class Info
    {
        public string Name { get; set; }
        public string Phon { get; set; }
        public string Area { get; set; }
        public string CreDate { get; set; }
        public int ID { get; set; }
    }
}
