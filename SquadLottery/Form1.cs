using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SquadLottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            playerNamesCheckedListBox.CheckOnClick = true;
        }

        private void LeaderLotteryButton_Click(object sender, EventArgs e)
        {
            if (playerNamesCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Select at least one name!");
                return;
            }
            Random random = new Random();
            int randomNameIdx = random.Next(playerNamesCheckedListBox.CheckedItems.Count);
            leaderNameLabel.Text = playerNamesCheckedListBox.CheckedItems[randomNameIdx].ToString();
        }

        private void RemoveNameButton_Click(object sender, EventArgs e)
        {
            if (playerNamesCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Select at least one name!");
                return;
            }
            for (int i = 0; i < playerNamesCheckedListBox.CheckedItems.Count; i++)
            {
                playerNamesCheckedListBox.Items.Remove(playerNamesCheckedListBox.CheckedItems[i]);
            }
        }

        private void AddNameButton_Click(object sender, EventArgs e)
        {
            string newName = Interaction.InputBox("Enter the new name", "Name to add");
            playerNamesCheckedListBox.Items.Add(newName);
        }
    }
}
