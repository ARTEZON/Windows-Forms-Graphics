namespace Lab_14
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_act1 = new System.Windows.Forms.Label();
            this.button_act1 = new System.Windows.Forms.Button();
            this.button_act2 = new System.Windows.Forms.Button();
            this.label_act2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_treeSequenceInput = new System.Windows.Forms.TextBox();
            this.button_makeTree = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_tree2 = new System.Windows.Forms.Label();
            this.pictureBox_tree2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_tree1 = new System.Windows.Forms.PictureBox();
            this.label_tree1 = new System.Windows.Forms.Label();
            this.label_hint = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tree1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_act1
            // 
            this.label_act1.AutoSize = true;
            this.label_act1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_act1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_act1.Location = new System.Drawing.Point(375, 0);
            this.label_act1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.label_act1.Name = "label_act1";
            this.label_act1.Size = new System.Drawing.Size(366, 33);
            this.label_act1.TabIndex = 3;
            this.label_act1.Text = "Нажмите кнопку, чтобы выполнить преобразование";
            this.label_act1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_act1
            // 
            this.button_act1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_act1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_act1.Location = new System.Drawing.Point(3, 3);
            this.button_act1.Name = "button_act1";
            this.button_act1.Size = new System.Drawing.Size(366, 28);
            this.button_act1.TabIndex = 0;
            this.button_act1.Text = "Заменить чётные элементы дерева нулём";
            this.button_act1.UseVisualStyleBackColor = true;
            this.button_act1.Click += new System.EventHandler(this.button_act1_Click);
            // 
            // button_act2
            // 
            this.button_act2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_act2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_act2.Location = new System.Drawing.Point(3, 37);
            this.button_act2.Name = "button_act2";
            this.button_act2.Size = new System.Drawing.Size(366, 28);
            this.button_act2.TabIndex = 2;
            this.button_act2.Text = "Найти наименьший чётный элемент среди ветвей дерева";
            this.button_act2.UseVisualStyleBackColor = true;
            this.button_act2.Click += new System.EventHandler(this.button_act2_Click);
            // 
            // label_act2
            // 
            this.label_act2.AutoSize = true;
            this.label_act2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_act2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_act2.Location = new System.Drawing.Point(375, 34);
            this.label_act2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.label_act2.Name = "label_act2";
            this.label_act2.Size = new System.Drawing.Size(366, 33);
            this.label_act2.TabIndex = 4;
            this.label_act2.Text = "Нажмите кнопку, чтобы вычислить показатель";
            this.label_act2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label_act2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_act2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_act1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_act1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 109);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(744, 68);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_treeSequenceInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_makeTree, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(744, 34);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_treeSequenceInput
            // 
            this.textBox_treeSequenceInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_treeSequenceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_treeSequenceInput.Location = new System.Drawing.Point(3, 3);
            this.textBox_treeSequenceInput.Name = "textBox_treeSequenceInput";
            this.textBox_treeSequenceInput.Size = new System.Drawing.Size(507, 37);
            this.textBox_treeSequenceInput.TabIndex = 0;
            // 
            // button_makeTree
            // 
            this.button_makeTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_makeTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_makeTree.Location = new System.Drawing.Point(516, 2);
            this.button_makeTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.button_makeTree.Name = "button_makeTree";
            this.button_makeTree.Size = new System.Drawing.Size(225, 29);
            this.button_makeTree.TabIndex = 1;
            this.button_makeTree.Text = "Построить дерево";
            this.button_makeTree.UseVisualStyleBackColor = true;
            this.button_makeTree.Click += new System.EventHandler(this.button_makeTree_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(9, 102);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(744, 7);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(9, 177);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(744, 7);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label_tree2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox_tree2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox_tree1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label_tree1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 184);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(744, 281);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label_tree2
            // 
            this.label_tree2.AutoSize = true;
            this.label_tree2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tree2.Location = new System.Drawing.Point(375, 5);
            this.label_tree2.Name = "label_tree2";
            this.label_tree2.Size = new System.Drawing.Size(361, 20);
            this.label_tree2.TabIndex = 3;
            this.label_tree2.Text = "Обработанное дерево";
            this.label_tree2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_tree2
            // 
            this.pictureBox_tree2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_tree2.Location = new System.Drawing.Point(377, 31);
            this.pictureBox_tree2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox_tree2.Name = "pictureBox_tree2";
            this.pictureBox_tree2.Size = new System.Drawing.Size(357, 269);
            this.pictureBox_tree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_tree2.TabIndex = 1;
            this.pictureBox_tree2.TabStop = false;
            // 
            // pictureBox_tree1
            // 
            this.pictureBox_tree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_tree1.Location = new System.Drawing.Point(10, 31);
            this.pictureBox_tree1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox_tree1.Name = "pictureBox_tree1";
            this.pictureBox_tree1.Size = new System.Drawing.Size(356, 269);
            this.pictureBox_tree1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_tree1.TabIndex = 0;
            this.pictureBox_tree1.TabStop = false;
            // 
            // label_tree1
            // 
            this.label_tree1.AutoSize = true;
            this.label_tree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tree1.Location = new System.Drawing.Point(8, 5);
            this.label_tree1.Name = "label_tree1";
            this.label_tree1.Size = new System.Drawing.Size(360, 20);
            this.label_tree1.TabIndex = 2;
            this.label_tree1.Text = "Исходное дерево";
            this.label_tree1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_hint
            // 
            this.label_hint.AutoSize = true;
            this.label_hint.BackColor = System.Drawing.Color.Transparent;
            this.label_hint.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hint.Location = new System.Drawing.Point(3, 3);
            this.label_hint.Margin = new System.Windows.Forms.Padding(3);
            this.label_hint.Name = "label_hint";
            this.label_hint.Padding = new System.Windows.Forms.Padding(0, 2, 0, 8);
            this.label_hint.Size = new System.Drawing.Size(738, 54);
            this.label_hint.TabIndex = 7;
            this.label_hint.Text = "Введите последовательность целых чисел, разделённых пробелом и нажмите на кнопку " +
    "«Построить дерево».";
            this.label_hint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label_hint, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(9, 8);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(744, 60);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(762, 473);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(780, 520);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Text = "Бинарные деревья";
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tree1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_act1;
        private System.Windows.Forms.Button button_act1;
        private System.Windows.Forms.Button button_act2;
        private System.Windows.Forms.Label label_act2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox_tree1;
        private System.Windows.Forms.TextBox textBox_treeSequenceInput;
        private System.Windows.Forms.Button button_makeTree;
        private System.Windows.Forms.Label label_hint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label_tree2;
        private System.Windows.Forms.PictureBox pictureBox_tree2;
        private System.Windows.Forms.Label label_tree1;
    }
}

