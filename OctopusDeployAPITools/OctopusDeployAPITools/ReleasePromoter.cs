using Octopus.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OctopusDeployAPITools
{
    public partial class ReleasePromoter : Form
    {
        OctopusRepository _repository;

        public ReleasePromoter(OctopusRepository repository)
        {
            InitializeComponent();

            _repository = repository;
            ps_projects.Initialise(_repository);
            es_baseenvironment.Initialise(_repository, "Base Environment");
            es_targetenvironment.Initialise(_repository, "Target Environment");

            dtp_deploylaterdatetime.Value = DateTime.Now.AddHours(1);
            dtp_deploylaterdatetime.MinDate = DateTime.Now.AddMinutes(5);
        }

        private void rb_deploynow_CheckedChanged(object sender, EventArgs e)
        {
            ManageDeployTimeOptions();
        }

        private void rb_deploylater_CheckedChanged(object sender, EventArgs e)
        {
            ManageDeployTimeOptions();
        }

        private void ManageDeployTimeOptions()
        {
            if (rb_deploynow.Checked)
                dtp_deploylaterdatetime.Enabled = false;

            if (rb_deploylater.Checked)
                dtp_deploylaterdatetime.Enabled = true;
        }
    }
}
