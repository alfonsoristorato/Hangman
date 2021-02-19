using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hangman.BL;

namespace Hangman.WebForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            //ErrorMessage.CssClass = "hiddenControls";
            ErrorMessage.Visible = false;
            RestartApp.Visible = false;
            if (PlayingWord.Text.Length < 1)
            {
                HintButton.Enabled = false;
                Submitter.Enabled = false;
            }
            

        }

        List<char> correctGuesses = ProcessGuesses.CorrectGuesses;
        List<char> incorrectGuesses = ProcessGuesses.IncorrectGuesses;

        static StringBuilder hiddenWord;
        static string secretWord;
        static int lives;
        bool won;      

        protected void HideForms()
        {
            //LivesCounter.CssClass = "hiddenControls";
            //LivesCounterTitle.CssClass = "hiddenControls";
            //Submitter.CssClass = "hiddenControls";
            //SubmitWord.CssClass = "hiddenControls";
            //ResultBox.CssClass = "hiddenControls";
            //PlayingWord.CssClass = "hiddenControls";
            //IncorrectGuessesBox.CssClass = "hiddenControls";
            //IncorrectGuessesBoxTitle.CssClass = "hiddenControls";
            //ErrorMessage.CssClass = "hiddenControls";
            //RestartApp.Visible = false;
            //HintButton.CssClass = "hiddenControls";
            //HintText.CssClass = "hiddenControls";
            //GenerateWord.CssClass = "hiddenControls";
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
            GenerateWord.Visible = false;

        }

        protected void ShowForms()
        {
            //LivesCounterTitle.CssClass = "visibleControls";
            //LivesCounter.CssClass = "visibleControls";
            //Submitter.CssClass = "visibleControls";
            //SubmitWord.CssClass = "visibleControls";
            //PlayingWord.CssClass = "visibleControls";
            //IncorrectGuessesBox.CssClass = "visibleControls";
            //IncorrectGuessesBoxTitle.CssClass = "visibleControls";
            ////ErrorMessage.CssClass = "visibleControls";
            //HintButton.CssClass = "visibleControls";
            LivesCounterTitle.Visible = true;
            LivesCounter.Visible = true;
            Submitter.Visible = true;
            SubmitWord.Visible = true;
            PlayingWord.Visible = true;
            IncorrectGuessesBox.Visible = true;
            IncorrectGuessesBoxTitle.Visible = true;
            HintButton.Visible = true;

        }

        protected void GenerateWord_Click(object sender, EventArgs e)
        {
            //IncorrectGuessesBox.Clear();
            HandleWord handleWord = new HandleWord();
            string newSecret = handleWord.chosenWord;
            StringBuilder newHidden = handleWord.DisplayToPlayer();
            hiddenWord = newHidden;
            secretWord = newSecret;
            incorrectGuesses.Clear();
            correctGuesses.Clear();
            ShowForms();
            lives = 6;
            won = false;
            PlayingWord.Text = hiddenWord.ToString();
            LivesCounter.Text = $"{lives}";
            //GenerateWord.CssClass = "visibleControls";
            GenerateWord.Visible = true;
            hangmanImage.ImageUrl = "Images/hangman/lives" + lives + ".png";
            HintButton.Enabled = true;
            Submitter.Enabled = true;
            GenerateWord.Enabled = false;
        }
        protected void Submitter_Click(object sender, EventArgs e)
        {
            //ErrorMessage.CssClass = "hiddenControls";
            ErrorMessage.Visible = false;
            string TextBoxText = SubmitWord.Text.ToUpper();
            char inputLetter()
            {
                if (string.IsNullOrEmpty(TextBoxText))
                {
                    string x = " ";
                    char y = char.Parse(x);
                    //ErrorMessage.CssClass = "visibleControls";
                    ErrorMessage.Visible = true;
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
                //ErrorMessage.CssClass = "visibleControls";
                ErrorMessage.Visible = true;
                ErrorMessage.Text = $"You've already tried '{guessedLetter}' and it was correct!";
            }

            else if (incorrectGuesses.Contains(guessedLetter))
            {
                //ErrorMessage.CssClass = "visibleControls";
                ErrorMessage.Visible = true;
                ErrorMessage.Text = $"You've already tried '{guessedLetter}', and it was wrong!";
            }

            //string secretWord = HandleWord.chosenWord;
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
                SubmitWord.Text = string.Empty;
                SubmitWord.Focus();

            }
            var myString = string.Join(" - ", incorrectGuesses);
            IncorrectGuessesBox.Text = myString;

            if (PlayingWord.Text == secretWord)
            {
                won = true;
                HideForms();
                GenerateWord.Visible = false;
                HintButton.Visible = false;
                RestartApp.Visible = true;
                //ResultBox.CssClass = "visibleControls";
                ResultBox.Visible = true;
                ResultBox.Text = "Congratulations, YOU WON! Click " + RestartApp.Text + " to play again.";
                //PlayingWord.CssClass = "visibleControls";
                PlayingWord.Visible = true;

            }

            if (lives == 0)
            {
                HideForms();
                GenerateWord.Visible = false;
                HintButton.Visible = false;
                RestartApp.Visible = true;
                //ResultBox.CssClass = "visibleControls";
                ResultBox.Visible = true;
                ResultBox.Text = ("You lost! It was " + secretWord + ". Click " + RestartApp.Text + " to play again.");
            }
            if (lives < 3)
            {
                HintButton.Enabled = false;
            }
            hangmanImage.ImageUrl = "Images/hangman/lives" + lives + ".png";
        }

        protected void RestartApp_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }

        //protected void SubmitWord_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        Submitter.PerformClick();
        //        // these last two lines will stop the beep sound
        //        e.SuppressKeyPress = true;
        //        e.Handled = true;
        //    }
        //}

        protected void HintButton_Click(object sender, EventArgs e)
        {
            //ErrorMessage.CssClass = "hiddenControls";
            ErrorMessage.Visible = false;
            if (lives < 3)
            {
                HintButton.Enabled = false;
            }
            else
            {
                //HintText.CssClass = "visibleControls";
                HintText.Visible = true;
                lives -= 2;
                LivesCounter.Text = $"{lives}";

                hangmanImage.ImageUrl = "Images/hangman/lives"+ lives + ".png";
                

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