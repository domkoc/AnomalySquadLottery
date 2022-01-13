using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquadLottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Sets up the initial objects in the CheckedListBox.
            string[] names = { "Ágoston", "Andris", "Bence", "Botond", "Dominik", "Martin", "Peti" };
            playerNamesCheckedListBox.Items.AddRange(names);

            // Changes the selection mode from double-click to single click.
            playerNamesCheckedListBox.CheckOnClick = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNameIdx = random.Next(playerNamesCheckedListBox.CheckedItems.Count);
            leaderNameLabel.Text = playerNamesCheckedListBox.CheckedItems[randomNameIdx].ToString();
        }
    }
}
