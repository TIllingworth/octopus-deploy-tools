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
    public partial class ReleaseDuplicator : Form
    {
        OctopusRepository _repository;

        public ReleaseDuplicator(OctopusRepository repository)
        {
            InitializeComponent();

            _repository = repository;
            ps_projects.Initialise(_repository, SelectionMode.One);
        }

        private void btn_loadreleases_Click(object sender, EventArgs e)
        {
            rs_releases.LoadProjectReleases(ps_projects.SelectedProjects.First().Id);
        }
    }
}
