using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aikido.DAO;
using Aikido.DAO.Model;
namespace Aikido.BLO
{
   public class ManageClass_BLO
    {
        LoadClass_DAO Class_DAO;
        public ManageClass_BLO()
        {
            Class_DAO = new LoadClass_DAO();
        }
        //Load Class
        public List<dgvClass_ViewModel> LoadClass()
        {
            LoadClass_DAO loadData = new LoadClass_DAO();
            return loadData.selectAll();
        }
        //Delete Class
        public void DeleteClass(int ID)
        {
            DeleteClass_DAO delete = new DeleteClass_DAO();
            delete.deleteClass(ID);
        }
        //Save Class Info
        public void SaveClass(List<dgvClass_ViewModel> dataAdd, List<dgvClass_ViewModel> dataEdit)
        {
            SaveClass_DAO save = new SaveClass_DAO();
            save.saveClass(dataAdd, dataEdit);
        }

        //Load Combox Class
        public List<Class> ComboxClass()
        {
           return Class_DAO.LoadComboxClass();

        }
    }
}
