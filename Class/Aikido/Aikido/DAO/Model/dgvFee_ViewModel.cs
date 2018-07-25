using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aikido.DAO.Model
{
    public class dgvFee_ViewModel
    {
        [ColumnName("RegisterNumber")]
        public int RegisterNumber { get; set; }
        [ColumnName("SKU")]
        public string lblSKU { get; set; }
        [ColumnName("Tên Hội Viên")]
        public string lblnameHV { get; set; }
        [ColumnName("Tên Lớp")]
        public string lblnameClass { get; set; }
        [ColumnName("Loại Phí")]
        public string lbltypeFee { get; set; }
        [ColumnName("Tháng")]
        public decimal lblmonthHT3A { get; set; }
        [ColumnName("Tháng")]
        public decimal lblmonthHT2A { get; set; }
        [ColumnName("Tháng")]
        public decimal lblmonthHT1A { get; set; }
        [ColumnName("Tháng")]
        public decimal lblmonthHT { get; set; }
        [ColumnName("Tháng")]
        public decimal lblmonthHT1P { get; set; }
        [ColumnName("Tháng")]
        public decimal lblmonthHT2P { get; set; }
        [ColumnName("Tháng")]
        public decimal lblmonthHT3P { get; set; }
        [ColumnName("Tháng")]
        public decimal lblmonthHT4P { get; set; }
        [ColumnName("Tháng")]
        public decimal lblmonthHT5P { get; set; }
        [ColumnName("Tháng")]
        public decimal lblmonthHT6P { get; set; }

        [ColumnName("Tháng")]
        public decimal lblDmonthHT3A { get; set; }
        [ColumnName("Tháng")]
        public decimal lblDmonthHT2A { get; set; }
        [ColumnName("Tháng")]
        public decimal lblDmonthHT1A { get; set; }
        [ColumnName("Tháng")]
        public decimal lblDmonthHT { get; set; }
        [ColumnName("Tháng")]
        public decimal lblDmonthHT1P { get; set; }
        [ColumnName("Tháng")]
        public decimal lblDmonthHT2P { get; set; }
        [ColumnName("Tháng")]
        public decimal lblDmonthHT3P { get; set; }
        [ColumnName("Tháng")]
        public decimal lblDmonthHT4P { get; set; }
        [ColumnName("Tháng")]
        public decimal lblDmonthHT5P { get; set; }
        [ColumnName("Tháng")]
        public decimal lblDmonthHT6P { get; set; }

        [ColumnName("Tổng Hội Phí")]
        public decimal lblToTalS { get; set; }
    }
    public class dgvTotalC_ViewModel
    {
        public string lblToal { get; set; }

        public decimal lblmonthHT3A { get; set; }

        public decimal lblmonthHT2A { get; set; }

        public decimal lblmonthHT1A { get; set; }

        public decimal lblmonthHT { get; set; }

        public decimal lblmonthHT1P { get; set; }

        public decimal lblmonthHT2P { get; set; }

        public decimal lblmonthHT3P { get; set; }

        public decimal lblmonthHT4P { get; set; }

        public decimal lblmonthHT5P { get; set; }

        public decimal lblmonthHT6P { get; set; }

        public decimal lblToTalS { get; set; }
    }
}
