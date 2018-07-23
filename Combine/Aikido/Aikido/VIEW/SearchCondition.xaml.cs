using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.ComponentModel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Aikido.VIEW
{
    /// <summary>
    /// Interaction logic for SearchCondition.xaml
    /// </summary>
    public partial class SearchCondition : System.Windows.Window
    {
        private List<bool> btnSelect = new List<bool>();

        public SearchCondition()
        {
            //var lst = new SearchMember_BLO();
            //var a = lst.GetStudents();
            //dgvSearchC.ItemsSource = a;

            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                btnSelect.Add(true);
            }
            btnSelect[1] = false;
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

        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            String error = null;
            int err = 0;
            if (dtpNgaySinh.SelectedDate > DateTime.Now)
            {
                error += "Ngày sinh phải nhỏ hơn ngày hiện tại";
                err = 1;
            }
            if (dtpNgayDangKy.SelectedDate > DateTime.Now)
            {
                error += " Ngày đăng ký phải nhỏ hơn hoặc bằng ngày hiện tại";
                err = 1;
            }
            if (err == 0)
            {
                dgvSearchC.Visibility = Visibility.Visible;
                var lst = new SearchMember_BLO();
                var a = lst.SearchCon(txtSKU.Text, txtHoTen.Text, dtpNgayDangKy.Text, dtpNgaySinh.Text);
                dgvSearchC.ItemsSource = a;
            }
            else
            {
                MessageBox.Show(error);
            }
            //if (dtpNgaySinh.SelectedDate > DateTime.Now)
            //{
            //    MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại");
            //}
            //if (dtpNgayDangKy.SelectedDate >= DateTime.Now)
            //{
            //    MessageBox.Show("Ngày đăng ký phải nhỏ hơn hoặc bằng ngày hiện tại");
            //}
            //dgvSearchC.Visibility = Visibility.Visible;
            //var lst = new SearchMember_BLO();
            //var a=lst.SearchCon(txtSKU.Text, txtHoTen.Text, dtpNgayDangKy.Text, dtpNgaySinh.Text);
            //dgvSearchC.ItemsSource = a;
        }

        //private void loaddata(object sender, RoutedEventArgs e)
        //{
        //    loaddata();
        //}
        //public void loaddata()
        //{
        //    var lst = new SearchMember_DAO();
        //    var a = lst.GetStudent();
        //    dgvSearchC.ItemsSource = a;
        //}

        private void dgvSearchC_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {

            var desc = e.PropertyDescriptor as PropertyDescriptor;
            var att = desc.Attributes[typeof(DAO.Model.ColumnNameAttribute)] as DAO.Model.ColumnNameAttribute;
            if (att != null)
            {
                e.Column.Header = att.Name;
            }
        }

        private void btnXuatFile_Click(object sender, RoutedEventArgs e)
        {
            if (dgvSearchC.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Không có nội dung để xuất file");
            }
            else
            {
                Excel.Application excel = new Excel.Application();
                excel.Visible = true;//mở file excel
                Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Excel.Worksheet sheet1 = (Excel.Worksheet)workbook.Sheets[1];

                //header
                for (int j = 0; j < dgvSearchC.Columns.Count; j++)
                {
                    Excel.Range myRange = (Excel.Range)sheet1.Cells[1, j + 1];
                    sheet1.Cells[1, j + 1].Font.Bold = true;
                    sheet1.Columns[j + 1].ColumnWidth = 15;
                    myRange.Value2 = dgvSearchC.Columns[j].Header;
                }
                //content
                for (int i = 0; i < dgvSearchC.Columns.Count; i++)
                {
                    for (int j = 0; j < dgvSearchC.Items.Count; j++)
                    {
                        TextBlock b = dgvSearchC.Columns[i].GetCellContent(dgvSearchC.Items[j]) as TextBlock;
                        Excel.Range myRange = (Excel.Range)sheet1.Cells[j + 2, i + 1];
                        myRange.Value2 = b.Text;
                    }
                }

                // Kẻ viền và tô màu
                Excel.Range rowHead = sheet1.get_Range("A1", "G1");

                rowHead.Borders.LineStyle = Excel.Constants.xlSolid;
                rowHead.Interior.ColorIndex = 8;

                rowHead.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                string row = "G" + (dgvSearchC.Items.Count);

                Excel.Range rowContent = sheet1.get_Range("A2", row);
                rowContent.Borders.LineStyle = Excel.Constants.xlSolid;
            }
        }
    }
}
