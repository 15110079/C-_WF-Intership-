using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aikido.DAO
{
    public class SaveMemberInfo_DAO 
    {
        public void SaveNewMember (string SKU, string Name, string Nation,string address,string Phone, DateTime RegisterDay, DateTime Birthday,string Birthplace,DateTime Day_Create,Boolean DeleteFlag)
        {
           
            using (var db = new AccessDB_DAO())
            {
                db.Students.Add(new Student() { FullName = Name, SKU = SKU, Nation = Nation, Address = address, PhoneNumber = Phone, Place_of_Birth = Birthplace, Day_Create = RegisterDay, Day_of_Birth =Birthday,Delete_Flag=DeleteFlag });
                db.SaveChanges();              
             }
        }

        public int RegisterNewMember()
        {
            using (var db = new AccessDB_DAO())
            { 
                db.SaveChanges(); return db.Students.Max(c => c.RegisterNumber);
            }
        }
    }
}
