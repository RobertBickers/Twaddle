﻿using Bickers.Twaddle.Core;
using NUnit.Framework;

namespace Tests.UnitTesting.Color
{
    [TestFixture]
    public class ColourTest
    {
        [Test()]
        public void GenerateColour_WithoutArgs_7CharacterStringReturned()
        {
            int expectedNumberOfCharacters = 7;
            string colourString = Twaddle.Colour.GenerateColourString();

            int actualNumberOfCharacters = colourString.Length;

            Assert.AreEqual(expectedNumberOfCharacters, actualNumberOfCharacters, "Colour string does not have the expected number of characters");
        }

        [Test()]
        public void GenerateColour_WithoutArgs_StringStartsWithHash()
        {
            string expectedStartingCharacter = "#";

            string colourString = Twaddle.Colour.GenerateColourString();

            Assert.IsTrue(colourString.StartsWith(expectedStartingCharacter), "Colour string does not start with a hash (#) character");
        }

        [Test()]
        public void Generatecolour_WithoutArgs_ColourCanBeParsedBySystemDrawingColour()
        {
            string colourString = Twaddle.Colour.GenerateColourString();

            System.Drawing.Color convertedColour = System.Drawing.ColorTranslator.FromHtml(colourString);

            Assert.IsFalse(convertedColour.IsEmpty, "Colour string has not been generated");
            Assert.IsTrue(convertedColour.R > 0, "Red channel doesn't have any value");
            Assert.IsTrue(convertedColour.G > 0, "Green channel doesn't have any value");
            Assert.IsTrue(convertedColour.B > 0, "Blue channel doesn't have any value");
        }

        [Test()]
        public void GenerateColour_WithoutArgs_ColorReturned()
        {
            System.Drawing.Color color = Twaddle.Colour.GenerateColour();

            Assert.IsFalse(color.IsEmpty, "Colour string has not been initialised");
            Assert.IsTrue(color.R != 0);
            Assert.IsTrue(color.G != 0);
            Assert.IsTrue(color.B != 0);
        }
    }
}