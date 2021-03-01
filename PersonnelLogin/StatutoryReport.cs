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
    public partial class StatutoryReport : Form
    {
        public StatutoryReport()
        {
            InitializeComponent();
        }

        private void StatutoryReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StatutoryView.View_Statutory' table. You can move, or remove it, as needed.
            this.View_StatutoryTableAdapter.Fill(this.StatutoryView.View_Statutory);

            this.reportViewer1.RefreshReport();
        }
    }
}
