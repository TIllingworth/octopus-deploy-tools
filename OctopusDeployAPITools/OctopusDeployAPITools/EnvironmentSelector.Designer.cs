namespace OctopusDeployAPITools
{
    partial class EnvironmentSelector
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
            gp_container = new GroupBox();
            lb_environments = new ListBox();
            gp_container.SuspendLayout();
            SuspendLayout();
            // 
            // gp_container
            // 
            gp_container.Controls.Add(lb_environments);
            gp_container.Dock = DockStyle.Fill;
            gp_container.Location = new Point(0, 0);
            gp_container.Name = "gp_container";
            gp_container.Size = new Size(403, 647);
            gp_container.TabIndex = 0;
            gp_container.TabStop = false;
            gp_container.Text = "Environment";
            // 
            // lb_environments
            // 
            lb_environments.Dock = DockStyle.Fill;
            lb_environments.FormattingEnabled = true;
            lb_environments.ItemHeight = 25;
            lb_environments.Location = new Point(3, 27);
            lb_environments.Name = "lb_environments";
            lb_environments.Size = new Size(397, 617);
            lb_environments.TabIndex = 0;
            // 
            // EnvironmentSelector
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gp_container);
            Name = "EnvironmentSelector";
            Size = new Size(403, 647);
            gp_container.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gp_container;
        private ListBox lb_environments;
    }
}
