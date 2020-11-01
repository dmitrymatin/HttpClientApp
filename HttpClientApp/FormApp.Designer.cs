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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlReqResp = new System.Windows.Forms.TabControl();
            this.tabPageRequest = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageResponse = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(815, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
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
            this.tabPageRequest.Controls.Add(this.textBox2);
            this.tabPageRequest.Controls.Add(this.label3);
            this.tabPageRequest.Controls.Add(this.textBox1);
            this.tabPageRequest.Controls.Add(this.label2);
            this.tabPageRequest.Location = new System.Drawing.Point(4, 29);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequest.Size = new System.Drawing.Size(856, 574);
            this.tabPageRequest.TabIndex = 0;
            this.tabPageRequest.Text = "Запрос";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(15, 298);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(823, 254);
            this.textBox2.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(15, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(823, 218);
            this.textBox1.TabIndex = 1;
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
            this.tabPageResponse.Controls.Add(this.button2);
            this.tabPageResponse.Controls.Add(this.textBox5);
            this.tabPageResponse.Controls.Add(this.label6);
            this.tabPageResponse.Controls.Add(this.textBox4);
            this.tabPageResponse.Controls.Add(this.label5);
            this.tabPageResponse.Controls.Add(this.textBox3);
            this.tabPageResponse.Controls.Add(this.label4);
            this.tabPageResponse.Location = new System.Drawing.Point(4, 29);
            this.tabPageResponse.Name = "tabPageResponse";
            this.tabPageResponse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResponse.Size = new System.Drawing.Size(856, 574);
            this.tabPageResponse.TabIndex = 1;
            this.tabPageResponse.Text = "Ответ";
            this.tabPageResponse.UseVisualStyleBackColor = true;
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
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(85, 10);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(753, 70);
            this.textBox3.TabIndex = 1;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 120);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(825, 171);
            this.textBox4.TabIndex = 3;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 330);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(825, 186);
            this.textBox5.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(692, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Визуализировать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 663);
            this.Controls.Add(this.tabControlReqResp);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControlReqResp;
        private System.Windows.Forms.TabPage tabPageRequest;
        private System.Windows.Forms.TabPage tabPageResponse;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
    }
}

