using System;
using System.Windows.Forms;

namespace Ghiceste_numarul
{
    public partial class Form1 : Form
    {
        private int secretNumber;
        private int guessCount;

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random random = new Random();
            secretNumber = random.Next(1, 101);
            guessCount = 0;
            label1.Text = "Guess a number between 1 and 100.";
            textBox1.Text = string.Empty;
            textBox1.Enabled = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess;

            if (int.TryParse(textBox1.Text, out guess))
            {
                guessCount++;

                if (guess == secretNumber)
                {
                    label1.Text = $"Congratulations! You guessed the number {secretNumber} in {guessCount} attempts.";
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                }
                else if (guess < secretNumber)
                {
                    label1.Text = "Too low! Try again.";
                }
                else
                {
                    label1.Text = "Too high! Try again.";
                }
            }
            else
            {
                label1.Text = "Invalid input. Please enter a valid number.";
            }

            textBox1.Text = string.Empty;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}
