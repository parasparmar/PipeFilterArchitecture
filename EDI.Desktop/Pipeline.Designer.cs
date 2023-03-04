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
            toolStrip1 = new ToolStrip();
            lblProcessPipeline = new ToolStripLabel();
            ProcessPipelinebtn = new ToolStripButton();
            tbLogs = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblProcessPipeline, ProcessPipelinebtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // lblProcessPipeline
            // 
            lblProcessPipeline.Name = "lblProcessPipeline";
            lblProcessPipeline.Size = new Size(92, 22);
            lblProcessPipeline.Text = "Process Pipeline";
            // 
            // ProcessPipelinebtn
            // 
            ProcessPipelinebtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ProcessPipelinebtn.Image = (Image)resources.GetObject("ProcessPipelinebtn.Image");
            ProcessPipelinebtn.ImageTransparentColor = Color.Magenta;
            ProcessPipelinebtn.Name = "ProcessPipelinebtn";
            ProcessPipelinebtn.Size = new Size(23, 22);
            ProcessPipelinebtn.Text = "ProcessPipeline";
            ProcessPipelinebtn.Click += ProcessPipelinebtn_Click;
            // 
            // tbLogs
            // 
            tbLogs.Dock = DockStyle.Left;
            tbLogs.Location = new Point(0, 25);
            tbLogs.Multiline = true;
            tbLogs.Name = "tbLogs";
            tbLogs.ScrollBars = ScrollBars.Both;
            tbLogs.Size = new Size(330, 425);
            tbLogs.TabIndex = 1;
            // 
            // Pipeline
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbLogs);
            Controls.Add(toolStrip1);
            Name = "Pipeline";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel lblProcessPipeline;
        private ToolStripButton ProcessPipelinebtn;
        private TextBox tbLogs;
    }
}