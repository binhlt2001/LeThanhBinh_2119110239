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
    public class EmployeeDAL : DBConnection
    {
        public List<EmployeeBEL> ReadCustomer()
        {

            {

                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Employee", conn) { CommandType = CommandType.StoredProcedure };
                SqlDataReader reader = cmd.ExecuteReader();

                List<EmployeeBEL> lstCus = new List<EmployeeBEL>();
                DepartmentDAL dpm = new DepartmentDAL();
                while (reader.Read())
                {
                    EmployeeBEL cus = new EmployeeBEL();
                    cus.IdEmployee = reader["IdEmployee"].ToString();
                    cus.Name = reader["Name"].ToString();
                    cus.DateBirth = reader["DateBirth"].ToString();
                    cus.Gender = (bool.Parse(reader["Gender"].ToString()));
                    cus.PlaceBirth = reader["PlaceBirth"].ToString();
                    cus.Department = dpm.ReadArea(reader["IdDepartment"].ToString());
                    lstCus.Add(cus);
                }
                conn.Close();
                return lstCus;

            }
        }
        public void NewCustomer(EmployeeBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("AddEmployee", conn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", cus.IdEmployee));
            cmd.Parameters.Add(new SqlParameter("@Name", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@DateBirth", cus.DateBirth));
            cmd.Parameters.Add(new SqlParameter("@Gender", cus.Gender));
            cmd.Parameters.Add(new SqlParameter("@PlaceBirth", cus.PlaceBirth));

            cmd.Parameters.Add(new SqlParameter("@IdDepartment", cus.Department.IdDepartment));
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void DeleteCustomer(EmployeeBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DeleteEmployee", conn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", cus.IdEmployee));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditCustomer(EmployeeBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("EditEmployee", conn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.Add(new SqlParameter("@IdEmployee", cus.IdEmployee));
            cmd.Parameters.Add(new SqlParameter("@Name", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@DateBirth", cus.DateBirth));
            cmd.Parameters.Add(new SqlParameter("@Gender", cus.Gender));
            cmd.Parameters.Add(new SqlParameter("@PlaceBirth", cus.PlaceBirth));

            cmd.Parameters.Add(new SqlParameter("@IdDepartment", cus.Department.IdDepartment));
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
