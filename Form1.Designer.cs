
namespace paintCoLaborChecker
{
    partial class Form1
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
            this.btn_gen = new System.Windows.Forms.Button();
            this.txt_sqft = new System.Windows.Forms.TextBox();
            this.txt_paintprc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_gal = new System.Windows.Forms.Label();
            this.lbl_laborhrs = new System.Windows.Forms.Label();
            this.lbl_paintcst = new System.Windows.Forms.Label();
            this.lbl_laborcst = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_gen
            // 
            this.btn_gen.Location = new System.Drawing.Point(243, 140);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(183, 45);
            this.btn_gen.TabIndex = 0;
            this.btn_gen.Text = "Generate Job";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // txt_sqft
            // 
            this.txt_sqft.Location = new System.Drawing.Point(470, 53);
            this.txt_sqft.Name = "txt_sqft";
            this.txt_sqft.Size = new System.Drawing.Size(101, 26);
            this.txt_sqft.TabIndex = 1;
            this.txt_sqft.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_paintprc
            // 
            this.txt_paintprc.Location = new System.Drawing.Point(470, 98);
            this.txt_paintprc.Name = "txt_paintprc";
            this.txt_paintprc.Size = new System.Drawing.Size(100, 26);
            this.txt_paintprc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter the square footage that needs to be painted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please enter the price per gallon of paint";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Gallons Needed: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hours of Labor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cost of Paint:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cost of Labor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Cost of Job:";
            // 
            // lbl_gal
            // 
            this.lbl_gal.AutoSize = true;
            this.lbl_gal.Location = new System.Drawing.Point(320, 202);
            this.lbl_gal.Name = "lbl_gal";
            this.lbl_gal.Size = new System.Drawing.Size(35, 20);
            this.lbl_gal.TabIndex = 10;
            this.lbl_gal.Text = "N/A";
            // 
            // lbl_laborhrs
            // 
            this.lbl_laborhrs.AutoSize = true;
            this.lbl_laborhrs.Location = new System.Drawing.Point(320, 247);
            this.lbl_laborhrs.Name = "lbl_laborhrs";
            this.lbl_laborhrs.Size = new System.Drawing.Size(35, 20);
            this.lbl_laborhrs.TabIndex = 11;
            this.lbl_laborhrs.Text = "N/A";
            // 
            // lbl_paintcst
            // 
            this.lbl_paintcst.AutoSize = true;
            this.lbl_paintcst.Location = new System.Drawing.Point(320, 291);
            this.lbl_paintcst.Name = "lbl_paintcst";
            this.lbl_paintcst.Size = new System.Drawing.Size(35, 20);
            this.lbl_paintcst.TabIndex = 12;
            this.lbl_paintcst.Text = "N/A";
            this.lbl_paintcst.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbl_laborcst
            // 
            this.lbl_laborcst.AutoSize = true;
            this.lbl_laborcst.Location = new System.Drawing.Point(320, 337);
            this.lbl_laborcst.Name = "lbl_laborcst";
            this.lbl_laborcst.Size = new System.Drawing.Size(35, 20);
            this.lbl_laborcst.TabIndex = 13;
            this.lbl_laborcst.Text = "N/A";
            this.lbl_laborcst.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(341, 396);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(35, 20);
            this.lbl_total.TabIndex = 14;
            this.lbl_total.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_laborcst);
            this.Controls.Add(this.lbl_paintcst);
            this.Controls.Add(this.lbl_laborhrs);
            this.Controls.Add(this.lbl_gal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_paintprc);
            this.Controls.Add(this.txt_sqft);
            this.Controls.Add(this.btn_gen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.TextBox txt_sqft;
        private System.Windows.Forms.TextBox txt_paintprc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_gal;
        private System.Windows.Forms.Label lbl_laborhrs;
        private System.Windows.Forms.Label lbl_paintcst;
        private System.Windows.Forms.Label lbl_laborcst;
        private System.Windows.Forms.Label lbl_total;
    }
}

