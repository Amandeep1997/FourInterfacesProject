namespace Final_project
{
    partial class currency_exchange
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
            this.convrt_btn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GBP_TO = new System.Windows.Forms.RadioButton();
            this.EUR_TO = new System.Windows.Forms.RadioButton();
            this.USD_TO = new System.Windows.Forms.RadioButton();
            this.CAN_TO = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GBP_FROM = new System.Windows.Forms.RadioButton();
            this.EUR_FROM = new System.Windows.Forms.RadioButton();
            this.USD_FROM = new System.Windows.Forms.RadioButton();
            this.CAN_FROM = new System.Windows.Forms.RadioButton();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Readfile_btn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // convrt_btn
            // 
            this.convrt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convrt_btn.Location = new System.Drawing.Point(6, 252);
            this.convrt_btn.Name = "convrt_btn";
            this.convrt_btn.Size = new System.Drawing.Size(105, 46);
            this.convrt_btn.TabIndex = 9;
            this.convrt_btn.Text = "&Convert";
            this.convrt_btn.UseVisualStyleBackColor = true;
            this.convrt_btn.Click += new System.EventHandler(this.convrt_btn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GBP_TO);
            this.groupBox2.Controls.Add(this.EUR_TO);
            this.groupBox2.Controls.Add(this.USD_TO);
            this.groupBox2.Controls.Add(this.CAN_TO);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(200, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 154);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // GBP_TO
            // 
            this.GBP_TO.AutoSize = true;
            this.GBP_TO.Location = new System.Drawing.Point(6, 116);
            this.GBP_TO.Name = "GBP_TO";
            this.GBP_TO.Size = new System.Drawing.Size(61, 22);
            this.GBP_TO.TabIndex = 4;
            this.GBP_TO.TabStop = true;
            this.GBP_TO.Text = "GBP";
            this.GBP_TO.UseVisualStyleBackColor = true;
            // 
            // EUR_TO
            // 
            this.EUR_TO.AutoSize = true;
            this.EUR_TO.Location = new System.Drawing.Point(6, 88);
            this.EUR_TO.Name = "EUR_TO";
            this.EUR_TO.Size = new System.Drawing.Size(61, 22);
            this.EUR_TO.TabIndex = 3;
            this.EUR_TO.TabStop = true;
            this.EUR_TO.Text = "EUR";
            this.EUR_TO.UseVisualStyleBackColor = true;
            // 
            // USD_TO
            // 
            this.USD_TO.AutoSize = true;
            this.USD_TO.Location = new System.Drawing.Point(6, 60);
            this.USD_TO.Name = "USD_TO";
            this.USD_TO.Size = new System.Drawing.Size(61, 22);
            this.USD_TO.TabIndex = 2;
            this.USD_TO.TabStop = true;
            this.USD_TO.Text = "USD";
            this.USD_TO.UseVisualStyleBackColor = true;
            // 
            // CAN_TO
            // 
            this.CAN_TO.AutoSize = true;
            this.CAN_TO.Location = new System.Drawing.Point(6, 32);
            this.CAN_TO.Name = "CAN_TO";
            this.CAN_TO.Size = new System.Drawing.Size(60, 22);
            this.CAN_TO.TabIndex = 1;
            this.CAN_TO.TabStop = true;
            this.CAN_TO.Text = "CAN";
            this.CAN_TO.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GBP_FROM);
            this.groupBox1.Controls.Add(this.EUR_FROM);
            this.groupBox1.Controls.Add(this.USD_FROM);
            this.groupBox1.Controls.Add(this.CAN_FROM);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 154);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // GBP_FROM
            // 
            this.GBP_FROM.AutoSize = true;
            this.GBP_FROM.Location = new System.Drawing.Point(6, 116);
            this.GBP_FROM.Name = "GBP_FROM";
            this.GBP_FROM.Size = new System.Drawing.Size(61, 22);
            this.GBP_FROM.TabIndex = 3;
            this.GBP_FROM.TabStop = true;
            this.GBP_FROM.Text = "GBP";
            this.GBP_FROM.UseVisualStyleBackColor = true;
//            this.GBP_FROM.CheckedChanged += new System.EventHandler(this.GBP_FROM_CheckedChanged);
            // 
            // EUR_FROM
            // 
            this.EUR_FROM.AutoSize = true;
            this.EUR_FROM.Location = new System.Drawing.Point(6, 88);
            this.EUR_FROM.Name = "EUR_FROM";
            this.EUR_FROM.Size = new System.Drawing.Size(61, 22);
            this.EUR_FROM.TabIndex = 2;
            this.EUR_FROM.TabStop = true;
            this.EUR_FROM.Text = "EUR";
            this.EUR_FROM.UseVisualStyleBackColor = true;
            // 
            // USD_FROM
            // 
            this.USD_FROM.AutoSize = true;
            this.USD_FROM.Location = new System.Drawing.Point(6, 60);
            this.USD_FROM.Name = "USD_FROM";
            this.USD_FROM.Size = new System.Drawing.Size(61, 22);
            this.USD_FROM.TabIndex = 1;
            this.USD_FROM.TabStop = true;
            this.USD_FROM.Text = "USD";
            this.USD_FROM.UseVisualStyleBackColor = true;
            // 
            // CAN_FROM
            // 
            this.CAN_FROM.AutoSize = true;
            this.CAN_FROM.Location = new System.Drawing.Point(6, 32);
            this.CAN_FROM.Name = "CAN_FROM";
            this.CAN_FROM.Size = new System.Drawing.Size(60, 22);
            this.CAN_FROM.TabIndex = 0;
            this.CAN_FROM.TabStop = true;
            this.CAN_FROM.Text = "CAN";
            this.CAN_FROM.UseVisualStyleBackColor = true;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(281, 252);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(81, 46);
            this.Exit_btn.TabIndex = 10;
            this.Exit_btn.Text = "E&XIT";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Readfile_btn
            // 
            this.Readfile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Readfile_btn.Location = new System.Drawing.Point(131, 252);
            this.Readfile_btn.Name = "Readfile_btn";
            this.Readfile_btn.Size = new System.Drawing.Size(129, 46);
            this.Readfile_btn.TabIndex = 11;
            this.Readfile_btn.Text = "&Readfile";
            this.Readfile_btn.UseVisualStyleBackColor = true;
            this.Readfile_btn.Click += new System.EventHandler(this.Readfile_btn_Click);
            // 
            // currency_exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 310);
            this.Controls.Add(this.Readfile_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.convrt_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "currency_exchange";
            this.Text = "currency_exchange";
            this.Load += new System.EventHandler(this.currency_exchange_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convrt_btn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton GBP_TO;
        private System.Windows.Forms.RadioButton EUR_TO;
        private System.Windows.Forms.RadioButton USD_TO;
        private System.Windows.Forms.RadioButton CAN_TO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton GBP_FROM;
        private System.Windows.Forms.RadioButton EUR_FROM;
        private System.Windows.Forms.RadioButton USD_FROM;
        private System.Windows.Forms.RadioButton CAN_FROM;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Readfile_btn;
    }
}