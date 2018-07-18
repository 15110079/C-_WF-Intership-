using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Aikido.DAO
{
    public class Class
    {
        [Key]
        public int ID_Class { get; set; }

        [Required]
        [StringLength(30)]
        public String Class_Name { get; set; }

        [DataType(DataType.Time)]
        public DateTime Start_Time { get; set; }

        [DataType(DataType.Time)]
        public DateTime End_Time { get; set; }

        public Boolean Monday { get; set; }
        public Boolean Tuesday { get; set; }
        public Boolean Wednesday { get; set; }
        public Boolean Thursday { get; set; }
        public Boolean Friday { get; set; }
        public Boolean Saturday { get; set; }
        public Boolean Sunday { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime Day_Create { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? Day_Update { get; set; }

        public Boolean Delete_Flag { get; set; }

    }
}
