using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using practice_api;

namespace PracticeTest
{
    public class AddTest
    {
        [Fact]
        public void PassingTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.True(false);
        }

        [Fact]
        public void TwoAndThree()
        {
            //Arrange
            string result;
            var controller = new practice_api.Controllers.AddController();
            //Act
            result = controller.Get("2", "3");
            //Assert
            Assert.True(result == "5");
        }
        [Fact]
        public void AddLetters()
        {
            //Arrange
            string result;
            var controller = new practice_api.Controllers.AddController();
            //Act
            result = controller.Get("a", "3");
            //Assert
            Assert.True(result == "Error, Not a Number");
        }
        [Fact]
        public void ReturnOK()
        {
            //Arrange
            
            var controller = new practice_api.Controllers.AddController();
            //Act
            //IHttpActionResult actionResult = controller.Add(2, 3);
            //Assert
            //Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }
    }
        /*
         *New Test Ideas
         * Add really big numbers
         * add decimal numbers
         * add negitive number
         * 
         */
    }
}
