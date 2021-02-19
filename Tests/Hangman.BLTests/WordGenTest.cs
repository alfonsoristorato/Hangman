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
            HandleWord wordGen = new HandleWord
            {
                SecretWord = "alfo"
            };
            string expected = "alfo";


            //Act
            string actual = HandleWord.SecretWord;
            //Assert
            Assert.AreNotEqual(expected, actual);
        }
    }
}
