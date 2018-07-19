using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aikido.DAO;
namespace Aikido.BLO
{
   public class ManageClass_BLO
    {
        LoadClass_DAO Class_DAO;
        public ManageClass_BLO()
        {
            Class_DAO = new LoadClass_DAO();
        }
        //Load Clsss
        //Delete Class
        //Export Excel
        //Save Class Info
        //Load Combox Class
        public List<Class> ComboxClass()
        {
           return Class_DAO.LoadComboxClass();

        }
    }
}
