namespace OctopusDeployAPITools
{
    partial class TaskManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_activetasks = new ListBox();
            btn_selectall = new Button();
            btn_selectnone = new Button();
            btn_canceltasks = new Button();
            pow_outputmessages = new ProcessOutputWindow();
            SuspendLayout();
            // 
            // lb_activetasks
            // 
            lb_activetasks.FormattingEnabled = true;
            lb_activetasks.ItemHeight = 25;
            lb_activetasks.Location = new Point(12, 12);
            lb_activetasks.Name = "lb_activetasks";
            lb_activetasks.SelectionMode = SelectionMode.MultiSimple;
            lb_activetasks.Size = new Size(638, 629);
            lb_activetasks.TabIndex = 0;
            lb_activetasks.Format += lb_activetasks_Format;
            // 
            // btn_selectall
            // 
            btn_selectall.Location = new Point(12, 647);
            btn_selectall.Name = "btn_selectall";
            btn_selectall.Size = new Size(144, 34);
            btn_selectall.TabIndex = 1;
            btn_selectall.Text = "Select All";
            btn_selectall.UseVisualStyleBackColor = true;
            btn_selectall.Click += btn_selectall_Click;
            // 
            // btn_selectnone
            // 
            btn_selectnone.Location = new Point(162, 647);
            btn_selectnone.Name = "btn_selectnone";
            btn_selectnone.Size = new Size(144, 34);
            btn_selectnone.TabIndex = 2;
            btn_selectnone.Text = "Select None";
            btn_selectnone.UseVisualStyleBackColor = true;
            btn_selectnone.Click += btn_selectnone_Click;
            // 
            // btn_canceltasks
            // 
            btn_canceltasks.BackColor = Color.DarkRed;
            btn_canceltasks.ForeColor = SystemColors.Window;
            btn_canceltasks.Location = new Point(506, 647);
            btn_canceltasks.Name = "btn_canceltasks";
            btn_canceltasks.Size = new Size(144, 34);
            btn_canceltasks.TabIndex = 3;
            btn_canceltasks.Text = "Cancel Tasks";
            btn_canceltasks.UseVisualStyleBackColor = false;
            btn_canceltasks.Click += btn_canceltasks_Click;
            // 
            // pow_outputmessages
            // 
            pow_outputmessages.Dock = DockStyle.Bottom;
            pow_outputmessages.Location = new Point(0, 726);
            pow_outputmessages.Name = "pow_outputmessages";
            pow_outputmessages.Size = new Size(662, 270);
            pow_outputmessages.TabIndex = 4;
            // 
            // TaskManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 996);
            Controls.Add(pow_outputmessages);
            Controls.Add(btn_canceltasks);
            Controls.Add(btn_selectnone);
            Controls.Add(btn_selectall);
            Controls.Add(lb_activetasks);
            Name = "TaskManager";
            Text = "TaskManager";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lb_activetasks;
        private Button btn_selectall;
        private Button btn_selectnone;
        private Button btn_canceltasks;
        private ProcessOutputWindow pow_outputmessages;
    }
}