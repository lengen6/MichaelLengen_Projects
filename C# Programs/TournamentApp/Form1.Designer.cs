
namespace TournamentApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.addCompBtn = new System.Windows.Forms.Button();
            this.testLbl = new System.Windows.Forms.Label();
            this.startBracketBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayOrderElimBtn = new System.Windows.Forms.Button();
            this.displayByWinsBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.importCompLbl = new System.Windows.Forms.Label();
            this.importInstructions = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.subTitleLbl = new System.Windows.Forms.Label();
            this.tournamentInfoLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(18, 189);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(228, 25);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Enter Competitor Name:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(18, 247);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(228, 23);
            this.nameTxt.TabIndex = 1;
            // 
            // addCompBtn
            // 
            this.addCompBtn.Location = new System.Drawing.Point(18, 315);
            this.addCompBtn.Name = "addCompBtn";
            this.addCompBtn.Size = new System.Drawing.Size(213, 43);
            this.addCompBtn.TabIndex = 2;
            this.addCompBtn.Text = "Add Competitor:";
            this.addCompBtn.UseVisualStyleBackColor = true;
            this.addCompBtn.Click += new System.EventHandler(this.addCompBtn_Click);
            // 
            // testLbl
            // 
            this.testLbl.AutoSize = true;
            this.testLbl.Location = new System.Drawing.Point(38, 0);
            this.testLbl.Name = "testLbl";
            this.testLbl.Size = new System.Drawing.Size(31, 15);
            this.testLbl.TabIndex = 3;
            this.testLbl.Text = "Info:";
            this.testLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBracketBtn
            // 
            this.startBracketBtn.Location = new System.Drawing.Point(270, 395);
            this.startBracketBtn.Name = "startBracketBtn";
            this.startBracketBtn.Size = new System.Drawing.Size(127, 43);
            this.startBracketBtn.TabIndex = 4;
            this.startBracketBtn.Text = "Start Bracket:";
            this.startBracketBtn.UseVisualStyleBackColor = true;
            this.startBracketBtn.Click += new System.EventHandler(this.startBracketBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.testLbl);
            this.panel1.Location = new System.Drawing.Point(252, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 200);
            this.panel1.TabIndex = 5;
            // 
            // displayOrderElimBtn
            // 
            this.displayOrderElimBtn.Location = new System.Drawing.Point(3, 395);
            this.displayOrderElimBtn.Name = "displayOrderElimBtn";
            this.displayOrderElimBtn.Size = new System.Drawing.Size(261, 43);
            this.displayOrderElimBtn.TabIndex = 6;
            this.displayOrderElimBtn.Text = "Display Ranking by Order Eliminated:";
            this.displayOrderElimBtn.UseVisualStyleBackColor = true;
            this.displayOrderElimBtn.Click += new System.EventHandler(this.displayOrderElimBtn_Click);
            // 
            // displayByWinsBtn
            // 
            this.displayByWinsBtn.Location = new System.Drawing.Point(536, 395);
            this.displayByWinsBtn.Name = "displayByWinsBtn";
            this.displayByWinsBtn.Size = new System.Drawing.Size(229, 43);
            this.displayByWinsBtn.TabIndex = 7;
            this.displayByWinsBtn.Text = "Display Ranking by Wins:";
            this.displayByWinsBtn.UseVisualStyleBackColor = true;
            this.displayByWinsBtn.Click += new System.EventHandler(this.displayByWinsBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(403, 395);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(127, 43);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Reset:";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // importCompLbl
            // 
            this.importCompLbl.AutoSize = true;
            this.importCompLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.importCompLbl.Location = new System.Drawing.Point(543, 189);
            this.importCompLbl.Name = "importCompLbl";
            this.importCompLbl.Size = new System.Drawing.Size(215, 30);
            this.importCompLbl.TabIndex = 9;
            this.importCompLbl.Text = "Import Competitors:";
            // 
            // importInstructions
            // 
            this.importInstructions.Location = new System.Drawing.Point(536, 247);
            this.importInstructions.Name = "importInstructions";
            this.importInstructions.Size = new System.Drawing.Size(222, 46);
            this.importInstructions.TabIndex = 10;
            this.importInstructions.Text = "Must be an excel spreadsheet with each competitor\'s name listed in a new cell ver" +
    "tically.";
            this.importInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Competitor:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // subTitleLbl
            // 
            this.subTitleLbl.AutoSize = true;
            this.subTitleLbl.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.subTitleLbl.Location = new System.Drawing.Point(180, 54);
            this.subTitleLbl.Name = "subTitleLbl";
            this.subTitleLbl.Size = new System.Drawing.Size(462, 25);
            this.subTitleLbl.TabIndex = 12;
            this.subTitleLbl.Text = "Last Person Standing Double Elimination Tournament";
            this.subTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tournamentInfoLbl
            // 
            this.tournamentInfoLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tournamentInfoLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tournamentInfoLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tournamentInfoLbl.Location = new System.Drawing.Point(18, 88);
            this.tournamentInfoLbl.Name = "tournamentInfoLbl";
            this.tournamentInfoLbl.Size = new System.Drawing.Size(740, 98);
            this.tournamentInfoLbl.TabIndex = 13;
            this.tournamentInfoLbl.Text = resources.GetString("tournamentInfoLbl.Text");
            this.tournamentInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Showcard Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(270, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(258, 40);
            this.titleLbl.TabIndex = 14;
            this.titleLbl.Text = "The Gauntlet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.tournamentInfoLbl);
            this.Controls.Add(this.subTitleLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.importInstructions);
            this.Controls.Add(this.importCompLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.displayByWinsBtn);
            this.Controls.Add(this.displayOrderElimBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startBracketBtn);
            this.Controls.Add(this.addCompBtn);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.nameLbl);
            this.Name = "Form1";
            this.Text = "Bracket App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button addCompBtn;
        private System.Windows.Forms.Label testLbl;
        private System.Windows.Forms.Button startBracketBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button displayOrderElimBtn;
        private System.Windows.Forms.Button displayByWinsBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label importCompLbl;
        private System.Windows.Forms.Label importInstructions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label subTitleLbl;
        private System.Windows.Forms.Label tournamentInfoLbl;
        private System.Windows.Forms.Label titleLbl;
    }
}

