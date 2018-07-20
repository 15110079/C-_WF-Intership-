using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Aikido.DAO;
namespace Aikido.BLO
{
    public class RegisterMember_BLO
    {
        SaveMemberInfo_DAO Member_DAO;
        public RegisterMember_BLO()
        {
             Member_DAO = new SaveMemberInfo_DAO();
        }

        public void RegisterNewMember(int RegisterNewNumber,string SKU,string Name,string Nation,string address, string phone, DateTime registerday, DateTime birthday, string birthplace,int malop, Dictionary<string,DateTime> listLevel,DateTime Day_Create, Boolean DeleteFlag)
        {
            try
            {
                //get Register New Member
                Member_DAO.SaveNewMember(SKU, Name, Nation, address, phone, registerday, birthday, birthplace, Day_Create, DeleteFlag);
                Member_DAO.SaveRegisterClass(RegisterNewNumber, malop, registerday);
                Member_DAO.SaveLevel(listLevel, RegisterNewNumber);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
           
        }
      
        //get new register member's number
        public int NewRegisterNumber()
        {
            int register_number;
           return  register_number= Member_DAO.RegisterNewMember();
        }

      
        
    }
}
