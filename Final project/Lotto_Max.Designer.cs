namespace Final_project
{
    partial class Lotto_Max
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
            this.label1 = new System.Windows.Forms.Label();
            this.winning_num = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.Readfile = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Winning number are:";
            // 
            // winning_num
            // 
            this.winning_num.Location = new System.Drawing.Point(58, 45);
            this.winning_num.Multiline = true;
            this.winning_num.Name = "winning_num";
            this.winning_num.ReadOnly = true;
            this.winning_num.Size = new System.Drawing.Size(174, 167);
            this.winning_num.TabIndex = 1;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(21, 218);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 2;
            this.Generate.Text = "&Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Readfile
            // 
            this.Readfile.Location = new System.Drawing.Point(102, 218);
            this.Readfile.Name = "Readfile";
            this.Readfile.Size = new System.Drawing.Size(75, 23);
            this.Readfile.TabIndex = 3;
            this.Readfile.Text = "&Read File";
            this.Readfile.UseVisualStyleBackColor = true;
            this.Readfile.Click += new System.EventHandler(this.Readfile_Click_1);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(183, 218);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Lotto_Max
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 283);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Readfile);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.winning_num);
            this.Controls.Add(this.label1);
            this.Name = "Lotto_Max";
            this.Text = "Lotto_Nbrs";
            this.Load += new System.EventHandler(this.Lotto_Max_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox winning_num;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Readfile;
        private System.Windows.Forms.Button Exit;
    }
}