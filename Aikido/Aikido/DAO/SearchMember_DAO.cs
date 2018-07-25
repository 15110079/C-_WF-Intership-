using Aikido.BLO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aikido.DAO.Model;
using System.Globalization;


namespace Aikido.DAO
{

    public class SearchMember_DAO
    {

        //lấy dữ liệu
        public List<Search_Model> GetStudent()
        {

            using (var dbContext = new AccessDB_DAO())
            {
                List<Search_Model> datas = new List<Search_Model>();
                try
                {
                    var query = dbContext.Students;

                    //var a=dbContext.Searches.Select(c => new { c.FullName, c.Nation }).ToList();
                    foreach (var i in query)
                    {
                        Search_Model data = new Search_Model();
                        data.RegisterNumber = i.RegisterNumber;
                        data.SKU = i.SKU;
                        data.FullName = i.FullName;
                        data.Nation = i.Nation;
                        data.Address = i.Address;
                        data.PhoneNumber = i.PhoneNumber;
                        data.Day_of_Birth = i.Day_of_Birth.Date;
                        data.Place_of_birth = i.Place_of_Birth;
                        data.Day_Create = i.Day_Create.Date;
                        var lp = dbContext.Learns.Where(s => s.RegisterNumber == i.RegisterNumber).Last();
                        var gt = dbContext.Classes.Where(s => s.ID_Class == lp.ID_Class).Last();
                        data.class_ID = gt.ID_Class;
                        data.Class_Name = gt.Class_Name;
                        data.Image = i.Image;
                       
                        //Lấy Mã DAI DAN
                        foreach (var dd in dbContext.Provide_Dai_Dans.Where(s => s.RegisterNumber == i.RegisterNumber))
                        {
                            var na = dbContext.Dai_Dans.Where(s => s.ID == dd.ID_DAI_DAN).First();
                            if (na.Name.Equals("Cấp 6")) data.DAI_Cap_6 = dd.Day_Create;
                            if (na.Name.Equals("Cấp 5")) data.DAI_Cap_5 = dd.Day_Create;
                            if (na.Name.Equals("Cấp 4")) data.DAI_Cap_4 = dd.Day_Create;
                            if (na.Name.Equals("Cấp 3")) data.DAI_Cap_3 = dd.Day_Create;
                            if (na.Name.Equals("Cấp 2")) data.DAI_Cap_2 = dd.Day_Create;
                            if (na.Name.Equals("Cấp 1")) data.DAI_Cap_1 = dd.Day_Create;
                            if (na.Name.Equals("I DAN VN")) data.DAN_VN_1 = dd.Day_Create;
                            if (na.Name.Equals("II DAN VN")) data.DAN_VN_2 = dd.Day_Create;
                            if (na.Name.Equals("III DAN VN")) data.DAN_VN_3 = dd.Day_Create;
                            if (na.Name.Equals("IV DAN VN")) data.DAN_VN_4 = dd.Day_Create;
                            if (na.Name.Equals("V DAN VN")) data.DAN_VN_5 = dd.Day_Create;
                            if (na.Name.Equals("VI DAN VN")) data.DAN_VN_6 = dd.Day_Create;
                            if (na.Name.Equals("VII DAN VN")) data.DAN_VN_7 = dd.Day_Create;
                            if (na.Name.Equals("VIII DAN VN")) data.DAN_VN_8 = dd.Day_Create;
                            if (na.Name.Equals("I DAN AIKIKAI")) data.DAN_AIKIKAI_1 = dd.Day_Create;
                            if (na.Name.Equals("II DAN AIKIKAI")) data.DAN_AIKIKAI_2 = dd.Day_Create;
                            if (na.Name.Equals("III DAN AIKIKAI")) data.DAN_AIKIKAI_3 = dd.Day_Create;
                            if (na.Name.Equals("IV DAN AIKIKAI")) data.DAN_AIKIKAI_4 = dd.Day_Create;
                            if (na.Name.Equals("V DAN AIKIKAI")) data.DAN_AIKIKAI_5 = dd.Day_Create;
                            if (na.Name.Equals("VI DAN AIKIKAI")) data.DAN_AIKIKAI_6 = dd.Day_Create;
                            if (na.Name.Equals("VII DAN AIKIKAI")) data.DAN_AIKIKAI_7 = dd.Day_Create;
                            if (na.Name.Equals("VIII DAN AIKIKAI")) data.DAN_AIKIKAI_8 = dd.Day_Create;
                        }
                        
                        datas.Add(data);
                        
                    }
                }
                catch
                {

                }
                return datas;
            }
        }

        //Tìm kiếm theo điều kiện
        public List<Search_Model> SearchMember(String SKU, String HoTen, String NgayDangKy, String NgaySinh)
        {

            using (var db = new AccessDB_DAO())
            {
                if (NgayDangKy == "" && NgaySinh == "")
                {
                    List<Search_Model> listThanhVien = new List<Search_Model>();
                    foreach (var i in GetStudent())
                    {
                        if (i.FullName.Contains(HoTen) && i.SKU.Contains(SKU))
                        {
                            listThanhVien.Add(i);
                        }

                    }
                    return listThanhVien.ToList();
                }

                else if (NgayDangKy == "" && NgaySinh != "")
                {
                  
                    List<Search_Model> listThanhVien = new List<Search_Model>();
                    foreach (var i in GetStudent())
                    {
                        if (i.FullName.Contains(HoTen) && i.SKU.Contains(SKU) && i.Day_of_Birth == DateTime.Parse(NgaySinh))
                        {
                            listThanhVien.Add(i);
                        }
                    }
                    return listThanhVien.ToList();
                }
                else if (NgaySinh == "" && NgayDangKy != "")
                {
                    //var listThanhVien = from ltv in db.S
                    //                    where ltv.FullName.Contains(HoTen)
                    //                    && ltv.SKU.Contains(SKU)
                    //                    && ltv.Day_Create == DateTime.Parse(NgayDangKy)
                    //                    select ltv;
                    List<Search_Model> listThanhVien = new List<Search_Model>();
                    foreach (var i in GetStudent())
                    {
                        if (i.FullName.Contains(HoTen) && i.SKU.Contains(SKU) && i.Day_Create == DateTime.Parse(NgayDangKy))
                        {
                            listThanhVien.Add(i);
                        }
                    }
                    return listThanhVien.ToList();
                }

                else
                {
                    //var listThanhVien = from ltv in db.Searches
                    //                    where ltv.FullName.Contains(HoTen)
                    //                    && ltv.SKU.Contains(SKU)
                    //                    && ltv.Day_Create == DateTime.Parse(NgayDangKy)
                    //                    && ltv.Day_of_Birth == DateTime.Parse(NgaySinh)
                    //                    select ltv;
                    List<Search_Model> listThanhVien = new List<Search_Model>();
                    foreach (var i in GetStudent())
                    {
                        if (i.FullName.Contains(HoTen) && i.SKU.Contains(SKU) && i.Day_Create == DateTime.Parse(NgayDangKy)
                                        && i.Day_of_Birth == DateTime.Parse(NgaySinh))
                        {
                            listThanhVien.Add(i);
                        }
                    }
                    return listThanhVien.ToList();
                }
            }

        }
        //Tìm kiếm nhanh
        public List<Search_Model> QuicSearchMember(String key)
        {
            using (var db = new AccessDB_DAO())
            {
                List<Search_Model> listThanhVien = new List<Search_Model>();

                try
                {
                    DateTime x = DateTime.Parse(key);
                    foreach (var i in GetStudent())
                    {
                        if (i.Day_Create == x || i.Day_of_Birth == x)
                        {
                            listThanhVien.Add(i);
                        }
                    }
                    return listThanhVien.ToList();
                }
                catch
                {
                    foreach (var i in GetStudent())
                    {
                        if (i.FullName.Contains(key) || i.SKU.Contains(key))
                        {
                            listThanhVien.Add(i);
                        }
                    }
                    return listThanhVien.ToList();
                }
            }
        }

    }
}
