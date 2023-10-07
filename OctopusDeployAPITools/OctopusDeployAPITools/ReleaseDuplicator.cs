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
    public partial class ReleaseDuplicator : Form
    {
        OctopusRepository _repository;
        private ReleaseResource _selectedRelease;

        public ReleaseDuplicator(OctopusRepository repository)
        {
            InitializeComponent();

            _repository = repository;
            ps_projects.Initialise(_repository, SelectionMode.One);
            rs_releases.Initialise(_repository, SelectionMode.One);
        }

        public void SetInputEnabled(bool enabled)
        {
            ps_projects.Enabled = enabled;
            rs_releases.Enabled = enabled;
            tb_version.Enabled = enabled;
            btn_loadreleases.Enabled = enabled;
            btn_selectrelease.Enabled = enabled;
            btn_copyrelease.Enabled = enabled;
        }

        private void btn_loadreleases_Click(object sender, EventArgs e)
        {
            SetInputEnabled(false);
            rs_releases.LoadProjectReleases(ps_projects.SelectedProjects.First().Id);
            SetInputEnabled(true);
        }

        private void btn_selectrelease_Click(object sender, EventArgs e)
        {
            SetInputEnabled(false);

            _selectedRelease = rs_releases.SelectedReleases.FirstOrDefault();
            tb_version.Text = _selectedRelease.Version;

            SetInputEnabled(true);
        }

        private void btn_copyrelease_Click(object sender, EventArgs e)
        {
            if (_selectedRelease.Version.Length == 0)
            {
                pow_output.DisplayMessage("No version selected");
                return;
            }

            SetInputEnabled(false);

            pow_output.DisplayMessage("Beginning copy");

            _selectedRelease.Version = tb_version.Text;
            _selectedRelease.ProjectDeploymentProcessSnapshotId = null;// _repository.DeploymentProcesses.Get(ps_projects.SelectedProjects.First()).LastSnapshotId;
            _selectedRelease.ProjectVariableSetSnapshotId = null;
            _selectedRelease.LibraryVariableSetSnapshotIds = null;

            _repository.Releases.Create(_selectedRelease);

            pow_output.DisplayMessage("Copy complete");
            pow_output.DisplayMessage("Refreshing releases list");

            rs_releases.ReloadReleases(ps_projects.SelectedProjects.First().Id);

            pow_output.DisplayMessage("Refresh complete");

            SetInputEnabled(true);
        }
    }
}
