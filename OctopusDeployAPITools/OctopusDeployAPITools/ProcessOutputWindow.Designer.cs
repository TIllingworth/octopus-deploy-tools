namespace OctopusDeployAPITools
{
    partial class ProcessOutputWindow
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
            tb_outputwindow = new TextBox();
            SuspendLayout();
            // 
            // tb_outputwindow
            // 
            tb_outputwindow.Dock = DockStyle.Fill;
            tb_outputwindow.Location = new Point(0, 0);
            tb_outputwindow.Multiline = true;
            tb_outputwindow.Name = "tb_outputwindow";
            tb_outputwindow.ReadOnly = true;
            tb_outputwindow.Size = new Size(972, 461);
            tb_outputwindow.TabIndex = 0;
            // 
            // ProcessOutputWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tb_outputwindow);
            Name = "ProcessOutputWindow";
            Size = new Size(972, 461);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_outputwindow;
    }
}
