using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Aikido.DAO;
using Aikido.BLO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;
using Microsoft.Win32;
using System.IO;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace Aikido.VIEW
{
    ///
    public partial class RegisterMemberScreen : Window
    {
        RegisterMember_BLO db ;
        ManageClass_BLO ClassDB;
        private List<bool> btnSelect = new List<bool>();
        private Brush brush;
        private int NewRegisterNumber;
        private byte[] arrImage=null;
        public RegisterMemberScreen()
        {
            InitializeComponent();
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            Thread.CurrentThread.CurrentCulture = ci;

            using (var dataContext = new AccessDB_DAO())
            {
                try
                {

                    dataContext.Classes.Add(new Class() { Class_Name = "A", Start_Time = new DateTime(2016, 6, 28), End_Time = new DateTime(2016, 6, 28), Monday = true, Tuesday = true, Wednesday = false, Thursday = false, Friday = true, Saturday = false, Sunday = true, Delete_Flag = true, Day_Update = new DateTime(2016, 6, 28), Day_Create = new DateTime(2016, 6, 28) });
                    dataContext.Classes.Add(new Class() { Class_Name = "B", Start_Time = new DateTime(2016, 6, 28), End_Time = new DateTime(2016, 6, 28), Monday = true, Tuesday = true, Wednesday = false, Thursday = false, Friday = true, Saturday = false, Sunday = true, Delete_Flag = true, Day_Update = new DateTime(2016, 6, 28), Day_Create = new DateTime(2016, 6, 28) });
                    dataContext.Classes.Add(new Class() { Class_Name = "C", Start_Time = new DateTime(2016, 6, 28), End_Time = new DateTime(2016, 6, 28), Monday = true, Tuesday = true, Wednesday = false, Thursday = false, Friday = true, Saturday = false, Sunday = true, Delete_Flag = true, Day_Update = new DateTime(2016, 6, 28), Day_Create = new DateTime(2016, 6, 28) });

                    dataContext.Learns.Add(new Learn() { ID_Class = 1, RegisterNumber = 1, Fee_January = 0, Fee_February = 0, Fee_March = 0, Fee_April = 0, Fee_May = 0, Fee_June = 0, Fee_July = 0, Fee_August = 0, Fee_September = 0, Fee_October = 0, Fee_December = 0, Fee_November = 0, RegisterDay = DateTime.Now, Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap6", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap5", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap4", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap3", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap2", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap1", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN1", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN2", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN3", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN4", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN5", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN6", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN7", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN8", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI1", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI2", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI3", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI4", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI5", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI6", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI7", Day_Create = DateTime.Now, Delete_Flag = false });
                    dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI8", Day_Create = DateTime.Now, Delete_Flag = false });

                    dataContext.SaveChanges();
                }
                catch { }
            }
            //Set Manu Tab
            for (int i = 0; i < 5; i++)
            {
                btnSelect.Add(true);
            }
            btnSelect[0] = false;
            BrushConverter bc = new BrushConverter();
            brush = (Brush)bc.ConvertFrom("#E5E1E1");
            brush.Freeze();

            //Load New Register Number
            db = new RegisterMember_BLO();
            NewRegisterNumber = db.NewRegisterNumber() + 1;
            txtRegisterNumber.Text = (NewRegisterNumber).ToString();

            //Load Class in Combobox
            ClassDB = new ManageClass_BLO();
            List<Class> showCombobox = ClassDB.ComboxClass();
            cboRegisterClass.ItemsSource = showCombobox;
            cboRegisterClass.DisplayMemberPath = "Class_Name";
            cboRegisterClass.SelectedValuePath = "ID_Class";
            
            //Load Register Day
            dtpRegisterDay.SelectedDate = DateTime.Now;

        }

        //------------------------------------------------------ Handle register member
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Check_DataBase() == true)
            {
                string SKU = txtSKU.Text;
                string FullName = txtName.Text;
                string Nation = txtNation.Text;
                string Address = txtAddress.Text;
                string PhoneNumber = txtPhone.Text;

                CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
                ci.DateTimeFormat.ShortDatePattern = "dd mm yyyy";
                Thread.CurrentThread.CurrentCulture = ci;
       
                DateTime RegisterDay = dtpRegisterDay.SelectedDate.Value;
                DateTime Day_of_Birth = dtpBirthday.SelectedDate.Value;
                string Place_of_Birth = txtBirthplace.Text;
                int RegisterClass = int.Parse(cboRegisterClass.SelectedValue.ToString());
                //Thieu image
                Dictionary<string, DateTime> listLevel = new Dictionary<string, DateTime>();
                listLevel.Add("Cap6", (dtpLevel6.SelectedDate == null) ? DateTime.MinValue : dtpLevel6.SelectedDate.Value);
                listLevel.Add("Cap5", (dtpLevel5.SelectedDate == null) ? DateTime.MinValue : dtpLevel5.SelectedDate.Value);
                listLevel.Add("Cap4", (dtpLevel4.SelectedDate == null) ? DateTime.MinValue : dtpLevel4.SelectedDate.Value);
                listLevel.Add("Cap3", (dtpLevel3.SelectedDate == null) ? DateTime.MinValue : dtpLevel3.SelectedDate.Value);
                listLevel.Add("Cap2", (dtpLevel2.SelectedDate == null) ? DateTime.MinValue : dtpLevel2.SelectedDate.Value);
                listLevel.Add("Cap1", (dtpLevel1.SelectedDate == null) ? DateTime.MinValue : dtpLevel2.SelectedDate.Value);
                listLevel.Add("DANVN1", (dtpDanVN1.SelectedDate == null) ? DateTime.MinValue : dtpDanVN1.SelectedDate.Value);
                listLevel.Add("DANVN2", (dtpDanVN2.SelectedDate == null) ? DateTime.MinValue : dtpDanVN2.SelectedDate.Value);
                listLevel.Add("DANVN3", (dtpDanVN3.SelectedDate == null) ? DateTime.MinValue : dtpDanVN3.SelectedDate.Value);
                listLevel.Add("DANVN4", (dtpDanVN4.SelectedDate == null) ? DateTime.MinValue : dtpDanVN4.SelectedDate.Value);
                listLevel.Add("DANVN5", (dtpDanVN5.SelectedDate == null) ? DateTime.MinValue : dtpDanVN5.SelectedDate.Value);
                listLevel.Add("DANVN6", (dtpDanVN6.SelectedDate == null) ? DateTime.MinValue : dtpDanVN6.SelectedDate.Value);
                listLevel.Add("DANVN7", (dtpDanVN7.SelectedDate == null) ? DateTime.MinValue : dtpDanVN7.SelectedDate.Value);
                listLevel.Add("DANVN8", (dtpDanVN8.SelectedDate == null) ? DateTime.MinValue : dtpDanVN8.SelectedDate.Value);
                listLevel.Add("DANAIKIKAI1", (dtpDanAIKIKAI1.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI1.SelectedDate.Value);
                listLevel.Add("DANAIKIKAI2", (dtpDanAIKIKAI2.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI2.SelectedDate.Value);
                listLevel.Add("DANAIKIKAI3", (dtpDanAIKIKAI3.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI3.SelectedDate.Value);
                listLevel.Add("DANAIKIKAI4", (dtpDanAIKIKAI4.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI4.SelectedDate.Value);
                listLevel.Add("DANAIKIKAI5", (dtpDanAIKIKAI5.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI5.SelectedDate.Value);
                listLevel.Add("DANAIKIKAI6", (dtpDanAIKIKAI6.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI6.SelectedDate.Value);
                listLevel.Add("DANAIKIKAI7", (dtpDanAIKIKAI7.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI7.SelectedDate.Value);
                listLevel.Add("DANAIKIKAI8", (dtpDanAIKIKAI8.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI8.SelectedDate.Value);
                DateTime Day_Create = DateTime.Now;
                Boolean DeleteFlag = false;
                db.RegisterNewMember(NewRegisterNumber, SKU, FullName, Nation, Address, PhoneNumber, RegisterDay, Day_of_Birth, Place_of_Birth, RegisterClass, listLevel, Day_Create,DeleteFlag,arrImage);

            }
        }

        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {
            SettingImage_BLO settingImage_BLO = new SettingImage_BLO();
            try
            {
                ImageBrush image = settingImage_BLO.LoadImage_Button();
                if (image == null) return;  // Case: Open Dialog but not choose image
                ImageButton.Background = image;
                arrImage = settingImage_BLO.ConvertImage_ToBytes(image.ImageSource);
            }
            catch { MessageBox.Show("Ảnh không hợp lệ", "Lỗi"); }          
        }
     
        private void Print_MouseEnter(object sender, RoutedEventArgs e)
        {

        }

        private Boolean Check_DataBase()
        {
            try
            {
                string err = null;
                int error = 0;

                if (txtSKU.Text.Equals("")) { err += "SKU is not input " + "\n"; error = 1;}
                if (txtName.Text.Equals("")) {err += "Họ Tên is not input" + "\n"; error = 1;   }
                if (txtAddress.Text.Equals(""))  {err += "Địa chỉ is not input" + "\n"; error = 1; }
                if (txtPhone.Text.Equals("")) { err += "Số Điện Thoại is not input" + "\n"; error = 1;  }
                if(dtpRegisterDay.SelectedDate==null) { err += "Ngày Đăng Ký is not input" + "\n"; error = 1;}
                if (dtpBirthday.SelectedDate == null) {err += "Ngày Sinh is not input" + "\n"; error = 1;}
                if (txtBirthplace.Text.Equals("")) {err += "Nơi sinh is not input" + "\n"; error = 1; }
                if (cboRegisterClass.SelectedValue==null) {err += "Lớp Đăng Ký is not input" + "\n"; error = 1;}
                if (txtSKU.Text.Length > 20) {err += "SKU nhỏ hơn 20 ký tự\n"; error = 1;  }
                if (txtName.Text.Length > 50) { err += "Họ Tên quá dài\n";  error = 1; }
                if (txtName.Text.Length > 50) { err += "Quốc Tịch quá dài\n"; error = 1; }
                if(txtAddress.Text.Length>100) { err += "Địa chỉ quá dài\n"; error = 1; }
                if(txtBirthplace.Text.Length>50) { err += "Nơi sinh quá dài\n"; error = 1; }
                if(dtpBirthday.SelectedDate >DateTime.Now) { err += "Ngày sinh phải nhỏ hơn hiện tại\n"; error = 1; }
                
                if (dtpLevel6.SelectedDate > dtpLevel5.SelectedDate)  { err +=messageCheckDateCap(6,5) ; error = 1; }
                if (dtpLevel5.SelectedDate > dtpLevel4.SelectedDate) { err += messageCheckDateCap(5,4); error = 1; }
                if (dtpLevel4.SelectedDate>dtpLevel3.SelectedDate)  { err += messageCheckDateCap(4,3); error = 1; }
                if(dtpLevel3.SelectedDate > dtpLevel2.SelectedDate)  { err += messageCheckDateCap(3,2); error = 1; }
                if(dtpLevel2.SelectedDate > dtpLevel1.SelectedDate)  { err += messageCheckDateCap(2, 1); error = 1; }

                if (dtpDanVN1.SelectedDate > dtpDanVN2.SelectedDate) { err += messageCheckDateDANVN(1, 2); error = 1; }
                if (dtpDanVN2.SelectedDate > dtpDanVN3.SelectedDate) { err += messageCheckDateDANVN(2, 3); error = 1; }
                if (dtpDanVN3.SelectedDate > dtpDanVN4.SelectedDate) { err += messageCheckDateDANVN(3, 4); error = 1; }
                if (dtpDanVN4.SelectedDate > dtpDanVN5.SelectedDate) { err += messageCheckDateDANVN(4, 5); error = 1; }
                if (dtpDanVN5.SelectedDate > dtpDanVN6.SelectedDate) { err += messageCheckDateDANVN(5, 6); error = 1; }
                if (dtpDanVN6.SelectedDate > dtpDanVN7.SelectedDate) { err += messageCheckDateDANVN(5, 6); error = 1; }
                if (dtpDanVN7.SelectedDate > dtpDanVN8.SelectedDate) { err += messageCheckDateDANVN(5, 6); error = 1; }

                if (dtpDanAIKIKAI1.SelectedDate > dtpDanAIKIKAI2.SelectedDate) { err += messageCheckDateDANAIKIKAI(1, 2); error = 1; }
                if (dtpDanAIKIKAI2.SelectedDate > dtpDanAIKIKAI3.SelectedDate) { err += messageCheckDateDANAIKIKAI(2, 3); error = 1; }
                if (dtpDanAIKIKAI3.SelectedDate > dtpDanAIKIKAI4.SelectedDate) { err += messageCheckDateDANAIKIKAI(3, 4); error = 1; }
                if (dtpDanAIKIKAI4.SelectedDate > dtpDanAIKIKAI5.SelectedDate) { err += messageCheckDateDANAIKIKAI(4, 5); error = 1; }
                if (dtpDanAIKIKAI5.SelectedDate > dtpDanAIKIKAI6.SelectedDate) { err += messageCheckDateDANAIKIKAI(5, 6); error = 1; }
                if (dtpDanAIKIKAI6.SelectedDate > dtpDanAIKIKAI7.SelectedDate) { err += messageCheckDateDANAIKIKAI(6, 7); error = 1; }
                if (dtpDanAIKIKAI7.SelectedDate > dtpDanAIKIKAI8.SelectedDate) { err += messageCheckDateDANAIKIKAI(7, 8); error = 1; }

                if (error==1)
                {
                    MessageBox.Show(err, "Lỗi");
                    return false;
                }
                if (!Regex.IsMatch(txtPhone.Text, @"(<Undefined control sequence>\d)?^[0-9]{10,13}$"))
                {
                    MessageBox.Show("Error!, Số Điện Thoại is invalid  ");
                }
                
                return true;
            }
            catch
            {
                MessageBox.Show("Error!,Lỗi nhập thông tin ");
                return false;
            }
        }
        private String messageCheckDateCap(int a, int b)
        {
            return $"Ngày cấp DAI {a} phải trước ngày cấp DAI {b}\n";
        }
        private String messageCheckDateDANVN(int a, int b)
        {
            return $"Ngày cấp DAN VN {a} phải trước ngày cấp DAN VN {b}\n";
        }
        private String messageCheckDateDANAIKIKAI(int a, int b)
        {
            return $"Ngày cấp DAN AIKIKAI {a} phải trước ngày cấp DAN AIKIKAI {b}\n";
        }
        //------------------------------------------------------Menu bar


        private void btnDKHV_MouseEnter(object sender, MouseEventArgs e)
        {
            btnDKHVb.Background = Brushes.DarkBlue;
            btnDKHV.Background =  Brushes.LightGray;
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
            
            //RegisterMemberScreen rgm = new RegisterMemberScreen();
            //rgm.Show();
            //this.Close();
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

  

    }
}
