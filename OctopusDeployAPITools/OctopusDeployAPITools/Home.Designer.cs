namespace OctopusDeployAPITools
{
    partial class Home
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
            this.gb_configuration = new System.Windows.Forms.GroupBox();
            this.btn_authenticate = new System.Windows.Forms.Button();
            this.tb_apikey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_octopusurl = new System.Windows.Forms.TextBox();
            this.gb_navigation = new System.Windows.Forms.GroupBox();
            this.btn_taskmanager = new System.Windows.Forms.Button();
            this.btn_releaseduplicator = new System.Windows.Forms.Button();
            this.btn_releasepromoter = new System.Windows.Forms.Button();
            this.btn_channelremover = new System.Windows.Forms.Button();
            this.btn_channelcreator = new System.Windows.Forms.Button();
            this.gb_configuration.SuspendLayout();
            this.gb_navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_configuration
            // 
            this.gb_configuration.Controls.Add(this.btn_authenticate);
            this.gb_configuration.Controls.Add(this.tb_apikey);
            this.gb_configuration.Controls.Add(this.label2);
            this.gb_configuration.Controls.Add(this.label1);
            this.gb_configuration.Controls.Add(this.tb_octopusurl);
            this.gb_configuration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_configuration.Location = new System.Drawing.Point(0, 0);
            this.gb_configuration.Name = "gb_configuration";
            this.gb_configuration.Size = new System.Drawing.Size(643, 215);
            this.gb_configuration.TabIndex = 0;
            this.gb_configuration.TabStop = false;
            this.gb_configuration.Text = "Configuration";
            // 
            // btn_authenticate
            // 
            this.btn_authenticate.Location = new System.Drawing.Point(12, 166);
            this.btn_authenticate.Name = "btn_authenticate";
            this.btn_authenticate.Size = new System.Drawing.Size(137, 34);
            this.btn_authenticate.TabIndex = 4;
            this.btn_authenticate.Text = "Authenticate";
            this.btn_authenticate.UseVisualStyleBackColor = true;
            this.btn_authenticate.Click += new System.EventHandler(this.btn_authenticate_Click);
            // 
            // tb_apikey
            // 
            this.tb_apikey.Location = new System.Drawing.Point(12, 129);
            this.tb_apikey.Name = "tb_apikey";
            this.tb_apikey.PasswordChar = '#';
            this.tb_apikey.Size = new System.Drawing.Size(571, 31);
            this.tb_apikey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "API Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Octopus URL";
            // 
            // tb_octopusurl
            // 
            this.tb_octopusurl.Location = new System.Drawing.Point(12, 55);
            this.tb_octopusurl.Name = "tb_octopusurl";
            this.tb_octopusurl.Size = new System.Drawing.Size(571, 31);
            this.tb_octopusurl.TabIndex = 0;
            // 
            // gb_navigation
            // 
            this.gb_navigation.Controls.Add(this.btn_taskmanager);
            this.gb_navigation.Controls.Add(this.btn_releaseduplicator);
            this.gb_navigation.Controls.Add(this.btn_releasepromoter);
            this.gb_navigation.Controls.Add(this.btn_channelremover);
            this.gb_navigation.Controls.Add(this.btn_channelcreator);
            this.gb_navigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_navigation.Location = new System.Drawing.Point(0, 215);
            this.gb_navigation.Name = "gb_navigation";
            this.gb_navigation.Size = new System.Drawing.Size(643, 129);
            this.gb_navigation.TabIndex = 1;
            this.gb_navigation.TabStop = false;
            this.gb_navigation.Text = "Navigation";
            // 
            // btn_taskmanager
            // 
            this.btn_taskmanager.Location = new System.Drawing.Point(428, 73);
            this.btn_taskmanager.Name = "btn_taskmanager";
            this.btn_taskmanager.Size = new System.Drawing.Size(200, 37);
            this.btn_taskmanager.TabIndex = 4;
            this.btn_taskmanager.Text = "Task Manager";
            this.btn_taskmanager.UseVisualStyleBackColor = true;
            this.btn_taskmanager.Click += new System.EventHandler(this.btn_taskmanager_Click);
            // 
            // btn_releaseduplicator
            // 
            this.btn_releaseduplicator.Location = new System.Drawing.Point(16, 73);
            this.btn_releaseduplicator.Name = "btn_releaseduplicator";
            this.btn_releaseduplicator.Size = new System.Drawing.Size(200, 37);
            this.btn_releaseduplicator.TabIndex = 3;
            this.btn_releaseduplicator.Text = "Release Duplicator";
            this.btn_releaseduplicator.UseVisualStyleBackColor = true;
            this.btn_releaseduplicator.Click += new System.EventHandler(this.btn_releaseduplicator_Click);
            // 
            // btn_releasepromoter
            // 
            this.btn_releasepromoter.Location = new System.Drawing.Point(428, 30);
            this.btn_releasepromoter.Name = "btn_releasepromoter";
            this.btn_releasepromoter.Size = new System.Drawing.Size(200, 37);
            this.btn_releasepromoter.TabIndex = 2;
            this.btn_releasepromoter.Text = "Release Promoter";
            this.btn_releasepromoter.UseVisualStyleBackColor = true;
            this.btn_releasepromoter.Click += new System.EventHandler(this.btn_releasepromoter_Click);
            // 
            // btn_channelremover
            // 
            this.btn_channelremover.Location = new System.Drawing.Point(222, 30);
            this.btn_channelremover.Name = "btn_channelremover";
            this.btn_channelremover.Size = new System.Drawing.Size(200, 37);
            this.btn_channelremover.TabIndex = 1;
            this.btn_channelremover.Text = "Channel Remover";
            this.btn_channelremover.UseVisualStyleBackColor = true;
            this.btn_channelremover.Click += new System.EventHandler(this.btn_channelremover_Click);
            // 
            // btn_channelcreator
            // 
            this.btn_channelcreator.Location = new System.Drawing.Point(16, 30);
            this.btn_channelcreator.Name = "btn_channelcreator";
            this.btn_channelcreator.Size = new System.Drawing.Size(200, 37);
            this.btn_channelcreator.TabIndex = 0;
            this.btn_channelcreator.Text = "Channel Creator";
            this.btn_channelcreator.UseVisualStyleBackColor = true;
            this.btn_channelcreator.Click += new System.EventHandler(this.btn_channelcreator_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 344);
            this.Controls.Add(this.gb_navigation);
            this.Controls.Add(this.gb_configuration);
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "Home";
            this.Text = "Octopus Toolbox";
            this.gb_configuration.ResumeLayout(false);
            this.gb_configuration.PerformLayout();
            this.gb_navigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb_configuration;
        private Button btn_authenticate;
        private TextBox tb_apikey;
        private Label label2;
        private Label label1;
        private TextBox tb_octopusurl;
        private GroupBox gb_navigation;
        private Button btn_channelcreator;
        private Button btn_channelremover;
        private Button btn_releasepromoter;
        private Button btn_releaseduplicator;
        private Button btn_taskmanager;
    }
}