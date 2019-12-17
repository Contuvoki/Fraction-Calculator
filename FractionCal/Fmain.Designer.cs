namespace FractionCal
{
    partial class Fmain
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
            this.btn_New = new System.Windows.Forms.Button();
            this.bt_Calc = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Txt_Denominator = new System.Windows.Forms.TextBox();
            this.Txt_Numerator = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.LightGray;
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_New.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(12, 80);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(123, 72);
            this.btn_New.TabIndex = 31;
            this.btn_New.Text = "NEW";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // bt_Calc
            // 
            this.bt_Calc.BackColor = System.Drawing.Color.LightGray;
            this.bt_Calc.FlatAppearance.BorderSize = 0;
            this.bt_Calc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_Calc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.bt_Calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Calc.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Calc.Location = new System.Drawing.Point(225, 95);
            this.bt_Calc.Name = "bt_Calc";
            this.bt_Calc.Size = new System.Drawing.Size(169, 39);
            this.bt_Calc.TabIndex = 35;
            this.bt_Calc.Text = "Calculate";
            this.bt_Calc.UseVisualStyleBackColor = false;
            this.bt_Calc.Click += new System.EventHandler(this.bt_Calc_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 62);
            this.panel3.TabIndex = 39;
            // 
            // Txt_Denominator
            // 
            this.Txt_Denominator.Location = new System.Drawing.Point(524, 123);
            this.Txt_Denominator.Name = "Txt_Denominator";
            this.Txt_Denominator.Size = new System.Drawing.Size(41, 20);
            this.Txt_Denominator.TabIndex = 54;
            // 
            // Txt_Numerator
            // 
            this.Txt_Numerator.Location = new System.Drawing.Point(524, 90);
            this.Txt_Numerator.Name = "Txt_Numerator";
            this.Txt_Numerator.Size = new System.Drawing.Size(41, 20);
            this.Txt_Numerator.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(524, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 1);
            this.panel1.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Denominator: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Numerator: ";
            // 
            // Fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(659, 163);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.Txt_Denominator);
            this.Controls.Add(this.Txt_Numerator);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Calc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Fmain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button bt_Calc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Txt_Denominator;
        private System.Windows.Forms.TextBox Txt_Numerator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

