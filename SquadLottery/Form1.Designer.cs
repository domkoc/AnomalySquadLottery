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
            this.AddNameButton = new System.Windows.Forms.Button();
            this.RemoveNameButton = new System.Windows.Forms.Button();
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
            this.leaderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leaderNameLabel.Location = new System.Drawing.Point(276, 79);
            this.leaderNameLabel.Name = "leaderNameLabel";
            this.leaderNameLabel.Size = new System.Drawing.Size(231, 26);
            this.leaderNameLabel.TabIndex = 1;
            this.leaderNameLabel.Text = "Press the Go button!";
            // 
            // LeaderLotteryButton
            // 
            this.LeaderLotteryButton.Location = new System.Drawing.Point(276, 172);
            this.LeaderLotteryButton.Name = "LeaderLotteryButton";
            this.LeaderLotteryButton.Size = new System.Drawing.Size(231, 23);
            this.LeaderLotteryButton.TabIndex = 2;
            this.LeaderLotteryButton.Text = "Go";
            this.LeaderLotteryButton.UseVisualStyleBackColor = true;
            this.LeaderLotteryButton.Click += new System.EventHandler(this.LeaderLotteryButton_Click);
            // 
            // leaderTitleLabel
            // 
            this.leaderTitleLabel.AutoSize = true;
            this.leaderTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leaderTitleLabel.Location = new System.Drawing.Point(273, 12);
            this.leaderTitleLabel.Name = "leaderTitleLabel";
            this.leaderTitleLabel.Size = new System.Drawing.Size(148, 13);
            this.leaderTitleLabel.TabIndex = 3;
            this.leaderTitleLabel.Text = "The next squad leader will be:";
            // 
            // AddNameButton
            // 
            this.AddNameButton.Location = new System.Drawing.Point(12, 172);
            this.AddNameButton.Name = "AddNameButton";
            this.AddNameButton.Size = new System.Drawing.Size(131, 23);
            this.AddNameButton.TabIndex = 4;
            this.AddNameButton.Text = "Add New";
            this.AddNameButton.UseVisualStyleBackColor = true;
            this.AddNameButton.Click += new System.EventHandler(this.AddNameButton_Click);
            // 
            // RemoveNameButton
            // 
            this.RemoveNameButton.Location = new System.Drawing.Point(149, 172);
            this.RemoveNameButton.Name = "RemoveNameButton";
            this.RemoveNameButton.Size = new System.Drawing.Size(121, 23);
            this.RemoveNameButton.TabIndex = 4;
            this.RemoveNameButton.Text = "Remove Selected";
            this.RemoveNameButton.UseVisualStyleBackColor = true;
            this.RemoveNameButton.Click += new System.EventHandler(this.RemoveNameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 203);
            this.Controls.Add(this.RemoveNameButton);
            this.Controls.Add(this.AddNameButton);
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
        private System.Windows.Forms.Button AddNameButton;
        private System.Windows.Forms.Button RemoveNameButton;
    }
}

