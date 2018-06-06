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
        public void TwoAndThree()
        {
            //Arrange
            string result;
            var controller = new practice_api.Controllers.AddController();
            //Act
            result = controller.Get("2", "3");
            //Assert
            Assert.Equal("5", result);
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
            Assert.Equal("Error, Not a Number", result);
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
            //expect an overflow
            Assert.Equal("Error: Expect 32 bit integer values", result);
        }
        [Fact]
        public void Decimal()
        {
            //Arrange
            string result;
            var controller = new practice_api.Controllers.AddController();
            //Act
            result = controller.Get("9.8", "6.1");
            //Assert
            Assert.Equal("Error: Expecting Integers", result);
        }
        [Fact]
        public void NegAdd()
        {
            //Arrange
            string result;
            var controller = new practice_api.Controllers.AddController();
            //Act
            result = controller.Get("-9", "6");
            //Assert
            Assert.Equal("-3", result);
        }
    }
        /*
         *New Test Ideas
         */
    }
}
