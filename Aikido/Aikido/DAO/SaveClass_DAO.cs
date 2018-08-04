using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aikido.DAO.Model;
namespace Aikido.DAO
{
    public class SaveClass_DAO
    {
        public void saveClass(List<dgvClass_ViewModel> datadgvAdd, List<dgvClass_ViewModel> datadgvUpdate)
        {
            using (var dataContext = new AccessDB_DAO())
            {
                 
                int IdClass;
                try
                {
                  IdClass= dataContext.Classes.Max(s => s.ID_Class);
                }
                catch { IdClass= 0; }
                foreach (var dataClass in datadgvAdd)
                {
                    Class data = new Class();
                    data.ID_Class = ++IdClass;
                    data.Class_Name = dataClass.txtName;
                    data.Start_Time = DateTime.Parse(dataClass.txtStartTime);
                    data.End_Time = DateTime.Parse(dataClass.txtFinishTime);
                    data.Monday = dataClass.cbMonday;
                    data.Tuesday = dataClass.cbTuesday;
                    data.Wednesday = dataClass.cbWednesday;
                    data.Thursday = dataClass.cbThursday;
                    data.Friday = dataClass.cbFriday;
                    data.Saturday = dataClass.cbSarturday;
                    data.Sunday = dataClass.cbSunday;
                    data.Day_Create = DateTime.Now;
                    data.Day_Update = DateTime.MinValue;
                    data.Delete_Flag = false;
                    dataContext.Classes.Add(data);
                    dataContext.SaveChanges();
                }
                foreach (var dataClass in datadgvUpdate)
                {
                    Class data = dataContext.Classes.FirstOrDefault(s => s.ID_Class == dataClass.ID);
                    data.Class_Name = dataClass.txtName;
                    data.Start_Time = DateTime.Parse(dataClass.txtStartTime);
                    data.End_Time = DateTime.Parse(dataClass.txtFinishTime);
                    data.Monday = dataClass.cbMonday;
                    data.Tuesday = dataClass.cbTuesday;
                    data.Wednesday = dataClass.cbWednesday;
                    data.Thursday = dataClass.cbThursday;
                    data.Friday = dataClass.cbFriday;
                    data.Saturday = dataClass.cbSarturday;
                    data.Sunday = dataClass.cbSunday;
                    data.Day_Update = DateTime.Now;
                    dataContext.Classes.Update(data);
                    dataContext.SaveChanges();
                }
            }
        }
    }
}
