namespace Lab_16
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_draw = new System.Windows.Forms.Button();
            this.label_const = new System.Windows.Forms.Label();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.pictureBox_func = new System.Windows.Forms.PictureBox();
            this.label_A = new System.Windows.Forms.Label();
            this.rightMenu = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.userInputContainer = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.label_B = new System.Windows.Forms.Label();
            this.label_func = new System.Windows.Forms.Label();
            this.zedGraphControl = new ZedGraph.ZedGraphControl();
            this.container = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_func)).BeginInit();
            this.rightMenu.SuspendLayout();
            this.userInputContainer.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_draw
            // 
            this.button_draw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_draw.Location = new System.Drawing.Point(13, 506);
            this.button_draw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(199, 37);
            this.button_draw.TabIndex = 1;
            this.button_draw.Text = "Построить";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
            // 
            // label_const
            // 
            this.label_const.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_const.Location = new System.Drawing.Point(13, 83);
            this.label_const.Name = "label_const";
            this.label_const.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label_const.Size = new System.Drawing.Size(199, 37);
            this.label_const.TabIndex = 8;
            this.label_const.Text = "Введите значения констант";
            this.label_const.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBox_A
            // 
            this.textBox_A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_A.Location = new System.Drawing.Point(24, 6);
            this.textBox_A.Margin = new System.Windows.Forms.Padding(11, 6, 7, 6);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(173, 26);
            this.textBox_A.TabIndex = 2;
            this.textBox_A.TextChanged += new System.EventHandler(this.textBox_A_TextChanged);
            // 
            // pictureBox_func
            // 
            this.pictureBox_func.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_func.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_func.Image")));
            this.pictureBox_func.Location = new System.Drawing.Point(13, 25);
            this.pictureBox_func.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_func.Name = "pictureBox_func";
            this.pictureBox_func.Size = new System.Drawing.Size(199, 58);
            this.pictureBox_func.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_func.TabIndex = 6;
            this.pictureBox_func.TabStop = false;
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_A.Location = new System.Drawing.Point(0, 0);
            this.label_A.Margin = new System.Windows.Forms.Padding(0);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(13, 38);
            this.label_A.TabIndex = 4;
            this.label_A.Text = "A";
            this.label_A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightMenu
            // 
            this.rightMenu.Controls.Add(this.button_clear);
            this.rightMenu.Controls.Add(this.splitter1);
            this.rightMenu.Controls.Add(this.button_draw);
            this.rightMenu.Controls.Add(this.userInputContainer);
            this.rightMenu.Controls.Add(this.label_const);
            this.rightMenu.Controls.Add(this.pictureBox_func);
            this.rightMenu.Controls.Add(this.label_func);
            this.rightMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightMenu.Location = new System.Drawing.Point(754, 12);
            this.rightMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightMenu.Name = "rightMenu";
            this.rightMenu.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.rightMenu.Size = new System.Drawing.Size(212, 543);
            this.rightMenu.TabIndex = 9;
            // 
            // button_clear
            // 
            this.button_clear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_clear.Location = new System.Drawing.Point(13, 457);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(199, 37);
            this.button_clear.TabIndex = 10;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(13, 494);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(199, 12);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // userInputContainer
            // 
            this.userInputContainer.ColumnCount = 2;
            this.userInputContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.userInputContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.userInputContainer.Controls.Add(this.textBox_B, 1, 1);
            this.userInputContainer.Controls.Add(this.label_A, 0, 0);
            this.userInputContainer.Controls.Add(this.label_B, 0, 1);
            this.userInputContainer.Controls.Add(this.textBox_A, 1, 0);
            this.userInputContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.userInputContainer.Location = new System.Drawing.Point(13, 120);
            this.userInputContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userInputContainer.Name = "userInputContainer";
            this.userInputContainer.RowCount = 2;
            this.userInputContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userInputContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userInputContainer.Size = new System.Drawing.Size(199, 76);
            this.userInputContainer.TabIndex = 9;
            // 
            // textBox_B
            // 
            this.textBox_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_B.Location = new System.Drawing.Point(24, 44);
            this.textBox_B.Margin = new System.Windows.Forms.Padding(11, 6, 7, 6);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(173, 26);
            this.textBox_B.TabIndex = 6;
            this.textBox_B.TextChanged += new System.EventHandler(this.textBox_B_TextChanged);
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_B.Location = new System.Drawing.Point(0, 38);
            this.label_B.Margin = new System.Windows.Forms.Padding(0);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(13, 38);
            this.label_B.TabIndex = 5;
            this.label_B.Text = "B";
            this.label_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_func
            // 
            this.label_func.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_func.Location = new System.Drawing.Point(13, 0);
            this.label_func.Name = "label_func";
            this.label_func.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label_func.Size = new System.Drawing.Size(199, 25);
            this.label_func.TabIndex = 7;
            this.label_func.Text = "Функция";
            this.label_func.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // zedGraphControl
            // 
            this.zedGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl.IsAntiAlias = true;
            this.zedGraphControl.IsAutoScrollRange = true;
            this.zedGraphControl.Location = new System.Drawing.Point(13, 12);
            this.zedGraphControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.zedGraphControl.Name = "zedGraphControl";
            this.zedGraphControl.ScrollGrace = 0D;
            this.zedGraphControl.ScrollMaxX = 0D;
            this.zedGraphControl.ScrollMaxY = 0D;
            this.zedGraphControl.ScrollMaxY2 = 0D;
            this.zedGraphControl.ScrollMinX = 0D;
            this.zedGraphControl.ScrollMinY = 0D;
            this.zedGraphControl.ScrollMinY2 = 0D;
            this.zedGraphControl.Size = new System.Drawing.Size(741, 543);
            this.zedGraphControl.TabIndex = 0;
            this.zedGraphControl.UseExtendedPrintDialog = true;
            // 
            // container
            // 
            this.container.Controls.Add(this.zedGraphControl);
            this.container.Controls.Add(this.rightMenu);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.container.Name = "container";
            this.container.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.container.Size = new System.Drawing.Size(979, 567);
            this.container.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 567);
            this.Controls.Add(this.container);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(794, 479);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_func)).EndInit();
            this.rightMenu.ResumeLayout(false);
            this.userInputContainer.ResumeLayout(false);
            this.userInputContainer.PerformLayout();
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_draw;
        private System.Windows.Forms.Label label_const;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.PictureBox pictureBox_func;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Panel rightMenu;
        private System.Windows.Forms.Label label_func;
        private System.Windows.Forms.Label label_B;
        private ZedGraph.ZedGraphControl zedGraphControl;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.TableLayoutPanel userInputContainer;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Splitter splitter1;
    }
}

