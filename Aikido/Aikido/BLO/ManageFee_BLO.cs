using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aikido.DAO;
using Aikido.DAO.Model;
namespace Aikido.BLO
{
    public class ManageFee_BLO
    {
        //ExportExcel
        public void ExportFee(List<dgvFee_ViewModel> dataExport)
        {
            ExportExcel_DAO exportFee = new ExportExcel_DAO();
        }
        //Load Fee
        public List<dgvFee_ViewModel> LoadFee()
        {
            LoadFee_DAO loadFee = new LoadFee_DAO();
            List<dgvFee_ViewModel> datas = new List<dgvFee_ViewModel>();
            datas = loadFee.selectAll();
            return datas;
        }
        //Save Fee Infos
        
        private void SaveFee(List<dgvFee_ViewModel> dgvFees)
        {
            SaveFee_DAO saveFee = new SaveFee_DAO();

        }
        //Filter
        public List<dgvFee_ViewModel> FilterFee(string nameClass)
        {
            FilterFee_DAO filterFee = new FilterFee_DAO();
            List<dgvFee_ViewModel> dtfilter = new List<dgvFee_ViewModel>();
            dtfilter = filterFee.filter(nameClass);
            return dtfilter;
        }
    }
}
