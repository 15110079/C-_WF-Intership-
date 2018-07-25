using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aikido.DAO.Model;
namespace Aikido.DAO
{
    public class LoadFee_DAO
    {
        public List<dgvFee_ViewModel> selectAll()
        {
            List<dgvFee_ViewModel> data = new List<dgvFee_ViewModel>();

            using (var dataContext = new AccessDB_DAO())
            {
                var cls = dataContext.Learns.Where(s => s.Delete_Flag == false);
                foreach (var dt in cls)
                {
                    int r = DateTime.Now.Month;
                    var dts = dataContext.Students.Where(s => s.RegisterNumber == dt.RegisterNumber).First();
                    var dtc = dataContext.Classes.Where(s => s.ID_Class == dt.ID_Class).First();
                    dgvFee_ViewModel dtg = new dgvFee_ViewModel();
                    dtg.RegisterNumber = dt.RegisterNumber;
                    dtg.lblSKU = dts.SKU;
                    dtg.lblnameHV = dts.FullName;
                    dtg.lblnameClass = dtc.Class_Name;
                    dtg.lbltypeFee = "Hội Phí";
                    
                    dtg.lblToTalS = 0;
                    data.Add(dtg);
                }
            }
            return data;
        }
    }
}
