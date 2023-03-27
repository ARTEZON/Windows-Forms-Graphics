using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_14
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearImage(PictureBox pBox)
        {
            pBox.Image = null;
        }

        private void SetZoomMode(PictureBox pBox)
        {
            if (pBox.Image != null)
            {
                if (pBox.Image.Height > pBox.Height | pBox.Image.Width > pBox.Width)
                    pBox.SizeMode = PictureBoxSizeMode.Zoom;
                else
                    pBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private Bitmap CreateBitmap(BinaryTree tree)
        {
            int horizontalOffset = 0, x, y;
            var coords = new Dictionary<BinaryTreeNode, Tuple<int, int>>();

            GetCoords(tree.Root, 0);

            int w = horizontalOffset * 50 - 5;
            int h = tree.MaxLevel * 60 - 16;
            Bitmap bmp = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush br = new SolidBrush(pictureBox_tree1.BackColor);
            Font font = new Font("Arial", 18, FontStyle.Regular);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            DrawBranches();
            DrawNodes();
            return bmp;

            void GetCoords(BinaryTreeNode current, int depth)
            {
                if (current != null)
                {
                    if (current.Left != null) GetCoords(current.Left, depth + 1);
                    x = horizontalOffset * 50 + 22;
                    y = depth * 60 + 22;
                    horizontalOffset++;
                    coords.Add(current, new Tuple<int, int>(x, y));
                    if (current.Right != null) GetCoords(current.Right, depth + 1);
                }
            }

            void DrawNodes()
            {
                foreach (var i in coords)
                {
                    int thisX = i.Value.Item1;
                    int thisY = i.Value.Item2;
                    g.FillEllipse(br, thisX - 20, thisY - 20, 40, 40);
                    g.DrawEllipse(pen, thisX - 20, thisY - 20, 40, 40);
                    string valueString = i.Key.Value.ToString();
                    g.DrawString(valueString, font, Brushes.Black, thisX - g.MeasureString(valueString, font).ToSize().Width / 2, thisY - 14);
                }
            }

            void DrawBranches()
            {
                foreach (var i in coords)
                {
                    int thisX = i.Value.Item1;
                    int thisY = i.Value.Item2;
                    if (i.Key.Parent != null) g.DrawLine(pen, coords[i.Key.Parent].Item1, coords[i.Key.Parent].Item2, thisX, thisY);
                }
            }
        }

        private void button_makeTree_Click(object sender, EventArgs e)
        {
            string input = this.textBox_treeSequenceInput.Text;
            int[] seq;
            try
            {
                seq = input.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
                if (seq.Length == 0) throw new InvalidOperationException("Последовательность пуста. Введите хотя бы одно число.");
            }
            catch (Exception ex) when (
                ex is FormatException ||
                ex is OverflowException ||
                ex is InvalidOperationException)
            {
                string title = "Неверный ввод";
                string msg = "";
                if (ex is FormatException) msg = "Введённая строка должна состоять только из целых чисел и пробелов между ними.";
                else if (ex is OverflowException) msg = "Одно или несколько из введённых чисел находятся вне допустимого диапазона.\n\nПожалуйста, используйте числа от -2147483648 до 2147483647.";
                else if (ex is InvalidOperationException) msg = ex.Message;
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            label_act1.Text = "Нажмите кнопку, чтобы выполнить преобразование";
            label_act1.ForeColor = Color.Black;
            label_act2.Text = "Нажмите кнопку, чтобы вычислить показатель";
            label_act2.ForeColor = Color.Black;

            Data.Tree = new BinaryTree(seq);
            Data.ProcessedTree = null;

            pictureBox_tree1.Image = CreateBitmap(Data.Tree);
            ClearImage(pictureBox_tree2);
            SetZoomMode(pictureBox_tree1);
        }

        private void button_act1_Click(object sender, EventArgs e)
        {
            if (Data.Tree == null)
            {
                MessageBox.Show($"Перед обработкой дерева нужно сначала его построить.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Data.ProcessedTree = new BinaryTree(Data.Tree);
            Data.ProcessedTree.ReplaceEvenNumbersWithZero();
            if (Data.ProcessedTree.IsBinarySearchTree())
            {
                label_act1.Text = "Обработанное дерево осталось деревом двоичного поиска";
                label_act1.ForeColor = Color.Green;
            }
            else
            {
                label_act1.Text = "Обработанное дерево больше не является деревом двоичного поиска";
                label_act1.ForeColor = Color.Red;
            }

            // try { Data.ProcessedTree.SaveTree(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)); }
            // catch (Exception ex)
            // {
            //     MessageBox.Show($"Ошибка: {ex.Message}\n\nФайл не был сохранён.",
            //     "Ошибка при сохранении файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }

            pictureBox_tree2.Image = CreateBitmap(Data.ProcessedTree);
            SetZoomMode(pictureBox_tree2);
        }

        private void button_act2_Click(object sender, EventArgs e)
        {
            if (Data.Tree == null)
            {
                MessageBox.Show($"Перед вычислением показателя нужно сначала построить дерево.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int minEvenInBranches = Data.Tree.FindMinEvenNumberInBranches();
            if (minEvenInBranches != int.MaxValue)
            {
                label_act2.Text = "Результат: " + minEvenInBranches.ToString();
                label_act2.ForeColor = Color.Green;
            }
            else
            {
                label_act2.Text = "Среди ветвей дерева чётные элементы не найдены.";
                label_act2.ForeColor = Color.Red;
            }
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            SetZoomMode(pictureBox_tree1);
            SetZoomMode(pictureBox_tree2);
        }
    }
}