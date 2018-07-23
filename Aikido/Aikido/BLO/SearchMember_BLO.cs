using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aikido.DAO;
using Aikido.VIEW;
using Aikido.DAO.Model;

namespace Aikido.BLO
{

    public class SearchMember_BLO
    {
        //public List<Data_dgvSearch> GetStudents()
        //{

        //    using (var dbContext = new AccessDB_DAO())
        //    {
        //        var query = from p in dbContext.Students
        //                    select p;

        //        List<Data_dgvSearch> datas = new List<Data_dgvSearch>();
        //    //var a=dbContext.Students.Select(c => new { c.FullName, c.Nation }).ToList();
        //    foreach (var i in query)
        //    {
        //        Data_dgvSearch data = new Data_dgvSearch();
        //        data.SKU = i.SKU;
        //        data.FullName = i.FullName;
        //        data.Nation = i.Nation;
        //        data.Address = i.Address;
        //        data.PhoneNumber = i.PhoneNumber;
        //        data.Day_Create = i.Day_Create.ToShortDateString();

        //        datas.Add(data);
        //    }
        //        return datas;

        //    }
        //}
        //public List<Student> Search()
        //{
        //    using (var dbContext = new AccessDB_DAO())
        //    {
        //        var listThanhVien = from ltv in dbContext.Students
        //                            where ltv.FullName.Contains(txtHoTen.Text)
        //                            select ltv;
        //        return listThanhVien.ToList();
        //    }
        //}

        //SearchMember_DAO getdata;
        //public SearchMember_BLO()
        //{
        //    getdata = new SearchMember_DAO();
        //}

        SearchMember_DAO getdata = new SearchMember_DAO();

        public List<Search_Model> getstudent()
        {
            return getdata.GetStudent();
        }

        public List<Search_Model> SearchCon(String SKU, String HoTen, String NgayDangKy, String NgaySinh)
        {
            return getdata.SearchMember(SKU, HoTen, NgayDangKy, NgaySinh);
        }

        //Tìm kiếm nhanh
        public List<Search_Model> SearchQuick(String key)
        {
            return getdata.QuicSearchMember(key);
        }
    }
}


