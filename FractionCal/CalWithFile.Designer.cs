namespace FractionCal
{
    partial class CalWithFile
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Import = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btn_Cal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Numerator = new System.Windows.Forms.TextBox();
            this.Txt_Denominator = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(12, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(151, 96);
            this.richTextBox1.TabIndex = 44;
            this.richTextBox1.Text = "";
            // 
            // btn_Import
            // 
            this.btn_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Import.FlatAppearance.BorderSize = 0;
            this.btn_Import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_Import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Import.Location = new System.Drawing.Point(12, 141);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(151, 23);
            this.btn_Import.TabIndex = 45;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = false;
            this.btn_Import.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(176, 66);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(145, 48);
            this.richTextBox2.TabIndex = 46;
            this.richTextBox2.Text = "";
            // 
            // btn_Cal
            // 
            this.btn_Cal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Cal.FlatAppearance.BorderSize = 0;
            this.btn_Cal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_Cal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Cal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cal.Location = new System.Drawing.Point(176, 141);
            this.btn_Cal.Name = "btn_Cal";
            this.btn_Cal.Size = new System.Drawing.Size(323, 23);
            this.btn_Cal.TabIndex = 47;
            this.btn_Cal.Text = "Calculate";
            this.btn_Cal.UseVisualStyleBackColor = false;
            this.btn_Cal.Click += new System.EventHandler(this.btn_Cal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Numerator: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Denominator: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(169, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 125);
            this.panel2.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(458, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 1);
            this.panel1.TabIndex = 49;
            // 
            // Txt_Numerator
            // 
            this.Txt_Numerator.Location = new System.Drawing.Point(458, 61);
            this.Txt_Numerator.Name = "Txt_Numerator";
            this.Txt_Numerator.Size = new System.Drawing.Size(41, 20);
            this.Txt_Numerator.TabIndex = 50;
            // 
            // Txt_Denominator
            // 
            this.Txt_Denominator.Location = new System.Drawing.Point(458, 94);
            this.Txt_Denominator.Name = "Txt_Denominator";
            this.Txt_Denominator.Size = new System.Drawing.Size(41, 20);
            this.Txt_Denominator.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(327, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 110);
            this.panel3.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Input Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Result in Decimal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Result in Fraction";
            // 
            // CalWithFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 177);
            this.Controls.Add(this.Txt_Denominator);
            this.Controls.Add(this.Txt_Numerator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cal);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.richTextBox1);
            this.Name = "CalWithFile";
            this.Text = "test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btn_Cal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_Numerator;
        private System.Windows.Forms.TextBox Txt_Denominator;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}