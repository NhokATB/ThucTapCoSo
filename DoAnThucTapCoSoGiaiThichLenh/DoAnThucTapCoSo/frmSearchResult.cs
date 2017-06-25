using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTapCoSo
{
    public partial class frmSearchResult : Form
    {
        private bool deleteConfirm = false;
        public bool DeleteConfirm
        {
            get
            {
                return deleteConfirm;
            }

            set
            {
                deleteConfirm = value;
            }
        }
        public frmSearchResult(ListEmployee listEmployee, string action)
        {
            InitializeComponent();

            ShowListEmployeeToDatagridView(listEmployee);

            
            if(action == "Delete")
            {
                btnOk.Visible = false;
            }
            else
            {
                btnYes.Visible = false;
                btnNo.Visible = false;
                lblConfirm.Visible = false;
                this.Size = new Size(this.Size.Width, 440);
            }
        }
        private void ShowListEmployeeToDatagridView(ListEmployee listEmployee)
        {
            dgvListEmployee.Rows.Clear();
            for (Node<Employee> employee = listEmployee.FirstEmployee; employee != null; employee = employee.Next)
            {
                dgvListEmployee.Rows.Add(employee.OrderNumber, employee.Data.Name, employee.Data.BirthDay.ToString(), employee.Data.Position, employee.Data.CoefficienceSalary);
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            deleteConfirm = true;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
