﻿namespace Calculator
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
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.SumBackground = new System.Windows.Forms.PictureBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SumBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModulo
            // 
            this.btnModulo.BackColor = System.Drawing.Color.RosyBrown;
            this.btnModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnModulo.Location = new System.Drawing.Point(20, 176);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(90, 80);
            this.btnModulo.TabIndex = 0;
            this.btnModulo.Text = "%";
            this.btnModulo.UseVisualStyleBackColor = false;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.RosyBrown;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReset.Location = new System.Drawing.Point(113, 176);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 80);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "CE";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClear.Location = new System.Drawing.Point(206, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 80);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDivide.Location = new System.Drawing.Point(299, 176);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(90, 80);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMultiply.Location = new System.Drawing.Point(299, 258);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(90, 80);
            this.btnMultiply.TabIndex = 7;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DimGray;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(206, 258);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(90, 80);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DimGray;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(113, 258);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(90, 80);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DimGray;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(20, 258);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 80);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinus.Location = new System.Drawing.Point(299, 340);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(90, 80);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DimGray;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(206, 340);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(90, 80);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DimGray;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(113, 340);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 80);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DimGray;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(20, 340);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 80);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Location = new System.Drawing.Point(299, 422);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 80);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DimGray;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(206, 422);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 80);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DimGray;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(113, 422);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 80);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DimGray;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(20, 422);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 80);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.Sienna;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEquals.Location = new System.Drawing.Point(299, 504);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(90, 80);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.DimGray;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.ForeColor = System.Drawing.Color.White;
            this.btnDecimal.Location = new System.Drawing.Point(206, 504);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(90, 80);
            this.btnDecimal.TabIndex = 18;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DimGray;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(113, 504);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(90, 80);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.DimGray;
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.ForeColor = System.Drawing.Color.White;
            this.btnSign.Location = new System.Drawing.Point(20, 504);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(90, 80);
            this.btnSign.TabIndex = 16;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // SumBackground
            // 
            this.SumBackground.BackColor = System.Drawing.Color.Gray;
            this.SumBackground.Location = new System.Drawing.Point(20, 42);
            this.SumBackground.Name = "SumBackground";
            this.SumBackground.Size = new System.Drawing.Size(368, 98);
            this.SumBackground.TabIndex = 20;
            this.SumBackground.TabStop = false;
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.Gray;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Source Sans Pro", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.Color.Snow;
            this.txtDisplay.Location = new System.Drawing.Point(31, 71);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDisplay.Size = new System.Drawing.Size(343, 59);
            this.txtDisplay.TabIndex = 21;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Gray;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLog.Location = new System.Drawing.Point(25, 48);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(357, 19);
            this.txtLog.TabIndex = 22;
            this.txtLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(409, 611);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.SumBackground);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnModulo);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SumBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.PictureBox SumBackground;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtLog;
    }
}

