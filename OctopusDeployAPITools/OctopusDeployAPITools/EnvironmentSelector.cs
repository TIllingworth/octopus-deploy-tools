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
    public partial class EnvironmentSelector : UserControl
    {
        OctopusRepository _repository;
        private List<EnvironmentResource> _environments;

        public IEnumerable<EnvironmentResource> SelectedEnvironments { get { return lb_environments.SelectedItems.Cast<EnvironmentResource>(); } }

        public EnvironmentSelector()
        {
            InitializeComponent();
        }

        public void Initialise(OctopusRepository repository, string? collectionName)
        {
            _repository = repository;
            _environments = _repository.Environments.GetAll();

            lb_environments.DataSource = _environments;
            lb_environments.ValueMember = "Id";
            lb_environments.DisplayMember = "Name";

            gp_container.Text = collectionName ?? gp_container.Text;
        }

        public void SetInputEnabled(bool enabled)
        {
            lb_environments.Enabled = enabled;
        }
    }
}
