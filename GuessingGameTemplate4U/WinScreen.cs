using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GuessingGameTemplate4U
{
    public partial class WinScreen : UserControl
    {
        public WinScreen()
        {
            InitializeComponent();
        }

        private void WinScreen_Load(object sender, EventArgs e)
        {
            winLabel.Text = "Congratulations! It Took you " + Form1.guessedNumbers.Count + " Tries";
            Thread.Sleep(1000);

            for (int i = 0; i < Form1.guessedNumbers.Count(); i++)
            {
                guessLabel.Text += " " + Form1.guessedNumbers[i];
            }

            Thread.Sleep(250);
            Form1.guessedNumbers.Sort();

            for (int i = 0; i < Form1.guessedNumbers.Count(); i++)
            {
                sortLabel.Text += " " + Form1.guessedNumbers[i];
            }
        }

        private void guessLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
