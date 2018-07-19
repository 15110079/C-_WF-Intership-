using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aikido.DAO
{
    public class LoadClass_DAO
    {
        public List<Class> LoadComboxClass()
        {
            List<Class> listclass = new List<Class>();
            using (  var db = new AccessDB_DAO())
            {
                // db.Classes.Select(x => x);
                foreach (var i in db.Classes)
                {
                    listclass.Add(i);
                };
            }
            return listclass;
        }
    }
}
