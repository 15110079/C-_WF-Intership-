using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aikido.DAO.Model;
using Aikido.DAO;
namespace Aikido.BLO
{
    public class ManageClass_BLO
    {
        LoadClass_DAO Class_DAO = new LoadClass_DAO();
        //Load Class
        public List<dgvClass_ViewModel> LoadClass()
        {
            LoadClass_DAO loadData = new LoadClass_DAO();
            return loadData.selectAll();
        }
        //Delete Class

        //Save Class Info
        public void SaveClass(List<dgvClass_ViewModel> dataAdd, List<dgvClass_ViewModel> dataEdit)
        {
            SaveClass_DAO save = new SaveClass_DAO();     
            save.saveClass(dataAdd, dataEdit);
        }
        public void DeleteClass(int ID)
        {
            DeleteClass_DAO delete = new DeleteClass_DAO();
            delete.deleteClass(ID);
        }
        public List<Class> ComboxClass()
        {
            return Class_DAO.LoadComboxClass();
        }
    }
}
