using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AidikoMemberManagement.View
{
    public class authors
    {
        [ColumnName("Mã")]
        public int ID { get; set; }
        [ColumnName("Tên")]
        public string Name { get; set; }
        [ColumnName("Ngày")]
        public DateTime DOB { get; set; }
        [ColumnName("Tiêu Đề Sách")]
        public string BookTitle { get; set; }
        [ColumnName("MVP")]
        public bool IsMVP { get; set; }
    }
}
