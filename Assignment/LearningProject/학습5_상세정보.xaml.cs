using System.Data.Entity;
using System.Windows;
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
    /// 학습5_상세정보.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class 학습5_상세정보 : UserControl
    {
        public int SelectID;

        public 학습5_상세정보(string name, string phon, string area, string datetime, int id)
        {
            InitializeComponent();
            Tname.Text = name;
            Tphon.Text = phon;
            Tarea.Text = area;
            Tdate.Content = datetime.ToString();
            SelectID = id;
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Info> list = new List<Info>();

            if (Tname.Text == "" || Tphon.Text == "" || Tarea.Text == "")
            {
                MessageBox.Show("정보를 모두 입력해주세요.");
            }
            else
            {
                using (User ui = new User())
                {
                    var create = ui.Set<INFO>();

                    create.Add(new INFO
                    {

                        USER_NAME = Tname.Text,
                        USER_PHON = Tphon.Text,
                        USER_AREA = Tarea.Text,
                        CRE_DATE = DateTime.Now
                    });

                    ui.SaveChanges();

                    MessageBox.Show(Tname.Text + "님의 정보가 생성되었습니다.");

                    
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (User ui = new User())
            {
                var OraLINQ1 = (from u in ui.INFO
                               where u.USER_ID == SelectID
                               select u).ToList();

                OraLINQ1[0].USER_NAME = Tname.Text;
                OraLINQ1[0].USER_PHON = Tphon.Text;
                OraLINQ1[0].USER_AREA = Tarea.Text;

                ui.SaveChanges();

                MessageBox.Show(Tname.Text + "님의 정보가 갱신되었습니다.");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            using (User ui = new User())
            {
                ui.INFO.Remove(ui.INFO.Where(d => d.USER_ID == SelectID).First());
                ui.SaveChanges();

                MessageBox.Show(Tname.Text + "님의 정보가 삭제되었습니다.");
            }
        }



        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    using (User ui = new User())
        //    {
        //        var delete = ui.Set<INFO>();

        //        create.Add(new INFO
        //        {
        //            //USER_NAME = Tname.Text,
        //            //USER_PHON = Tphon.Text,
        //            //USER_AREA = Tarea.Text,
        //            //CRE_DATE = Convert.ToDateTime(Tdate.Text)

        //            USER_NAME = Tname.Text,
        //            USER_PHON = Tphon.Text,
        //            USER_AREA = Tarea.Text,
        //            CRE_DATE = DateTime.Now
        //        });

        //        ui.SaveChanges();

        //        MessageBox.Show(Tname.Text + "님의 정보가 생성되었습니다.");
        //    }
        //}
    }
}

        //public Change(string name, string phon, string area, string datetime)
        //{
        //    Tname.Text = name;
        //    Tphon.Text = phon;
        //    Tarea.Text = area;
        //    Tdate.Text = datetime.ToString();
        //}


        //public List<Info> DataPassing()
        //{
        //    List<Info> list = new List<Info>();

        //    list.Add(new Info()
        //    {
        //        Name = Tname.Text,
        //        Phon = Tphon.Text,
        //        Area = Tarea.Text,
        //        CreDate = Tdate.
        //    });

        //    return list;
        //}