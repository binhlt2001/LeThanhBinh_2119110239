using Cau1.BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAL
{
    public class DepartmentDAL : DBConnection
    {

        public List<DepartmentBEL> ReadAreaList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Department", conn) { CommandType = CommandType.StoredProcedure };
            SqlDataReader reader = cmd.ExecuteReader();

            List<DepartmentBEL> lstDepartment = new List<DepartmentBEL>();
            while (reader.Read())
            {
                DepartmentBEL dep = new DepartmentBEL();
                dep.IdDepartment = reader["IdDepartment"].ToString();
                dep.Name = reader["name"].ToString();
                lstDepartment.Add(dep);
            }
            conn.Close();
            return lstDepartment;

        }
        public DepartmentBEL ReadArea(string IdDepartment)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "select*from Department_2119110239  where IdDepartment= " + "'" + IdDepartment.ToString() + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DepartmentBEL dep = new DepartmentBEL();
            if (reader.HasRows && reader.Read())
            {
                dep.IdDepartment = reader["IdDepartment"].ToString();
                dep.Name = reader["name"].ToString();
            }
            conn.Close();
            return dep;
        }
    }
}
