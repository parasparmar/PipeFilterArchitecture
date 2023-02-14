namespace EDI.Desktop
{
    partial class Pipeline
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pipeline));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblProcessPipeline = new System.Windows.Forms.ToolStripLabel();
            this.ProcessPipelinebtn = new System.Windows.Forms.ToolStripButton();
            this.tbLogs = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblProcessPipeline,
            this.ProcessPipelinebtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblProcessPipeline
            // 
            this.lblProcessPipeline.Name = "lblProcessPipeline";
            this.lblProcessPipeline.Size = new System.Drawing.Size(92, 22);
            this.lblProcessPipeline.Text = "Process Pipeline";
            // 
            // ProcessPipelinebtn
            // 
            this.ProcessPipelinebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ProcessPipelinebtn.Image = ((System.Drawing.Image)(resources.GetObject("ProcessPipelinebtn.Image")));
            this.ProcessPipelinebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProcessPipelinebtn.Name = "ProcessPipelinebtn";
            this.ProcessPipelinebtn.Size = new System.Drawing.Size(23, 22);
            this.ProcessPipelinebtn.Text = "ProcessPipeline";
            this.ProcessPipelinebtn.Click += new System.EventHandler(this.ProcessPipelinebtn_Click);
            // 
            // tbLogs
            // 
            this.tbLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogs.Location = new System.Drawing.Point(0, 25);
            this.tbLogs.Multiline = true;
            this.tbLogs.Name = "tbLogs";
            this.tbLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLogs.Size = new System.Drawing.Size(800, 425);
            this.tbLogs.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbLogs);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel lblProcessPipeline;
        private ToolStripButton ProcessPipelinebtn;
        private TextBox tbLogs;
    }
}