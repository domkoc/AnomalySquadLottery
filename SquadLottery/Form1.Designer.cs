namespace SquadLottery
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
            this.playerNamesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.leaderNameLabel = new System.Windows.Forms.Label();
            this.LeaderLotteryButton = new System.Windows.Forms.Button();
            this.leaderTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerNamesCheckedListBox
            // 
            this.playerNamesCheckedListBox.FormattingEnabled = true;
            this.playerNamesCheckedListBox.Location = new System.Drawing.Point(12, 12);
            this.playerNamesCheckedListBox.Name = "playerNamesCheckedListBox";
            this.playerNamesCheckedListBox.Size = new System.Drawing.Size(258, 154);
            this.playerNamesCheckedListBox.TabIndex = 0;
            // 
            // leaderNameLabel
            // 
            this.leaderNameLabel.AutoSize = true;
            this.leaderNameLabel.Location = new System.Drawing.Point(166, 169);
            this.leaderNameLabel.Name = "leaderNameLabel";
            this.leaderNameLabel.Size = new System.Drawing.Size(104, 13);
            this.leaderNameLabel.TabIndex = 1;
            this.leaderNameLabel.Text = "Press the Go button!";
            // 
            // LeaderLotteryButton
            // 
            this.LeaderLotteryButton.Location = new System.Drawing.Point(15, 185);
            this.LeaderLotteryButton.Name = "LeaderLotteryButton";
            this.LeaderLotteryButton.Size = new System.Drawing.Size(255, 23);
            this.LeaderLotteryButton.TabIndex = 2;
            this.LeaderLotteryButton.Text = "Go";
            this.LeaderLotteryButton.UseVisualStyleBackColor = true;
            this.LeaderLotteryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // leaderTitleLabel
            // 
            this.leaderTitleLabel.AutoSize = true;
            this.leaderTitleLabel.Location = new System.Drawing.Point(12, 169);
            this.leaderTitleLabel.Name = "leaderTitleLabel";
            this.leaderTitleLabel.Size = new System.Drawing.Size(148, 13);
            this.leaderTitleLabel.TabIndex = 3;
            this.leaderTitleLabel.Text = "The next squad leader will be:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 213);
            this.Controls.Add(this.leaderTitleLabel);
            this.Controls.Add(this.LeaderLotteryButton);
            this.Controls.Add(this.leaderNameLabel);
            this.Controls.Add(this.playerNamesCheckedListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox playerNamesCheckedListBox;
        private System.Windows.Forms.Label leaderNameLabel;
        private System.Windows.Forms.Button LeaderLotteryButton;
        private System.Windows.Forms.Label leaderTitleLabel;
    }
}

