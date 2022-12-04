using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class Form1 : Form
    {
        private int loses, wins, numToGuess, attempts;
        private int start = 0, end = 10;


        public Form1()
        {
            InitializeComponent();
            NewGame();
        }

        private void NewGame()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            numToGuess = random.Next(1, 10);
            attempts = 3; start = 0; end = 10;
            EnterTextBox.Text = "";
            ControlLabel.Text = "Enter a number";
            GuessButton.Enabled = true;
        }

        private void Guess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(EnterTextBox.Text, out int num))
                Guessing(num);
            else
                ControlLabel.Text = "It seems like you ain't entered a number";
        }

        private void Guess_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                Guess_Click(this, null);
        }
        private void Reset_Click(object sender, EventArgs e) => NewGame();

        private void Guessing(int number)
        {
            if (start >= number || number >= end)
            {
                ControlLabel.Text = "Are you silly?";
                return;
            }

            if (number == numToGuess)
            {
                ControlLabel.Text = "You Won!";
                GuessButton.Enabled = false;
                wins++;
                CorrectCountLabel.Text = "Correclty guessed: " + wins.ToString() + " / " + (loses + wins).ToString();
                return;
            }
            else if (number > numToGuess)
                end = number;
            else
                start = number;

            attempts--;
            if (attempts == 0)
            {
                ControlLabel.Text = "You are out of attempts! Correct answer: " + numToGuess.ToString();
                GuessButton.Enabled = false;
                loses++;
                CorrectCountLabel.Text = "Correclty guessed: " + wins.ToString() + " / " + (loses + wins).ToString();
                return;
            }

            ControlLabel.Text = number > numToGuess ? "Less" : "More";
        }
    }
}
