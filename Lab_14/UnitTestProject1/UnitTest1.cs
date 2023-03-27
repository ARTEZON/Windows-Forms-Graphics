using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_14;
using System;
using System.IO;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProcessing()
        {
            // Arrange
            var tree = new BinaryTree(7, 3, 1, 0, 2, 6, 4, 5, 12, 9, 8, 11, 10, 13, 15, 14);
            var expected = new BinaryTree(7, 3, 1, 0, 0, 0, 0, 5, 0, 9, 0, 11, 0, 13, 15, 0);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // Act
            tree.ReplaceEvenNumbersWithZero();
            tree.SaveTree(desktopPath);
            string seqFromFile = File.ReadAllText(desktopPath + @"\tree.res");
            int[] seq = seqFromFile.Split(' ').Select(x => int.Parse(x)).ToArray();
            var treeFromFile = new BinaryTree(seq);
            // Assert
            Assert.IsTrue(treeFromFile.Equals(expected));
        }
    }
}