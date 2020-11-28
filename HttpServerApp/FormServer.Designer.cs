
namespace HttpServerApp
{
    partial class FormServer
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
            this.textBoxLogger = new System.Windows.Forms.TextBox();
            this.buttonStartListener = new System.Windows.Forms.Button();
            this.buttonStopListener = new System.Windows.Forms.Button();
            this.progressBarListener = new System.Windows.Forms.ProgressBar();
            this.listBoxAvailablePaths = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogger
            // 
            this.textBoxLogger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogger.Location = new System.Drawing.Point(12, 150);
            this.textBoxLogger.Multiline = true;
            this.textBoxLogger.Name = "textBoxLogger";
            this.textBoxLogger.ReadOnly = true;
            this.textBoxLogger.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLogger.Size = new System.Drawing.Size(776, 260);
            this.textBoxLogger.TabIndex = 0;
            this.textBoxLogger.TabStop = false;
            // 
            // buttonStartListener
            // 
            this.buttonStartListener.Location = new System.Drawing.Point(12, 20);
            this.buttonStartListener.Name = "buttonStartListener";
            this.buttonStartListener.Size = new System.Drawing.Size(94, 29);
            this.buttonStartListener.TabIndex = 1;
            this.buttonStartListener.Text = "Start";
            this.buttonStartListener.UseVisualStyleBackColor = true;
            this.buttonStartListener.Click += new System.EventHandler(this.buttonStartListener_Click);
            // 
            // buttonStopListener
            // 
            this.buttonStopListener.Location = new System.Drawing.Point(112, 20);
            this.buttonStopListener.Name = "buttonStopListener";
            this.buttonStopListener.Size = new System.Drawing.Size(94, 29);
            this.buttonStopListener.TabIndex = 2;
            this.buttonStopListener.Text = "Stop";
            this.buttonStopListener.UseVisualStyleBackColor = true;
            this.buttonStopListener.Click += new System.EventHandler(this.buttonStopListener_Click);
            // 
            // progressBarListener
            // 
            this.progressBarListener.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarListener.Location = new System.Drawing.Point(12, 416);
            this.progressBarListener.Name = "progressBarListener";
            this.progressBarListener.Size = new System.Drawing.Size(776, 29);
            this.progressBarListener.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarListener.TabIndex = 3;
            this.progressBarListener.Visible = false;
            // 
            // listBoxAvailablePaths
            // 
            this.listBoxAvailablePaths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAvailablePaths.FormattingEnabled = true;
            this.listBoxAvailablePaths.ItemHeight = 20;
            this.listBoxAvailablePaths.Location = new System.Drawing.Point(427, 20);
            this.listBoxAvailablePaths.Name = "listBoxAvailablePaths";
            this.listBoxAvailablePaths.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxAvailablePaths.Size = new System.Drawing.Size(361, 124);
            this.listBoxAvailablePaths.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Available paths";
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAvailablePaths);
            this.Controls.Add(this.progressBarListener);
            this.Controls.Add(this.buttonStopListener);
            this.Controls.Add(this.buttonStartListener);
            this.Controls.Add(this.textBoxLogger);
            this.Name = "FormServer";
            this.Text = "HTTP-Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogger;
        private System.Windows.Forms.Button buttonStartListener;
        private System.Windows.Forms.Button buttonStopListener;
        private System.Windows.Forms.ProgressBar progressBarListener;
        private System.Windows.Forms.ListBox listBoxAvailablePaths;
        private System.Windows.Forms.Label label1;
    }
}

