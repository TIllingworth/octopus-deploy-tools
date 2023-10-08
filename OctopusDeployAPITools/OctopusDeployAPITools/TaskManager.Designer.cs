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
            this.lb_activetasks = new System.Windows.Forms.ListBox();
            this.btn_selectall = new System.Windows.Forms.Button();
            this.btn_selectnone = new System.Windows.Forms.Button();
            this.btn_canceltasks = new System.Windows.Forms.Button();
            this.pow_outputmessages = new OctopusDeployAPITools.ProcessOutputWindow();
            this.btn_refreshtasklist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_activetasks
            // 
            this.lb_activetasks.FormattingEnabled = true;
            this.lb_activetasks.ItemHeight = 25;
            this.lb_activetasks.Location = new System.Drawing.Point(12, 12);
            this.lb_activetasks.Name = "lb_activetasks";
            this.lb_activetasks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_activetasks.Size = new System.Drawing.Size(893, 629);
            this.lb_activetasks.TabIndex = 0;
            // 
            // btn_selectall
            // 
            this.btn_selectall.Location = new System.Drawing.Point(12, 647);
            this.btn_selectall.Name = "btn_selectall";
            this.btn_selectall.Size = new System.Drawing.Size(144, 34);
            this.btn_selectall.TabIndex = 1;
            this.btn_selectall.Text = "Select All";
            this.btn_selectall.UseVisualStyleBackColor = true;
            this.btn_selectall.Click += new System.EventHandler(this.btn_selectall_Click);
            // 
            // btn_selectnone
            // 
            this.btn_selectnone.Location = new System.Drawing.Point(162, 647);
            this.btn_selectnone.Name = "btn_selectnone";
            this.btn_selectnone.Size = new System.Drawing.Size(144, 34);
            this.btn_selectnone.TabIndex = 2;
            this.btn_selectnone.Text = "Select None";
            this.btn_selectnone.UseVisualStyleBackColor = true;
            this.btn_selectnone.Click += new System.EventHandler(this.btn_selectnone_Click);
            // 
            // btn_canceltasks
            // 
            this.btn_canceltasks.BackColor = System.Drawing.Color.DarkRed;
            this.btn_canceltasks.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_canceltasks.Location = new System.Drawing.Point(761, 647);
            this.btn_canceltasks.Name = "btn_canceltasks";
            this.btn_canceltasks.Size = new System.Drawing.Size(144, 34);
            this.btn_canceltasks.TabIndex = 3;
            this.btn_canceltasks.Text = "Cancel Tasks";
            this.btn_canceltasks.UseVisualStyleBackColor = false;
            this.btn_canceltasks.Click += new System.EventHandler(this.btn_canceltasks_Click);
            // 
            // pow_outputmessages
            // 
            this.pow_outputmessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pow_outputmessages.Location = new System.Drawing.Point(0, 726);
            this.pow_outputmessages.Name = "pow_outputmessages";
            this.pow_outputmessages.Size = new System.Drawing.Size(917, 270);
            this.pow_outputmessages.TabIndex = 4;
            // 
            // btn_refreshtasklist
            // 
            this.btn_refreshtasklist.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_refreshtasklist.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_refreshtasklist.Location = new System.Drawing.Point(611, 647);
            this.btn_refreshtasklist.Name = "btn_refreshtasklist";
            this.btn_refreshtasklist.Size = new System.Drawing.Size(144, 34);
            this.btn_refreshtasklist.TabIndex = 5;
            this.btn_refreshtasklist.Text = "Refresh";
            this.btn_refreshtasklist.UseVisualStyleBackColor = false;
            this.btn_refreshtasklist.Click += new System.EventHandler(this.btn_refreshtasklist_Click);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 996);
            this.Controls.Add(this.btn_refreshtasklist);
            this.Controls.Add(this.pow_outputmessages);
            this.Controls.Add(this.btn_canceltasks);
            this.Controls.Add(this.btn_selectnone);
            this.Controls.Add(this.btn_selectall);
            this.Controls.Add(this.lb_activetasks);
            this.Name = "TaskManager";
            this.Text = "TaskManager";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lb_activetasks;
        private Button btn_selectall;
        private Button btn_selectnone;
        private Button btn_canceltasks;
        private ProcessOutputWindow pow_outputmessages;
        private Button btn_refreshtasklist;
    }
}