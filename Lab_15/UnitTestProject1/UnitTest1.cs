using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Lab_15;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGraphAlgorithm()
        {
            // Arrange
            List<int> expectedResult = new List<int>() { 2, 8, 7, 4, 3, 2 };
            Graph graph = new Graph();
            graph.Load(@"..\..\..\G.grf");
            // Act
            List<int> result = graph.ShortestCycleBFS();
            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}