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
    public partial class Home : Form
    {
        OctopusRepository? _repository;

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_authenticate_Click(object sender, EventArgs e)
        {
            gb_navigation.Enabled = false;
            tb_octopusurl.BackColor = Color.White;
            tb_apikey.BackColor = Color.White;

            if (tb_octopusurl.Text.Length == 0)
            {
                MessageBox.Show("A URL must be provided", "Error");
                return;
            }

            if (tb_apikey.Text.Length == 0)
            {
                MessageBox.Show("An API key must be provided", "Error");
                return;
            }

            try
            {
                var endpoint = new OctopusServerEndpoint(tb_octopusurl.Text, tb_apikey.Text);
                _repository = new OctopusRepository(endpoint);

                tb_octopusurl.BackColor = Color.PaleGreen;
                tb_apikey.BackColor = Color.PaleGreen;
            }
            catch
            {
                MessageBox.Show("Something went wrong when authenticating with the Octopus server", "Error");
                return;
            }

            if (_repository != null)
                gb_navigation.Enabled = true;
        }

        private void btn_channelcreator_Click(object sender, EventArgs e)
        {
            new ChannelCreator(_repository).Show();
        }

        private void btn_channelremover_Click(object sender, EventArgs e)
        {
            new ChannelRemover(_repository).Show();
        }

        private void btn_releasepromoter_Click(object sender, EventArgs e)
        {
            new ReleasePromoter(_repository).Show();
        }

        private void btn_releaseduplicator_Click(object sender, EventArgs e)
        {
            new ReleaseDuplicator(_repository).Show();
        }
    }
}
