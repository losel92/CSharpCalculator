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
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonComma = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.plusMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(338, 60);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // buttonComma
            // 
            this.buttonComma.Location = new System.Drawing.Point(176, 433);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(77, 81);
            this.buttonComma.TabIndex = 2;
            this.buttonComma.Text = ".";
            this.buttonComma.UseVisualStyleBackColor = true;
            this.buttonComma.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(93, 433);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(77, 81);
            this.number0.TabIndex = 3;
            this.number0.Tag = "Number";
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(10, 346);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(77, 81);
            this.number7.TabIndex = 7;
            this.number7.Tag = "Number";
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(93, 346);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(77, 81);
            this.number8.TabIndex = 6;
            this.number8.Tag = "Number";
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(176, 346);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(77, 81);
            this.number9.TabIndex = 5;
            this.number9.Tag = "Number";
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(10, 259);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(77, 81);
            this.number4.TabIndex = 10;
            this.number4.Tag = "Number";
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(93, 259);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(77, 81);
            this.number5.TabIndex = 9;
            this.number5.Tag = "Number";
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(176, 259);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(77, 81);
            this.number6.TabIndex = 8;
            this.number6.Tag = "Number";
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(263, 433);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(85, 81);
            this.buttonEquals.TabIndex = 11;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(263, 172);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(85, 81);
            this.buttonMultiply.TabIndex = 12;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(10, 172);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(77, 81);
            this.number1.TabIndex = 15;
            this.number1.Tag = "Number";
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(93, 172);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(77, 81);
            this.number2.TabIndex = 14;
            this.number2.Tag = "Number";
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(176, 172);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(77, 81);
            this.number3.TabIndex = 13;
            this.number3.Tag = "Number";
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(263, 259);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(85, 81);
            this.buttonMinus.TabIndex = 16;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(263, 346);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(85, 81);
            this.buttonPlus.TabIndex = 17;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.operator_Click);
            // 
            // cButton
            // 
            this.cButton.Location = new System.Drawing.Point(10, 85);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(120, 81);
            this.cButton.TabIndex = 21;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(136, 85);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(117, 81);
            this.backspace.TabIndex = 19;
            this.backspace.Text = "Backspace";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(263, 85);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(85, 81);
            this.buttonDivide.TabIndex = 18;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.operator_Click);
            // 
            // plusMinus
            // 
            this.plusMinus.Location = new System.Drawing.Point(10, 433);
            this.plusMinus.Name = "plusMinus";
            this.plusMinus.Size = new System.Drawing.Size(77, 81);
            this.plusMinus.TabIndex = 4;
            this.plusMinus.Text = "- +";
            this.plusMinus.UseVisualStyleBackColor = true;
            this.plusMinus.Click += new System.EventHandler(this.plusMinus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 521);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.plusMinus);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.buttonComma);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button plusMinus;
    }
}

