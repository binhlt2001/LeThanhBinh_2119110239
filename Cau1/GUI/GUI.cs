using Cau1.BAL;
using Cau1.BEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau1.GUI
{
    public partial class GUI : Form
    {
        DepartmentBAL depart = new DepartmentBAL();
        EmployeeBAL cusBAL = new EmployeeBAL();
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            List<EmployeeBEL> lstCus = cusBAL.ReadCustomer();
            foreach (EmployeeBEL cus in lstCus)
            {
                dgvEmployee.Rows.Add(cus.IdEmployee, cus.Name, cus.DateBirth, cus.Gender, cus.PlaceBirth, cus.IdDepartment);
            }

            List<DepartmentBEL> dbm = depart.ReadAreaList();
            foreach (DepartmentBEL Depart in dbm)
            {
                tbNameDepartment.Items.Add(Depart);
                tbNameDepartment.DisplayMember = "Name";
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult Thoát;
            Thoát = MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Thoát == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            EmployeeBEL Nv = new EmployeeBEL();

            if (tbId.Text.Equals("") || tbName.Text.Equals("") || tbPlaceBirth.Text.Equals(""))
            {
                MessageBox.Show("Không được bỏ trống", "Thông báo");
            }
            else
            {
                Nv.IdEmployee = tbId.Text;
                Nv.Name = tbName.Text;
                Nv.PlaceBirth = tbPlaceBirth.Text;
                Nv.DateBirth = tbDateBirth.Text;
                Nv.Department = (DepartmentBEL)tbNameDepartment.SelectedItem;
                cusBAL.EditCustomer(Nv);

                DataGridViewRow row = dgvEmployee.CurrentRow;
                row.Cells[0].Value = Nv.IdEmployee;
                row.Cells[1].Value = Nv.Name;
                row.Cells[2].Value = Nv.DateBirth;
                row.Cells[3].Value = Nv.Gender;
                row.Cells[4].Value = Nv.PlaceBirth;
                row.Cells[5].Value = Nv.IdDepartment;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            EmployeeBEL Nv = new EmployeeBEL();
            Nv.IdEmployee = tbId.Text;
            Nv.Name = tbName.Text;
            Nv.PlaceBirth = tbPlaceBirth.Text;
            Nv.DateBirth = tbDateBirth.Text;
            Nv.Department = (DepartmentBEL)tbNameDepartment.SelectedItem;
            int idx = dgvEmployee.CurrentCell.RowIndex;
            cusBAL.DeleteCustomer(Nv);
            dgvEmployee.Rows.RemoveAt(idx);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            EmployeeBEL cus = new EmployeeBEL();
            if (tbId.Text.Equals("") || tbName.Text.Equals("") || tbPlaceBirth.Text.Equals(""))
            {
                MessageBox.Show("Không bỏ trống", "Thông báo");
            }
            else
            {
                cus.IdEmployee = tbId.Text;
                cus.Name = tbName.Text;
                cus.DateBirth = tbDateBirth.Value.Date.ToString();
                cus.Gender = tbGender.Checked;
                cus.PlaceBirth = tbPlaceBirth.Text;
                cus.Department = (DepartmentBEL)tbNameDepartment.SelectedItem;
                cusBAL.NewCustomer(cus);

                dgvEmployee.Rows.Add(cus.IdEmployee, cus.Name, cus.DateBirth, cus.Gender, cus.PlaceBirth, cus.IdDepartment);
            }
        }
    }
}
