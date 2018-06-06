using System;
using System.Collections.Generic;
using System.Text;
using practice_api.Controllers;
using Xunit;

namespace PracticeTest
{
    public class ModTest : IClassFixture<ModController>
    {
        ModController modCont;

        public ModTest(ModController modCont)
        {
            this.modCont = modCont;
        }

        [Fact]
        public void IfValidValuesArePassedIn()
        {
            string value1 = "5";
            string value2 = "2";

            var result = modCont.Get(value1, value2);

            Assert.Equal("1", result);
        }

        [Fact]
        public void IfDecmialValuesArePassedIn()
        {
            string value1 = "5.0";
            string value2 = "2.0";

            string errorMessage = "Invalid input";

            var result = modCont.Get(value1, value2);

            Assert.Equal(errorMessage, result);
        }

        [Fact]
        public void IfEmptyStringValuesArePassedIn()
        {
            string value1 ="";
            string value2 ="";

            string errorMessage = "Invalid input";
            var result = modCont.Get(value1, value2);

            Assert.Equal(errorMessage, result);
        }

        [Fact]
        public void IfNullValuesArePassedIn()
        {
            string value1 = null;
            string value2 = null;

            string errorMessage = "Null input";
            var result = modCont.Get(value1, value2);

            Assert.Equal(errorMessage, result);
        }

        [Fact]
        public void IfStringOfLettersPassedIn()
        {
            string value1 = "abc";
            string value2 = "abcd";

            string errorMessage = "Invalid input";
            var result = modCont.Get(value1, value2);

            Assert.Equal(errorMessage, result);
        }

        [Fact]
        public void IfParenthesesAroundValidNumbersArePassedIn()
        {
            string value1 = "(10)";
            string value2 = "(5)";

            string errorMessage = "Invalid input";
            var result = modCont.Get(value1, value2);

            Assert.Equal(errorMessage, result);
        }

    }
}
