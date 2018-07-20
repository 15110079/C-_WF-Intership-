using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aikido.DAO
{
    public class SaveMemberInfo_DAO 
    {
        //Save New Member's Info
        public void SaveNewMember (string SKU, string Name, string Nation,string address,string Phone, DateTime RegisterDay, DateTime Birthday,string Birthplace,DateTime Day_Create,Boolean DeleteFlag)
        {
           
            using (var db = new AccessDB_DAO())
            {
                db.Students.Add(new Student() { FullName = Name, SKU = SKU, Nation = Nation, Address = address, PhoneNumber = Phone, Place_of_Birth = Birthplace, Day_Create = RegisterDay, Day_of_Birth =Birthday,Delete_Flag=DeleteFlag });
                db.SaveChanges();              
             }
        }
        //Return New Member Register ID to be a default ID
        public int RegisterNewMember()
        {
            using (var db = new AccessDB_DAO())
            {
                try
                {
                    return db.Students.Max(c => c.RegisterNumber);
                }
                catch { return 0; } //TH DS Hoi vien rong
            
            }
        }

        //Save Class which New Member register
        public void SaveRegisterClass(int RegisterNumber, int ClassID,DateTime RegisterDay)
        {
            using(var db = new AccessDB_DAO())
            {
                db.Learns.Add(new Learn() { ID_Class = ClassID, RegisterNumber = RegisterNumber, Fee_January = 0, Fee_February = 0, Fee_March = 0, Fee_April = 0, Fee_May = 0, Fee_June = 0, Fee_July = 0, Fee_August = 0, Fee_September = 0, Fee_October = 0, Fee_December = 0, Fee_November = 0, RegisterDay = RegisterDay, Day_Create = DateTime.Now, Delete_Flag = false });
                db.SaveChanges();
            }
        }

        //Save Level Dai Dan Of Member
        public void SaveLevel(Dictionary<string,DateTime> listLevel, int RegisterNumber)
        {
            using (var db = new AccessDB_DAO())
            {
                foreach (var i in listLevel)
                {
                    if (i.Value != DateTime.MinValue)
                    {
                        int Level_ID = db.Dai_Dans.Where(x=>x.Name.Contains(i.Key)).Select(c=>c.ID).First();
                        db.Provide_Dai_Dans.Add(new Provide_DAI_DAN() { RegisterNumber = RegisterNumber, ID_DAI_DAN = Level_ID , Day_Provide = i.Value, Day_Create = DateTime.Now, Delete_FLag = false });
                        db.SaveChanges();
                    }

                }
            }
           
        }
    }
}
