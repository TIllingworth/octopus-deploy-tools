namespace OctopusDeployAPITools
{
    partial class ChannelCreator
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
            label1 = new Label();
            tb_channelname = new TextBox();
            groupBox1 = new GroupBox();
            ps_projects = new ProjectSelector();
            btn_createchannels = new Button();
            tb_versionrange = new TextBox();
            label3 = new Label();
            cb_defaultchannel = new CheckBox();
            tb_channeldescription = new TextBox();
            label2 = new Label();
            pow_output = new ProcessOutputWindow();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 0;
            label1.Text = "Channel Name";
            // 
            // tb_channelname
            // 
            tb_channelname.Location = new Point(6, 55);
            tb_channelname.Name = "tb_channelname";
            tb_channelname.Size = new Size(297, 31);
            tb_channelname.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ps_projects);
            groupBox1.Controls.Add(btn_createchannels);
            groupBox1.Controls.Add(tb_versionrange);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cb_defaultchannel);
            groupBox1.Controls.Add(tb_channeldescription);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_channelname);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 631);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // ps_projects
            // 
            ps_projects.Location = new Point(406, 27);
            ps_projects.Name = "ps_projects";
            ps_projects.Size = new Size(382, 542);
            ps_projects.TabIndex = 12;
            // 
            // btn_createchannels
            // 
            btn_createchannels.Location = new Point(603, 575);
            btn_createchannels.Name = "btn_createchannels";
            btn_createchannels.Size = new Size(185, 34);
            btn_createchannels.TabIndex = 11;
            btn_createchannels.Text = "Create Channels";
            btn_createchannels.UseVisualStyleBackColor = true;
            btn_createchannels.Click += btn_createchannels_Click;
            // 
            // tb_versionrange
            // 
            tb_versionrange.Location = new Point(6, 323);
            tb_versionrange.Name = "tb_versionrange";
            tb_versionrange.Size = new Size(297, 31);
            tb_versionrange.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 295);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 6;
            label3.Text = "Version Range";
            // 
            // cb_defaultchannel
            // 
            cb_defaultchannel.AutoSize = true;
            cb_defaultchannel.Location = new Point(6, 250);
            cb_defaultchannel.Name = "cb_defaultchannel";
            cb_defaultchannel.Size = new Size(210, 29);
            cb_defaultchannel.TabIndex = 5;
            cb_defaultchannel.Text = "Set as default channel";
            cb_defaultchannel.UseVisualStyleBackColor = true;
            // 
            // tb_channeldescription
            // 
            tb_channeldescription.Location = new Point(6, 129);
            tb_channeldescription.Multiline = true;
            tb_channeldescription.Name = "tb_channeldescription";
            tb_channeldescription.Size = new Size(297, 101);
            tb_channeldescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 101);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 2;
            label2.Text = "Channel Description";
            // 
            // pow_output
            // 
            pow_output.Dock = DockStyle.Fill;
            pow_output.Location = new Point(0, 631);
            pow_output.Name = "pow_output";
            pow_output.Size = new Size(800, 362);
            pow_output.TabIndex = 3;
            // 
            // ChannelCreator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 993);
            Controls.Add(pow_output);
            Controls.Add(groupBox1);
            Name = "ChannelCreator";
            Text = "ChannelCreator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tb_channelname;
        private GroupBox groupBox1;
        private TextBox tb_versionrange;
        private Label label3;
        private CheckBox cb_defaultchannel;
        private TextBox tb_channeldescription;
        private Label label2;
        private Button btn_createchannels;
        private ProjectSelector ps_projects;
        private ProcessOutputWindow pow_output;
    }
}