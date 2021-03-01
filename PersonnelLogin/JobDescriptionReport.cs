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
    public partial class JobDescriptionReport : Form
    {
        public JobDescriptionReport()
        {
            InitializeComponent();
        }

        private void JobDescriptionReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'JobDescriptionView.View_JobDescription' table. You can move, or remove it, as needed.
            this.View_JobDescriptionTableAdapter.Fill(this.JobDescriptionView.View_JobDescription);

            this.reportViewer1.RefreshReport();
        }
    }
}
