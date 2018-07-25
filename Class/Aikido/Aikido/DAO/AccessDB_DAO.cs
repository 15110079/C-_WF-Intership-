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
            if (!File.Exists("sDBe.db"))
            {
                //_created = true;
                //Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite(@"Data Source=C:\Users\VUONGVANHAU\Desktop\sDBe.db");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<DAI_DAN> Dai_Dans { get; set; }
        public DbSet<Learn> Learns { get; set; }
        public DbSet<Provide_DAI_DAN> Provide_Dai_Dans { get; set; }
        public DbSet<StoreSettingImage_Model> SettingImage { get; set; }

    }
}
