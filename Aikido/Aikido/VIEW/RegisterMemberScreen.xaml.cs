using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Aikido.DAO;
using Aikido.BLO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;
using Aikido.DAO.Model;

namespace Aikido.VIEW
{
    ///
    public partial class RegisterMemberScreen : Window
    {
        RegisterMember_BLO db =  new RegisterMember_BLO(); 
        ManageClass_BLO ClassDB= new ManageClass_BLO();
        private Brush brush;
        private byte[] arrImage=null;

        //Constructor
        public RegisterMemberScreen()
        {
            InitializeComponent();
          
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            Thread.CurrentThread.CurrentCulture = ci;

            BrushConverter bc = new BrushConverter();
            brush = (Brush)bc.ConvertFrom("#E5E1E1");
            brush.Freeze();

            //txtRegisterNumber.Text = ("0000"+NewRegisterNumber).ToString();
            txtRegisterNumber.Background= Brushes.WhiteSmoke;

            //Load Class in Combobox
            List<Class> showCombobox = ClassDB.ComboxClass();
            cboRegisterClass.ItemsSource = showCombobox;
            cboRegisterClass.DisplayMemberPath = "Class_Name";
            cboRegisterClass.SelectedValuePath = "ID_Class";
            
            //Load Register Day
            dtpRegisterDay.SelectedDate = DateTime.Now;

        }
        public RegisterMemberScreen(Search_Model search_Model)
        {
            InitializeComponent();
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            Thread.CurrentThread.CurrentCulture = ci;

           
            List<Class> showCombobox = ClassDB.ComboxClass();
            cboRegisterClass.ItemsSource = showCombobox;
            cboRegisterClass.DisplayMemberPath = "Class_Name";
            cboRegisterClass.SelectedValuePath = "ID_Class";

            Set_DBVIew(search_Model);
        }

        // Handle register member
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            DateTime Day_Create = DateTime.Now;
            Boolean DeleteFlag = false;
            if (Check_DataBase() == true)
            {
                MemberInfo_ViewModel info = new MemberInfo_ViewModel();
                info = getDB_FromForm();
                if (txtRegisterNumber.Text.Equals(""))
                {
                    try
                    {                   
                        db.RegisterNewMember(info, Day_Create, DeleteFlag);

                    }
                    catch(Exception r)
                    {
                        MessageBox.Show("Lưu không thành công"+r, "Lỗi"); return;
                    }
                    SetEmplty();
                }
                else
                {
                    try
                    {
                        db.EditMember_Info(info, Day_Create, DeleteFlag);
                    }
                    catch(Exception r)
                    {
                        MessageBox.Show("Lưu không thành công"+r, "Lỗi"); return;
                    }
                }
                MessageBox.Show("Lưu Thành Công");
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
            ExportWord exportWord = new ExportWord();
            if (Check_DataBase() == true)
            {
                MemberInfo_ViewModel info = getDB_FromForm();
                SettingImage_BLO settingImage_BLO = new SettingImage_BLO();
                try
                {         
                     exportWord.CreateDocument(info, settingImage_BLO.getBackGround());
                }
                catch { MessageBox.Show("In file bị lỗi");  return; }
            }
         }

        private Boolean Check_DataBase()
        {
            try
            {
                string err = null;
                int error = 0;

                if (txtSKU.Text.Equals("")) { err += "SKU chưa được nhập " + "\n"; error = 1;}
                if (txtName.Text.Equals("")) {err += "Họ Tên chưa được nhập" + "\n"; error = 1;   }
                if (txtAddress.Text.Equals(""))  {err += "Địa chỉ chưa được nhập" + "\n"; error = 1; }
                if (txtPhone.Text.Equals("")) { err += "Số Điện Thoại chưa được nhập" + "\n"; error = 1;  }
                if(dtpRegisterDay.SelectedDate==null) { err += "Ngày Đăng Ký chưa được nhập" + "\n"; error = 1;}
                if (dtpBirthday.SelectedDate == null) {err += "Ngày Sinh chưa được nhập" + "\n"; error = 1;}
                if (txtBirthplace.Text.Equals("")) {err += "Nơi sinh chưa được nhập" + "\n"; error = 1; }
                if (cboRegisterClass.SelectedValue==null) {err += "Lớp Đăng Ký chưa được nhập" + "\n"; error = 1;}
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
                    MessageBox.Show("Số Điện Thoại không hợp lệ"); return false;
                }
                
                return true;
            }
            catch
            {
                MessageBox.Show(" Lỗi nhập thông tin ");
                return false;
            }
        }
        private void Set_DBVIew(Search_Model search_Model)
        {

            txtSKU.Text = search_Model.SKU.ToString();
            txtRegisterNumber.Text = search_Model.RegisterNumber.ToString();
            txtName.Text = search_Model.FullName.ToString();
            txtNation.Text = search_Model.Nation.ToString();
            txtAddress.Text = search_Model.Address.ToString();
            txtPhone.Text = search_Model.PhoneNumber.ToString();
            dtpBirthday.Text = search_Model.Day_of_Birth.ToString();
            dtpRegisterDay.Text = search_Model.Day_Create.ToString();
            txtBirthplace.Text = search_Model.Place_of_birth.ToString();
            cboRegisterClass.Text = search_Model.Class_Name.ToString();
            cboRegisterClass.SelectedValue = search_Model.class_ID;

            arrImage = search_Model.Image;
            SettingImage_BLO settingImage_BLO = new SettingImage_BLO();
            try
            {
                ImageBrush image  = new ImageBrush();
                image.ImageSource =settingImage_BLO.ConvertByte_ToImage(arrImage);
                if (image == null) return;  // Case: Open Dialog but not choose image
                ImageButton.Background = image;
            }
            catch { MessageBox.Show("Ảnh không hợp lệ", "Lỗi"); }

            dtpLevel6.Text = search_Model.DAI_Cap_6.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAI_Cap_6.ToString();
            dtpLevel5.Text = search_Model.DAI_Cap_5.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAI_Cap_5.ToString();
            dtpLevel4.Text = search_Model.DAI_Cap_4.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAI_Cap_4.ToString();
            dtpLevel3.Text = search_Model.DAI_Cap_3.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAI_Cap_3.ToString();
            dtpLevel2.Text = search_Model.DAI_Cap_2.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAI_Cap_2.ToString();
            dtpLevel1.Text = search_Model.DAI_Cap_1.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAI_Cap_1.ToString();

            dtpDanVN1.Text = search_Model.DAN_VN_1.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_VN_1.ToString();
            dtpDanVN2.Text = search_Model.DAN_VN_2.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_VN_2.ToString();
            dtpDanVN3.Text = search_Model.DAN_VN_3.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_VN_3.ToString();
            dtpDanVN4.Text = search_Model.DAN_VN_4.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_VN_4.ToString();
            dtpDanVN5.Text = search_Model.DAN_VN_5.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_VN_5.ToString();
            dtpDanVN6.Text = search_Model.DAN_VN_6.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_VN_6.ToString();
            dtpDanVN7.Text = search_Model.DAN_VN_7.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_VN_7.ToString();
            dtpDanVN8.Text = search_Model.DAN_VN_8.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_VN_8.ToString();


            dtpDanAIKIKAI1.Text = search_Model.DAN_AIKIKAI_1.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_AIKIKAI_1.ToString();
            dtpDanAIKIKAI2.Text = search_Model.DAN_AIKIKAI_2.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_AIKIKAI_2.ToString();
            dtpDanAIKIKAI3.Text = search_Model.DAN_AIKIKAI_3.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_AIKIKAI_3.ToString();
            dtpDanAIKIKAI4.Text = search_Model.DAN_AIKIKAI_4.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_AIKIKAI_4.ToString();
            dtpDanAIKIKAI5.Text = search_Model.DAN_AIKIKAI_5.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_AIKIKAI_5.ToString();
            dtpDanAIKIKAI6.Text = search_Model.DAN_AIKIKAI_6.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_AIKIKAI_6.ToString();
            dtpDanAIKIKAI7.Text = search_Model.DAN_AIKIKAI_7.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_AIKIKAI_7.ToString();
            dtpDanAIKIKAI8.Text = search_Model.DAN_AIKIKAI_8.ToString().Contains(DateTime.MinValue.ToString()) == true ? " " : search_Model.DAN_AIKIKAI_8.ToString();

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
        private MemberInfo_ViewModel getDB_FromForm( )
        {
            MemberInfo_ViewModel info = new MemberInfo_ViewModel();
            if (!txtRegisterNumber.Text.Equals("")) info.RegisterNumber = int.Parse(txtRegisterNumber.Text); //TH edit
            else info.RegisterNumber = db.NewRegisterNumber() + 1; 
            info.SKU = txtSKU.Text;
            info.FullName = txtName.Text;
            info.Nation = txtNation.Text;
            info.Address = txtAddress.Text;
            info.PhoneNumber = txtPhone.Text;
            info.Register_day = dtpRegisterDay.SelectedDate.Value;
            info.Day_of_Birth = (dtpBirthday.SelectedDate == null) ? DateTime.MinValue : dtpBirthday.SelectedDate.Value.Date;
            info.Place_of_Birth = txtBirthplace.Text;
            info.ID_Class = int.Parse(cboRegisterClass.SelectedValue.ToString());
            info.Class_Name = cboRegisterClass.Text;
            info.Image = arrImage;
            info.listLevel = new Dictionary<string, DateTime>();
            info.listLevel.Add("Cap6", (dtpLevel6.SelectedDate == null) ? DateTime.MinValue : dtpLevel6.SelectedDate.Value);
            info.listLevel.Add("Cap5", (dtpLevel5.SelectedDate == null) ? DateTime.MinValue : dtpLevel5.SelectedDate.Value);
            info.listLevel.Add("Cap4", (dtpLevel4.SelectedDate == null) ? DateTime.MinValue : dtpLevel4.SelectedDate.Value);
            info.listLevel.Add("Cap3", (dtpLevel3.SelectedDate == null) ? DateTime.MinValue : dtpLevel3.SelectedDate.Value);
            info.listLevel.Add("Cap2", (dtpLevel2.SelectedDate == null) ? DateTime.MinValue : dtpLevel2.SelectedDate.Value);
            info.listLevel.Add("Cap1", (dtpLevel1.SelectedDate == null) ? DateTime.MinValue : dtpLevel2.SelectedDate.Value);
            info.listLevel.Add("DANVN1", (dtpDanVN1.SelectedDate == null) ? DateTime.MinValue : dtpDanVN1.SelectedDate.Value);
            info.listLevel.Add("DANVN2", (dtpDanVN2.SelectedDate == null) ? DateTime.MinValue : dtpDanVN2.SelectedDate.Value);
            info.listLevel.Add("DANVN3", (dtpDanVN3.SelectedDate == null) ? DateTime.MinValue : dtpDanVN3.SelectedDate.Value);
            info.listLevel.Add("DANVN4", (dtpDanVN4.SelectedDate == null) ? DateTime.MinValue : dtpDanVN4.SelectedDate.Value);
            info.listLevel.Add("DANVN5", (dtpDanVN5.SelectedDate == null) ? DateTime.MinValue : dtpDanVN5.SelectedDate.Value);
            info.listLevel.Add("DANVN6", (dtpDanVN6.SelectedDate == null) ? DateTime.MinValue : dtpDanVN6.SelectedDate.Value);
            info.listLevel.Add("DANVN7", (dtpDanVN7.SelectedDate == null) ? DateTime.MinValue : dtpDanVN7.SelectedDate.Value);
            info.listLevel.Add("DANVN8", (dtpDanVN8.SelectedDate == null) ? DateTime.MinValue : dtpDanVN8.SelectedDate.Value);
            info.listLevel.Add("DANAIKIKAI1", (dtpDanAIKIKAI1.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI1.SelectedDate.Value);
            info.listLevel.Add("DANAIKIKAI2", (dtpDanAIKIKAI2.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI2.SelectedDate.Value);
            info.listLevel.Add("DANAIKIKAI3", (dtpDanAIKIKAI3.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI3.SelectedDate.Value);
            info.listLevel.Add("DANAIKIKAI4", (dtpDanAIKIKAI4.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI4.SelectedDate.Value);
            info.listLevel.Add("DANAIKIKAI5", (dtpDanAIKIKAI5.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI5.SelectedDate.Value);
            info.listLevel.Add("DANAIKIKAI6", (dtpDanAIKIKAI6.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI6.SelectedDate.Value);
            info.listLevel.Add("DANAIKIKAI7", (dtpDanAIKIKAI7.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI7.SelectedDate.Value);
            info.listLevel.Add("DANAIKIKAI8", (dtpDanAIKIKAI8.SelectedDate == null) ? DateTime.MinValue : dtpDanAIKIKAI8.SelectedDate.Value);

            return info;

        }
        //------------------------------------------------------Menu bar
        private void SetEmplty()
        {

            txtSKU.Text = "";
            txtRegisterNumber.Text = "";
            txtName.Text = "";
            txtNation.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            dtpBirthday.Text = "";
            dtpRegisterDay.Text = "";
            txtBirthplace.Text = "";
            cboRegisterClass.Text = "";
            cboRegisterClass.SelectedValue = null;
            cboRegisterClass.Text = "";

            dtpRegisterDay.SelectedDate = DateTime.Now;
            arrImage = null;
            ImageButton.Background = Brushes.WhiteSmoke; 

            dtpLevel6.Text = "";
            dtpLevel5.Text = "";
            dtpLevel4.Text = "";
            dtpLevel3.Text = "";
            dtpLevel2.Text = "";
            dtpLevel1.Text = "";
            dtpDanVN1.Text = "";
            dtpDanVN2.Text = "";
            dtpDanVN3.Text = "";
            dtpDanVN4.Text = "";
            dtpDanVN5.Text = "";
            dtpDanVN6.Text = "";
            dtpDanVN7.Text = "";
            dtpDanVN8.Text = "";


            dtpDanAIKIKAI1.Text = "";
            dtpDanAIKIKAI2.Text = "";
            dtpDanAIKIKAI3.Text = "";
            dtpDanAIKIKAI4.Text = "";
            dtpDanAIKIKAI5.Text = "";
            dtpDanAIKIKAI6.Text = "";
            dtpDanAIKIKAI7.Text = "";
            dtpDanAIKIKAI8.Text = "";
        }
        
        private void btnDKHV_MouseEnter(object sender, MouseEventArgs e)
        {
            //btnDKHVb.Background = Brushes.DarkBlue;
            //btnDKHV.Background = Brushes.LightGray;
        }

        private void btnDKHV_MouseLeave(object sender, MouseEventArgs e)
        {
            //if (btnSelect[0] == true)
            //{
            //    btnDKHVb.Background = Brushes.White;
            //    btnDKHV.Background = Brushes.White;
            //}
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
            //RegisterMemberScreen rgm = new RegisterMemberScreen();
            //rgm.Show();
            //this.Close();
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

 
    }
}
