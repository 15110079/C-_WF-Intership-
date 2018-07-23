using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Aikido.DAO;
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
        private List<bool> btnSelect = new List<bool>();
        public ClassScreen()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                btnSelect.Add(true);
            }
            btnSelect[3] = false;
            dgvClass.ItemsSource = manageClass.LoadClass();
            dgvClass.CanUserAddRows = false;
            
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

        private void btnSearch_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnQLHP_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FeeScreen fs = new FeeScreen();
            fs.Show();
            this.Close();
        }

        private void btnQLL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //ClassScreen cs = new ClassScreen();
            //cs.Show();
            //this.Close();
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
                }
                else
                {
                    MessageBox.Show(message, "Lỗi", MessageBoxButton.OKCancel,MessageBoxImage.Error);
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
                    if (dgvClass.SelectedIndex < dgvClass.Items.Count - 1)
                    {
                        
                        manageClass.DeleteClass(currentItem.ID);
                        dgvClass.ItemsSource = manageClass.LoadClass();
                        dgvClass.Columns[0].Visibility = Visibility.Hidden;
                    }
                    else if (dgvClass.SelectedIndex == dgvClass.Items.Count - 1)
                    {
                        MessageBox.Show("Dòng này để nhập dữ liệu");
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
                        err += " - Tên Lớp Không Thể Trống" + " Dòng " + (IDdataEdit[line1] + 1).ToString() + "\n"; error = false;
                    }
                    if (currentItem.txtStartTime == null || currentItem.txtStartTime == "")
                    {
                        err += " - Giờ Bắt Đầu Không Để Trống" + " Dòng " + (IDdataEdit[line1] + 1).ToString() + "\n"; error = false;
                    }
                    else if (CheckTimeInput(currentItem.txtStartTime) == false)
                    {
                        err += " - Giờ Bắt Đầu Dạng HH:MM" + " Dòng " + (IDdataEdit[line1] + 1).ToString() + "\n"; error = false;
                    }
                    if (currentItem.txtFinishTime == null || currentItem.txtFinishTime == "")
                    {
                        err += " - Giờ Kết Thúc Không Để Trống" + " Dòng " + (IDdataEdit[line1] + 1).ToString() + "\n"; error = false;
                    }
                    else if (CheckTimeInput(currentItem.txtFinishTime) == false)
                    {
                        err += " - Giờ Kết Thúc Dạng HH:MM" + " Dòng " + (IDdataEdit[line1] + 1).ToString() + "\n"; error = false;
                    }
                    if (currentItem.cbMonday == false && currentItem.cbTuesday == false
                            && currentItem.cbWednesday == false && currentItem.cbThursday == false
                            && currentItem.cbFriday == false && currentItem.cbSarturday == false
                            && currentItem.cbSunday == false
                      )
                    {
                        err += " - Chọn ít nhất một ngày học trong tuần" + " Dòng " + (IDdataEdit[line1] + 1).ToString() + "\n";
                        error = false;
                    }
                    line1++;
                }
                foreach (var currentItem in dataEdit)
                {
                    if (currentItem.txtName == null || currentItem.txtName == "")
                    {
                        err += " - Tên Lớp Không Thể Trống" + " Dòng " + (IDdataEdit[line2] + 1).ToString() + "\n"; error = false;
                    }
                    if (currentItem.txtStartTime == null || currentItem.txtStartTime == "")
                    {
                        err += " - Giờ Bắt Đầu Không Để Trống" + " Dòng " + (IDdataEdit[line2] + 1).ToString() + "\n"; error = false;
                    }
                    else if (CheckTimeInput(currentItem.txtStartTime) == false)
                    {
                        err += " - Giờ Bắt Đầu Dạng HH:MM" + " Dòng " + (IDdataEdit[line2] + 1).ToString() + "\n"; error = false;
                    }
                    if (currentItem.txtFinishTime == null || currentItem.txtFinishTime == "")
                    {
                        err += " - Giờ Kết Thúc Không Để Trống" + " Dòng " + (IDdataEdit[line2] + 1).ToString() + "\n"; error = false;
                    }
                    else if (CheckTimeInput(currentItem.txtFinishTime) == false)
                    {
                        err += " - Giờ Kết Thúc Dạng HH:MM"+ " Dòng " + (IDdataEdit[line2] + 1).ToString() + "\n"; error = false;
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
                dgvClass.CanUserAddRows = false;
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
                if (dgvClass.CanUserAddRows==true)
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
                    if (kt==0) IDdataAdd.Add(dgvClass.SelectedIndex);
                }
                else
                {
                    int kt = 0;
                    foreach(var i in IDdataAdd)
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
                dgvClass.CanUserAddRows = false;
            }
            catch
            {

            }        
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dgvClass.CanUserAddRows = true;
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
            }
            catch
            {

            }
        }

        private void dgvClass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnDelete.Margin = new Thickness(735, 0, 0, 475 - 20 * dgvClass.SelectedIndex);
        }
    }
}
