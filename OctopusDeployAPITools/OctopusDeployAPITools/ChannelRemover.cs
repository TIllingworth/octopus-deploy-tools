using Octopus.Client.Model;
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
    public partial class ChannelRemover : Form
    {
        OctopusRepository _repository;

        public ChannelRemover(OctopusRepository repository)
        {
            InitializeComponent();

            _repository = repository;
            ps_projects.Initialise(_repository);
        }

        private void SetInputEnabled(bool enabled)
        {
            btn_removechannels.Enabled = enabled;
            ps_projects.SetInputEnabled(enabled);
        }

        private void btn_removechannels_Click(object sender, EventArgs e)
        {
            SetInputEnabled(false);

            try
            {
                foreach (var project in ps_projects.SelectedProjects)
                {
                    pow_output.DisplayMessage("Beginning remove channel for " + project.Name);

                    // Get channel
                    var channel = _repository.Channels.FindByName(project, tb_channelname.Text);
                    if (channel == null) { pow_output.DisplayMessage("Channel not found, skipping project"); continue; }

                    // Remove releases for channel
                    var releases = _repository.Releases.FindMany(r => r.ChannelId == channel.Id);
                    foreach (var release in releases)
                    {
                        _repository.Releases.Delete(release);
                    }

                    // Delete channel
                    _repository.Channels.Delete(channel);

                    pow_output.DisplayMessage("Channel removed for " + project.Name);
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
