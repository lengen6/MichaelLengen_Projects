
namespace FractionCalculator_MichaelLengen
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
            this.numerator1Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.denominator1Txt = new System.Windows.Forms.TextBox();
            this.denominator2Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numerator2Txt = new System.Windows.Forms.TextBox();
            this.operationDropDown = new System.Windows.Forms.ComboBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.numResultLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.denomResultLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.doubleBtn = new System.Windows.Forms.Button();
            this.mixedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numerator1Txt
            // 
            this.numerator1Txt.Location = new System.Drawing.Point(28, 21);
            this.numerator1Txt.Name = "numerator1Txt";
            this.numerator1Txt.Size = new System.Drawing.Size(28, 23);
            this.numerator1Txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "___________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // denominator1Txt
            // 
            this.denominator1Txt.Location = new System.Drawing.Point(28, 80);
            this.denominator1Txt.Name = "denominator1Txt";
            this.denominator1Txt.Size = new System.Drawing.Size(28, 23);
            this.denominator1Txt.TabIndex = 2;
            // 
            // denominator2Txt
            // 
            this.denominator2Txt.Location = new System.Drawing.Point(147, 80);
            this.denominator2Txt.Name = "denominator2Txt";
            this.denominator2Txt.Size = new System.Drawing.Size(28, 23);
            this.denominator2Txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "___________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numerator2Txt
            // 
            this.numerator2Txt.Location = new System.Drawing.Point(147, 21);
            this.numerator2Txt.Name = "numerator2Txt";
            this.numerator2Txt.Size = new System.Drawing.Size(28, 23);
            this.numerator2Txt.TabIndex = 3;
            // 
            // operationDropDown
            // 
            this.operationDropDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.operationDropDown.FormattingEnabled = true;
            this.operationDropDown.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operationDropDown.Location = new System.Drawing.Point(80, 44);
            this.operationDropDown.Name = "operationDropDown";
            this.operationDropDown.Size = new System.Drawing.Size(37, 33);
            this.operationDropDown.TabIndex = 6;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateBtn.Location = new System.Drawing.Point(210, 47);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(38, 30);
            this.calculateBtn.TabIndex = 7;
            this.calculateBtn.Text = "=";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // numResultLbl
            // 
            this.numResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numResultLbl.Location = new System.Drawing.Point(270, 24);
            this.numResultLbl.Name = "numResultLbl";
            this.numResultLbl.Size = new System.Drawing.Size(32, 23);
            this.numResultLbl.TabIndex = 8;
            this.numResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "___________";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // denomResultLbl
            // 
            this.denomResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.denomResultLbl.Location = new System.Drawing.Point(270, 79);
            this.denomResultLbl.Name = "denomResultLbl";
            this.denomResultLbl.Size = new System.Drawing.Size(32, 23);
            this.denomResultLbl.TabIndex = 10;
            this.denomResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(309, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLbl
            // 
            this.resultLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLbl.Location = new System.Drawing.Point(340, 8);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(83, 98);
            this.resultLbl.TabIndex = 12;
            this.resultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(438, 90);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // doubleBtn
            // 
            this.doubleBtn.Location = new System.Drawing.Point(440, 61);
            this.doubleBtn.Name = "doubleBtn";
            this.doubleBtn.Size = new System.Drawing.Size(75, 23);
            this.doubleBtn.TabIndex = 14;
            this.doubleBtn.Text = "Double: ";
            this.doubleBtn.UseVisualStyleBackColor = true;
            this.doubleBtn.Click += new System.EventHandler(this.doubleBtn_Click);
            // 
            // mixedBtn
            // 
            this.mixedBtn.Location = new System.Drawing.Point(440, 8);
            this.mixedBtn.Name = "mixedBtn";
            this.mixedBtn.Size = new System.Drawing.Size(75, 47);
            this.mixedBtn.TabIndex = 15;
            this.mixedBtn.Text = "Mixed Number:";
            this.mixedBtn.UseVisualStyleBackColor = true;
            this.mixedBtn.Click += new System.EventHandler(this.mixedBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 115);
            this.Controls.Add(this.mixedBtn);
            this.Controls.Add(this.doubleBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.denomResultLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numResultLbl);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.operationDropDown);
            this.Controls.Add(this.denominator2Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numerator2Txt);
            this.Controls.Add(this.denominator1Txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numerator1Txt);
            this.Name = "Form1";
            this.Text = "Fraction Calculator - Michael Lengen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numerator1Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox denominator1Txt;
        private System.Windows.Forms.TextBox denominator2Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numerator2Txt;
        private System.Windows.Forms.ComboBox operationDropDown;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label numResultLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label denomResultLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button doubleBtn;
        private System.Windows.Forms.Button mixedBtn;
    }
}

