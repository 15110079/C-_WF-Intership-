using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aikido.DAO;
using System.IO;

namespace Aikido.DAO
{
    public class AccessDB_DAO : DbContext

    {
        //private static bool _created = false;
        public AccessDB_DAO()
        {
            if (!File.Exists("DB.db"))
            {
                //_created = true;
                //Database.EnsureDeleted();
                Database.EnsureCreated();


                //Classes.Add(new Class() { Class_Name = "A", Start_Time = new DateTime(2016, 6, 28), End_Time = new DateTime(2016, 6, 28), Monday = true, Tuesday = true, Wednesday = false, Thursday = false, Friday = true, Saturday = false, Sunday = true, Delete_Flag = true, Day_Update = new DateTime(2016, 6, 28), Day_Create = new DateTime(2016, 6, 28) });
                //        dataContext.Classes.Add(new Class() { Class_Name = "B", Start_Time = new DateTime(2016, 6, 28), End_Time = new DateTime(2016, 6, 28), Monday = true, Tuesday = true, Wednesday = false, Thursday = false, Friday = true, Saturday = false, Sunday = true, Delete_Flag = true, Day_Update = new DateTime(2016, 6, 28), Day_Create = new DateTime(2016, 6, 28) });
                //        dataContext.Classes.Add(new Class() { Class_Name = "C", Start_Time = new DateTime(2016, 6, 28), End_Time = new DateTime(2016, 6, 28), Monday = true, Tuesday = true, Wednesday = false, Thursday = false, Friday = true, Saturday = false, Sunday = true, Delete_Flag = true, Day_Update = new DateTime(2016, 6, 28), Day_Create = new DateTime(2016, 6, 28) });

                //        //dataContext.Learns.Add(new Learn() { ID_Class = 1, RegisterNumber = 1, Fee_January = 0, Fee_February = 0, Fee_March = 0, Fee_April = 0, Fee_May = 0, Fee_June = 0, Fee_July = 0, Fee_August = 0, Fee_September = 0, Fee_October = 0, Fee_December = 0, Fee_November = 0, RegisterDay = DateTime.Now, Day_Create = DateTime.Now, Delete_Flag = false });

                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap6", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap5", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap4", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap3", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap2", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "Cap1", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN1", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN2", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN3", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN4", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN5", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN6", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN7", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANVN8", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI1", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI2", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI3", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI4", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI5", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI6", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI7", Day_Create = DateTime.Now, Delete_Flag = false });
                //        dataContext.Dai_Dans.Add(new DAI_DAN() { Name = "DANAIKIKAI8", Day_Create = DateTime.Now, Delete_Flag = false });
                // Sql("SET IDENTITY_INSERT MembershipTypes ON INSERT INTO MembershipTypes (Typeid,name,SignUpFee,DurationInMonths,DiscountRate) values (1,'Pay as You Go',2,3,4)");

                //}
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite(@"Data Source=C:\Users\minhh\OneDrive\Desktop\C#_WF\Github\Aikido\DB.db");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<DAI_DAN> Dai_Dans { get; set; }
        public DbSet<Learn> Learns { get; set; }
        public DbSet<Provide_DAI_DAN> Provide_Dai_Dans { get; set; }
        public DbSet<StoreSettingImage_Model> SettingImage { get; set; }

    }
}
