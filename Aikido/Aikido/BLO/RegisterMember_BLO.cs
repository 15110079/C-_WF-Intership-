using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Aikido.DAO;
using Aikido.DAO.Model;

namespace Aikido.BLO
{
    public class RegisterMember_BLO
    {
        SaveMemberInfo_DAO SaveMember_DAO;
        public RegisterMember_BLO()
        {
             SaveMember_DAO = new SaveMemberInfo_DAO();
        }

        public void RegisterNewMember(MemberInfo_ViewModel info,DateTime Day_Create, Boolean DeleteFlage)
        {
        
                //get Register New Member
                SaveMember_DAO.SaveNewMember(info.SKU, info.FullName, info.Nation, info.Address, info.PhoneNumber, info.Register_day, info.Day_of_Birth, info.Place_of_Birth, Day_Create, DeleteFlage, info.Image);
                SaveMember_DAO.SaveRegisterClass(info.RegisterNumber, info.ID_Class, info.Register_day);
                SaveMember_DAO.SaveLevel(info.listLevel, info.RegisterNumber);
       
           
        }
      
        //get new register member's number
        public int NewRegisterNumber()
        {
            int register_number;
           return  register_number= SaveMember_DAO.RegisterNewMember();
        }

      
        
    }
}
