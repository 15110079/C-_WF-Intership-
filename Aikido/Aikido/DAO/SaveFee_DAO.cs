using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Aikido.DAO;
using Aikido.DAO.Model;
namespace Aikido.DAO
{
    public class SaveFee_DAO
    {
        public void saveFeeD(List<dgvFee_ViewModel> UpdateFeeD)
        {
            using (var dataContext = new AccessDB_DAO())
            {
                int r = DateTime.Now.Month;
                try
                {
                    foreach (var dataFee in UpdateFeeD)
                    {
                        switch (r)
                        {
                            case 1:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);

                                    learn.FeeD_January = dataFee.lblmonthHT;
                                    learn.FeeD_February = dataFee.lblmonthHT1P;
                                    learn.FeeD_March = dataFee.lblmonthHT2P;
                                    learn.FeeD_April = dataFee.lblmonthHT3P;
                                    learn.FeeD_May = dataFee.lblmonthHT4P;
                                    learn.FeeD_June = dataFee.lblmonthHT5P;
                                    learn.FeeD_July = dataFee.lblmonthHT6P;
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    //Learn learn1 = dataContext.Learns.Where(s => s.RegisterNumber == dataFee.RegisterNumber && s.Day_Create.Year == r - 1 && s.Delete_Flag == false).Last();

                                    break;
                                }
                            case 2:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.FeeD_January = dataFee.lblmonthHT1A;
                                    learn.FeeD_February = dataFee.lblmonthHT;
                                    learn.FeeD_March = dataFee.lblmonthHT1P;
                                    learn.FeeD_April = dataFee.lblmonthHT2P;
                                    learn.FeeD_May = dataFee.lblmonthHT3P;
                                    learn.FeeD_June = dataFee.lblmonthHT4P;
                                    learn.FeeD_July = dataFee.lblmonthHT5P;
                                    learn.FeeD_August = dataFee.lblmonthHT6P;
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 3:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.FeeD_January = dataFee.lblmonthHT2A;
                                    learn.FeeD_February = dataFee.lblmonthHT1A;
                                    learn.FeeD_March = dataFee.lblmonthHT;
                                    learn.FeeD_April = dataFee.lblmonthHT1P;
                                    learn.FeeD_May = dataFee.lblmonthHT2P;
                                    learn.FeeD_June = dataFee.lblmonthHT3P;
                                    learn.FeeD_July = dataFee.lblmonthHT4P;
                                    learn.FeeD_August = dataFee.lblmonthHT5P;
                                    learn.FeeD_September = dataFee.lblmonthHT6P;
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 4:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.FeeD_January = dataFee.lblmonthHT3A;
                                    learn.FeeD_February = dataFee.lblmonthHT2A;
                                    learn.FeeD_March = dataFee.lblmonthHT1A;
                                    learn.FeeD_April = dataFee.lblmonthHT;
                                    learn.FeeD_May = dataFee.lblmonthHT1P;
                                    learn.FeeD_June = dataFee.lblmonthHT2P;
                                    learn.FeeD_July = dataFee.lblmonthHT3P;
                                    learn.FeeD_August = dataFee.lblmonthHT4P;
                                    learn.FeeD_September = dataFee.lblmonthHT5P;
                                    learn.FeeD_October = dataFee.lblmonthHT6P;
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 5:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.FeeD_February = dataFee.lblmonthHT3A;
                                    learn.FeeD_March = dataFee.lblmonthHT2A;
                                    learn.FeeD_April = dataFee.lblmonthHT1A;
                                    learn.FeeD_May = dataFee.lblmonthHT;
                                    learn.FeeD_June = dataFee.lblmonthHT1P;
                                    learn.FeeD_July = dataFee.lblmonthHT2P;
                                    learn.FeeD_August = dataFee.lblmonthHT3P;
                                    learn.FeeD_September = dataFee.lblmonthHT4P;
                                    learn.FeeD_October = dataFee.lblmonthHT5P;
                                    learn.FeeD_November = dataFee.lblmonthHT6P;
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 6:
                                {
                                    Learn learn = dataContext.Learns.Where(s => s.ID_Learn == dataFee.ID_Learn).Last();
                                    learn.FeeD_March = dataFee.lblmonthHT3A;
                                    learn.FeeD_April = dataFee.lblmonthHT2A;
                                    learn.FeeD_May = dataFee.lblmonthHT1A;
                                    learn.FeeD_June = dataFee.lblmonthHT;
                                    learn.FeeD_July = dataFee.lblmonthHT1P;
                                    learn.FeeD_August = dataFee.lblmonthHT2P;
                                    learn.FeeD_September = dataFee.lblmonthHT3P;
                                    learn.FeeD_October = dataFee.lblmonthHT4P;
                                    learn.FeeD_November = dataFee.lblmonthHT5P;
                                    learn.FeeD_December = dataFee.lblmonthHT6P;
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 7:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.FeeD_April = dataFee.lblmonthHT3A;
                                    learn.FeeD_May = dataFee.lblmonthHT2A;
                                    learn.FeeD_June = dataFee.lblmonthHT1A;
                                    learn.FeeD_July = dataFee.lblmonthHT;
                                    learn.FeeD_August = dataFee.lblmonthHT1P;
                                    learn.FeeD_September = dataFee.lblmonthHT2P;
                                    learn.FeeD_October = dataFee.lblmonthHT3P;
                                    learn.FeeD_November = dataFee.lblmonthHT4P;
                                    learn.FeeD_December = dataFee.lblmonthHT5P;
                                    //
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 8:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);

                                    learn.FeeD_May = dataFee.lblmonthHT3A;
                                    learn.FeeD_June = dataFee.lblmonthHT2A;
                                    learn.FeeD_July = dataFee.lblmonthHT1A;
                                    learn.FeeD_August = dataFee.lblmonthHT;
                                    learn.FeeD_September = dataFee.lblmonthHT1P;
                                    learn.FeeD_October = dataFee.lblmonthHT2P;
                                    learn.FeeD_November = dataFee.lblmonthHT3P;
                                    learn.FeeD_December = dataFee.lblmonthHT4P;
                                    //
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 9:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.FeeD_June = dataFee.lblmonthHT3A;
                                    learn.FeeD_July = dataFee.lblmonthHT2A;
                                    learn.FeeD_August = dataFee.lblmonthHT1A;
                                    learn.FeeD_September = dataFee.lblmonthHT;
                                    learn.FeeD_October = dataFee.lblmonthHT1P;
                                    learn.FeeD_November = dataFee.lblmonthHT2P;
                                    learn.FeeD_December = dataFee.lblmonthHT3P;
                                    //
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 10:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.FeeD_July = dataFee.lblmonthHT3A;
                                    learn.FeeD_August = dataFee.lblmonthHT2A;
                                    learn.FeeD_September = dataFee.lblmonthHT1A;
                                    learn.FeeD_October = dataFee.lblmonthHT;
                                    learn.FeeD_November = dataFee.lblmonthHT1P;
                                    learn.FeeD_December = dataFee.lblmonthHT2P;
                                    //
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 11:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.FeeD_August = dataFee.lblmonthHT3A;
                                    learn.FeeD_September = dataFee.lblmonthHT2A;
                                    learn.FeeD_October = dataFee.lblmonthHT1A;
                                    learn.FeeD_November = dataFee.lblmonthHT;
                                    learn.FeeD_December = dataFee.lblmonthHT1P;
                                    //
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 12:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.FeeD_September = dataFee.lblmonthHT3A;
                                    learn.FeeD_October = dataFee.lblmonthHT2A;
                                    learn.FeeD_November = dataFee.lblmonthHT1A;
                                    learn.FeeD_December = dataFee.lblmonthHT;
                                    //
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        public void saveFee(List<dgvFee_ViewModel> UpdateFee)
        {
            using (var dataContext = new AccessDB_DAO())
            {
                int r = DateTime.Now.Month;
                try
                {
                    foreach (var dataFee in UpdateFee)
                    {
                        switch (r)
                        {
                            case 1:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);

                                    learn.Fee_January = dataFee.lblmonthHT;
                                    learn.Fee_February = dataFee.lblmonthHT1P;
                                    learn.Fee_March = dataFee.lblmonthHT2P;
                                    learn.Fee_April = dataFee.lblmonthHT3P;
                                    learn.Fee_May = dataFee.lblmonthHT4P;
                                    learn.Fee_June = dataFee.lblmonthHT5P;
                                    learn.Fee_July = dataFee.lblmonthHT6P;
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    //Learn learn1 = dataContext.Learns.Where(s => s.RegisterNumber == dataFee.RegisterNumber && s.Day_Create.Year == r - 1 && s.Delete_Flag == false).Last();

                                    break;
                                }
                            case 2:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.Fee_January = dataFee.lblmonthHT1A;
                                    learn.Fee_February = dataFee.lblmonthHT;
                                    learn.Fee_March = dataFee.lblmonthHT1P;
                                    learn.Fee_April = dataFee.lblmonthHT2P;
                                    learn.Fee_May = dataFee.lblmonthHT3P;
                                    learn.Fee_June = dataFee.lblmonthHT4P;
                                    learn.Fee_July = dataFee.lblmonthHT5P;
                                    learn.Fee_August = dataFee.lblmonthHT6P;
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 3:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.Fee_January = dataFee.lblmonthHT2A;
                                    learn.Fee_February = dataFee.lblmonthHT1A;
                                    learn.Fee_March = dataFee.lblmonthHT;
                                    learn.Fee_April = dataFee.lblmonthHT1P;
                                    learn.Fee_May = dataFee.lblmonthHT2P;
                                    learn.Fee_June = dataFee.lblmonthHT3P;
                                    learn.Fee_July = dataFee.lblmonthHT4P;
                                    learn.Fee_August = dataFee.lblmonthHT5P;
                                    learn.Fee_September = dataFee.lblmonthHT6P;
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 4:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.Fee_January = dataFee.lblmonthHT3A;
                                    learn.Fee_February = dataFee.lblmonthHT2A;
                                    learn.Fee_March = dataFee.lblmonthHT1A;
                                    learn.Fee_April = dataFee.lblmonthHT;
                                    learn.Fee_May = dataFee.lblmonthHT1P;
                                    learn.Fee_June = dataFee.lblmonthHT2P;
                                    learn.Fee_July = dataFee.lblmonthHT3P;
                                    learn.Fee_August = dataFee.lblmonthHT4P;
                                    learn.Fee_September = dataFee.lblmonthHT5P;
                                    learn.Fee_October = dataFee.lblmonthHT6P;
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 5:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.Fee_February = dataFee.lblmonthHT3A;
                                    learn.Fee_March = dataFee.lblmonthHT2A;
                                    learn.Fee_April = dataFee.lblmonthHT1A;
                                    learn.Fee_May = dataFee.lblmonthHT;
                                    learn.Fee_June = dataFee.lblmonthHT1P;
                                    learn.Fee_July = dataFee.lblmonthHT2P;
                                    learn.Fee_August = dataFee.lblmonthHT3P;
                                    learn.Fee_September = dataFee.lblmonthHT4P;
                                    learn.Fee_October = dataFee.lblmonthHT5P;
                                    learn.Fee_November = dataFee.lblmonthHT6P;
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 6:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.Fee_March = dataFee.lblmonthHT3A;
                                    learn.Fee_April = dataFee.lblmonthHT2A;
                                    learn.Fee_May = dataFee.lblmonthHT1A;
                                    learn.Fee_June = dataFee.lblmonthHT;
                                    learn.Fee_July = dataFee.lblmonthHT1P;
                                    learn.Fee_August = dataFee.lblmonthHT2P;
                                    learn.Fee_September = dataFee.lblmonthHT3P;
                                    learn.Fee_October = dataFee.lblmonthHT4P;
                                    learn.Fee_November = dataFee.lblmonthHT5P;
                                    learn.Fee_December = dataFee.lblmonthHT6P;
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 7:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.Fee_April = dataFee.lblmonthHT3A;
                                    learn.Fee_May = dataFee.lblmonthHT2A;
                                    learn.Fee_June = dataFee.lblmonthHT1A;
                                    learn.Fee_July = dataFee.lblmonthHT;
                                    learn.Fee_August = dataFee.lblmonthHT1P;
                                    learn.Fee_September = dataFee.lblmonthHT2P;
                                    learn.Fee_October = dataFee.lblmonthHT3P;
                                    learn.Fee_November = dataFee.lblmonthHT4P;
                                    learn.Fee_December = dataFee.lblmonthHT5P;
                                    //
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 8:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);

                                    learn.Fee_May = dataFee.lblmonthHT3A;
                                    learn.Fee_June = dataFee.lblmonthHT2A;
                                    learn.Fee_July = dataFee.lblmonthHT1A;
                                    learn.Fee_August = dataFee.lblmonthHT;
                                    learn.Fee_September = dataFee.lblmonthHT1P;
                                    learn.Fee_October = dataFee.lblmonthHT2P;
                                    learn.Fee_November = dataFee.lblmonthHT3P;
                                    learn.Fee_December = dataFee.lblmonthHT4P;
                                    //
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 9:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.Fee_June = dataFee.lblmonthHT3A;
                                    learn.Fee_July = dataFee.lblmonthHT2A;
                                    learn.Fee_August = dataFee.lblmonthHT1A;
                                    learn.Fee_September = dataFee.lblmonthHT;
                                    learn.Fee_October = dataFee.lblmonthHT1P;
                                    learn.Fee_November = dataFee.lblmonthHT2P;
                                    learn.Fee_December = dataFee.lblmonthHT3P;
                                    //
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 10:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.Fee_July = dataFee.lblmonthHT3A;
                                    learn.Fee_August = dataFee.lblmonthHT2A;
                                    learn.Fee_September = dataFee.lblmonthHT1A;
                                    learn.Fee_October = dataFee.lblmonthHT;
                                    learn.Fee_November = dataFee.lblmonthHT1P;
                                    learn.Fee_December = dataFee.lblmonthHT2P;
                                    //
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 11:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.Fee_August = dataFee.lblmonthHT3A;
                                    learn.Fee_September = dataFee.lblmonthHT2A;
                                    learn.Fee_October = dataFee.lblmonthHT1A;
                                    learn.Fee_November = dataFee.lblmonthHT;
                                    learn.Fee_December = dataFee.lblmonthHT1P;
                                    //
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                            case 12:
                                {
                                    Learn learn = dataContext.Learns.FirstOrDefault(s => s.ID_Learn == dataFee.ID_Learn);
                                    learn.Fee_September = dataFee.lblmonthHT3A;
                                    learn.Fee_October = dataFee.lblmonthHT2A;
                                    learn.Fee_November = dataFee.lblmonthHT1A;
                                    learn.Fee_December = dataFee.lblmonthHT;
                                    //
                                    learn.Day_Update = DateTime.Now;
                                    dataContext.Learns.Update(learn);
                                    dataContext.SaveChanges();
                                    break;
                                }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
