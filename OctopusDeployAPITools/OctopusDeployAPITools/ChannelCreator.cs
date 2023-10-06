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
    public partial class ChannelCreator : Form
    {
        OctopusRepository _repository;

        public ChannelCreator(OctopusRepository repository)
        {
            InitializeComponent();
            _repository = repository;
            ps_projects.Initialise(_repository);
        }

        private void SetInputEnabled(bool enabled)
        {
            btn_createchannels.Enabled = enabled;
            tb_channelname.Enabled = enabled;
            tb_channeldescription.Enabled = enabled;
            tb_versionrange.Enabled = enabled;
            cb_defaultchannel.Enabled = enabled;
            ps_projects.SetInputEnabled(enabled);
        }

        private void btn_createchannels_Click(object sender, EventArgs e)
        {
            SetInputEnabled(false);

            try
            {
                foreach (var project in ps_projects.SelectedProjects)
                {
                    pow_output.DisplayMessage("Creating channel for " + project.Name);

                    var deploymentProcess = _repository.DeploymentProcesses.Get(project.DeploymentProcessId);

                    var channelRequest = new ChannelResource
                    {
                        Name = tb_channelname.Text,
                        Description = tb_channeldescription.Text,
                        ProjectId = project.Id,
                        IsDefault = cb_defaultchannel.Checked,
                        Rules = new List<ChannelVersionRuleResource>
                        {
                            new ChannelVersionRuleResource
                            {
                                VersionRange = tb_versionrange.Text,
                                ActionPackages = deploymentProcess.Steps.SelectMany(s => s.Actions.Where(w => w.Packages.Any()))
                                                                            .Select(s => new DeploymentActionPackageResource(s.Name)).ToList()
                }
                        }
                    };

                    _repository.Channels.Create(channelRequest);
                    pow_output.DisplayMessage("Channel sucessfully created for " + project.Name);
                }
            }
            catch (Exception error)
            {
                pow_output.DisplayMessage("An Error has occured");
                pow_output.DisplayMessage(error.Message);
            }
            finally
            {
                SetInputEnabled(true);
            }
        }
    }
}
