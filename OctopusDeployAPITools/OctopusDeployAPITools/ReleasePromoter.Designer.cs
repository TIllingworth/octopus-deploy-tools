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
            this.ps_projects = new OctopusDeployAPITools.ProjectSelector();
            this.pow_outputmessages = new OctopusDeployAPITools.ProcessOutputWindow();
            this.es_baseenvironment = new OctopusDeployAPITools.EnvironmentSelector();
            this.es_targetenvironment = new OctopusDeployAPITools.EnvironmentSelector();
            this.rb_deploynow = new System.Windows.Forms.RadioButton();
            this.rb_deploylater = new System.Windows.Forms.RadioButton();
            this.dtp_deploylaterdatetime = new System.Windows.Forms.DateTimePicker();
            this.tb_baseenvironmentversions = new System.Windows.Forms.TextBox();
            this.btn_checkversions = new System.Windows.Forms.Button();
            this.btn_deployreleases = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ps_projects
            // 
            this.ps_projects.Location = new System.Drawing.Point(12, 12);
            this.ps_projects.Name = "ps_projects";
            this.ps_projects.Size = new System.Drawing.Size(377, 635);
            this.ps_projects.TabIndex = 0;
            // 
            // pow_outputmessages
            // 
            this.pow_outputmessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pow_outputmessages.Location = new System.Drawing.Point(0, 1011);
            this.pow_outputmessages.Name = "pow_outputmessages";
            this.pow_outputmessages.Size = new System.Drawing.Size(992, 312);
            this.pow_outputmessages.TabIndex = 1;
            // 
            // es_baseenvironment
            // 
            this.es_baseenvironment.Location = new System.Drawing.Point(395, 12);
            this.es_baseenvironment.Name = "es_baseenvironment";
            this.es_baseenvironment.Size = new System.Drawing.Size(288, 635);
            this.es_baseenvironment.TabIndex = 2;
            // 
            // es_targetenvironment
            // 
            this.es_targetenvironment.Location = new System.Drawing.Point(689, 12);
            this.es_targetenvironment.Name = "es_targetenvironment";
            this.es_targetenvironment.Size = new System.Drawing.Size(288, 635);
            this.es_targetenvironment.TabIndex = 3;
            // 
            // rb_deploynow
            // 
            this.rb_deploynow.AutoSize = true;
            this.rb_deploynow.Checked = true;
            this.rb_deploynow.Location = new System.Drawing.Point(12, 690);
            this.rb_deploynow.Name = "rb_deploynow";
            this.rb_deploynow.Size = new System.Drawing.Size(136, 29);
            this.rb_deploynow.TabIndex = 4;
            this.rb_deploynow.TabStop = true;
            this.rb_deploynow.Text = "Deploy Now";
            this.rb_deploynow.UseVisualStyleBackColor = true;
            this.rb_deploynow.CheckedChanged += new System.EventHandler(this.rb_deploynow_CheckedChanged);
            // 
            // rb_deploylater
            // 
            this.rb_deploylater.AutoSize = true;
            this.rb_deploylater.Location = new System.Drawing.Point(12, 725);
            this.rb_deploylater.Name = "rb_deploylater";
            this.rb_deploylater.Size = new System.Drawing.Size(137, 29);
            this.rb_deploylater.TabIndex = 5;
            this.rb_deploylater.Text = "Deploy Later";
            this.rb_deploylater.UseVisualStyleBackColor = true;
            this.rb_deploylater.CheckedChanged += new System.EventHandler(this.rb_deploylater_CheckedChanged);
            // 
            // dtp_deploylaterdatetime
            // 
            this.dtp_deploylaterdatetime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtp_deploylaterdatetime.Enabled = false;
            this.dtp_deploylaterdatetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_deploylaterdatetime.Location = new System.Drawing.Point(42, 760);
            this.dtp_deploylaterdatetime.Name = "dtp_deploylaterdatetime";
            this.dtp_deploylaterdatetime.Size = new System.Drawing.Size(227, 31);
            this.dtp_deploylaterdatetime.TabIndex = 6;
            // 
            // tb_baseenvironmentversions
            // 
            this.tb_baseenvironmentversions.Location = new System.Drawing.Point(395, 693);
            this.tb_baseenvironmentversions.Multiline = true;
            this.tb_baseenvironmentversions.Name = "tb_baseenvironmentversions";
            this.tb_baseenvironmentversions.ReadOnly = true;
            this.tb_baseenvironmentversions.Size = new System.Drawing.Size(582, 313);
            this.tb_baseenvironmentversions.TabIndex = 7;
            // 
            // btn_checkversions
            // 
            this.btn_checkversions.Location = new System.Drawing.Point(395, 653);
            this.btn_checkversions.Name = "btn_checkversions";
            this.btn_checkversions.Size = new System.Drawing.Size(257, 34);
            this.btn_checkversions.TabIndex = 8;
            this.btn_checkversions.Text = "Check Versions";
            this.btn_checkversions.UseVisualStyleBackColor = true;
            this.btn_checkversions.Click += new System.EventHandler(this.btn_checkversions_Click);
            // 
            // btn_deployreleases
            // 
            this.btn_deployreleases.Location = new System.Drawing.Point(12, 971);
            this.btn_deployreleases.Name = "btn_deployreleases";
            this.btn_deployreleases.Size = new System.Drawing.Size(377, 34);
            this.btn_deployreleases.TabIndex = 9;
            this.btn_deployreleases.Text = "Deploy Releases";
            this.btn_deployreleases.UseVisualStyleBackColor = true;
            this.btn_deployreleases.Click += new System.EventHandler(this.btn_deployreleases_Click);
            // 
            // ReleasePromoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(992, 1323);
            this.Controls.Add(this.btn_deployreleases);
            this.Controls.Add(this.btn_checkversions);
            this.Controls.Add(this.tb_baseenvironmentversions);
            this.Controls.Add(this.dtp_deploylaterdatetime);
            this.Controls.Add(this.rb_deploylater);
            this.Controls.Add(this.rb_deploynow);
            this.Controls.Add(this.es_targetenvironment);
            this.Controls.Add(this.es_baseenvironment);
            this.Controls.Add(this.pow_outputmessages);
            this.Controls.Add(this.ps_projects);
            this.Name = "ReleasePromoter";
            this.Text = "Release Promoter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectSelector ps_projects;
        private ProcessOutputWindow pow_outputmessages;
        private EnvironmentSelector es_baseenvironment;
        private EnvironmentSelector es_targetenvironment;
        private RadioButton rb_deploynow;
        private RadioButton rb_deploylater;
        private DateTimePicker dtp_deploylaterdatetime;
        private TextBox tb_baseenvironmentversions;
        private Button btn_checkversions;
        private Button btn_deployreleases;
    }
}