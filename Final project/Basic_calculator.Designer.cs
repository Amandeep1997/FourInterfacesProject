namespace Final_project
{
    partial class Basic_calculator
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.Readfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(146, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 32);
            this.btnExit.TabIndex = 54;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(28, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 32);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(188, 38);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(32, 152);
            this.btnEquals.TabIndex = 52;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(142, 152);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(32, 32);
            this.btnDiv.TabIndex = 51;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(142, 114);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(32, 32);
            this.btnMul.TabIndex = 50;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(142, 76);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(32, 32);
            this.btnSub.TabIndex = 49;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(142, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn_point
            // 
            this.btn_point.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_point.Location = new System.Drawing.Point(104, 152);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(32, 32);
            this.btn_point.TabIndex = 47;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // btn0
            // 
            this.btn0.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn0.Location = new System.Drawing.Point(28, 152);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(32, 32);
            this.btn0.TabIndex = 46;
            this.btn0.Text = "&0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn9.Location = new System.Drawing.Point(104, 114);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(32, 32);
            this.btn9.TabIndex = 45;
            this.btn9.Text = "&9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn8.Location = new System.Drawing.Point(66, 114);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(32, 32);
            this.btn8.TabIndex = 44;
            this.btn8.Text = "&8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn7.Location = new System.Drawing.Point(28, 114);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(32, 32);
            this.btn7.TabIndex = 43;
            this.btn7.Text = "&7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn6.Location = new System.Drawing.Point(104, 76);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(32, 32);
            this.btn6.TabIndex = 42;
            this.btn6.Text = "&6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn5.Location = new System.Drawing.Point(66, 76);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(32, 32);
            this.btn5.TabIndex = 41;
            this.btn5.Text = "&5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn4.Location = new System.Drawing.Point(28, 76);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(32, 32);
            this.btn4.TabIndex = 40;
            this.btn4.Text = "&4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn3.Location = new System.Drawing.Point(104, 38);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(32, 32);
            this.btn3.TabIndex = 39;
            this.btn3.Text = "&3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn2.Location = new System.Drawing.Point(66, 38);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(32, 32);
            this.btn2.TabIndex = 38;
            this.btn2.Text = "&2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn1.Location = new System.Drawing.Point(28, 38);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(32, 32);
            this.btn1.TabIndex = 37;
            this.btn1.Text = "&1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(28, 12);
            this.txtBox.Name = "txtBox";
            this.txtBox.ReadOnly = true;
            this.txtBox.Size = new System.Drawing.Size(192, 20);
            this.txtBox.TabIndex = 36;
            this.txtBox.TabStop = false;
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Readfile
            // 
            this.Readfile.Location = new System.Drawing.Point(28, 228);
            this.Readfile.Name = "Readfile";
            this.Readfile.Size = new System.Drawing.Size(192, 23);
            this.Readfile.TabIndex = 55;
            this.Readfile.Text = "&ReadFile";
            this.Readfile.UseVisualStyleBackColor = true;
            this.Readfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // Basic_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 275);
            this.Controls.Add(this.Readfile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtBox);
            this.Name = "Basic_calculator";
            this.Text = "Basic_calculator";
            this.Load += new System.EventHandler(this.Basic_calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button Readfile;
    }
}