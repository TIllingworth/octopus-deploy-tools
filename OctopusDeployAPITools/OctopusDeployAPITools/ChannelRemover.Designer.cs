namespace OctopusDeployAPITools
{
    partial class ChannelRemover
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
            groupBox1 = new GroupBox();
            btn_removechannels = new Button();
            tb_channelname = new TextBox();
            label1 = new Label();
            ps_projects = new ProjectSelector();
            pow_output = new ProcessOutputWindow();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_removechannels);
            groupBox1.Controls.Add(tb_channelname);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ps_projects);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(888, 679);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btn_removechannels
            // 
            btn_removechannels.Location = new Point(675, 625);
            btn_removechannels.Name = "btn_removechannels";
            btn_removechannels.Size = new Size(192, 34);
            btn_removechannels.TabIndex = 3;
            btn_removechannels.Text = "Remove Channels";
            btn_removechannels.UseVisualStyleBackColor = true;
            btn_removechannels.Click += btn_removechannels_Click;
            // 
            // tb_channelname
            // 
            tb_channelname.Location = new Point(12, 55);
            tb_channelname.Name = "tb_channelname";
            tb_channelname.Size = new Size(277, 31);
            tb_channelname.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 1;
            label1.Text = "Channel Name";
            // 
            // ps_projects
            // 
            ps_projects.Location = new Point(457, 12);
            ps_projects.Name = "ps_projects";
            ps_projects.Size = new Size(410, 607);
            ps_projects.TabIndex = 0;
            // 
            // pow_output
            // 
            pow_output.Dock = DockStyle.Fill;
            pow_output.Location = new Point(0, 679);
            pow_output.Name = "pow_output";
            pow_output.Size = new Size(888, 376);
            pow_output.TabIndex = 1;
            // 
            // ChannelRemover
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 1055);
            Controls.Add(pow_output);
            Controls.Add(groupBox1);
            Name = "ChannelRemover";
            Text = "ChannelRemover";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_removechannels;
        private TextBox tb_channelname;
        private Label label1;
        private ProjectSelector ps_projects;
        private ProcessOutputWindow pow_output;
    }
}