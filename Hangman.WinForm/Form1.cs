using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hangman.BL;

namespace Hangman.WinForm
{

    public partial class Hangman : Form
    {
        public Hangman()
        {
            InitializeComponent();
            
        }
        
        List<char> correctGuesses = ProcessGuesses.CorrectGuesses;
        List<char> incorrectGuesses = ProcessGuesses.IncorrectGuesses;
        int lives;
        bool won;

        StringBuilder hiddenWord = HandleWord.hiddenWord;

        public void HideForms()
        {
            LivesCounter.Visible = false;
            LivesCounterTitle.Visible = false;
            Submitter.Visible = false;
            SubmitWord.Visible = false;
            ResultBox.Visible = false;
            PlayingWord.Visible = false;
            IncorrectGuessesBox.Visible = false;
            IncorrectGuessesBoxTitle.Visible = false;
            ErrorMessage.Visible = false;
            RestartApp.Visible = false;
            HintButton.Visible = false;
            HintText.Visible = false;

        }

        public void ShowForms()
        {
            LivesCounterTitle.Visible = true;
            LivesCounter.Visible = true;
            Submitter.Visible = true;
            SubmitWord.Visible = true;
            PlayingWord.Visible = true;
            IncorrectGuessesBox.Visible = true;
            IncorrectGuessesBoxTitle.Visible = true;
            ErrorMessage.Visible = true;
            HintButton.Visible = true;

        }

        public void Form1_Load(object sender, EventArgs e)
        {

            HideForms();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Submitter_Click(object sender, EventArgs e)
        {
            ErrorMessage.Text = "";
            string TextBoxText = SubmitWord.Text;
            char inputLetter()
            {
                if (string.IsNullOrEmpty(TextBoxText))
                {
                    string x = " ";
                    char y = char.Parse(x);
                    ErrorMessage.Text = "You need to insert a letter!";
                    return y;
                }
                else 
                {
                    char x = char.Parse(TextBoxText);
                    return x;
                }
                
            };
            char guessedLetter = inputLetter();
            if (correctGuesses.Contains(guessedLetter))
            {
                ErrorMessage.Text = $"You've already tried '{guessedLetter}' and it was correct!";
            }

            else if (incorrectGuesses.Contains(guessedLetter))
            {
                ErrorMessage.Text = $"You've already tried '{guessedLetter}', and it was wrong!";
            }

            string secretWord = HandleWord.chosenWord;
            if (!won && lives > 0)
            {
                if (secretWord.Contains(guessedLetter))
                {
                    if (!correctGuesses.Contains(guessedLetter))
                    {
                        correctGuesses.Add(guessedLetter);
                    }
                    
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if (guessedLetter == secretWord[i])
                        {
                            hiddenWord[i] = secretWord[i];
                            PlayingWord.Text = hiddenWord.ToString();
                        }
                    }
                }
                else
                {
                    incorrectGuesses.Add(guessedLetter);
                    lives--;
                    LivesCounter.Text = $"{lives}";
                }
                SubmitWord.Clear();
                SubmitWord.Focus();

            }
            var myString = string.Join(" - ", incorrectGuesses);
            IncorrectGuessesBox.Text = myString;
            
            if (PlayingWord.Text == secretWord)
            {
                won = true;
                HideForms();
                RestartApp.Visible = true;
                ResultBox.Visible = true;
                ResultBox.Text = "Congratulations, YOU WON! Click " + RestartApp.Text + " to play again.";
                PlayingWord.Visible = true;

            }
            
            if (lives == 0) 
            {
                HideForms();
                RestartApp.Visible = true;
                ResultBox.Visible = true;
                ResultBox.Text = ("You lost! It was " + secretWord + ". Click " + RestartApp.Text + " to play again.");
                
            }
            if (lives < 3)
            {
                HintButton.Enabled = false;
            }
        }

        private void GenerateWord_Click(object sender, EventArgs e)
        {
            IncorrectGuessesBox.Clear();
            incorrectGuesses.Clear();
            correctGuesses.Clear();
            ShowForms();
            lives = 6;
            won = false;
            PlayingWord.Text = hiddenWord.ToString();
            LivesCounter.Text = $"{lives}";
            GenerateWord.Visible = false;
        }

        private void RestartApp_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void SubmitWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submitter.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void HintButton_Click(object sender, EventArgs e)
        {
            ErrorMessage.Text = "";
            if (lives < 3)
            {
                HintButton.Enabled = false;
            }
            else
            {
                HintText.Visible = true;
                lives -= 2;
                LivesCounter.Text = $"{lives}";
                string secretWord = HandleWord.chosenWord;

                switch (secretWord)
                {
                    case "OXYGEN":
                        HintText.Text = "We need it to survive!";
                        break;
                    case "THUNDER":
                        HintText.Text = "It breaks the sky";
                        break;
                    case "STORM":
                        HintText.Text = "Wets the world";
                        break;
                    case "NORTHERN LIGHTS":
                        HintText.Text = "Same as a rainbow, but without the rain";
                        break;
                    case "GREAT BARRIER REEF":
                        HintText.Text = "A natural underwater 'separator'";
                        break;
                }
                HintButton.Enabled = false;

            }
        }
    }
}
