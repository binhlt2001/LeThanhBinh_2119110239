using Cau1.BEL;
using Cau1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BAL
{
    public class EmployeeBAL
    {
        EmployeeDAL dal = new EmployeeDAL();
        public List<EmployeeBEL> ReadCustomer()
        {
            List<EmployeeBEL> lstCus = dal.ReadCustomer();

            return lstCus;
        }
        public void NewCustomer(EmployeeBEL cus)
        {
            dal.NewCustomer(cus);
        }
        public void DeleteCustomer(EmployeeBEL cus)
        {
            dal.DeleteCustomer(cus);
        }
        public void EditCustomer(EmployeeBEL cus)
        {
            dal.EditCustomer(cus);
        }
    }
}
