
namespace WindowsFormsAppLab1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_X1 = new System.Windows.Forms.Label();
            this.label_A = new System.Windows.Forms.Label();
            this.label_X2 = new System.Windows.Forms.Label();
            this.textBox_X1 = new System.Windows.Forms.TextBox();
            this.textBox_X2 = new System.Windows.Forms.TextBox();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button_background = new System.Windows.Forms.Button();
            this.button_line_color = new System.Windows.Forms.Button();
            this.button_axes_color = new System.Windows.Forms.Button();
            this.button_point_color = new System.Windows.Forms.Button();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 541);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label_X1
            // 
            this.label_X1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_X1.AutoSize = true;
            this.label_X1.Location = new System.Drawing.Point(859, 12);
            this.label_X1.Name = "label_X1";
            this.label_X1.Size = new System.Drawing.Size(21, 13);
            this.label_X1.TabIndex = 1;
            this.label_X1.Text = "x1:";
            // 
            // label_A
            // 
            this.label_A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(982, 12);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(17, 13);
            this.label_A.TabIndex = 1;
            this.label_A.Text = "A:";
            // 
            // label_X2
            // 
            this.label_X2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_X2.AutoSize = true;
            this.label_X2.Location = new System.Drawing.Point(921, 12);
            this.label_X2.Name = "label_X2";
            this.label_X2.Size = new System.Drawing.Size(21, 13);
            this.label_X2.TabIndex = 1;
            this.label_X2.Text = "x2:";
            // 
            // textBox_X1
            // 
            this.textBox_X1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_X1.Location = new System.Drawing.Point(883, 9);
            this.textBox_X1.Name = "textBox_X1";
            this.textBox_X1.Size = new System.Drawing.Size(32, 20);
            this.textBox_X1.TabIndex = 2;
            this.textBox_X1.Text = "-5";
            // 
            // textBox_X2
            // 
            this.textBox_X2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_X2.Location = new System.Drawing.Point(944, 9);
            this.textBox_X2.Name = "textBox_X2";
            this.textBox_X2.Size = new System.Drawing.Size(32, 20);
            this.textBox_X2.TabIndex = 2;
            this.textBox_X2.Text = "5";
            // 
            // textBox_A
            // 
            this.textBox_A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_A.Location = new System.Drawing.Point(1001, 9);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(32, 20);
            this.textBox_A.TabIndex = 2;
            this.textBox_A.Text = "1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(863, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(858, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1. Background:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(859, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "2. Line color:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(859, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "3. Axes color:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(859, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "4. Point color:";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.Yellow;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.domainUpDown1.Location = new System.Drawing.Point(965, 142);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(45, 20);
            this.domainUpDown1.TabIndex = 8;
            this.domainUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(858, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Толщина линии";
            // 
            // button_background
            // 
            this.button_background.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_background.BackColor = System.Drawing.Color.Black;
            this.button_background.Location = new System.Drawing.Point(943, 41);
            this.button_background.Name = "button_background";
            this.button_background.Size = new System.Drawing.Size(89, 19);
            this.button_background.TabIndex = 11;
            this.button_background.UseVisualStyleBackColor = false;
            this.button_background.Click += new System.EventHandler(this.button_background_Click);
            // 
            // button_line_color
            // 
            this.button_line_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_line_color.BackColor = System.Drawing.Color.Black;
            this.button_line_color.Location = new System.Drawing.Point(943, 66);
            this.button_line_color.Name = "button_line_color";
            this.button_line_color.Size = new System.Drawing.Size(89, 19);
            this.button_line_color.TabIndex = 11;
            this.button_line_color.UseVisualStyleBackColor = false;
            this.button_line_color.Click += new System.EventHandler(this.button_line_color_Click);
            // 
            // button_axes_color
            // 
            this.button_axes_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_axes_color.BackColor = System.Drawing.Color.Black;
            this.button_axes_color.Location = new System.Drawing.Point(943, 92);
            this.button_axes_color.Name = "button_axes_color";
            this.button_axes_color.Size = new System.Drawing.Size(89, 19);
            this.button_axes_color.TabIndex = 11;
            this.button_axes_color.UseVisualStyleBackColor = false;
            this.button_axes_color.Click += new System.EventHandler(this.button_axes_color_Click);
            // 
            // button_point_color
            // 
            this.button_point_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_point_color.BackColor = System.Drawing.Color.Black;
            this.button_point_color.Location = new System.Drawing.Point(943, 117);
            this.button_point_color.Name = "button_point_color";
            this.button_point_color.Size = new System.Drawing.Size(89, 19);
            this.button_point_color.TabIndex = 11;
            this.button_point_color.UseVisualStyleBackColor = false;
            this.button_point_color.Click += new System.EventHandler(this.button_point_color_Click);
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.domainUpDown2.Location = new System.Drawing.Point(965, 168);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(45, 20);
            this.domainUpDown2.TabIndex = 8;
            this.domainUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(858, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Масштабирование";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 600);
            this.Controls.Add(this.button_point_color);
            this.Controls.Add(this.button_axes_color);
            this.Controls.Add(this.button_line_color);
            this.Controls.Add(this.button_background);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.textBox_X2);
            this.Controls.Add(this.textBox_X1);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.label_X2);
            this.Controls.Add(this.label_X1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_X1;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_X2;
        private System.Windows.Forms.TextBox textBox_X1;
        private System.Windows.Forms.TextBox textBox_X2;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_background;
        private System.Windows.Forms.Button button_line_color;
        private System.Windows.Forms.Button button_axes_color;
        private System.Windows.Forms.Button button_point_color;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.Label label4;
    }
}

