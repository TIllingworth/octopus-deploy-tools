namespace OctopusDeployAPITools
{
    partial class ReleaseSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gp_releases = new GroupBox();
            lb_releases = new ListBox();
            gp_releases.SuspendLayout();
            SuspendLayout();
            // 
            // gp_releases
            // 
            gp_releases.Controls.Add(lb_releases);
            gp_releases.Dock = DockStyle.Fill;
            gp_releases.Location = new Point(0, 0);
            gp_releases.Name = "gp_releases";
            gp_releases.Size = new Size(522, 757);
            gp_releases.TabIndex = 0;
            gp_releases.TabStop = false;
            gp_releases.Text = "Releases";
            // 
            // lb_releases
            // 
            lb_releases.Dock = DockStyle.Fill;
            lb_releases.Enabled = false;
            lb_releases.FormattingEnabled = true;
            lb_releases.ItemHeight = 25;
            lb_releases.Location = new Point(3, 27);
            lb_releases.Name = "lb_releases";
            lb_releases.Size = new Size(516, 727);
            lb_releases.TabIndex = 0;
            // 
            // ReleaseSelector
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gp_releases);
            Name = "ReleaseSelector";
            Size = new Size(522, 757);
            gp_releases.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gp_releases;
        private ListBox lb_releases;
    }
}
