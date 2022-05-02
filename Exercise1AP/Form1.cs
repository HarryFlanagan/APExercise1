using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Exercise1AP
{
    public partial class Form1 : Form
    {
     

        int GuessedWordCount = 0;
        int GuessedLetterCount = 0;
        string wrongLetters = "";
        List<string> HangmanWords = new List<string>() { "Dove", "Bank", "Word", "Hang" };

        public Form1()
        {
            InitializeComponent();

            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;

            bw.DoWork += Bw_DoWork;
            bw.ProgressChanged += Bw_ProgressChanged;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("You cancelled the game");
            }
            else
            {
                MessageBox.Show("You have won the game! The background worker is now complete!");
            }
        }

        private void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           pb.Value = e.ProgressPercentage;
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            GuessedLetterCount = 0;
            GuessedWordCount = 0;
            WordReset();

            while (GuessedWordCount < HangmanWords.Count)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                Thread.Sleep(3000); //Three second break between checks

                //Retrieve letter
                string guessedLetter = string.Empty;
                 guessedLetter = GetLetter();

                if (!string.IsNullOrWhiteSpace(guessedLetter))
                {
                    //Clear guess box
                    txtbxEnterGuess.Text = "";


                    if (HangmanWords[GuessedWordCount].ToUpper().Contains(guessedLetter))
                    {
                        //Correct letter guess
                        GuessedLetterCount++;
                        int index = HangmanWords[GuessedWordCount].ToUpper().IndexOf(guessedLetter);

                        DisplayLetter(index);

                        //All letters guessed
                        if (GuessedLetterCount >= HangmanWords[GuessedWordCount].Length)
                        {
                            GuessedWordCount++;

                            Thread.Sleep(1000);
                            MessageBox.Show("Well done, you guessed the word!");
                            bw.ReportProgress(GetPercentage(GuessedWordCount, HangmanWords.Count));

                             WordReset();

                            if (bw.CancellationPending)
                            {
                                e.Cancel = true;
                                break;
                            }

                            if (GetPercentage(GuessedWordCount, HangmanWords.Count) != 100)
                                MessageBox.Show("Guess this new word by typing letters in the text box and waiting a few seconds until the text box clears – then type another letter, etc.");
                        }
                    }
                    else
                    {
                        //Incorrect letter guess
                        wrongLetters = string.Concat(wrongLetters, guessedLetter, ", ");
                       lblIncorrectGuesses.Text = wrongLetters;
                    }
                }

                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
            }
        }

        public string GetLetter()
        {
            if (!string.IsNullOrWhiteSpace(txtbxEnterGuess.Text))
            {
                return txtbxEnterGuess.Text[0].ToString().ToUpper();
            }
            else return string.Empty;
        }

        public void DisplayLetter(int index)
        {
            switch (index)
            {
                case 0:
                    txtbx1.Text = HangmanWords[GuessedWordCount].ToUpper()[index].ToString();
                    break;

                case 1:
                    txtbx2.Text = HangmanWords[GuessedWordCount].ToUpper()[index].ToString();
                    break;

                case 2:
                    txtbx3.Text = HangmanWords[GuessedWordCount].ToUpper()[index].ToString();
                    break;

                case 3:
                    txtbx4.Text = HangmanWords[GuessedWordCount].ToUpper()[index].ToString();
                    break;

                default:
                    break;
            }
        }

        public void WordReset()
        {
            txtbx1.Text = "";
            txtbx2.Text = "";
            txtbx3.Text = "";
            txtbx4.Text = "";
            txtbxEnterGuess.Text = "";
            lblIncorrectGuesses.Text = "";

            GuessedLetterCount = 0;
            wrongLetters = "";
        }

        public int GetPercentage(double progress, double total)
        {
            int val = (int)Math.Round((progress / total) * 100, 0);
            return val;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            bw.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bw.CancelAsync();
        }
    }
}