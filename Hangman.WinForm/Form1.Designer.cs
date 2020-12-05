namespace Hangman.WinForm
{
    partial class Hangman
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
            this.PlayingWord = new System.Windows.Forms.Label();
            this.SubmitWord = new System.Windows.Forms.TextBox();
            this.Submitter = new System.Windows.Forms.Button();
            this.IncorrectGuessesBox = new System.Windows.Forms.TextBox();
            this.IncorrectGuessesBoxTitle = new System.Windows.Forms.Label();
            this.LivesCounter = new System.Windows.Forms.Label();
            this.GenerateWord = new System.Windows.Forms.Button();
            this.LivesCounterTitle = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.RestartApp = new System.Windows.Forms.Button();
            this.HintText = new System.Windows.Forms.Label();
            this.HintButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayingWord
            // 
            this.PlayingWord.AccessibleName = "";
            this.PlayingWord.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayingWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayingWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayingWord.Location = new System.Drawing.Point(367, 278);
            this.PlayingWord.Name = "PlayingWord";
            this.PlayingWord.Size = new System.Drawing.Size(300, 50);
            this.PlayingWord.TabIndex = 0;
            this.PlayingWord.Tag = "";
            this.PlayingWord.Text = "Word to Guess";
            this.PlayingWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubmitWord
            // 
            this.SubmitWord.AccessibleName = "";
            this.SubmitWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SubmitWord.Location = new System.Drawing.Point(462, 105);
            this.SubmitWord.MaxLength = 1;
            this.SubmitWord.Name = "SubmitWord";
            this.SubmitWord.Size = new System.Drawing.Size(30, 20);
            this.SubmitWord.TabIndex = 1;
            this.SubmitWord.Tag = "";
            this.SubmitWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SubmitWord_KeyDown);
            // 
            // Submitter
            // 
            this.Submitter.AccessibleName = "";
            this.Submitter.Location = new System.Drawing.Point(498, 103);
            this.Submitter.Name = "Submitter";
            this.Submitter.Size = new System.Drawing.Size(75, 23);
            this.Submitter.TabIndex = 2;
            this.Submitter.Tag = "";
            this.Submitter.Text = "Submit";
            this.Submitter.UseVisualStyleBackColor = true;
            this.Submitter.Click += new System.EventHandler(this.Submitter_Click);
            // 
            // IncorrectGuessesBox
            // 
            this.IncorrectGuessesBox.AccessibleName = "";
            this.IncorrectGuessesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectGuessesBox.Location = new System.Drawing.Point(207, 512);
            this.IncorrectGuessesBox.Name = "IncorrectGuessesBox";
            this.IncorrectGuessesBox.ReadOnly = true;
            this.IncorrectGuessesBox.Size = new System.Drawing.Size(620, 26);
            this.IncorrectGuessesBox.TabIndex = 3;
            this.IncorrectGuessesBox.Tag = "";
            this.IncorrectGuessesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IncorrectGuessesBoxTitle
            // 
            this.IncorrectGuessesBoxTitle.AccessibleName = "";
            this.IncorrectGuessesBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectGuessesBoxTitle.ForeColor = System.Drawing.Color.Red;
            this.IncorrectGuessesBoxTitle.Location = new System.Drawing.Point(396, 474);
            this.IncorrectGuessesBoxTitle.Name = "IncorrectGuessesBoxTitle";
            this.IncorrectGuessesBoxTitle.Size = new System.Drawing.Size(242, 25);
            this.IncorrectGuessesBoxTitle.TabIndex = 4;
            this.IncorrectGuessesBoxTitle.Tag = "";
            this.IncorrectGuessesBoxTitle.Text = "Incorrect Guesses";
            this.IncorrectGuessesBoxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LivesCounter
            // 
            this.LivesCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LivesCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesCounter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LivesCounter.Location = new System.Drawing.Point(874, 66);
            this.LivesCounter.Name = "LivesCounter";
            this.LivesCounter.Size = new System.Drawing.Size(125, 61);
            this.LivesCounter.TabIndex = 5;
            this.LivesCounter.Text = "6";
            this.LivesCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerateWord
            // 
            this.GenerateWord.Location = new System.Drawing.Point(874, 273);
            this.GenerateWord.Name = "GenerateWord";
            this.GenerateWord.Size = new System.Drawing.Size(114, 83);
            this.GenerateWord.TabIndex = 6;
            this.GenerateWord.Text = "Generate a Word";
            this.GenerateWord.UseVisualStyleBackColor = true;
            this.GenerateWord.Click += new System.EventHandler(this.GenerateWord_Click);
            // 
            // LivesCounterTitle
            // 
            this.LivesCounterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesCounterTitle.ForeColor = System.Drawing.Color.Red;
            this.LivesCounterTitle.Location = new System.Drawing.Point(874, 21);
            this.LivesCounterTitle.Name = "LivesCounterTitle";
            this.LivesCounterTitle.Size = new System.Drawing.Size(125, 45);
            this.LivesCounterTitle.TabIndex = 7;
            this.LivesCounterTitle.Text = "Lives Counter";
            this.LivesCounterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultBox
            // 
            this.ResultBox.AccessibleName = "";
            this.ResultBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.Location = new System.Drawing.Point(12, 9);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(328, 129);
            this.ResultBox.TabIndex = 8;
            this.ResultBox.Tag = "";
            this.ResultBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(401, 128);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(230, 41);
            this.ErrorMessage.TabIndex = 9;
            this.ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestartApp
            // 
            this.RestartApp.Location = new System.Drawing.Point(874, 381);
            this.RestartApp.Name = "RestartApp";
            this.RestartApp.Size = new System.Drawing.Size(114, 83);
            this.RestartApp.TabIndex = 10;
            this.RestartApp.Text = "Start a new Game";
            this.RestartApp.UseVisualStyleBackColor = true;
            this.RestartApp.Click += new System.EventHandler(this.RestartApp_Click);
            // 
            // HintText
            // 
            this.HintText.ForeColor = System.Drawing.Color.Red;
            this.HintText.Location = new System.Drawing.Point(345, 346);
            this.HintText.Name = "HintText";
            this.HintText.Size = new System.Drawing.Size(345, 41);
            this.HintText.TabIndex = 11;
            this.HintText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HintButton
            // 
            this.HintButton.Location = new System.Drawing.Point(874, 167);
            this.HintButton.Name = "HintButton";
            this.HintButton.Size = new System.Drawing.Size(114, 83);
            this.HintButton.TabIndex = 12;
            this.HintButton.Text = "Hint? \r\n(It will cost 2 lives)";
            this.HintButton.UseVisualStyleBackColor = true;
            this.HintButton.Click += new System.EventHandler(this.HintButton_Click);
            // 
            // Hangman
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1034, 606);
            this.Controls.Add(this.HintButton);
            this.Controls.Add(this.HintText);
            this.Controls.Add(this.RestartApp);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.LivesCounterTitle);
            this.Controls.Add(this.GenerateWord);
            this.Controls.Add(this.LivesCounter);
            this.Controls.Add(this.IncorrectGuessesBoxTitle);
            this.Controls.Add(this.IncorrectGuessesBox);
            this.Controls.Add(this.Submitter);
            this.Controls.Add(this.SubmitWord);
            this.Controls.Add(this.PlayingWord);
            this.Controls.Add(this.ResultBox);
            this.MaximizeBox = false;
            this.Name = "Hangman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayingWord;
        private System.Windows.Forms.TextBox SubmitWord;
        private System.Windows.Forms.Button Submitter;
        private System.Windows.Forms.TextBox IncorrectGuessesBox;
        private System.Windows.Forms.Label IncorrectGuessesBoxTitle;
        private System.Windows.Forms.Label LivesCounter;
        private System.Windows.Forms.Button GenerateWord;
        private System.Windows.Forms.Label LivesCounterTitle;
        private System.Windows.Forms.Label ResultBox;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.Button RestartApp;
        private System.Windows.Forms.Label HintText;
        private System.Windows.Forms.Button HintButton;
    }
}

