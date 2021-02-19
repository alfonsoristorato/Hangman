using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.BL
{
    public class HandleWord 
    {
        public HandleWord()
        {

        }

        public static string[] Words = { "OXYGEN", "THUNDER", "STORM", "NORTHERN LIGHTS", "GREAT BARRIER REEF" };
        static readonly List<string> WordsList = new List<string>(Words);

        static Random randWord = new Random();
        public string chosenWord = SecretWord();
        //public static StringBuilder hiddenWord = DisplayToPlayer();

        public static string SecretWord()
        {
            if (WordsList.Count < 1)
                return "There are no more new words!! :(";

            int randWordNumb = randWord.Next(0, WordsList.Count);
            string secretWord = WordsList[randWordNumb];
            WordsList.RemoveAt(randWordNumb);

            return secretWord;

        }

        public StringBuilder DisplayToPlayer()
        {
            StringBuilder displayToPlayer = new StringBuilder(chosenWord.Length);
            for (int i = 0; i < chosenWord.Length; i++)
            {
                if (chosenWord == "There are no more new words!! :(")
                {
                    displayToPlayer.Append(chosenWord);
                    break;
                }
                displayToPlayer.Append("_");
                if (chosenWord[i].Equals(' '))
                {
                    displayToPlayer[i] = chosenWord[i];
                }

            }
            return displayToPlayer;            
        }    
    }
}
