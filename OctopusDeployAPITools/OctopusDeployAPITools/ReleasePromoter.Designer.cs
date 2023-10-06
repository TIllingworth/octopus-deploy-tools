namespace OctopusDeployAPITools
{
    partial class ReleasePromoter
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
            ps_projects = new ProjectSelector();
            processOutputWindow1 = new ProcessOutputWindow();
            es_baseenvironment = new EnvironmentSelector();
            es_targetenvironment = new EnvironmentSelector();
            rb_deploynow = new RadioButton();
            rb_deploylater = new RadioButton();
            dtp_deploylaterdatetime = new DateTimePicker();
            tb_baseenvironmentversions = new TextBox();
            SuspendLayout();
            // 
            // ps_projects
            // 
            ps_projects.Location = new Point(12, 12);
            ps_projects.Name = "ps_projects";
            ps_projects.Size = new Size(377, 635);
            ps_projects.TabIndex = 0;
            // 
            // processOutputWindow1
            // 
            processOutputWindow1.Dock = DockStyle.Bottom;
            processOutputWindow1.Location = new Point(0, 1011);
            processOutputWindow1.Name = "processOutputWindow1";
            processOutputWindow1.Size = new Size(992, 312);
            processOutputWindow1.TabIndex = 1;
            // 
            // es_baseenvironment
            // 
            es_baseenvironment.Location = new Point(395, 12);
            es_baseenvironment.Name = "es_baseenvironment";
            es_baseenvironment.Size = new Size(288, 635);
            es_baseenvironment.TabIndex = 2;
            // 
            // es_targetenvironment
            // 
            es_targetenvironment.Location = new Point(689, 12);
            es_targetenvironment.Name = "es_targetenvironment";
            es_targetenvironment.Size = new Size(288, 635);
            es_targetenvironment.TabIndex = 3;
            // 
            // rb_deploynow
            // 
            rb_deploynow.AutoSize = true;
            rb_deploynow.Checked = true;
            rb_deploynow.Location = new Point(12, 690);
            rb_deploynow.Name = "rb_deploynow";
            rb_deploynow.Size = new Size(136, 29);
            rb_deploynow.TabIndex = 4;
            rb_deploynow.TabStop = true;
            rb_deploynow.Text = "Deploy Now";
            rb_deploynow.UseVisualStyleBackColor = true;
            rb_deploynow.CheckedChanged += rb_deploynow_CheckedChanged;
            // 
            // rb_deploylater
            // 
            rb_deploylater.AutoSize = true;
            rb_deploylater.Location = new Point(12, 725);
            rb_deploylater.Name = "rb_deploylater";
            rb_deploylater.Size = new Size(137, 29);
            rb_deploylater.TabIndex = 5;
            rb_deploylater.Text = "Deploy Later";
            rb_deploylater.UseVisualStyleBackColor = true;
            rb_deploylater.CheckedChanged += rb_deploylater_CheckedChanged;
            // 
            // dtp_deploylaterdatetime
            // 
            dtp_deploylaterdatetime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtp_deploylaterdatetime.Enabled = false;
            dtp_deploylaterdatetime.Format = DateTimePickerFormat.Custom;
            dtp_deploylaterdatetime.Location = new Point(42, 760);
            dtp_deploylaterdatetime.Name = "dtp_deploylaterdatetime";
            dtp_deploylaterdatetime.Size = new Size(227, 31);
            dtp_deploylaterdatetime.TabIndex = 6;
            // 
            // tb_baseenvironmentversions
            // 
            tb_baseenvironmentversions.Location = new Point(395, 653);
            tb_baseenvironmentversions.Multiline = true;
            tb_baseenvironmentversions.Name = "tb_baseenvironmentversions";
            tb_baseenvironmentversions.ReadOnly = true;
            tb_baseenvironmentversions.Size = new Size(582, 353);
            tb_baseenvironmentversions.TabIndex = 7;
            // 
            // ReleasePromoter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(992, 1323);
            Controls.Add(tb_baseenvironmentversions);
            Controls.Add(dtp_deploylaterdatetime);
            Controls.Add(rb_deploylater);
            Controls.Add(rb_deploynow);
            Controls.Add(es_targetenvironment);
            Controls.Add(es_baseenvironment);
            Controls.Add(processOutputWindow1);
            Controls.Add(ps_projects);
            Name = "ReleasePromoter";
            Text = "Release Promoter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProjectSelector ps_projects;
        private ProcessOutputWindow processOutputWindow1;
        private EnvironmentSelector es_baseenvironment;
        private EnvironmentSelector es_targetenvironment;
        private RadioButton rb_deploynow;
        private RadioButton rb_deploylater;
        private DateTimePicker dtp_deploylaterdatetime;
        private TextBox tb_baseenvironmentversions;
    }
}