using System;
using Xunit;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using practice_api;
using practice_api.Controllers;


namespace PracticeTest
{
    public class MultiplyTest
    {
        private MultiplyController _controller = new MultiplyController();

        [Fact]
        public void TestGetValidInputs()
        {
            string expected = "20";
            string actual = _controller.Get("20", "1");

            Assert.Equal(expected,actual);
        }

        [Fact]
        public void TestGetValidInputs1()
        {
            string expected = "-20";
            string actual = _controller.Get("-20", "1");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetValidInputs2()
        {
            string expected = "-20";
            string actual = _controller.Get("+20", "-1");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetInValidInputs()
        {
            string expected = "";
            string actual = _controller.Get("abc", "1");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetInValidInputs1()
        {
            string expected = "";
            string actual = _controller.Get("1", "abc");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetInValidInputs2()
        {
            string expected = "";
            string actual = _controller.Get("(1)", "(1)");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetInValidInputs3()
        {
            string expected = "";
            string actual = _controller.Get("", "");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetInValidInputs4()
        {
            string expected = "";
            string actual = _controller.Get(null, null);

            Assert.Equal(expected, actual);
        }



    }
}
