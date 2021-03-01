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
    public partial class TransactionReport : Form
    {
        public TransactionReport()
        {
            InitializeComponent();
        }

        private void TransactionReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TransactionTypeView.View_TransactionType' table. You can move, or remove it, as needed.
            this.View_TransactionTypeTableAdapter.Fill(this.TransactionTypeView.View_TransactionType);

            this.reportViewer1.RefreshReport();
        }
    }
}
