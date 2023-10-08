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
    public partial class TaskManager : Form
    {
        OctopusRepository _repository;
        private List<TaskResource> _activeTasks;

        public TaskManager(OctopusRepository repository)
        {
            InitializeComponent();

            _repository = repository;
            LoadActiveTasks();
        }

        private void SetInputEnabled(bool enabled)
        {
            lb_activetasks.Enabled = enabled;
            btn_selectall.Enabled = enabled;
            btn_selectnone.Enabled = enabled;
            btn_canceltasks.Enabled = enabled;
        }

        private void LoadActiveTasks()
        {
            SetInputEnabled(false);

            _activeTasks = _repository.Tasks.GetAllActive();

            lb_activetasks.DataSource = null;
            lb_activetasks.DataSource = _activeTasks;
            lb_activetasks.ValueMember = "Id";
            lb_activetasks.DisplayMember = "Description";

            SetInputEnabled(true);
        }

        private void btn_selectall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_activetasks.Items.Count; i++)
            {
                lb_activetasks.SetSelected(i, true);
            }
        }

        private void btn_selectnone_Click(object sender, EventArgs e)
        {
            lb_activetasks.ClearSelected();
        }

        private void btn_canceltasks_Click(object sender, EventArgs e)
        {
            SetInputEnabled(false);

            foreach (var task in lb_activetasks.SelectedItems.Cast<TaskResource>())
            {
                try
                {
                    _repository.Tasks.Cancel(task);

                    pow_outputmessages.DisplayMessage("Cancelled task:  " + task.Description);
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

        private void lb_activetasks_Format(object sender, ListControlConvertEventArgs e)
        {
            var startTime = (((TaskResource)e.ListItem).StartTime ?? ((TaskResource)e.ListItem).QueueTime).ToString();
            var description = ((TaskResource)e.ListItem).Description;
            var completed = ((TaskResource)e.ListItem).Completed;

            e.Value = startTime + "    " + completed + "    " + description;
        }
    }
}
