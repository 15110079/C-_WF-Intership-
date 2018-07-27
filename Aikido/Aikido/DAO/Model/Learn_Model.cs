using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Aikido.DAO
{
    public class Learn
    {
        [Key]
        public int ID_Learn { get; set; }

        [ForeignKey("Student")]
        public int RegisterNumber { get; set; }

        [ForeignKey("Class")]
        public int ID_Class { get; set; }

        public decimal Fee_January { get; set; }
        public decimal Fee_February { get; set; }
        public decimal Fee_March { get; set; }
        public decimal Fee_April { get; set; }
        public decimal Fee_May { get; set; }
        public decimal Fee_June { get; set; }
        public decimal Fee_July { get; set; }
        public decimal Fee_August { get; set; }
        public decimal Fee_September { get; set; }
        public decimal Fee_October { get; set; }
        public decimal Fee_November { get; set; }
        public decimal Fee_December { get; set; }


        public decimal FeeD_January { get; set; }
        public decimal FeeD_February { get; set; }
        public decimal FeeD_March { get; set; }
        public decimal FeeD_April { get; set; }
        public decimal FeeD_May { get; set; }
        public decimal FeeD_June { get; set; }
        public decimal FeeD_July { get; set; }
        public decimal FeeD_August { get; set; }
        public decimal FeeD_September { get; set; }
        public decimal FeeD_October { get; set; }
        public decimal FeeD_November { get; set; }
        public decimal FeeD_December { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime RegisterDay { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Day_Create { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? Day_Update { get; set; }


        public bool Delete_Flag { get; set; }

        public virtual Student Student { get; set; }
        public virtual Class Class { get; set; }
    }
}
