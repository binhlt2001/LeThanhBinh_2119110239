using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BEL
{
    public class DepartmentBEL
    {
        public string IdDepartment { get; set; }
        public string Name { get; set; }
        public List<EmployeeBEL> Employee { get; set; }
    }
}
