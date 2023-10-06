namespace OctopusDeployAPITools
{
    partial class ReleaseDuplicator
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
            this.rs_releases = new OctopusDeployAPITools.ReleaseSelector();
            this.btn_loadreleases = new System.Windows.Forms.Button();
            this.btn_selectrelease = new System.Windows.Forms.Button();
            this.tb_version = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_copyrelease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ps_projects
            // 
            this.ps_projects.Location = new System.Drawing.Point(12, 12);
            this.ps_projects.Name = "ps_projects";
            this.ps_projects.Size = new System.Drawing.Size(415, 441);
            this.ps_projects.TabIndex = 0;
            // 
            // rs_releases
            // 
            this.rs_releases.Location = new System.Drawing.Point(433, 12);
            this.rs_releases.Name = "rs_releases";
            this.rs_releases.Size = new System.Drawing.Size(384, 441);
            this.rs_releases.TabIndex = 1;
            // 
            // btn_loadreleases
            // 
            this.btn_loadreleases.Location = new System.Drawing.Point(12, 459);
            this.btn_loadreleases.Name = "btn_loadreleases";
            this.btn_loadreleases.Size = new System.Drawing.Size(183, 34);
            this.btn_loadreleases.TabIndex = 2;
            this.btn_loadreleases.Text = "Load Releases";
            this.btn_loadreleases.UseVisualStyleBackColor = true;
            this.btn_loadreleases.Click += new System.EventHandler(this.btn_loadreleases_Click);
            // 
            // btn_selectrelease
            // 
            this.btn_selectrelease.Location = new System.Drawing.Point(433, 459);
            this.btn_selectrelease.Name = "btn_selectrelease";
            this.btn_selectrelease.Size = new System.Drawing.Size(183, 34);
            this.btn_selectrelease.TabIndex = 3;
            this.btn_selectrelease.Text = "Select Release";
            this.btn_selectrelease.UseVisualStyleBackColor = true;
            this.btn_selectrelease.Click += new System.EventHandler(this.btn_selectrelease_Click);
            // 
            // tb_version
            // 
            this.tb_version.Location = new System.Drawing.Point(12, 600);
            this.tb_version.Name = "tb_version";
            this.tb_version.Size = new System.Drawing.Size(253, 31);
            this.tb_version.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Version";
            // 
            // btn_copyrelease
            // 
            this.btn_copyrelease.Location = new System.Drawing.Point(12, 637);
            this.btn_copyrelease.Name = "btn_copyrelease";
            this.btn_copyrelease.Size = new System.Drawing.Size(183, 34);
            this.btn_copyrelease.TabIndex = 6;
            this.btn_copyrelease.Text = "Create Copy";
            this.btn_copyrelease.UseVisualStyleBackColor = true;
            this.btn_copyrelease.Click += new System.EventHandler(this.btn_copyrelease_Click);
            // 
            // ReleaseDuplicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 1080);
            this.Controls.Add(this.btn_copyrelease);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_version);
            this.Controls.Add(this.btn_selectrelease);
            this.Controls.Add(this.btn_loadreleases);
            this.Controls.Add(this.rs_releases);
            this.Controls.Add(this.ps_projects);
            this.Name = "ReleaseDuplicator";
            this.Text = "ReleaseDuplicator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectSelector ps_projects;
        private ReleaseSelector rs_releases;
        private Button btn_loadreleases;
        private Button btn_selectrelease;
        private TextBox tb_version;
        private Label label1;
        private Button btn_copyrelease;
    }
}