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
    public partial class ProcessOutputWindow : UserControl
    {
        public ProcessOutputWindow()
        {
            InitializeComponent();
        }

        public void DisplayMessage(string message)
        {
            tb_outputwindow.AppendText(message);
            tb_outputwindow.AppendText(Environment.NewLine);
        }
    }
}
