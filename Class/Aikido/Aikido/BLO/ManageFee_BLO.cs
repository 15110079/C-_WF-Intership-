using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aikido.DAO.Model;
using Aikido.DAO;
namespace Aikido.BLO
{
    public class ManageFee_BLO
    {
        //ExportExcel
        //Load Fee
        
        public List<dgvFee_ViewModel> LoadAllFee()
        {
            LoadFee_DAO fee = new LoadFee_DAO();
            return fee.selectAll();
        }
        public List<dgvFee_ViewModel> LoadAllFee1()
        {
            LoadFee_DAO fee = new LoadFee_DAO();
            return fee.selectAllFee1();
        }
        //Save Fee Infos
        //Filter
    }
}
