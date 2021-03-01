using System;
using System.Windows.Forms;

namespace PersonnelLogin
{
    public partial class PayrollPortalWindow : Form
    {
        
        public PayrollPortalWindow(string department)
        {
            InitializeComponent();
           departmentlabel.Text = department;
        }

        private void MdiParent1_Load(object sender, EventArgs e)
        {
        }

        private void employeeBiodataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeBiodata ss = new EmployeeBiodata { MdiParent = this };
            ss.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to exit this application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            Application.Exit();
        }

        private void jobDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobDescription ss = new JobDescription { MdiParent = this };
            ss.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department ss = new Department { MdiParent = this };
            ss.Show();
        }

        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatesForm ss = new  StatesForm {MdiParent = this};
            ss.Show();  
        }

        private void banksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banks ss = new Banks {MdiParent = this};
            ss.Show();
        }

        private void passwordSetupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void passwordCreationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CreateYourPassword ss = new CreateYourPassword { MdiParent = this };
            ss.Show();
        }

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangePassword ss = new ChangePassword { MdiParent = this };
            ss.Show();
        }

        private void transactionTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionType ss = new TransactionType { MdiParent = this };
            ss.Show();
        }

        private void statutoryDeductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatutoryDeduction ss = new StatutoryDeduction { MdiParent = this };
            ss.Show();
        }

        private void pFADataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PfAtable ss = new PfAtable { MdiParent = this };
            ss.Show();
        }

        private void payrollTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayrollTransaction ss = new PayrollTransaction { MdiParent = this };
            ss.Show();
        }

        private void payrollTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayrollTable ss = new PayrollTable { MdiParent = this };
            ss.Show();
        }

        private void systemDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemDefaults ss = new SystemDefaults { MdiParent = this };
            ss.Show();
        }

        private void startANewMonthToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartANewMonth ss = new StartANewMonth { MdiParent = this };
            ss.Show();
        }

        private void salaryPToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void paySlipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayrollSlipReport ss = new PayrollSlipReport {MdiParent = this};
            ss.Show();
        }
    }
}
