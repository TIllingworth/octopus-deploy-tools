namespace OctopusDeployAPITools
{
    partial class ProjectSelector
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
            cb_customchannelprojectssonly = new CheckBox();
            lb_projectselection = new ListBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cb_customchannelprojectssonly
            // 
            cb_customchannelprojectssonly.AutoSize = true;
            cb_customchannelprojectssonly.Dock = DockStyle.Bottom;
            cb_customchannelprojectssonly.Location = new Point(0, 532);
            cb_customchannelprojectssonly.Name = "cb_customchannelprojectssonly";
            cb_customchannelprojectssonly.Size = new Size(403, 29);
            cb_customchannelprojectssonly.TabIndex = 13;
            cb_customchannelprojectssonly.Text = "Show only projects with custom channels";
            cb_customchannelprojectssonly.UseVisualStyleBackColor = true;
            cb_customchannelprojectssonly.CheckedChanged += cb_customchannelprojectssonly_CheckedChanged;
            // 
            // lb_projectselection
            // 
            lb_projectselection.Dock = DockStyle.Fill;
            lb_projectselection.FormattingEnabled = true;
            lb_projectselection.ItemHeight = 25;
            lb_projectselection.Location = new Point(3, 27);
            lb_projectselection.Name = "lb_projectselection";
            lb_projectselection.SelectionMode = SelectionMode.MultiSimple;
            lb_projectselection.Size = new Size(397, 502);
            lb_projectselection.Sorted = true;
            lb_projectselection.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_projectselection);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 532);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Projects";
            // 
            // ProjectSelector
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(cb_customchannelprojectssonly);
            Name = "ProjectSelector";
            Size = new Size(403, 561);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cb_customchannelprojectssonly;
        private ListBox lb_projectselection;
        private GroupBox groupBox1;
    }
}
