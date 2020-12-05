using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.BL
{
    public class HandleWord 
    {

        public static string[] Words = { "OXYGEN", "THUNDER", "STORM", "NORTHERN LIGHTS", "GREAT BARRIER REEF" };
        private static string _secretWord;

        public static string SecretWord
        {
            get
            {
                Random randWord = new Random();
                int randWordNumb = randWord.Next(Words.Length);
                return Words[randWordNumb];
               
            }
            set { _secretWord = value; }
        }
        public static string chosenWord = SecretWord;
        public static StringBuilder hiddenWord = DisplayToPlayer();

        private StringBuilder _displayToPlayer;

        public static StringBuilder DisplayToPlayer()
        {
            StringBuilder displayToPlayer = new StringBuilder(chosenWord.Length);
            for (int i = 0; i < chosenWord.Length; i++)
            {
                displayToPlayer.Append("*");
                if (chosenWord[i].Equals(' '))
                {
                    displayToPlayer[i] = chosenWord[i];
                }
                

            }
            return displayToPlayer;
            
        }





    }
}
