using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnelLogin
{
    public partial class PayrollTableReport : Form
    {
        public PayrollTableReport()
        {
            InitializeComponent();
        }

        private void PayrollTableReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PayrollTableView.View_PayrollTable' table. You can move, or remove it, as needed.
            this.View_PayrollTableTableAdapter.Fill(this.PayrollTableView.View_PayrollTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
