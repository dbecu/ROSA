﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RosaLogic;
using RosaModel;
using LoginForm.CustomControls;
namespace LoginForm
{
    public partial class ManagementForm : Form
    {
        private Employee employee;
        public ManagementForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void ManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new homeForm(employee));
        }

        private void tablesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new tableViewForm(employee));
        }

        private void barToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new BarKitchenForm(employee));
        }

        private void kitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new SwitchForms(employee, this, new BarKitchenForm(employee));
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new loginForm());
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            new SwitchForms(employee, this, new AddEmployeeForm(employee));
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }
      public void LoadEmployees()
        {
            Employee_Service employeeService = new Employee_Service();
            List<Employee> employees = employeeService.GetEmployees();

            employeeUC employeeControl;
            pnlEmployees.Controls.Clear(); //clear the existing panels

            foreach (Employee emp in employees) //for each employee, show a custom control and put it in the panel
            {
                employeeControl = new employeeUC(employee,emp,this);
                pnlEmployees.Controls.Add(employeeControl);
            }
        }
    }
}
