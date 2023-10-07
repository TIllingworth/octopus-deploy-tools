using Octopus.Client;
using Octopus.Client.Model;
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
        DashboardResource _dashboard;

        public ReleasePromoter(OctopusRepository repository)
        {
            InitializeComponent();

            _repository = repository;
            _dashboard = _repository.Dashboards.GetDashboard();
            ps_projects.Initialise(_repository);
            es_baseenvironment.Initialise(_repository, "Base Environment");
            es_targetenvironment.Initialise(_repository, "Target Environment");

            dtp_deploylaterdatetime.Value = DateTime.Now.AddHours(1);
            dtp_deploylaterdatetime.MinDate = DateTime.Now.AddMinutes(5);
        }

        public void SetInputEnabled(bool enabled)
        {
            ps_projects.Enabled = enabled;
            es_baseenvironment.Enabled = enabled;
            es_targetenvironment.Enabled = enabled;
            rb_deploynow.Enabled = enabled;
            rb_deploylater.Enabled = enabled;
            btn_checkversions.Enabled = enabled;
        }

        private void OutputVersion(string message)
        {
            tb_baseenvironmentversions.AppendText(message);
            tb_baseenvironmentversions.AppendText(Environment.NewLine);
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

        private void btn_checkversions_Click(object sender, EventArgs e)
        {
            SetInputEnabled(false);
            pow_outputmessages.DisplayMessage("Checking versions");

            tb_baseenvironmentversions.Clear();

            var versionSpacing = 40;

            foreach (var project in ps_projects.SelectedProjects)
            {
                try
                {
                    var projectName = project.Name + ":";
                    var padding = versionSpacing - projectName.Length < 0 ? 0 : versionSpacing - projectName.Length;
                    var version = GetBaseEnvironmentRelease(project.Id).ReleaseVersion;

                    OutputVersion(projectName.PadRight(versionSpacing, ' ') + version);
                }
                catch
                {
                    OutputVersion("Failed to locase base release version");
                }
            }

            pow_outputmessages.DisplayMessage("Version check complete - see results");
            SetInputEnabled(true);
        }

        private DashboardItemResource GetBaseEnvironmentRelease(string projectId)
        {
            return _dashboard.Items.First(w => w.ProjectId == projectId
                                                            && w.EnvironmentId == es_baseenvironment.SelectedEnvironments.First().Id);
        }

        private List<DashboardTenantResource> GetDeploymentTenants(string projectId, string environmentId)
        {
            ReferenceCollection col;
            return _dashboard.Tenants.Where(w => w.ProjectEnvironments.TryGetValue(projectId, out col) && col.ToList().Contains(environmentId)).ToList();
        }

        private void btn_deployreleases_Click(object sender, EventArgs e)
        {
            SetInputEnabled(false);

            var deployTime = rb_deploylater.Checked ? dtp_deploylaterdatetime.Value : (DateTime?)null;
            var deployExpiry = rb_deploylater.Checked ? dtp_deploylaterdatetime.Value.AddHours(3) : (DateTime?)null;

            try
            {
                foreach (var project in ps_projects.SelectedProjects)
                {
                    pow_outputmessages.DisplayMessage("Promoting release for project: " + project.Name);

                    var dashboardItem = GetBaseEnvironmentRelease(project.Id);
                    var targetEnvironment = es_targetenvironment.SelectedEnvironments.First();

                    var deploymentRequest = new DeploymentResource
                    {
                        Name = "Deploy to " + targetEnvironment.Name,
                        ReleaseId = dashboardItem.ReleaseId,
                        EnvironmentId = targetEnvironment.Id,
                        QueueTime = deployTime
                    };

                    if (dashboardItem.TenantId == null)
                    {
                        pow_outputmessages.DisplayMessage("Creating untenanted deployment");
                        _repository.Deployments.Create(deploymentRequest);
                    }
                    else
                    {
                        var tenants = GetDeploymentTenants(project.Id, targetEnvironment.Id);

                        foreach (var tenant in tenants)
                        {
                            deploymentRequest.TenantId = tenant.Id;
                            pow_outputmessages.DisplayMessage("Creating tenanted deployment for: " + tenant.Name);
                            _repository.Deployments.Create(deploymentRequest);
                        }
                    }

                    pow_outputmessages.DisplayMessage("All required deployments created for project: " + project.Name);
                }
            }
            catch (Exception error)
            {
                pow_outputmessages.DisplayMessage(error.Message);
            }
            finally
            {
                SetInputEnabled(true);
            }
        }
    }
}
