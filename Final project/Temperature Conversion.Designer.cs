namespace Final_project
{
    partial class Temperature_Conversion
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
            this.CToF_btn = new System.Windows.Forms.RadioButton();
            this.FToC_btn = new System.Windows.Forms.RadioButton();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessagebox = new System.Windows.Forms.TextBox();
            this.Convrt_btn = new System.Windows.Forms.Button();
            this.readfile_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CToF_btn
            // 
            this.CToF_btn.AutoSize = true;
            this.CToF_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CToF_btn.Location = new System.Drawing.Point(124, 21);
            this.CToF_btn.Name = "CToF_btn";
            this.CToF_btn.Size = new System.Drawing.Size(115, 24);
            this.CToF_btn.TabIndex = 0;
            this.CToF_btn.TabStop = true;
            this.CToF_btn.Text = "From C To F";
            this.CToF_btn.UseVisualStyleBackColor = true;
            this.CToF_btn.CheckedChanged += new System.EventHandler(this.CToF_btn_CheckedChanged);
            // 
            // FToC_btn
            // 
            this.FToC_btn.AutoSize = true;
            this.FToC_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FToC_btn.Location = new System.Drawing.Point(124, 44);
            this.FToC_btn.Name = "FToC_btn";
            this.FToC_btn.Size = new System.Drawing.Size(115, 24);
            this.FToC_btn.TabIndex = 1;
            this.FToC_btn.TabStop = true;
            this.FToC_btn.Text = "From F To C";
            this.FToC_btn.UseVisualStyleBackColor = true;
            this.FToC_btn.CheckedChanged += new System.EventHandler(this.FToC_btn_CheckedChanged);
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(42, 89);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(100, 20);
            this.txt_from.TabIndex = 2;
            // 
            // txt_To
            // 
            this.txt_To.Location = new System.Drawing.Point(221, 89);
            this.txt_To.Name = "txt_To";
            this.txt_To.ReadOnly = true;
            this.txt_To.Size = new System.Drawing.Size(100, 20);
            this.txt_To.TabIndex = 3;
            this.txt_To.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message:";
            // 
            // txtMessagebox
            // 
            this.txtMessagebox.Location = new System.Drawing.Point(42, 157);
            this.txtMessagebox.Multiline = true;
            this.txtMessagebox.Name = "txtMessagebox";
            this.txtMessagebox.ReadOnly = true;
            this.txtMessagebox.Size = new System.Drawing.Size(298, 100);
            this.txtMessagebox.TabIndex = 6;
            // 
            // Convrt_btn
            // 
            this.Convrt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convrt_btn.Location = new System.Drawing.Point(41, 279);
            this.Convrt_btn.Name = "Convrt_btn";
            this.Convrt_btn.Size = new System.Drawing.Size(83, 28);
            this.Convrt_btn.TabIndex = 7;
            this.Convrt_btn.Text = "&Convert";
            this.Convrt_btn.UseVisualStyleBackColor = true;
            this.Convrt_btn.Click += new System.EventHandler(this.Convrt_btn_Click);
            // 
            // readfile_btn
            // 
            this.readfile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readfile_btn.Location = new System.Drawing.Point(142, 279);
            this.readfile_btn.Name = "readfile_btn";
            this.readfile_btn.Size = new System.Drawing.Size(83, 28);
            this.readfile_btn.TabIndex = 8;
            this.readfile_btn.Text = "&Read File";
            this.readfile_btn.UseVisualStyleBackColor = true;
            this.readfile_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(238, 279);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(83, 28);
            this.Exit_btn.TabIndex = 9;
            this.Exit_btn.Text = "E&XIT";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "C or F";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "F or C";
            // 
            // Temperature_Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.readfile_btn);
            this.Controls.Add(this.Convrt_btn);
            this.Controls.Add(this.txtMessagebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.FToC_btn);
            this.Controls.Add(this.CToF_btn);
            this.Name = "Temperature_Conversion";
            this.Text = "Temperature_Conversion";
            this.Load += new System.EventHandler(this.Temperature_Conversion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CToF_btn;
        private System.Windows.Forms.RadioButton FToC_btn;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessagebox;
        private System.Windows.Forms.Button Convrt_btn;
        private System.Windows.Forms.Button readfile_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}