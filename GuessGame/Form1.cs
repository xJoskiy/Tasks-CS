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
        int loses, wins, numToGuess, attempts;
        int start = 0, end = 10;


        public Form1()
        {
            InitializeComponent();

            Start();
        }
        private void Start()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            numToGuess = random.Next(1, 10);
            attempts = 3; start = 0; end = 10;
            label2.Text = "Entert a number";
            textBox1.Text = "";
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num))
                Guessing(num);
            else
                label2.Text = "It seems like you ain't entered a number";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Guessing(int number)
        {
            if (start >= number || number >= end)
            {
                label2.Text = "Are you silly?";
                return;
            }

            if (number == numToGuess)
            {
                label2.Text = "You Won!";
                button1.Enabled = false;
                wins++;
                label3.Text = "Correclty guessed: " + wins.ToString() + " / " + (loses + wins).ToString();
                return;
            }
            else if (number > numToGuess)
                end = number;
            else
                start = number;

            attempts--;
            if (attempts == 0)
            {
                label2.Text = "You are out of attempts! Correct answer: " + numToGuess.ToString();
                button1.Enabled = false;
                loses++;
                label3.Text = "Correclty guessed: " + wins.ToString() + " / " + (loses + wins).ToString();
                return;
            }
           
            label2.Text = number > numToGuess ? "Less" : "More";
        }
    }
}
