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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

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
                if (a.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy");
                }
                else
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
            if (dgvSearchC.Items.Count == 0)
            {
                MessageBox.Show("Không thể xuất file excel");
            }
            else
            {
                XuatExcel("Search Data");
                //Excel.Application excel = new Excel.Application();
                //excel.Visible = true;//mở file excel
                //Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                //Worksheet sheet1 = (Worksheet)workbook.Sheets[1];

                ////header
                //for (int j = 0; j < dgvSearchC.Columns.Count; j++)
                //{
                //    Range myRange = (Range)sheet1.Cells[1, j + 1];
                //    sheet1.Cells[1, j + 1].Font.Bold = true;
                //    sheet1.Columns[j + 1].ColumnWidth = 15;
                //    myRange.Value2 = dgvSearchC.Columns[j].Header;
                //}
                ////content
                //for (int i = 0; i < dgvSearchC.Columns.Count; i++)
                //{
                //    for (int j = 0; j < dgvSearchC.Items.Count; j++)
                //    {
                //        TextBlock b = dgvSearchC.Columns[i].GetCellContent(dgvSearchC.Items[j]) as TextBlock;
                //        Range myRange = (Range)sheet1.Cells[j + 2, i + 1];
                //        myRange.Value2 = b.Text;
                //    }
                //}

                //// Kẻ viền và tô màu
                //Range rowHead = sheet1.get_Range("A1", "G1");

                //rowHead.Borders.LineStyle = Constants.xlSolid;
                //rowHead.Interior.ColorIndex = 8;

                //rowHead.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                //string row = "G" + (dgvSearchC.Items.Count);

                //Range rowContent = sheet1.get_Range("A2", row);
                //rowContent.Borders.LineStyle = Constants.xlSolid;
            }
        }
        private void XuatExcel(string sheetName)
        {
            //Tạo các đối tượng Excel
            try
            {
                //export2Excel(dgvSearchC, "E:/", "abc");
                if (dgvSearchC.Items.Count == 0)
                {
                    MessageBox.Show("Không có nội dung để xuất file");
                }
                else
                {
                    app oExcel = new app();
                    Workbooks oBooks;
                    Sheets oSheets;
                    Workbook oBook;
                    Worksheet oSheet;


                    oExcel.Application.SheetsInNewWorkbook = 1;
                    oBooks = oExcel.Workbooks;
                    oBook = (Workbook)(oExcel.Workbooks.Add(Type.Missing));
                    oSheets = oBook.Worksheets;
                    oSheet = (Worksheet)oSheets.get_Item(1);
                    oSheet.Name = "Export Search";
                    //Header

                    Range head = oSheet.get_Range("A1", "AG1");
                    head.Font.Bold = true;
                    head.Font.Name = "Tahoma";
                    head.Font.Size = "10";
                    head.Interior.ColorIndex = 8;
                    head.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;
                    head.Borders.LineStyle = Constants.xlSolid;
                    int r = 0;

                    // Tạo tiêu đề cột
                    List<Range> cl = new List<Range>();
                    List<string> rg = new List<string>();
                    rg.Add("A1"); rg.Add("B1"); rg.Add("C1"); rg.Add("D1"); rg.Add("E1"); rg.Add("F1");
                    rg.Add("G1"); rg.Add("H1"); rg.Add("I1"); rg.Add("J1"); rg.Add("K1"); rg.Add("L1");
                    rg.Add("M1"); rg.Add("N1"); rg.Add("O1"); rg.Add("P1"); rg.Add("Q1"); rg.Add("R1");
                    rg.Add("S1"); rg.Add("T1"); rg.Add("U1"); rg.Add("V1"); rg.Add("W1"); rg.Add("X1"); rg.Add("Y1");
                    rg.Add("Z1"); rg.Add("AA1"); rg.Add("AB1"); rg.Add("AC1"); rg.Add("AD1"); rg.Add("AE1");
                    rg.Add("AF1"); rg.Add("AG1");
                    int crg = 0;
                    Range rang;
                    rang = oSheet.get_Range(rg[crg], rg[crg]);
                    rang.Value2 = "STT";
                    rang.ColumnWidth = 10.0;
                    cl.Add(rang);
                    crg++;
                    foreach (var i in dgvSearchC.Columns)
                    {
                        Range cli;
                        cli = oSheet.get_Range(rg[crg], rg[crg]);
                        cli.Value2 = i.Header;
                        cli.ColumnWidth = 18.0;
                        cli.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;
                        cl.Add(cli);
                        crg++;
                    }

                    //Nội dung điền lên excel
                    object[,] arr = new object[dgvSearchC.Items.Count, dgvSearchC.Columns.Count + 1];

                    for (int i = 0; i < dgvSearchC.Items.Count - 1; i++)
                    {
                        var dt = dgvSearchC.Items[i] as DAO.Model.Search_Model;
                        arr[r, 0] = r + 1;
                        arr[r, 1] = dt.RegisterNumber;
                        arr[r, 2] = dt.SKU;
                        arr[r, 3] = dt.FullName;
                        arr[r, 4] = dt.Nation;
                        arr[r, 5] = dt.Address;
                        arr[r, 6] = "'" + dt.PhoneNumber.ToString();
                        arr[r, 7] = dt.Day_Create.ToShortDateString();
                        arr[r, 8] = dt.Day_of_Birth.ToShortDateString();
                        arr[r, 9] = dt.Place_of_birth;
                        arr[r, 10] = dt.Class_Name;
                        arr[r, 11] = dt.DAI_Cap_6.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp" : dt.DAI_Cap_6.ToShortDateString();
                        arr[r, 12] = dt.DAI_Cap_5.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp" : dt.DAI_Cap_5.ToShortDateString();
                        arr[r, 13] = dt.DAI_Cap_4.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp" : dt.DAI_Cap_4.ToShortDateString();
                        arr[r, 14] = dt.DAI_Cap_3.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp" : dt.DAI_Cap_3.ToShortDateString();
                        arr[r, 15] = dt.DAI_Cap_2.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp" : dt.DAI_Cap_2.ToShortDateString();
                        arr[r, 16] = dt.DAI_Cap_1.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp" : dt.DAI_Cap_1.ToShortDateString();
                        arr[r, 17] = dt.DAN_VN_1.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp" : dt.DAN_VN_1.ToShortDateString();
                        arr[r, 18] = dt.DAN_VN_2.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp" : dt.DAN_VN_2.ToShortDateString();
                        arr[r, 19] = dt.DAN_VN_3.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp " : dt.DAN_VN_3.ToShortDateString();
                        arr[r, 20] = dt.DAN_VN_4.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp " : dt.DAN_VN_4.ToShortDateString();
                        arr[r, 21] = dt.DAN_VN_5.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp " : dt.DAN_VN_5.ToShortDateString();
                        arr[r, 22] = dt.DAN_VN_6.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp " : dt.DAN_VN_6.ToShortDateString();
                        arr[r, 23] = dt.DAN_VN_7.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp " : dt.DAN_VN_7.ToShortDateString();
                        arr[r, 24] = dt.DAN_VN_8.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp " : dt.DAN_VN_8.ToShortDateString();
                        arr[r, 25] = dt.DAN_AIKIKAI_1.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp " : dt.DAN_AIKIKAI_1.ToShortDateString();
                        arr[r, 26] = dt.DAN_AIKIKAI_2.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp " : dt.DAN_AIKIKAI_2.ToShortDateString();
                        arr[r, 27] = dt.DAN_AIKIKAI_3.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp " : dt.DAN_AIKIKAI_3.ToShortDateString();
                        arr[r, 28] = dt.DAN_AIKIKAI_4.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp " : dt.DAN_AIKIKAI_4.ToShortDateString();
                        arr[r, 29] = dt.DAN_AIKIKAI_5.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp " : dt.DAN_AIKIKAI_5.ToShortDateString();
                        arr[r, 30] = dt.DAN_AIKIKAI_6.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp " : dt.DAN_AIKIKAI_6.ToShortDateString();
                        arr[r, 31] = dt.DAN_AIKIKAI_7.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp " : dt.DAN_AIKIKAI_7.ToShortDateString();
                        arr[r, 32] = dt.DAN_AIKIKAI_8.ToShortDateString().Contains(DateTime.MinValue.ToShortDateString()) == true ? "Chưa cấp " : dt.DAN_AIKIKAI_8.ToShortDateString();
                        r++;
                    }

                    //Thiết lập vùng điền dữ liệu
                    int rowStart = 2;
                    int columnStart = 1;
                    int rowEnd = rowStart + dgvSearchC.Items.Count - 1;
                    int columnEnd = dgvSearchC.Columns.Count + 1;

                    // Ô bắt đầu điền dữ liệu

                    Range c1 = (Range)oSheet.Cells[rowStart, columnStart];

                    // Ô kết thúc điền dữ liệu

                    Range c2 = (Range)oSheet.Cells[rowEnd, columnEnd];

                    // Lấy về vùng điền dữ liệu

                    Range range = oSheet.get_Range(c1, c2);

                    //Điền dữ liệu vào vùng đã thiết lập

                    range.Value2 = arr;

                    // Kẻ viền

                    range.Borders.LineStyle = Constants.xlSolid;
                    range.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;


                    // Căn giữa cột

                    Range c3 = (Range)oSheet.Cells[rowEnd, columnStart];

                    Range c4 = oSheet.get_Range(c1, c3);

                    oSheet.get_Range(c3, c4).HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    //oExcel.ActiveWorkbook.SaveCopyAs("E:/Export.xlsx");
                    //oExcel.ActiveWorkbook.Saved = true;
                    //System.Diagnostics.Process.Start("E:/Export.xlsx");
                    oExcel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
