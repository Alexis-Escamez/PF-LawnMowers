using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LawnMowers.Models;
using System.Collections.Generic;

namespace LawnMowers.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestHandler()
        {
            //Arrange
            const string input= "5 5 1 2 N LMLMLMLMM 3 3 E MMRMMRMRRM";
            List<LawnMowersViewModel> lm = new List<LawnMowersViewModel>();
            lm.Add(new LawnMowersViewModel() { x = 1, y = 3, o = "N", m = "LMLMLMLMM", n = 5 });
            lm.Add(new LawnMowersViewModel() { x = 5, y = 1, o = "E", m = "MMRMMRMRRM", n = 6 });

            //Act
            List<LawnMowersViewModel> expected = new List<LawnMowersViewModel>();
            LawnMowers.Controllers.ProcessData pd = new LawnMowers.Controllers.ProcessData();
            expected = pd.handler(input);

            //Assert
            CollectionAssert.Equals(expected,lm);
        }
    }
}
