using System;
using Hangman.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hangman.BLTests
{
    [TestClass]
    public class WordGenTest
    {
        [TestMethod]
        public void WordGeneratedIsRandomDespiteTestPassingSometimes()
        {
            //Arrange
            WordGen wordGen = new WordGen
            {
                SecretWord = "alfo"
            };
            string expected = "alfo";


            //Act
            string actual = wordGen.SecretWord;
            //Assert
            Assert.AreNotEqual(expected, actual);
        }
    }
}
