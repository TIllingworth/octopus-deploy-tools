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
using static Octopus.Client.Model.TenantVariableResource;

namespace OctopusDeployAPITools
{
    public partial class ReleaseSelector : UserControl
    {
        OctopusRepository _repository;
        private List<ReleaseResource> _releases;

        public ReleaseSelector()
        {
            InitializeComponent();
        }

        public void Initialise(OctopusRepository repository)
        {
            _repository = repository;

            lb_releases.DataSource = _releases;
            lb_releases.ValueMember = "Id";
            lb_releases.DisplayMember = "Version";
        }

        public void LoadProjectReleases(string projectId)
        {
            lb_releases.Enabled = false;

            _releases = _repository.Releases.FindMany(f => f.ProjectId == projectId);

            lb_releases.Enabled = true;
        }
    }
}
