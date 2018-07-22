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
        SaveMemberInfo_DAO SaveMember_DAO;
        public RegisterMember_BLO()
        {
             SaveMember_DAO = new SaveMemberInfo_DAO();
        }

        public void RegisterNewMember(int RegisterNewNumber,string SKU,string Name,string Nation,string address, string phone, DateTime registerday, DateTime birthday, string birthplace,
                                        int malop, Dictionary<string,DateTime> listLevel,DateTime Day_Create, Boolean DeleteFlag, byte[] arrImage)
        {
            try
            {
                //get Register New Member
                SaveMember_DAO.SaveNewMember(SKU, Name, Nation, address, phone, registerday, birthday, birthplace, Day_Create, DeleteFlag,arrImage);
                SaveMember_DAO.SaveRegisterClass(RegisterNewNumber, malop, registerday);
                SaveMember_DAO.SaveLevel(listLevel, RegisterNewNumber);
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
           return  register_number= SaveMember_DAO.RegisterNewMember();
        }

      
        
    }
}
