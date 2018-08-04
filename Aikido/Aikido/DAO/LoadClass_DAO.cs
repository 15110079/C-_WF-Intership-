using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aikido.DAO.Model;
namespace Aikido.DAO
{
    public class LoadClass_DAO
    {
        public List<dgvClass_ViewModel> selectAll()
        {
            List<dgvClass_ViewModel> data = new List<dgvClass_ViewModel>();
            using (var dataContext = new AccessDB_DAO())
            {
                var cls = dataContext.Classes.Where(s => s.Delete_Flag == false);
                foreach (var dt in cls)
                {
                    dgvClass_ViewModel dtg = new dgvClass_ViewModel();
                    dtg.ID = dt.ID_Class;
                    dtg.txtName = dt.Class_Name;
                    dtg.txtStartTime = dt.Start_Time.ToShortTimeString();
                    dtg.txtFinishTime = dt.End_Time.ToShortTimeString();
                    dtg.cbMonday = dt.Monday;
                    dtg.cbTuesday = dt.Tuesday;
                    dtg.cbWednesday = dt.Wednesday;
                    dtg.cbThursday = dt.Thursday;
                    dtg.cbFriday = dt.Friday;
                    dtg.cbSarturday = dt.Saturday;
                    dtg.cbSunday = dt.Sunday;
                    int sohv = 0;
                    var st = dataContext.Students.Where(s => s.Delete_Flag == false);
                    foreach (var i in st)
                    {
                        if (dataContext.Fees.FirstOrDefault(s => s.ID_Class == dt.ID_Class && s.RegisterNumber == i.RegisterNumber && s.Delete_Flag == false) != null)
                        {
                            sohv++;
                        }
                    }

                    dtg.txtAmountClass = sohv;
                    data.Add(dtg);
                }
            }
            return data;
        }
        //
        public List<Class> LoadComboxClass()
        {
            List<Class> listclass = new List<Class>();
            using (var db = new AccessDB_DAO())
            {
                foreach (var i in db.Classes.Where(c => c.Delete_Flag == false))
                {
                    listclass.Add(i);
                };
            }
            return listclass;
        }

    }
}
