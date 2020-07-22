using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlMs
{
    public partial class RelatorioAluno : Form
    {
        ReportClass Report = null;
        DataTable dataTable = null;
        public RelatorioAluno(ReportClass reportClass, DataTable data)
        {
            InitializeComponent();
            Report = reportClass;
            dataTable = data;
        }

        private void RelatorioAluno_Shown(object sender, EventArgs e)
        {
            this.Report.SetDataSource(dataTable);
            this.Report.Refresh();
            crystalReportViewer1.ReportSource = Report;
        }
    }
}
