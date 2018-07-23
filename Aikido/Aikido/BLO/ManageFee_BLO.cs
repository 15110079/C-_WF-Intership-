using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aikido.DAO;
using Aikido.DAO.Model;
namespace Aikido.BLO
{
    public class Data_dgvFee
    {
        [ColumnName("SKU")]
        public string SKU { get; set; }
        [ColumnName("Tên Hội Viên")]
        public string nameHV { get; set; }
        [ColumnName("Lớp")]
        public string nameClass { get; set; }
        [ColumnName("Loại Phí")]
        public string typeFee { get; set; }
        [ColumnName("Tháng")]
        public string monthHT3A { get; set; }
        [ColumnName("Tháng")]
        public string monthHT2A { get; set; }
        [ColumnName("Tháng")]
        public string monthHT1A { get; set; }
        [ColumnName("Tháng")]
        public string monthHT { get; set; }
        [ColumnName("Tháng")]
        public string monthHT1P { get; set; }
        [ColumnName("Tháng")]
        public string monthHT2P { get; set; }
        [ColumnName("Tháng")]
        public string monthHT3P { get; set; }
        [ColumnName("Tháng")]
        public string monthHT4P { get; set; }
        [ColumnName("Tháng")]
        public string monthHT5P { get; set; }
        [ColumnName("Tháng")]
        public string monthHT6P { get; set; }
        [ColumnName("Tổng")]
        public string toalFeeS { get; set; }
    }
    public class ManageFee_BLO
    {
        //ExportExcel
        public void ExportFee(List<Data_dgvFee> dataExport)
        {
            ExportExcel_DAO exportFee = new ExportExcel_DAO();
        }
        //Load Fee
        public List<Data_dgvFee> LoadFee()
        {
            LoadFee_DAO loadFee = new LoadFee_DAO();
            List<Data_dgvFee> datas = new List<Data_dgvFee>();
            datas = loadFee.selectAll();
            return datas;
        }
        //Save Fee Infos
        
        private void SaveFee(List<Data_dgvFee> dgvFees)
        {
            SaveFee_DAO saveFee = new SaveFee_DAO();

        }
        //Filter
        public List<Data_dgvFee> FilterFee(string nameClass)
        {
            FilterFee_DAO filterFee = new FilterFee_DAO();
            List<Data_dgvFee> dtfilter = new List<Data_dgvFee>();
            dtfilter = filterFee.filter(nameClass);
            return dtfilter;
        }
    }
}
