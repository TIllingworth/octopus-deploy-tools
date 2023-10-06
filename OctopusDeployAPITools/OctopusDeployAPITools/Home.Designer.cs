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
            gb_configuration = new GroupBox();
            btn_authenticate = new Button();
            tb_apikey = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tb_octopusurl = new TextBox();
            gb_navigation = new GroupBox();
            btn_releaseduplicator = new Button();
            btn_releasepromoter = new Button();
            btn_channelremover = new Button();
            btn_channelcreator = new Button();
            gb_configuration.SuspendLayout();
            gb_navigation.SuspendLayout();
            SuspendLayout();
            // 
            // gb_configuration
            // 
            gb_configuration.Controls.Add(btn_authenticate);
            gb_configuration.Controls.Add(tb_apikey);
            gb_configuration.Controls.Add(label2);
            gb_configuration.Controls.Add(label1);
            gb_configuration.Controls.Add(tb_octopusurl);
            gb_configuration.Dock = DockStyle.Top;
            gb_configuration.Location = new Point(0, 0);
            gb_configuration.Name = "gb_configuration";
            gb_configuration.Size = new Size(643, 215);
            gb_configuration.TabIndex = 0;
            gb_configuration.TabStop = false;
            gb_configuration.Text = "Configuration";
            // 
            // btn_authenticate
            // 
            btn_authenticate.Location = new Point(12, 166);
            btn_authenticate.Name = "btn_authenticate";
            btn_authenticate.Size = new Size(137, 34);
            btn_authenticate.TabIndex = 4;
            btn_authenticate.Text = "Authenticate";
            btn_authenticate.UseVisualStyleBackColor = true;
            btn_authenticate.Click += btn_authenticate_Click;
            // 
            // tb_apikey
            // 
            tb_apikey.Location = new Point(12, 129);
            tb_apikey.Name = "tb_apikey";
            tb_apikey.PasswordChar = '#';
            tb_apikey.Size = new Size(571, 31);
            tb_apikey.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 2;
            label2.Text = "API Key";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 1;
            label1.Text = "Octopus URL";
            // 
            // tb_octopusurl
            // 
            tb_octopusurl.Location = new Point(12, 55);
            tb_octopusurl.Name = "tb_octopusurl";
            tb_octopusurl.Size = new Size(571, 31);
            tb_octopusurl.TabIndex = 0;
            // 
            // gb_navigation
            // 
            gb_navigation.Controls.Add(btn_releaseduplicator);
            gb_navigation.Controls.Add(btn_releasepromoter);
            gb_navigation.Controls.Add(btn_channelremover);
            gb_navigation.Controls.Add(btn_channelcreator);
            gb_navigation.Dock = DockStyle.Fill;
            gb_navigation.Location = new Point(0, 215);
            gb_navigation.Name = "gb_navigation";
            gb_navigation.Size = new Size(643, 129);
            gb_navigation.TabIndex = 1;
            gb_navigation.TabStop = false;
            gb_navigation.Text = "Navigation";
            // 
            // btn_releaseduplicator
            // 
            btn_releaseduplicator.Location = new Point(16, 73);
            btn_releaseduplicator.Name = "btn_releaseduplicator";
            btn_releaseduplicator.Size = new Size(200, 37);
            btn_releaseduplicator.TabIndex = 3;
            btn_releaseduplicator.Text = "Release Duplicator";
            btn_releaseduplicator.UseVisualStyleBackColor = true;
            btn_releaseduplicator.Click += btn_releaseduplicator_Click;
            // 
            // btn_releasepromoter
            // 
            btn_releasepromoter.Location = new Point(428, 30);
            btn_releasepromoter.Name = "btn_releasepromoter";
            btn_releasepromoter.Size = new Size(200, 37);
            btn_releasepromoter.TabIndex = 2;
            btn_releasepromoter.Text = "Release Promoter";
            btn_releasepromoter.UseVisualStyleBackColor = true;
            btn_releasepromoter.Click += btn_releasepromoter_Click;
            // 
            // btn_channelremover
            // 
            btn_channelremover.Location = new Point(222, 30);
            btn_channelremover.Name = "btn_channelremover";
            btn_channelremover.Size = new Size(200, 37);
            btn_channelremover.TabIndex = 1;
            btn_channelremover.Text = "Channel Remover";
            btn_channelremover.UseVisualStyleBackColor = true;
            btn_channelremover.Click += btn_channelremover_Click;
            // 
            // btn_channelcreator
            // 
            btn_channelcreator.Location = new Point(16, 30);
            btn_channelcreator.Name = "btn_channelcreator";
            btn_channelcreator.Size = new Size(200, 37);
            btn_channelcreator.TabIndex = 0;
            btn_channelcreator.Text = "Channel Creator";
            btn_channelcreator.UseVisualStyleBackColor = true;
            btn_channelcreator.Click += btn_channelcreator_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 344);
            Controls.Add(gb_navigation);
            Controls.Add(gb_configuration);
            MinimumSize = new Size(640, 400);
            Name = "Home";
            Text = "Octopus Toolbox";
            Load += Home_Load;
            gb_configuration.ResumeLayout(false);
            gb_configuration.PerformLayout();
            gb_navigation.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}