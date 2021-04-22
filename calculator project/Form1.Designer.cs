
namespace calculator_project
{
    partial class Form1
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
            this.calculations = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.opt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculations
            // 
            this.calculations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.calculations.Location = new System.Drawing.Point(236, 383);
            this.calculations.Margin = new System.Windows.Forms.Padding(4);
            this.calculations.Name = "calculations";
            this.calculations.Size = new System.Drawing.Size(124, 32);
            this.calculations.TabIndex = 0;
            this.calculations.Text = "Calculate";
            this.calculations.UseVisualStyleBackColor = true;
            this.calculations.Click += new System.EventHandler(this.calculations_Click);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(377, 88);
            this.n1.Margin = new System.Windows.Forms.Padding(4);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(177, 29);
            this.n1.TabIndex = 3;
            this.n1.TextChanged += new System.EventHandler(this.n1_TextChanged);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(377, 150);
            this.n2.Margin = new System.Windows.Forms.Padding(4);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(177, 29);
            this.n2.TabIndex = 4;
            this.n2.TextChanged += new System.EventHandler(this.n2_TextChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(377, 298);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(177, 29);
            this.result.TabIndex = 5;
            this.result.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // opt
            // 
            this.opt.Location = new System.Drawing.Point(377, 216);
            this.opt.Margin = new System.Windows.Forms.Padding(4);
            this.opt.Name = "opt";
            this.opt.Size = new System.Drawing.Size(177, 29);
            this.opt.TabIndex = 7;
            this.opt.TextChanged += new System.EventHandler(this.opt_TextChanged);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(236, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter First Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter Second Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter the Operator";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opt);
            this.Controls.Add(this.result);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.calculations);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculations;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox opt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

