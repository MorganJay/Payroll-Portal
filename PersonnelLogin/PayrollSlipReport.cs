using System;
using System.Windows.Forms;

namespace PersonnelLogin
{
    public partial class PayrollSlipReport : Form
    {
        public PayrollSlipReport()
        {
            InitializeComponent();
        }

        private void PayrollSlipReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LogInDataSet4.View_3' table. You can move, or remove it, as needed.
            this.View_3TableAdapter.Fill(this.LogInDataSet4.View_3);
            this.reportViewer1.RefreshReport();
        }
    }
}
