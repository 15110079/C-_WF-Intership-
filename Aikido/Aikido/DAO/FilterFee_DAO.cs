using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aikido.BLO;
namespace Aikido.DAO
{
    public class FilterFee_DAO
    {
        public List<Data_dgvFee> filter(string nameClass)
        {
            List<Data_dgvFee> datas = new List<Data_dgvFee>();
            using (var dataContext = new AccessDB_DAO())
            {
                //var learn = from ls in dataContext.Learns where ls.Class.Class_Name.Contains(nameClass) select ls;
                var learns = dataContext.Learns.Where(s => s.Class.Class_Name.Contains(nameClass));
                foreach (var dt in learns)
                {
                    Data_dgvFee dtg = new Data_dgvFee();
                    dtg.SKU = dt.Student.SKU;
                    dtg.nameHV = dt.Student.FullName;
                    dtg.nameClass = dt.Class.Class_Name;
                    dtg.typeFee = "Hội Phí";
                    //Hội phí 10 tháng và total
                }
            }
            return datas; 
        }
    }
}
