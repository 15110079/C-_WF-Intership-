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
                var query = dbContext.Students;/* from p in dbContext.Students
                            select p;*/

                List<Search_Model> datas = new List<Search_Model>();
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
                    data.Day_Create = i.Day_Create.Date;

                    datas.Add(data);
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
                    //List<Search> listThanhVien = from ltv in db.Students.Select(n=>new {n.RegisterNumber, n.SKU, n.FullName,n.Nation, n.Address, n.PhoneNumber,n.Day_of_Birth,n.Day_Create})
                    //                    where ltv.FullName.Contains(HoTen)
                    //                    && ltv.SKU.Contains(SKU)
                    //                    select ltv;
                    //return listThanhVien.ToList();
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
                    //var listThanhVien = from ltv in db.Students
                    //                    where ltv.FullName.Contains(HoTen)
                    //                    && ltv.SKU.Contains(SKU)
                    //                    && ltv.Day_of_Birth == DateTime.Parse(NgaySinh)
                    //                    select ltv;
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
