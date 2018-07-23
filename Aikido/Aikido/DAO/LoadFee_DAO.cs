using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aikido.DAO.Model;
namespace Aikido.DAO
{
    class LoadFee_DAO
    {
        public List<dgvFee_ViewModel> selectAll()
        {
            List<dgvFee_ViewModel> data = new List<dgvFee_ViewModel>();
            using (var dataContext = new AccessDB_DAO())
            {
                //var learns = from ls in dataContext.Learns select new { ls.Class.Class_Name, ls.Fee_April,ls.Fee_August };
                var learnN = dataContext.Learns.Where(s => s.RegisterDay.Year == DateTime.Now.Year-1);
                var learn = dataContext.Learns.Where(s => s.RegisterDay.Year == DateTime.Now.Year);
                var learnP = dataContext.Learns.Where(s => s.RegisterDay.Year == DateTime.Now.Year+1);
                int monthht = DateTime.Now.Month;
                switch (monthht)
                {
                    case 1:
                        {
                            foreach (var dt in learn)
                            {
                                dgvFee_ViewModel dtg = new dgvFee_ViewModel();
                                dtg.lblSKU = dt.Student.SKU;
                                dtg.lblnameHV = dt.Student.FullName;
                                dtg.lblnameClass = dt.Class.Class_Name;
                                dtg.lbltypeFee = "Hội Phí";
                                dtg.lblmonthHT3A = dt.Fee_October;
                                dtg.lblmonthHT2A = dt.Fee_November;
                                dtg.lblmonthHT1A = dt.Fee_December;
                                dtg.lblmonthHT = dt.Fee_January;
                                dtg.lblmonthHT1P = dt.Fee_February;
                                dtg.lblmonthHT2P = dt.Fee_March;
                                dtg.lblmonthHT3P = dt.Fee_April;
                                dtg.lblmonthHT4P = dt.Fee_May;
                                dtg.lblmonthHT5P = dt.Fee_June;
                                dtg.lblmonthHT6P = dt.Fee_July;
                                dtg.lblToTalS = dt.Fee_October + dt.Fee_November + dt.Fee_December + dt.Fee_January + dt.Fee_February + dt.Fee_March + dt.Fee_April + dt.Fee_May + dt.Fee_June + dt.Fee_July;
                                data.Add(dtg);
                            }
                            break;
                        }
                    case 2:
                        {
                            foreach (var dt in learn)
                            {
                                dgvFee_ViewModel dtg = new dgvFee_ViewModel();
                                dtg.lblSKU = dt.Student.SKU;
                                dtg.lblnameHV = dt.Student.FullName;
                                dtg.lblnameClass = dt.Class.Class_Name;
                                dtg.lbltypeFee = "Hội Phí";
                                dtg.lblmonthHT3A = dt.Fee_November;
                                dtg.lblmonthHT2A = dt.Fee_December;
                                dtg.lblmonthHT1A = dt.Fee_January;
                                dtg.lblmonthHT = dt.Fee_February;
                                dtg.lblmonthHT1P = dt.Fee_March;
                                dtg.lblmonthHT2P = dt.Fee_April;
                                dtg.lblmonthHT3P = dt.Fee_May;
                                dtg.lblmonthHT4P = dt.Fee_June;
                                dtg.lblmonthHT5P = dt.Fee_July;
                                dtg.lblmonthHT6P = dt.Fee_August;
                                dtg.lblToTalS = dt.Fee_November + dt.Fee_December + dt.Fee_January + dt.Fee_February + dt.Fee_March + dt.Fee_April + dt.Fee_May + dt.Fee_June + dt.Fee_July + dt.Fee_August;
                                data.Add(dtg);
                            }
                            break;
                        }
                    case 3:
                        {
                            foreach (var dt in learn)
                            {
                                dgvFee_ViewModel dtg = new dgvFee_ViewModel();
                                dtg.lblSKU = dt.Student.SKU;
                                dtg.lblnameHV = dt.Student.FullName;
                                dtg.lblnameClass = dt.Class.Class_Name;
                                dtg.lbltypeFee = "Hội Phí";
                                dtg.lblmonthHT3A = dt.Fee_December;
                                dtg.lblmonthHT2A = dt.Fee_January;
                                dtg.lblmonthHT1A = dt.Fee_February;
                                dtg.lblmonthHT = dt.Fee_March;
                                dtg.lblmonthHT1P = dt.Fee_April;
                                dtg.lblmonthHT2P = dt.Fee_May;
                                dtg.lblmonthHT3P = dt.Fee_June;
                                dtg.lblmonthHT4P = dt.Fee_July;
                                dtg.lblmonthHT5P = dt.Fee_August;
                                dtg.lblmonthHT6P = dt.Fee_September;
                                dtg.lblToTalS = dt.Fee_December + dt.Fee_January + dt.Fee_February + dt.Fee_March + dt.Fee_April + dt.Fee_May + dt.Fee_June + dt.Fee_July + dt.Fee_August + dt.Fee_September;
                                data.Add(dtg);
                            }
                            break;
                        }
                    case 4:
                        {
                            foreach (var dt in learn)
                            {
                                dgvFee_ViewModel dtg = new dgvFee_ViewModel();
                                dtg.lblSKU = dt.Student.SKU;
                                dtg.lblnameHV = dt.Student.FullName;
                                dtg.lblnameClass = dt.Class.Class_Name;
                                dtg.lbltypeFee = "Hội Phí";
                                dtg.lblmonthHT3A = dt.Fee_January;
                                dtg.lblmonthHT2A = dt.Fee_February;
                                dtg.lblmonthHT1A = dt.Fee_March;
                                dtg.lblmonthHT = dt.Fee_April;
                                dtg.lblmonthHT1P = dt.Fee_May;
                                dtg.lblmonthHT2P = dt.Fee_June;
                                dtg.lblmonthHT3P = dt.Fee_July;
                                dtg.lblmonthHT4P = dt.Fee_August;
                                dtg.lblmonthHT5P = dt.Fee_September;
                                dtg.lblmonthHT6P = dt.Fee_October;
                                dtg.lblToTalS = dt.Fee_January + dt.Fee_February + dt.Fee_March + dt.Fee_April + dt.Fee_May + dt.Fee_June + dt.Fee_July + dt.Fee_August + dt.Fee_September + dt.Fee_October;
                                data.Add(dtg);
                            }
                            break;
                        }
                    case 5:
                        {
                            foreach (var dt in learn)
                            {
                                dgvFee_ViewModel dtg = new dgvFee_ViewModel();
                                dtg.lblSKU = dt.Student.SKU;
                                dtg.lblnameHV = dt.Student.FullName;
                                dtg.lblnameClass = dt.Class.Class_Name;
                                dtg.lbltypeFee = "Hội Phí";
                                dtg.lblmonthHT3A = dt.Fee_February;
                                dtg.lblmonthHT2A = dt.Fee_March;
                                dtg.lblmonthHT1A = dt.Fee_April;
                                dtg.lblmonthHT = dt.Fee_May;
                                dtg.lblmonthHT1P = dt.Fee_June;
                                dtg.lblmonthHT2P = dt.Fee_July;
                                dtg.lblmonthHT3P = dt.Fee_August;
                                dtg.lblmonthHT4P = dt.Fee_September;
                                dtg.lblmonthHT5P = dt.Fee_October;
                                dtg.lblmonthHT6P = dt.Fee_November;
                                dtg.lblToTalS = dt.Fee_February + dt.Fee_March + dt.Fee_April + dt.Fee_May + dt.Fee_June + dt.Fee_July + dt.Fee_August + dt.Fee_September + dt.Fee_October + dt.Fee_November;
                                data.Add(dtg);
                            }
                            break;
                        }
                    case 6:
                        {
                            foreach (var dt in learn)
                            {
                                dgvFee_ViewModel dtg = new dgvFee_ViewModel();
                                dtg.lblSKU = dt.Student.SKU;
                                dtg.lblnameHV = dt.Student.FullName;
                                dtg.lblnameClass = dt.Class.Class_Name;
                                dtg.lbltypeFee = "Hội Phí";
                                dtg.lblmonthHT3A = dt.Fee_March;
                                dtg.lblmonthHT2A = dt.Fee_April;
                                dtg.lblmonthHT1A = dt.Fee_May;
                                dtg.lblmonthHT = dt.Fee_June;
                                dtg.lblmonthHT1P = dt.Fee_July;
                                dtg.lblmonthHT2P = dt.Fee_August;
                                dtg.lblmonthHT3P = dt.Fee_September;
                                dtg.lblmonthHT4P = dt.Fee_October;
                                dtg.lblmonthHT5P = dt.Fee_November;
                                dtg.lblmonthHT6P = dt.Fee_December;
                                dtg.lblToTalS = dt.Fee_March + dt.Fee_April + dt.Fee_May + dt.Fee_June + dt.Fee_July + dt.Fee_August + dt.Fee_September + dt.Fee_October + dt.Fee_November + dt.Fee_December;
                                data.Add(dtg);
                            }
                            break;
                        }
                    case 7:
                        {
                            foreach (var dt in learn)
                            {
                                dgvFee_ViewModel dtg = new dgvFee_ViewModel();
                                dtg.lblSKU = dt.Student.SKU;
                                dtg.lblnameHV = dt.Student.FullName;
                                dtg.lblnameClass = dt.Class.Class_Name;
                                dtg.lbltypeFee = "Hội Phí";
                                dtg.lblmonthHT3A = dt.Fee_April;
                                dtg.lblmonthHT2A = dt.Fee_May;
                                dtg.lblmonthHT1A = dt.Fee_June;
                                dtg.lblmonthHT = dt.Fee_July;
                                dtg.lblmonthHT1P = dt.Fee_August;
                                dtg.lblmonthHT2P = dt.Fee_September;
                                dtg.lblmonthHT3P = dt.Fee_October;
                                dtg.lblmonthHT4P = dt.Fee_November;
                                dtg.lblmonthHT5P = dt.Fee_December;
                                dtg.lblmonthHT6P = dt.Fee_January;
                                dtg.lblToTalS = dt.Fee_April + dt.Fee_May + dt.Fee_June + dt.Fee_July + dt.Fee_August + dt.Fee_September + dt.Fee_October + dt.Fee_November + dt.Fee_December + dt.Fee_January;
                                data.Add(dtg);
                            }
                            break;
                        }
                    case 8:
                        {
                            foreach (var dt in learn)
                            {
                                dgvFee_ViewModel dtg = new dgvFee_ViewModel();
                                dtg.lblSKU = dt.Student.SKU;
                                dtg.lblnameHV = dt.Student.FullName;
                                dtg.lblnameClass = dt.Class.Class_Name;
                                dtg.lbltypeFee = "Hội Phí";
                                dtg.lblmonthHT3A = dt.Fee_May;
                                dtg.lblmonthHT2A = dt.Fee_June;
                                dtg.lblmonthHT1A = dt.Fee_July;
                                dtg.lblmonthHT = dt.Fee_August;
                                dtg.lblmonthHT1P = dt.Fee_September;
                                dtg.lblmonthHT2P = dt.Fee_October;
                                dtg.lblmonthHT3P = dt.Fee_November;
                                dtg.lblmonthHT4P = dt.Fee_December;
                                dtg.lblmonthHT5P = dt.Fee_January;
                                dtg.lblmonthHT6P = dt.Fee_February;
                                dtg.lblToTalS = dt.Fee_May + dt.Fee_June + dt.Fee_July + dt.Fee_August + dt.Fee_September + dt.Fee_October + dt.Fee_November + dt.Fee_December + dt.Fee_January + dt.Fee_February;
                                data.Add(dtg);
                            }
                            break;
                        }
                    case 9:
                        {
                            foreach (var dt in learn)
                            {
                                dgvFee_ViewModel dtg = new dgvFee_ViewModel();
                                dtg.lblSKU = dt.Student.SKU;
                                dtg.lblnameHV = dt.Student.FullName;
                                dtg.lblnameClass = dt.Class.Class_Name;
                                dtg.lbltypeFee = "Hội Phí";
                                dtg.lblmonthHT3A = dt.Fee_June;
                                dtg.lblmonthHT2A = dt.Fee_July;
                                dtg.lblmonthHT1A = dt.Fee_August;
                                dtg.lblmonthHT = dt.Fee_September;
                                dtg.lblmonthHT1P = dt.Fee_October;
                                dtg.lblmonthHT2P = dt.Fee_November;
                                dtg.lblmonthHT3P = dt.Fee_December;
                                dtg.lblmonthHT4P = dt.Fee_January;
                                dtg.lblmonthHT5P = dt.Fee_February;
                                dtg.lblmonthHT6P = dt.Fee_March;
                                dtg.lblToTalS = dt.Fee_June + dt.Fee_July + dt.Fee_August + dt.Fee_September + dt.Fee_October + dt.Fee_November + dt.Fee_December + dt.Fee_January + dt.Fee_February + dt.Fee_March;
                                data.Add(dtg);
                            }
                            break;
                        }
                    case 10:
                        {
                            foreach (var dt in learn)
                            {
                                dgvFee_ViewModel dtg = new dgvFee_ViewModel();
                                dtg.lblSKU = dt.Student.SKU;
                                dtg.lblnameHV = dt.Student.FullName;
                                dtg.lblnameClass = dt.Class.Class_Name;
                                dtg.lbltypeFee = "Hội Phí";
                                dtg.lblmonthHT3A = dt.Fee_July;
                                dtg.lblmonthHT2A = dt.Fee_August;
                                dtg.lblmonthHT1A = dt.Fee_September;
                                dtg.lblmonthHT = dt.Fee_October;
                                dtg.lblmonthHT1P = dt.Fee_November;
                                dtg.lblmonthHT2P = dt.Fee_December;
                                dtg.lblmonthHT3P = dt.Fee_January;
                                dtg.lblmonthHT4P = dt.Fee_February;
                                dtg.lblmonthHT5P = dt.Fee_March;
                                dtg.lblmonthHT6P = dt.Fee_April;
                                dtg.lblToTalS = dt.Fee_July + dt.Fee_August + dt.Fee_September + dt.Fee_October + dt.Fee_November + dt.Fee_December + dt.Fee_January + dt.Fee_February + dt.Fee_March + dt.Fee_April;
                                data.Add(dtg);
                            }
                            break;
                        }
                    case 11:
                        {
                            foreach (var dt in learn)
                            {
                                dgvFee_ViewModel dtg = new dgvFee_ViewModel();
                                dtg.lblSKU = dt.Student.SKU;
                                dtg.lblnameHV = dt.Student.FullName;
                                dtg.lblnameClass = dt.Class.Class_Name;
                                dtg.lbltypeFee = "Hội Phí";
                                dtg.lblmonthHT3A = dt.Fee_August;
                                dtg.lblmonthHT2A = dt.Fee_September;
                                dtg.lblmonthHT1A = dt.Fee_October;
                                dtg.lblmonthHT = dt.Fee_November;
                                dtg.lblmonthHT1P = dt.Fee_December;
                                dtg.lblmonthHT2P = dt.Fee_January;
                                dtg.lblmonthHT3P = dt.Fee_February;
                                dtg.lblmonthHT4P = dt.Fee_March;
                                dtg.lblmonthHT5P = dt.Fee_April;
                                dtg.lblmonthHT6P = dt.Fee_May;
                                dtg.lblToTalS = dt.Fee_August + dt.Fee_September + dt.Fee_October + dt.Fee_November + dt.Fee_December + dt.Fee_January + dt.Fee_February + dt.Fee_March + dt.Fee_April + dt.Fee_May;
                                data.Add(dtg);
                            }
                            break;
                        }
                    case 12:
                        {
                            foreach (var dt in learn)
                            {
                                dgvFee_ViewModel dtg = new dgvFee_ViewModel();
                                dtg.lblSKU = dt.Student.SKU;
                                dtg.lblnameHV = dt.Student.FullName;
                                dtg.lblnameClass = dt.Class.Class_Name;
                                dtg.lbltypeFee = "Hội Phí";
                                dtg.lblmonthHT3A = dt.Fee_September;
                                dtg.lblmonthHT2A = dt.Fee_October;
                                dtg.lblmonthHT1A = dt.Fee_November;
                                dtg.lblmonthHT = dt.Fee_December;
                                dtg.lblmonthHT1P = dt.Fee_January;
                                dtg.lblmonthHT2P = dt.Fee_February;
                                dtg.lblmonthHT3P = dt.Fee_March;
                                dtg.lblmonthHT4P = dt.Fee_April;
                                dtg.lblmonthHT5P = dt.Fee_May;
                                dtg.lblmonthHT6P = dt.Fee_June;
                                dtg.lblToTalS = dt.Fee_September + dt.Fee_October + dt.Fee_November + dt.Fee_December + dt.Fee_January + dt.Fee_February + dt.Fee_March + dt.Fee_April + dt.Fee_May + dt.Fee_June;
                                data.Add(dtg);
                            }
                            break;
                        }
                }
            }
            return data;
        }
    }
}
