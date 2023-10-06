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
            ps_projects = new ProjectSelector();
            rs_releases = new ReleaseSelector();
            btn_loadreleases = new Button();
            SuspendLayout();
            // 
            // ps_projects
            // 
            ps_projects.Location = new Point(12, 12);
            ps_projects.Name = "ps_projects";
            ps_projects.Size = new Size(360, 441);
            ps_projects.TabIndex = 0;
            // 
            // rs_releases
            // 
            rs_releases.Location = new Point(378, 12);
            rs_releases.Name = "rs_releases";
            rs_releases.Size = new Size(439, 441);
            rs_releases.TabIndex = 1;
            // 
            // btn_loadreleases
            // 
            btn_loadreleases.Location = new Point(12, 459);
            btn_loadreleases.Name = "btn_loadreleases";
            btn_loadreleases.Size = new Size(183, 34);
            btn_loadreleases.TabIndex = 2;
            btn_loadreleases.Text = "Load Releases";
            btn_loadreleases.UseVisualStyleBackColor = true;
            btn_loadreleases.Click += btn_loadreleases_Click;
            // 
            // ReleaseDuplicator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 1080);
            Controls.Add(btn_loadreleases);
            Controls.Add(rs_releases);
            Controls.Add(ps_projects);
            Name = "ReleaseDuplicator";
            Text = "ReleaseDuplicator";
            ResumeLayout(false);
        }

        #endregion

        private ProjectSelector ps_projects;
        private ReleaseSelector rs_releases;
        private Button btn_loadreleases;
    }
}