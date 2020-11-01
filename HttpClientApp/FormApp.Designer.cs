namespace HttpClientApp
{
    partial class FormApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonSubmitUrl = new System.Windows.Forms.Button();
            this.tabControlReqResp = new System.Windows.Forms.TabControl();
            this.tabPageRequest = new System.Windows.Forms.TabPage();
            this.textBoxModifiedRequest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDefaultRequest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageResponse = new System.Windows.Forms.TabPage();
            this.buttonVisualise = new System.Windows.Forms.Button();
            this.textBoxResponseBody = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxResponseHeaders = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxResponseErrors = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlReqResp.SuspendLayout();
            this.tabPageRequest.SuspendLayout();
            this.tabPageResponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.Location = new System.Drawing.Point(70, 10);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(734, 27);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonSubmitUrl
            // 
            this.buttonSubmitUrl.Location = new System.Drawing.Point(815, 9);
            this.buttonSubmitUrl.Name = "buttonSubmitUrl";
            this.buttonSubmitUrl.Size = new System.Drawing.Size(57, 29);
            this.buttonSubmitUrl.TabIndex = 2;
            this.buttonSubmitUrl.Text = "OK";
            this.buttonSubmitUrl.UseVisualStyleBackColor = true;
            this.buttonSubmitUrl.Click += new System.EventHandler(this.buttonSubmitUrl_Click);
            // 
            // tabControlReqResp
            // 
            this.tabControlReqResp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlReqResp.Controls.Add(this.tabPageRequest);
            this.tabControlReqResp.Controls.Add(this.tabPageResponse);
            this.tabControlReqResp.Location = new System.Drawing.Point(12, 44);
            this.tabControlReqResp.Name = "tabControlReqResp";
            this.tabControlReqResp.SelectedIndex = 0;
            this.tabControlReqResp.Size = new System.Drawing.Size(864, 607);
            this.tabControlReqResp.TabIndex = 3;
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.Controls.Add(this.textBoxModifiedRequest);
            this.tabPageRequest.Controls.Add(this.label3);
            this.tabPageRequest.Controls.Add(this.textBoxDefaultRequest);
            this.tabPageRequest.Controls.Add(this.label2);
            this.tabPageRequest.Location = new System.Drawing.Point(4, 29);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequest.Size = new System.Drawing.Size(856, 574);
            this.tabPageRequest.TabIndex = 0;
            this.tabPageRequest.Text = "Запрос";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // textBoxModifiedRequest
            // 
            this.textBoxModifiedRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModifiedRequest.Location = new System.Drawing.Point(15, 298);
            this.textBoxModifiedRequest.Multiline = true;
            this.textBoxModifiedRequest.Name = "textBoxModifiedRequest";
            this.textBoxModifiedRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxModifiedRequest.Size = new System.Drawing.Size(823, 254);
            this.textBoxModifiedRequest.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Запрос с изменениями";
            // 
            // textBoxDefaultRequest
            // 
            this.textBoxDefaultRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultRequest.Location = new System.Drawing.Point(15, 39);
            this.textBoxDefaultRequest.Multiline = true;
            this.textBoxDefaultRequest.Name = "textBoxDefaultRequest";
            this.textBoxDefaultRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDefaultRequest.Size = new System.Drawing.Size(823, 218);
            this.textBoxDefaultRequest.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Запрос по умолчанию";
            // 
            // tabPageResponse
            // 
            this.tabPageResponse.Controls.Add(this.buttonVisualise);
            this.tabPageResponse.Controls.Add(this.textBoxResponseBody);
            this.tabPageResponse.Controls.Add(this.label6);
            this.tabPageResponse.Controls.Add(this.textBoxResponseHeaders);
            this.tabPageResponse.Controls.Add(this.label5);
            this.tabPageResponse.Controls.Add(this.textBoxResponseErrors);
            this.tabPageResponse.Controls.Add(this.label4);
            this.tabPageResponse.Location = new System.Drawing.Point(4, 29);
            this.tabPageResponse.Name = "tabPageResponse";
            this.tabPageResponse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResponse.Size = new System.Drawing.Size(856, 574);
            this.tabPageResponse.TabIndex = 1;
            this.tabPageResponse.Text = "Ответ";
            this.tabPageResponse.UseVisualStyleBackColor = true;
            // 
            // buttonVisualise
            // 
            this.buttonVisualise.Location = new System.Drawing.Point(692, 522);
            this.buttonVisualise.Name = "buttonVisualise";
            this.buttonVisualise.Size = new System.Drawing.Size(146, 38);
            this.buttonVisualise.TabIndex = 6;
            this.buttonVisualise.Text = "Визуализировать";
            this.buttonVisualise.UseVisualStyleBackColor = true;
            // 
            // textBoxResponseBody
            // 
            this.textBoxResponseBody.Location = new System.Drawing.Point(13, 330);
            this.textBoxResponseBody.Multiline = true;
            this.textBoxResponseBody.Name = "textBoxResponseBody";
            this.textBoxResponseBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponseBody.Size = new System.Drawing.Size(825, 186);
            this.textBoxResponseBody.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Тело ответа";
            // 
            // textBoxResponseHeaders
            // 
            this.textBoxResponseHeaders.Location = new System.Drawing.Point(13, 120);
            this.textBoxResponseHeaders.Multiline = true;
            this.textBoxResponseHeaders.Name = "textBoxResponseHeaders";
            this.textBoxResponseHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponseHeaders.Size = new System.Drawing.Size(825, 171);
            this.textBoxResponseHeaders.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Поля заголовка";
            // 
            // textBoxResponseErrors
            // 
            this.textBoxResponseErrors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResponseErrors.Location = new System.Drawing.Point(85, 10);
            this.textBoxResponseErrors.Multiline = true;
            this.textBoxResponseErrors.Name = "textBoxResponseErrors";
            this.textBoxResponseErrors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResponseErrors.Size = new System.Drawing.Size(753, 70);
            this.textBoxResponseErrors.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ошибка";
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 663);
            this.Controls.Add(this.tabControlReqResp);
            this.Controls.Add(this.buttonSubmitUrl);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label1);
            this.Name = "FormApp";
            this.Text = "HTTP-client";
            this.tabControlReqResp.ResumeLayout(false);
            this.tabPageRequest.ResumeLayout(false);
            this.tabPageRequest.PerformLayout();
            this.tabPageResponse.ResumeLayout(false);
            this.tabPageResponse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonSubmitUrl;
        private System.Windows.Forms.TabControl tabControlReqResp;
        private System.Windows.Forms.TabPage tabPageRequest;
        private System.Windows.Forms.TabPage tabPageResponse;
        private System.Windows.Forms.TextBox textBoxModifiedRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDefaultRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResponseErrors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxResponseHeaders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxResponseBody;
        private System.Windows.Forms.Button buttonVisualise;
    }
}

