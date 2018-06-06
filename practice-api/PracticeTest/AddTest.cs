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
        [Fact]
        public void BigAdd()
        {
            //Arrange
            string result;
            var controller = new practice_api.Controllers.AddController();
            //Act
            result = controller.Get("999988887777666655554444333322221111", "111122223333444455556666777788889999");
            //Assert
            Assert.True(result == "1111111100000000000000000000000000000");
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
