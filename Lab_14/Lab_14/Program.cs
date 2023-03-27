using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab_14
{
    public class BinaryTreeNode : IComparable<BinaryTreeNode>
    {
        public int Value;
        public int Level;
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;
        public BinaryTreeNode Parent;
        public BinaryTreeNode(int value, int level, BinaryTreeNode parent)
        { Value = value; Level = level; Parent = parent; }
        public int CompareTo(BinaryTreeNode other) => Value.CompareTo(other.Value);
    }

    public class BinaryTree
    {
        BinaryTreeNode root;
        int maxLevel;

        public BinaryTree(params int[] sequence)
        { foreach (int i in sequence) Add(i); }

        public BinaryTree(BinaryTree copyFrom)
        {
            void PreorderTraversal(BinaryTreeNode node)
            {
                if (node != null)
                {
                    this.Add(node.Value);
                    PreorderTraversal(node.Left);
                    PreorderTraversal(node.Right);
                }
            }

            PreorderTraversal(copyFrom.root);
        }

        public int MaxLevel
        { get => maxLevel; }

        public BinaryTreeNode Root
        { get => root; }

        public void Add(int value)
        {
            void AddNode(ref BinaryTreeNode node, int currentLevel, BinaryTreeNode parent)
            {
                maxLevel = Math.Max(maxLevel, currentLevel);
                if (node == null)
                    node = new BinaryTreeNode(value, currentLevel, parent);
                else if (value < node.Value)
                    AddNode(ref node.Left, currentLevel + 1, node);
                else if (value > node.Value)
                    AddNode(ref node.Right, currentLevel + 1, node);
            }

            AddNode(ref root, 1, null);
        }

        public void ReplaceEvenNumbersWithZero()
        {
            void ReplaceEvenNumbersWithZero(BinaryTreeNode node)
            {
                if (node != null)
                {
                    if (node.Value % 2 == 0) node.Value = 0;
                    ReplaceEvenNumbersWithZero(node.Left);
                    ReplaceEvenNumbersWithZero(node.Right);
                }
            }

            ReplaceEvenNumbersWithZero(root);
        }

        public void SaveTree(string fileSavePath = "")
        {
            if (fileSavePath == null) fileSavePath = Application.StartupPath;
            StreamWriter f = new StreamWriter(Path.Combine(fileSavePath, "tree.res"));
            f.Write(this.ToString());
            f.Close();
        }

        public override string ToString()
        {
            const string sep = " ";
            List<int> sequence = new List<int>();

            void PreorderTraversal(BinaryTreeNode node)
            {
                if (node != null)
                {
                    sequence.Add(node.Value);
                    PreorderTraversal(node.Left);
                    PreorderTraversal(node.Right);
                }
            }

            PreorderTraversal(root);
            return String.Join(sep, sequence);
        }

        public int FindMinEvenNumberInBranches()
        {
            int FindMinEvenNumberInBranches(BinaryTreeNode node)
            {
                if (node != null)
                {
                    if (node.Left != null || node.Right != null)
                    {
                        if (node.Value % 2 == 0) return Math.Min(node.Value, Math.Min(FindMinEvenNumberInBranches(node.Left), FindMinEvenNumberInBranches(node.Right)));
                        else return Math.Min(FindMinEvenNumberInBranches(node.Left), FindMinEvenNumberInBranches(node.Right));
                    }
                    else return int.MaxValue;
                }
                else return int.MaxValue;
            }

            return FindMinEvenNumberInBranches(root);
        }

        public bool IsBinarySearchTree()
        {
            bool Check(BinaryTreeNode node, int min, int max)
            {
                if (node == null) return true;
                if (node.Value <= min || node.Value >= max) return false;
                return Check(node.Left, min, node.Value) && Check(node.Right, node.Value, max);
            }

            return Check(root, int.MinValue, int.MaxValue);
        }

        public bool Equals(BinaryTree tree) => this.ToString().Equals(tree.ToString());
    }

    static class Data
    {
        public static BinaryTree Tree;
        public static BinaryTree ProcessedTree;
    }

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}