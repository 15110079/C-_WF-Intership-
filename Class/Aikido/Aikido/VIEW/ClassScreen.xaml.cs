using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Aikido.DAO.Model;
namespace Aikido.VIEW
{
    /// <summary>
    /// Interaction logic for ClassScreen.xaml
    /// </summary>
    public partial class ClassScreen : Window
    {
        ManageClass_BLO manageClass = new ManageClass_BLO();
        private List<dgvClass_ViewModel> dataEdit = new List<dgvClass_ViewModel>();
        private List<dgvClass_ViewModel> dataAdd = new List<dgvClass_ViewModel>();
        private List<int> IDdataEdit = new List<int>();
        private List<int> IDdataAdd = new List<int>();

        public ClassScreen()
        {
            InitializeComponent();
            DataSet data = new DataSet();
            
            dgvClass.ItemsSource = manageClass.LoadClass();
            dgvClass.CanUserAddRows = true;

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
            btnQLHPb.Background = Brushes.DarkBlue;
            btnQLHP.Background = Brushes.LightGray;
        }

        private void btnQLHP_MouseLeave(object sender, MouseEventArgs e)
        {
            btnQLHPb.Background = Brushes.White;
            btnQLHP.Background = Brushes.White;
        }

        private void btnQLL_MouseEnter(object sender, MouseEventArgs e)
        {
            //btnQLLb.Background = Brushes.DarkBlue;
            //btnQLL.Background = Brushes.LightGray;
        }

        private void btnQLL_MouseLeave(object sender, MouseEventArgs e)
        {
            //btnQLLb.Background = Brushes.White;
            //btnQLL.Background = Brushes.White;
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
            //ClassScreen classScreen = new ClassScreen();
            //classScreen.Show();
            //this.Close();
        }
        private void FeeManagement_Click(object sender, RoutedEventArgs e)
        {
            FeeScreen fees = new FeeScreen();
            fees.Show();
            this.Close();
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
        private void dgvClass_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            var desc = e.PropertyDescriptor as PropertyDescriptor;
            var att = desc.Attributes[typeof(DAO.Model.ColumnNameAttribute)] as DAO.Model.ColumnNameAttribute;
            if (att != null)
            {
                e.Column.Header = att.Name;
            }
        }

        private void btnSaveC_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var i in IDdataAdd)
                {
                    dataAdd.Add(dgvClass.Items[i] as DAO.Model.dgvClass_ViewModel);
                }
                foreach (var i in IDdataEdit)
                {
                    dataEdit.Add(dgvClass.Items[i] as DAO.Model.dgvClass_ViewModel);
                }
                string message = null;
                if (checkData(ref message) == true)
                {
                    if (dataAdd.Count() > 0 || dataEdit.Count > 0) manageClass.SaveClass(dataAdd, dataEdit);
                    IDdataAdd.Clear(); dataAdd.Clear();
                    IDdataEdit.Clear(); dataEdit.Clear();
                    dgvClass.ItemsSource = manageClass.LoadClass();
                    dgvClass.Columns[0].Visibility = Visibility.Hidden;
                    dgvClass.Columns[2].Visibility = Visibility.Hidden;
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    MessageBox.Show(message, "Lỗi", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                }
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var currentItem = dgvClass.SelectedItem as DAO.Model.dgvClass_ViewModel;
                if (MessageBox.Show($"Chắc xóa lớp {currentItem.txtName} không?", "Cảnh báo", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (dgvClass.SelectedIndex == dgvClass.Items.Count - 1 && dgvClass.CanUserAddRows==true)
                    {
                        MessageBox.Show("Dòng này để nhập dữ liệu");
                    }
                    else if (dgvClass.SelectedIndex < dgvClass.Items.Count - 1 || (dgvClass.SelectedIndex == dgvClass.Items.Count - 1 && dgvClass.CanUserAddRows == false))
                    {
                        manageClass.DeleteClass(currentItem.ID);
                        dgvClass.ItemsSource = manageClass.LoadClass();
                        dgvClass.Columns[0].Visibility = Visibility.Hidden;
                        dgvClass.Columns[2].Visibility = Visibility.Hidden;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chọn dòng muốn xóa");
            }
        }

        public bool CheckTimeInput(string timein)
        {
            Regex objAlphaNumericPattern = new Regex("^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
            return objAlphaNumericPattern.IsMatch(timein);
        }

        private Boolean checkData(ref string mess)
        {
            bool error = true;
            string err = null;
            try
            {
                int line1 = 0;
                int line2 = 0;
                foreach (var currentItem in dataAdd)
                {
                    if (currentItem.txtName == null || currentItem.txtName == "")
                    {
                        err += " - Tên Lớp chưa được nhập" + " Dòng " + (IDdataAdd[line1] + 1).ToString() + "\n"; error = false;
                    }
                    if (currentItem.txtStartTime == null || currentItem.txtStartTime == "")
                    {
                        err += " - Giờ Bắt Đầu chưa được nhập" + " Dòng " + (IDdataAdd[line1] + 1).ToString() + "\n"; error = false;
                    }
                    else if (CheckTimeInput(currentItem.txtStartTime) == false)
                    {
                        err += " - Giờ Bắt Đầu Dạng HH:MM" + " Dòng " + (IDdataAdd[line1] + 1).ToString() + "\n"; error = false;
                    }
                    if (currentItem.txtFinishTime == null || currentItem.txtFinishTime == "")
                    {
                        err += " - Giờ Kết Thúc chưa được nhập" + " Dòng " + (IDdataAdd[line1] + 1).ToString() + "\n"; error = false;
                    }
                    else if (CheckTimeInput(currentItem.txtFinishTime) == false)
                    {
                        err += " - Giờ Kết Thúc Dạng HH:MM" + " Dòng " + (IDdataAdd[line1] + 1).ToString() + "\n"; error = false;
                    }
                    if (CheckTimeInput(currentItem.txtFinishTime) == true && CheckTimeInput(currentItem.txtStartTime) == true)
                    {
                        if (DateTime.Parse(currentItem.txtStartTime).Hour > DateTime.Parse(currentItem.txtFinishTime).Hour)
                        {
                            err += " - Giờ Bắt Đầu Phải Bé Hơn Giờ Kết Thúc" + " Dòng " + (IDdataAdd[line1] + 1).ToString() + "\n"; error = false;
                        }
                        else if (DateTime.Parse(currentItem.txtStartTime).Hour == DateTime.Parse(currentItem.txtFinishTime).Hour)
                        {
                            if (DateTime.Parse(currentItem.txtStartTime).Minute > DateTime.Parse(currentItem.txtFinishTime).Minute)
                            {
                                err += " - Giờ Bắt Đầu Phải Bé Hơn Giờ Kết Thúc" + " Dòng " + (IDdataAdd[line1] + 1).ToString() + "\n"; error = false;
                            }
                        }
                    }
                    if (currentItem.cbMonday == false && currentItem.cbTuesday == false
                            && currentItem.cbWednesday == false && currentItem.cbThursday == false
                            && currentItem.cbFriday == false && currentItem.cbSarturday == false
                            && currentItem.cbSunday == false
                      )
                    {
                        err += " - Chọn ít nhất một ngày học trong tuần" + " Dòng " + (IDdataAdd[line1] + 1).ToString() + "\n";
                        error = false;
                    }
                    line1++;
                }
                foreach (var currentItem in dataEdit)
                {
                    if (currentItem.txtName == null || currentItem.txtName == "")
                    {
                        err += " - Tên Lớp chưa được nhập" + " Dòng " + (IDdataEdit[line2] + 1).ToString() + "\n"; error = false;
                    }
                    if (currentItem.txtStartTime == null || currentItem.txtStartTime == "")
                    {
                        err += " - Giờ Bắt Đầu chưa được nhập" + " Dòng " + (IDdataEdit[line2] + 1).ToString() + "\n"; error = false;
                    }
                    else if (CheckTimeInput(currentItem.txtStartTime) == false)
                    {
                        err += " - Giờ Bắt Đầu Dạng HH:MM" + " Dòng " + (IDdataEdit[line2] + 1).ToString() + "\n"; error = false;
                    }
                    if (currentItem.txtFinishTime == null || currentItem.txtFinishTime == "")
                    {
                        err += " - Giờ Kết Thúc chưa được nhập" + " Dòng " + (IDdataEdit[line2] + 1).ToString() + "\n"; error = false;
                    }
                    else if (CheckTimeInput(currentItem.txtFinishTime) == false)
                    {
                        err += " - Giờ Kết Thúc Dạng HH:MM" + " Dòng " + (IDdataEdit[line2] + 1).ToString() + "\n"; error = false;
                    }
                    if(CheckTimeInput(currentItem.txtFinishTime) == true && CheckTimeInput(currentItem.txtStartTime) == true)
                    {
                        if(DateTime.Parse(currentItem.txtStartTime).Hour > DateTime.Parse(currentItem.txtFinishTime).Hour)
                        {
                            err += " - Giờ Bắt Đầu Phải Bé Hơn Giờ Kết Thúc" + " Dòng " + (IDdataEdit[line2] + 1).ToString() + "\n"; error = false;
                        }
                        else if (DateTime.Parse(currentItem.txtStartTime).Hour == DateTime.Parse(currentItem.txtFinishTime).Hour)
                        {
                            if(DateTime.Parse(currentItem.txtStartTime).Minute >= DateTime.Parse(currentItem.txtFinishTime).Minute)
                            {
                                err += " - Giờ Bắt Đầu Phải Bé Hơn Giờ Kết Thúc" + " Dòng " + (IDdataEdit[line2] + 1).ToString() + "\n"; error = false;
                            }
                        }
                    }
                    if (currentItem.cbMonday == false && currentItem.cbTuesday == false
                            && currentItem.cbWednesday == false && currentItem.cbThursday == false
                            && currentItem.cbFriday == false && currentItem.cbSarturday == false
                            && currentItem.cbSunday == false
                      )
                    {
                        err += " - Chọn ít nhất một ngày học trong tuần" + " Dòng " + (IDdataEdit[line2] + 1).ToString() + "\n";
                        error = false;
                    }
                    line2++;
                }
                //dgvClass.CanUserAddRows = false;
            }
            catch
            {

            }
            mess = "Lỗi: \n" + err;
            return error;
        }

        private void dgvClass_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            try
            {
                if (dgvClass.Items.Count-2 == dgvClass.SelectedIndex)
                {
                    int kt = 0;
                    foreach (var i in IDdataAdd)
                    {
                        if (dgvClass.SelectedIndex == i)
                        {
                            kt = 1;
                            break;
                        }
                    }
                    if (kt == 0) IDdataAdd.Add(dgvClass.SelectedIndex);
                }
                else
                {
                    int kt = 0;
                    foreach (var i in IDdataAdd)
                    {
                        if (dgvClass.SelectedIndex == i)
                        {
                            kt = 1;
                            break;
                        }
                    }
                    if (kt == 0)
                    {
                        int kte = 0;
                        foreach (var i in IDdataEdit)
                        {
                            if (dgvClass.SelectedIndex == i)
                            {
                                kte = 1;
                                break;
                            }
                        }
                        if (kte == 0) IDdataEdit.Add(dgvClass.SelectedIndex);
                    }
                }
            }
            catch
            {

            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //dgvClass.CanUserAddRows = true;
            }
            catch
            {

            }

        }

        private void dgvClass_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                dgvClass.Columns[0].Visibility = Visibility.Hidden;
                dgvClass.Columns[2].Visibility = Visibility.Hidden;
            }
            catch
            {

            }
        }

        private void dgvClass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Chuyển button delete theo đúng row đang chọn
            //btnDelete.Margin = new Thickness(735, 0, 0, 475 - 20 * dgvClass.SelectedIndex);
            //Chuyển button add khi chọn dòng cuối cùng

        }

        private void dgvClass_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }
    }
}
