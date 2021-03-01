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
    public partial class PayrollTransactionReport : Form
    {
        public PayrollTransactionReport()
        {
            InitializeComponent();
        }

        private void PayrollTransactionReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PayrollTransactionView.View_PayrollTransaction' table. You can move, or remove it, as needed.
            this.View_PayrollTransactionTableAdapter.Fill(this.PayrollTransactionView.View_PayrollTransaction);

            this.reportViewer1.RefreshReport();
        }
    }
}
