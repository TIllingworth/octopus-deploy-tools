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
    public partial class ProjectSelector : UserControl
    {
        OctopusRepository _repository;
        private List<ProjectResource> _projects;

        public IEnumerable<ProjectResource> SelectedProjects { get { return lb_projectselection.SelectedItems.Cast<ProjectResource>(); } }

        public ProjectSelector()
        {
            InitializeComponent();
        }

        public void Initialise(OctopusRepository repository, SelectionMode selectionMode = SelectionMode.MultiSimple)
        {
            _repository = repository;
            _projects = _repository.Projects.GetAll();

            lb_projectselection.SelectionMode = selectionMode;
            lb_projectselection.DataSource = _projects;
            lb_projectselection.ValueMember = "Id";
            lb_projectselection.DisplayMember = "Name";
        }

        public void SetInputEnabled(bool enabled)
        {
            cb_customchannelprojectssonly.Enabled = enabled;
            lb_projectselection.Enabled = enabled;
        }

        private void cb_customchannelprojectssonly_CheckedChanged(object sender, EventArgs e)
        {
            SetInputEnabled(false);

            if (cb_customchannelprojectssonly.Checked)
            {
                lb_projectselection.DataSource = _projects.Where(w => _repository.Projects.GetChannels(w).Items.Count() > 1).ToList();
            }
            else
            {
                lb_projectselection.DataSource = _projects;
            }

            SetInputEnabled(true);
        }
    }
}
