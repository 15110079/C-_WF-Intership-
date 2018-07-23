using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aikido.BLO;
namespace Aikido.DAO
{
    class LoadFee_DAO
    {
        public List<Data_dgvFee> selectAll()
        {
            List<Data_dgvFee> data = new List<Data_dgvFee>();
            using (var dataContext = new AccessDB_DAO())
            {
                //var learns = from ls in dataContext.Learns select new { ls.Class.Class_Name, ls.Fee_April,ls.Fee_August };
                var learn = dataContext.Learns;
                foreach (var dt in learn)
                {
                    Data_dgvFee dtg = new Data_dgvFee();
                    dtg.SKU = dt.Student.SKU;
                    dtg.nameHV = dt.Student.FullName;
                    dtg.nameClass = dt.Class.Class_Name;
                    dtg.typeFee = "Hội Phí";
                    //Hội phí 10 tháng và total
                }
            }
            return data;
        }
    }
}
