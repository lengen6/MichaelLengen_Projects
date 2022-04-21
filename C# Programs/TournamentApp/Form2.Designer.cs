
namespace TournamentApp
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.minutesDropbox = new System.Windows.Forms.ComboBox();
            this.secondsDropbox = new System.Windows.Forms.ComboBox();
            this.minutesLbl = new System.Windows.Forms.Label();
            this.secondsLbl = new System.Windows.Forms.Label();
            this.player1Lbl = new System.Windows.Forms.Label();
            this.player1PtsLbl = new System.Windows.Forms.Label();
            this.player1PtsResult = new System.Windows.Forms.Label();
            this.player2Lbl = new System.Windows.Forms.Label();
            this.player2PtsLbl = new System.Windows.Forms.Label();
            this.player2PtsResultLbl = new System.Windows.Forms.Label();
            this.countDownLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.p1IncreaseBtn = new System.Windows.Forms.Button();
            this.p2IncreaseButton = new System.Windows.Forms.Button();
            this.p1DecreaseBtn = new System.Windows.Forms.Button();
            this.p2DecreaseBtn = new System.Windows.Forms.Button();
            this.p1SubBtn = new System.Windows.Forms.Button();
            this.p2SubBtn = new System.Windows.Forms.Button();
            this.p1DqBtn = new System.Windows.Forms.Button();
            this.p2DqBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minutesDropbox
            // 
            this.minutesDropbox.FormattingEnabled = true;
            this.minutesDropbox.Location = new System.Drawing.Point(148, 62);
            this.minutesDropbox.Name = "minutesDropbox";
            this.minutesDropbox.Size = new System.Drawing.Size(173, 23);
            this.minutesDropbox.TabIndex = 0;
            // 
            // secondsDropbox
            // 
            this.secondsDropbox.FormattingEnabled = true;
            this.secondsDropbox.Location = new System.Drawing.Point(472, 62);
            this.secondsDropbox.Name = "secondsDropbox";
            this.secondsDropbox.Size = new System.Drawing.Size(163, 23);
            this.secondsDropbox.TabIndex = 1;
            // 
            // minutesLbl
            // 
            this.minutesLbl.AutoSize = true;
            this.minutesLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minutesLbl.Location = new System.Drawing.Point(192, 29);
            this.minutesLbl.Name = "minutesLbl";
            this.minutesLbl.Size = new System.Drawing.Size(93, 30);
            this.minutesLbl.TabIndex = 2;
            this.minutesLbl.Text = "Minutes:";
            // 
            // secondsLbl
            // 
            this.secondsLbl.AutoSize = true;
            this.secondsLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondsLbl.Location = new System.Drawing.Point(516, 29);
            this.secondsLbl.Name = "secondsLbl";
            this.secondsLbl.Size = new System.Drawing.Size(95, 30);
            this.secondsLbl.TabIndex = 3;
            this.secondsLbl.Text = "Seconds:";
            // 
            // player1Lbl
            // 
            this.player1Lbl.AutoSize = true;
            this.player1Lbl.BackColor = System.Drawing.Color.Red;
            this.player1Lbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1Lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.player1Lbl.Location = new System.Drawing.Point(12, 133);
            this.player1Lbl.Name = "player1Lbl";
            this.player1Lbl.Size = new System.Drawing.Size(124, 40);
            this.player1Lbl.TabIndex = 4;
            this.player1Lbl.Text = "Player 1:";
            // 
            // player1PtsLbl
            // 
            this.player1PtsLbl.AutoSize = true;
            this.player1PtsLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1PtsLbl.Location = new System.Drawing.Point(12, 194);
            this.player1PtsLbl.Name = "player1PtsLbl";
            this.player1PtsLbl.Size = new System.Drawing.Size(55, 21);
            this.player1PtsLbl.TabIndex = 5;
            this.player1PtsLbl.Text = "Points:";
            // 
            // player1PtsResult
            // 
            this.player1PtsResult.AutoSize = true;
            this.player1PtsResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1PtsResult.Location = new System.Drawing.Point(117, 194);
            this.player1PtsResult.Name = "player1PtsResult";
            this.player1PtsResult.Size = new System.Drawing.Size(19, 21);
            this.player1PtsResult.TabIndex = 6;
            this.player1PtsResult.Text = "0";
            this.player1PtsResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Lbl
            // 
            this.player2Lbl.AutoSize = true;
            this.player2Lbl.BackColor = System.Drawing.Color.Blue;
            this.player2Lbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2Lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.player2Lbl.Location = new System.Drawing.Point(664, 133);
            this.player2Lbl.Name = "player2Lbl";
            this.player2Lbl.Size = new System.Drawing.Size(124, 40);
            this.player2Lbl.TabIndex = 7;
            this.player2Lbl.Text = "Player 2:";
            // 
            // player2PtsLbl
            // 
            this.player2PtsLbl.AutoSize = true;
            this.player2PtsLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2PtsLbl.Location = new System.Drawing.Point(664, 194);
            this.player2PtsLbl.Name = "player2PtsLbl";
            this.player2PtsLbl.Size = new System.Drawing.Size(55, 21);
            this.player2PtsLbl.TabIndex = 8;
            this.player2PtsLbl.Text = "Points:";
            // 
            // player2PtsResultLbl
            // 
            this.player2PtsResultLbl.AutoSize = true;
            this.player2PtsResultLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2PtsResultLbl.Location = new System.Drawing.Point(769, 194);
            this.player2PtsResultLbl.Name = "player2PtsResultLbl";
            this.player2PtsResultLbl.Size = new System.Drawing.Size(19, 21);
            this.player2PtsResultLbl.TabIndex = 9;
            this.player2PtsResultLbl.Text = "0";
            this.player2PtsResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countDownLbl
            // 
            this.countDownLbl.AutoSize = true;
            this.countDownLbl.Font = new System.Drawing.Font("Segoe UI Symbol", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countDownLbl.Location = new System.Drawing.Point(249, 238);
            this.countDownLbl.Name = "countDownLbl";
            this.countDownLbl.Size = new System.Drawing.Size(283, 128);
            this.countDownLbl.TabIndex = 10;
            this.countDownLbl.Text = "00:00";
            this.countDownLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBtn.Location = new System.Drawing.Point(182, 124);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(139, 49);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "Start:";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pauseBtn.Location = new System.Drawing.Point(327, 124);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(139, 49);
            this.pauseBtn.TabIndex = 12;
            this.pauseBtn.Text = "Pause:";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopBtn.Location = new System.Drawing.Point(472, 124);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(139, 49);
            this.stopBtn.TabIndex = 13;
            this.stopBtn.Text = "End Match:";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // p1IncreaseBtn
            // 
            this.p1IncreaseBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.p1IncreaseBtn.Location = new System.Drawing.Point(12, 238);
            this.p1IncreaseBtn.Name = "p1IncreaseBtn";
            this.p1IncreaseBtn.Size = new System.Drawing.Size(124, 42);
            this.p1IncreaseBtn.TabIndex = 14;
            this.p1IncreaseBtn.Text = "+";
            this.p1IncreaseBtn.UseVisualStyleBackColor = true;
            this.p1IncreaseBtn.Click += new System.EventHandler(this.p1IncreaseBtn_Click);
            // 
            // p2IncreaseButton
            // 
            this.p2IncreaseButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.p2IncreaseButton.Location = new System.Drawing.Point(664, 238);
            this.p2IncreaseButton.Name = "p2IncreaseButton";
            this.p2IncreaseButton.Size = new System.Drawing.Size(124, 42);
            this.p2IncreaseButton.TabIndex = 15;
            this.p2IncreaseButton.Text = "+";
            this.p2IncreaseButton.UseVisualStyleBackColor = true;
            this.p2IncreaseButton.Click += new System.EventHandler(this.p2IncreaseButton_Click);
            // 
            // p1DecreaseBtn
            // 
            this.p1DecreaseBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.p1DecreaseBtn.Location = new System.Drawing.Point(12, 286);
            this.p1DecreaseBtn.Name = "p1DecreaseBtn";
            this.p1DecreaseBtn.Size = new System.Drawing.Size(124, 42);
            this.p1DecreaseBtn.TabIndex = 16;
            this.p1DecreaseBtn.Text = "-";
            this.p1DecreaseBtn.UseVisualStyleBackColor = true;
            this.p1DecreaseBtn.Click += new System.EventHandler(this.p1DecreaseBtn_Click);
            // 
            // p2DecreaseBtn
            // 
            this.p2DecreaseBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.p2DecreaseBtn.Location = new System.Drawing.Point(664, 286);
            this.p2DecreaseBtn.Name = "p2DecreaseBtn";
            this.p2DecreaseBtn.Size = new System.Drawing.Size(124, 42);
            this.p2DecreaseBtn.TabIndex = 17;
            this.p2DecreaseBtn.Text = "-";
            this.p2DecreaseBtn.UseVisualStyleBackColor = true;
            this.p2DecreaseBtn.Click += new System.EventHandler(this.p2DecreaseBtn_Click);
            // 
            // p1SubBtn
            // 
            this.p1SubBtn.Location = new System.Drawing.Point(12, 371);
            this.p1SubBtn.Name = "p1SubBtn";
            this.p1SubBtn.Size = new System.Drawing.Size(54, 54);
            this.p1SubBtn.TabIndex = 18;
            this.p1SubBtn.Text = "Sub";
            this.p1SubBtn.UseVisualStyleBackColor = true;
            this.p1SubBtn.Click += new System.EventHandler(this.p1SubBtn_Click);
            // 
            // p2SubBtn
            // 
            this.p2SubBtn.Location = new System.Drawing.Point(664, 384);
            this.p2SubBtn.Name = "p2SubBtn";
            this.p2SubBtn.Size = new System.Drawing.Size(54, 54);
            this.p2SubBtn.TabIndex = 19;
            this.p2SubBtn.Text = "Sub";
            this.p2SubBtn.UseVisualStyleBackColor = true;
            this.p2SubBtn.Click += new System.EventHandler(this.p2SubBtn_Click);
            // 
            // p1DqBtn
            // 
            this.p1DqBtn.Location = new System.Drawing.Point(82, 371);
            this.p1DqBtn.Name = "p1DqBtn";
            this.p1DqBtn.Size = new System.Drawing.Size(54, 54);
            this.p1DqBtn.TabIndex = 20;
            this.p1DqBtn.Text = "DQ\'d";
            this.p1DqBtn.UseVisualStyleBackColor = true;
            this.p1DqBtn.Click += new System.EventHandler(this.p1DqBtn_Click);
            // 
            // p2DqBtn
            // 
            this.p2DqBtn.Location = new System.Drawing.Point(734, 384);
            this.p2DqBtn.Name = "p2DqBtn";
            this.p2DqBtn.Size = new System.Drawing.Size(54, 54);
            this.p2DqBtn.TabIndex = 21;
            this.p2DqBtn.Text = "DQ\'d";
            this.p2DqBtn.UseVisualStyleBackColor = true;
            this.p2DqBtn.Click += new System.EventHandler(this.p2DqBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p2DqBtn);
            this.Controls.Add(this.p1DqBtn);
            this.Controls.Add(this.p2SubBtn);
            this.Controls.Add(this.p1SubBtn);
            this.Controls.Add(this.p2DecreaseBtn);
            this.Controls.Add(this.p1DecreaseBtn);
            this.Controls.Add(this.p2IncreaseButton);
            this.Controls.Add(this.p1IncreaseBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.countDownLbl);
            this.Controls.Add(this.player2PtsResultLbl);
            this.Controls.Add(this.player2PtsLbl);
            this.Controls.Add(this.player2Lbl);
            this.Controls.Add(this.player1PtsResult);
            this.Controls.Add(this.player1PtsLbl);
            this.Controls.Add(this.player1Lbl);
            this.Controls.Add(this.secondsLbl);
            this.Controls.Add(this.minutesLbl);
            this.Controls.Add(this.secondsDropbox);
            this.Controls.Add(this.minutesDropbox);
            this.Name = "Form1";
            this.Text = "Score Keeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox minutesDropbox;
        private System.Windows.Forms.ComboBox secondsDropbox;
        private System.Windows.Forms.Label minutesLbl;
        private System.Windows.Forms.Label secondsLbl;
        private System.Windows.Forms.Label player1Lbl;
        private System.Windows.Forms.Label player1PtsLbl;
        private System.Windows.Forms.Label player1PtsResult;
        private System.Windows.Forms.Label player2Lbl;
        private System.Windows.Forms.Label player2PtsLbl;
        private System.Windows.Forms.Label player2PtsResultLbl;
        private System.Windows.Forms.Label countDownLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button p1IncreaseBtn;
        private System.Windows.Forms.Button p2IncreaseButton;
        private System.Windows.Forms.Button p1DecreaseBtn;
        private System.Windows.Forms.Button p2DecreaseBtn;
        private System.Windows.Forms.Button p1SubBtn;
        private System.Windows.Forms.Button p2SubBtn;
        private System.Windows.Forms.Button p1DqBtn;
        private System.Windows.Forms.Button p2DqBtn;
    }
}

