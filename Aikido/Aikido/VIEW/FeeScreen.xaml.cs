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
using Aikido.BLO;
using Aikido.DAO;
using Aikido.DAO.Model;
namespace Aikido.VIEW
{
    /// <summary>
    /// Interaction logic for FeeScreen.xaml
    /// </summary>
    public partial class FeeScreen : Window
    {
        ManageClass_BLO classDB = new ManageClass_BLO();
        ManageFee_BLO feeBLO = new ManageFee_BLO();
        List<dgvFee_ViewModel> editFee = new List<dgvFee_ViewModel>();
        List<dgvFee_ViewModel> editFeeD = new List<dgvFee_ViewModel>();
        private List<int> IDEdit = new List<int>();
        private List<int> IDEditD = new List<int>();
        private int i = 0;
        private int val = -3;
        public FeeScreen()
        {
            InitializeComponent();

            List<Class> showCombobox = classDB.ComboxClass();
            cmbClassName.ItemsSource = showCombobox;
            cmbClassName.DisplayMemberPath = "Class_Name";
            cmbClassName.SelectedValuePath = "ID_Class";
            cmbClassName.Background = Brushes.White;
            cmbClassName.Foreground = Brushes.DarkBlue;
            dgvFee2.ItemsSource = feeBLO.LoadAllFee();
            dgvFee1.ItemsSource = feeBLO.LoadAllFee1();
            dgvTotalC.ItemsSource = feeBLO.LoadTotal(dgvFee2);
        }

        private void btnDKHV_MouseEnter(object sender, MouseEventArgs e)
        {
            btnDKHVb.Background = Brushes.DarkBlue;
            btnDKHV.Background = Brushes.LightGray;
        }

        private void btnDKHV_MouseLeave(object sender, MouseEventArgs e)
        {
            btnDKHVb.Background = Brushes.White;
            btnDKHV.Background = Brushes.White;
        }

        private void btnSearch_MouseEnter(object sender, MouseEventArgs e)
        {
            btnSearchb.Background = Brushes.DarkBlue;
            btnSearch.Background = Brushes.LightGray;
            btnSearchI.Background = Brushes.LightGray;

        }

        private void btnSearch_MouseLeave(object sender, MouseEventArgs e)
        {
            btnSearch.Background = Brushes.White;
            btnSearchb.Background = Brushes.White;
            btnSearchI.Background = Brushes.White;
        }

        private void btnQLHP_MouseEnter(object sender, MouseEventArgs e)
        {
            //btnQLHPb.Background = Brushes.DarkBlue;
            //btnQLHP.Background = Brushes.LightGray;
        }

        private void btnQLHP_MouseLeave(object sender, MouseEventArgs e)
        {
            //btnQLHPb.Background = Brushes.White;
            //btnQLHP.Background = Brushes.White;
        }

        private void btnQLL_MouseEnter(object sender, MouseEventArgs e)
        {
            btnQLLb.Background = Brushes.DarkBlue;
            btnQLL.Background = Brushes.LightGray;
        }

        private void btnQLL_MouseLeave(object sender, MouseEventArgs e)
        {
            btnQLLb.Background = Brushes.White;
            btnQLL.Background = Brushes.White;
        }

        private void btnTL_MouseEnter(object sender, MouseEventArgs e)
        {
            btnTLb.Background = Brushes.DarkBlue;
            btnTL.Background = Brushes.LightGray;
        }

        private void btnTL_MouseLeave(object sender, MouseEventArgs e)
        {
            btnTLb.Background = Brushes.White;
            btnTL.Background = Brushes.White;
        }

        private void btnHelpI_MouseEnter(object sender, MouseEventArgs e)
        {
            btnHelp.Background = Brushes.LightGray;
            btnHelpb.Background = Brushes.DarkBlue;
            btnHelpI.Background = Brushes.LightGray;
        }

        private void btnHelpI_MouseLeave(object sender, MouseEventArgs e)
        {
            btnHelp.Background = Brushes.White;
            btnHelpb.Background = Brushes.White;
            btnHelpI.Background = Brushes.White;
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegisterMemberScreen rgm = new RegisterMemberScreen();
            rgm.Show();
            this.Close();
        }
        private void Quick_Click(object sender, RoutedEventArgs e)
        {
            QuickSearch quick = new QuickSearch();
            quick.Show();
            this.Close();
        }
        private void Condition_Click(object sender, RoutedEventArgs e)
        {
            SearchCondition scon = new SearchCondition();
            scon.Show();
            this.Close();
        }
        private void ClassManagement_Click(object sender, RoutedEventArgs e)
        {
            ClassScreen classScreen = new ClassScreen();
            classScreen.Show();
            this.Close();
        }
        private void FeeManagement_Click(object sender, RoutedEventArgs e)
        {
            //FeeScreen fees = new FeeScreen();
            //fees.Show();
            //this.Close();
        }
        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            SettingScreen setting = new SettingScreen();
            setting.Show();
            this.Close();
        }
        private void TTNPT_Click(object sender, RoutedEventArgs e)
        {
            //SearchCondition scon = new SearchCondition();
            //scon.Show();
            //this.Close();
        }
        private void HDSD_Click(object sender, RoutedEventArgs e)
        {
            //SearchCondition scon = new SearchCondition();
            //scon.Show();
            //this.Close();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            feeBLO.XuatExcel(dgvFee1, dgvFee2, "Student Fee");
        }


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
                else if (i <= 13 && i > 3)
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
                    if (nl == 0) e.Column.Header = "Tháng " + (DateTime.Now.Month + val).ToString();
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

        private void dgvFee_Loaded(object sender, RoutedEventArgs e)
        {
            Dictionary<int, string> thang = new Dictionary<int, string>();
            thang.Add(1, "Tháng 1"); thang.Add(2, "Tháng 2"); thang.Add(3, "Tháng 3"); thang.Add(4, "Tháng 4"); thang.Add(5, "Tháng 5"); thang.Add(6, "Tháng 6");
            thang.Add(7, "Tháng 7"); thang.Add(8, "Tháng 8"); thang.Add(9, "Tháng 9"); thang.Add(10, "Tháng 10"); thang.Add(11, "Tháng 11"); thang.Add(12, "Tháng 12");
            int r = DateTime.Now.Month;
            switch (r)
            {
                case 1:
                    {
                        int j = 2;
                        int k = 1;
                        for (int i = 2; i < 12; i++)
                        {
                            if (j >= 0)
                            {
                                dgvFee2.Columns[i].Header = thang[12 - j];
                                j--;
                            }
                            else dgvFee2.Columns[i].Header = thang[k++];
                        }
                        break;
                    }
                case 2:
                    {
                        int j = 1;
                        int k = 1;
                        for (int i = 2; i < 12; i++)
                        {
                            if (j >= 0)
                            {
                                dgvFee2.Columns[i].Header = thang[12 - j];
                                j--;
                            }
                            else dgvFee2.Columns[i].Header = thang[k++];
                        }
                        break;
                    }
                case 3:
                    {
                        int j = 0;
                        int k = 1;
                        for (int i = 2; i < 12; i++)
                        {
                            if (j >= 0)
                            {
                                dgvFee2.Columns[i].Header = thang[12 - j];
                                j--;
                            }
                            else dgvFee2.Columns[i].Header = thang[k++];
                        }
                        break;
                    }
                case 4:
                    {
                        for (int i = 2; i < 12; i++)
                        {
                            dgvFee2.Columns[i].Header = thang[i];
                        }
                        break;
                    }
                case 5:
                    {
                        int k = 2;
                        for (int i = 2; i < 12; i++)
                        {
                            dgvFee2.Columns[i].Header = thang[k++];
                        }
                        break;
                    }
                case 6:
                    {
                        int k = 3;
                        for (int i = 2; i < 12; i++)
                        {
                            dgvFee2.Columns[i].Header = thang[k++];
                        }
                        break;
                    }
                case 7:
                    {
                        int k = 4;
                        for (int i = 2; i < 12; i++)
                        {
                            if (k <= 12) dgvFee2.Columns[i].Header = thang[k++];
                            else
                            {
                                dgvFee2.Columns[i].Header = thang[k - 12];
                                k++;
                            }
                        }
                        break;
                    }
                case 8:
                    {
                        int k = 5;
                        for (int i = 2; i < 12; i++)
                        {
                            if (k <= 12) dgvFee2.Columns[i].Header = thang[k++];
                            else
                            {
                                dgvFee2.Columns[i].Header = thang[k - 12];
                                k++;
                            }
                        }
                        break;
                    }
                case 9:
                    {
                        int k = 6;
                        for (int i = 2; i < 12; i++)
                        {
                            if (k <= 12) dgvFee2.Columns[i].Header = thang[k++];
                            else
                            {
                                dgvFee2.Columns[i].Header = thang[k - 12];
                                k++;
                            }
                        }
                        break;
                    }
                case 10:
                    {
                        int k = 7;
                        for (int i = 2; i < 12; i++)
                        {
                            if (k <= 12) dgvFee2.Columns[i].Header = thang[k++];
                            else
                            {
                                dgvFee2.Columns[i].Header = thang[k - 12];
                                k++;
                            }
                        }
                        break;
                    }
                case 11:
                    {
                        int k = 8;
                        for (int i = 2; i < 12; i++)
                        {
                            if (k <= 12) dgvFee2.Columns[i].Header = thang[k++];
                            else
                            {
                                dgvFee2.Columns[i].Header = thang[k - 12];
                                k++;
                            }
                        }
                        break;
                    }
                case 12:
                    {
                        int k = 9;
                        for (int i = 2; i < 12; i++)
                        {
                            if (k <= 12) dgvFee2.Columns[i].Header = thang[k++];
                            else
                            {
                                dgvFee2.Columns[i].Header = thang[k - 12];
                                k++;
                            }
                        }
                        break;
                    }
            }
        }

        private void cmbClassName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dgvFee1.ItemsSource = feeBLO.LoadFilter1((int)cmbClassName.SelectedValue);
            dgvFee2.ItemsSource = feeBLO.LoadFilter((int)cmbClassName.SelectedValue);
            dgvTotalC.ItemsSource = feeBLO.LoadTotal(dgvFee2);
        }

        private void dgvFee2_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            int index = dgvFee2.SelectedIndex;
            if (index % 2 == 0)
            {
                int kte = 0;
                foreach (var i in IDEdit)
                {
                    if (index == i)
                    {
                        kte = 1;
                        break;
                    }
                }
                if (kte == 0) IDEdit.Add(index);

            }
            else
            {
                int kte = 0;
                foreach (var i in IDEditD)
                {
                    if (index == i)
                    {
                        kte = 1;
                        break;
                    }
                }
                if (kte == 0) IDEditD.Add(index);
            }
        }

        private void dgvFee2_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            string err = "Lỗi: \n";
            try
            {
                if (IDEdit.Count > 0)
                {
                    foreach (var i in IDEdit)
                    {
                        editFee.Add(dgvFee2.Items[i] as DAO.Model.dgvFee_ViewModel);
                    }

                    if (checkData(ref err) == true)
                    {
                        feeBLO.SaveFee(editFee);
                        editFee.Clear();
                        IDEdit.Clear();
                        try
                        {
                            dgvFee2.ItemsSource = feeBLO.LoadFilter((int)cmbClassName.SelectedValue);
                        }
                        catch
                        {
                            dgvFee2.ItemsSource = feeBLO.LoadAllFee();
                        }
                        dgvTotalC.ItemsSource = feeBLO.LoadTotal(dgvFee2);
                    }
                    else MessageBox.Show(err);

                }
                if (IDEditD.Count > 0)
                {
                    foreach (var i in IDEditD)
                    {
                        editFeeD.Add(dgvFee2.Items[i] as DAO.Model.dgvFee_ViewModel);
                    }
                    if (checkData(ref err) == true)
                    {
                        feeBLO.SaveFeeD(editFeeD);
                        editFeeD.Clear();
                        IDEditD.Clear();
                        try
                        {
                            dgvFee2.ItemsSource = feeBLO.LoadFilter((int)cmbClassName.SelectedValue);
                        }
                        catch
                        {
                            dgvFee2.ItemsSource = feeBLO.LoadAllFee();
                        }
                        dgvTotalC.ItemsSource = feeBLO.LoadTotal(dgvFee2);
                    }
                    else MessageBox.Show(err);
                }

                //string message = null;
                //if (checkData(ref message) == true)
                //{
                //    if (dataAdd.Count() > 0 || dataEdit.Count > 0) feeBLO..SaveClass(dataAdd, dataEdit);
                //    IDdataAdd.Clear(); dataAdd.Clear();
                //    IDdataEdit.Clear(); dataEdit.Clear();
                //    dgvClass.ItemsSource = manageClass.LoadClass();
                //    dgvClass.Columns[0].Visibility = Visibility.Hidden;
                //    dgvClass.Columns[2].Visibility = Visibility.Hidden;
                //    MessageBox.Show("Lưu thành công");
                //}
                //else
                //{
                //    MessageBox.Show(message, "Lỗi", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                //}
            }
            catch
            {

            }
        }
        private Boolean checkData(ref string mess)
        {
            try
            {
                foreach (var item in editFee)
                {
                    try
                    {
                        Double i = Double.Parse(item.lblmonthHT3A.ToString());
                        if (i < 0)
                        {
                            mess = "- Phí phải lớn hơn 0";
                            return false;
                        }
                        return true;
                    }
                    catch
                    {
                        mess = "- Phí phải nhập hoàn toàn số";
                        return false;
                    }

                }
                foreach (var item in editFeeD)
                {
                    try
                    {
                        Double i = Double.Parse(item.lblmonthHT3A.ToString());
                        if (i < 0)
                        {
                            mess = "- Phí phải lớn hơn 0";
                            return false;
                        }
                        return true;
                    }
                    catch
                    {
                        mess = "- Phí phải nhập hoàn toàn số";
                        return false;
                    }

                }
                return true;
            }
            catch
            {
                mess = "Lỗi";
                return false;
            }
        }
    }
}
