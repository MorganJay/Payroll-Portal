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
    public partial class EReporrt : Form
    {
        public EReporrt()
        {
            InitializeComponent();
        }

        private void EReporrt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LogInDataSet6.SystemDefaults' table. You can move, or remove it, as needed.
            this.SystemDefaultsTableAdapter.Fill(this.LogInDataSet6.SystemDefaults);
            // TODO: This line of code loads data into the 'EmployeeView.View_1' table. You can move, or remove it, as needed.
            this.View_1TableAdapter.Fill(this.EmployeeView.View_1);

            this.reportViewer1.RefreshReport();
        }
    }
}
