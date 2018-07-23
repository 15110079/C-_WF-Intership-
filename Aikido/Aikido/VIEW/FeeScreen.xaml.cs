using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Aikido.DAO;
using Aikido.BLO;
namespace Aikido.VIEW
{
    /// <summary>
    /// Interaction logic for FeeScreen.xaml
    /// </summary>
    public partial class FeeScreen : Window
    {
        ManageFee_BLO manageFee = new ManageFee_BLO();
        private List<bool> btnSelect = new List<bool>();
        private int i = 0;
        private int val = -3;

        public FeeScreen()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                btnSelect.Add(true);
            }
            btnSelect[2] = false;
            try
            {
                using (var dataContext = new AccessDB_DAO())
                {
                    Learn learn = new Learn();
                    learn.ID_Class = 1;
                    learn.RegisterNumber = 1;
                    learn.Fee_January = 100;
                    learn.Fee_February = 100;
                    learn.Fee_March = 100;
                    learn.Fee_April = 100;
                    learn.Fee_May = 100;
                    learn.Fee_June = 100;
                    learn.Fee_July = 100;
                    learn.Fee_August = 100;
                    learn.Fee_September = 100;
                    learn.Fee_October = 100;
                    learn.Fee_November = 100;
                    learn.Fee_December = 100;
                    learn.RegisterDay = DateTime.Now;
                    learn.Day_Create = DateTime.Now;
                    learn.Delete_Flag = false;
                    dataContext.Learns.Add(learn);
                    dataContext.SaveChanges();
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            //dgvFee.ItemsSource = manageFee.LoadFee();

            //List<Class> cmb= new List<Class>();
            //var cls = 
            
            //cmbClassName.ItemsSource = cmb;
        }

        private void btnDKHV_MouseEnter(object sender, MouseEventArgs e)
        {
            btnDKHVb.Background = Brushes.DarkBlue;
            btnDKHV.Background = Brushes.LightGray;
        }

        private void btnDKHV_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[0] == true)
            {
                btnDKHVb.Background = Brushes.White;
                btnDKHV.Background = Brushes.White;
            }
        }

        private void btnSearch_MouseEnter(object sender, MouseEventArgs e)
        {
            btnSearchb.Background = Brushes.DarkBlue;
            btnSearch.Background = Brushes.LightGray;
            btnSearchC.Visibility = Visibility.Visible;
            btnSearchQ.Visibility = Visibility.Visible;
        }

        private void btnSearch_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[1] == true)
            {
                btnSearch.Background = Brushes.White;
            }
        }

        private void btnQLHP_MouseEnter(object sender, MouseEventArgs e)
        {
            btnQLHPb.Background = Brushes.DarkBlue;
            btnQLHP.Background = Brushes.LightGray;
        }

        private void btnQLHP_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[2] == true)
            {
                btnQLHPb.Background = Brushes.White;
                btnQLHP.Background = Brushes.White;
            }
        }

        private void btnQLL_MouseEnter(object sender, MouseEventArgs e)
        {
            btnQLLb.Background = Brushes.DarkBlue;
            btnQLL.Background = Brushes.LightGray;
        }

        private void btnQLL_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[3] == true)
            {
                btnQLLb.Background = Brushes.White;
                btnQLL.Background = Brushes.White;
            }
        }

        private void btnTL_MouseEnter(object sender, MouseEventArgs e)
        {
            btnTLb.Background = Brushes.DarkBlue;
            btnTL.Background = Brushes.LightGray;
        }

        private void btnTL_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[4] == true)
            {
                btnTLb.Background = Brushes.White;
                btnTL.Background = Brushes.White;
            }
        }

        private void btnDKHV_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RegisterMemberScreen rgm = new RegisterMemberScreen();
            rgm.Show();
            this.Close();
        }

        private void btnQLHP_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //FeeScreen fs = new FeeScreen();
            //fs.Show();
            //this.Close();
        }

        private void btnQLL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ClassScreen cs = new ClassScreen();
            cs.Show();
            this.Close();
        }

        private void btnTL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SettingScreen sc = new SettingScreen();
            sc.Show();
            this.Close();
        }

        private void btnSearchQ_MouseEnter(object sender, MouseEventArgs e)
        {
            btnSearchb.Background = Brushes.DarkBlue;
            if (btnSelect[1] == false)
            {
                btnSearchQ.Background = Brushes.LightGray;
                btnSearchC.Background = Brushes.White;
            }
            else btnSearchQ.Background = Brushes.LightGray;
        }

        private void btnSearchQ_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[1] == true)
            {
                btnSearchQ.Background = Brushes.White;
                btnSearchb.Background = Brushes.White;
            }
            btnSearchQ.Visibility = Visibility.Hidden;
            btnSearchC.Visibility = Visibility.Hidden;
        }

        private void btnSearchQ_MouseDown(object sender, MouseButtonEventArgs e)
        {
            QuickSearch qs = new QuickSearch();
            qs.Show();
            this.Close();
        }

        private void btnSearchC_MouseEnter(object sender, MouseEventArgs e)
        {
            if (btnSelect[1] == false)
            {
                btnSearchC.Background = Brushes.LightGray;
                btnSearchQ.Background = Brushes.White;
            }
            else btnSearchC.Background = Brushes.LightGray;
            btnSearchb.Background = Brushes.DarkBlue;
        }

        private void btnSearchC_MouseLeave(object sender, MouseEventArgs e)
        {
            if (btnSelect[1] == true)
            {
                btnSearchC.Background = Brushes.White;
                btnSearchb.Background = Brushes.White;
            }
            btnSearchQ.Visibility = Visibility.Hidden;
            btnSearchC.Visibility = Visibility.Hidden;
        }

        private void btnSearchC_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SearchCondition sc = new SearchCondition();
            sc.Show();
            this.Close();
        }

        //Set Column Name for datagrid Fee
        private void dgvFee_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            var desc = e.PropertyDescriptor as PropertyDescriptor;
            var att = desc.Attributes[typeof(DAO.Model.ColumnNameAttribute)] as DAO.Model.ColumnNameAttribute;
            
            if (att != null)
            {
                if (i <= 3)
                {
                    e.Column.Header = att.Name;
                    i++;
                }
                else if (i<=13 && i>3)
                {
                    int nl = 0;
                    switch (DateTime.Now.Month + val)
                    {
                        case 0:
                            {
                                e.Column.Header = "Tháng 12";
                                nl = 1;
                                break;
                            }
                        case -1:
                            {
                                e.Column.Header = "Tháng 11";
                                nl = 1;
                                break;
                            }
                        case -2:
                            {
                                e.Column.Header = "Tháng 10";
                                nl = 1;
                                break;
                            }
                        case 13:
                            {
                                e.Column.Header = "Tháng 1";
                                nl = 1;
                                break;
                            }
                        case 14:
                            {
                                e.Column.Header = "Tháng 2";
                                nl = 1;
                                break;
                            }
                        case 15:
                            {
                                e.Column.Header = "Tháng 3";
                                nl = 1;
                                break;
                            }
                        case 16:
                            {
                                e.Column.Header = "Tháng 4";
                                nl = 1;
                                break;
                            }
                        case 17:
                            {
                                e.Column.Header = "Tháng 5";
                                nl = 1;
                                break;
                            }
                        case 18:
                            {
                                e.Column.Header = "Tháng 6";
                                nl = 1;
                                break;
                            }
                    }
                    if(nl==0)  e.Column.Header = "Tháng " + (DateTime.Now.Month + val).ToString();
                    val++;
                    i++;
                }
                else
                {
                    e.Column.Header = att.Name;
                    i++;
                }
            }
        }

        //Filter
        private void cmbClassName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dgvFee.ItemsSource = manageFee.FilterFee(cmbClassName.SelectedItem.ToString());
        }
    }
}
