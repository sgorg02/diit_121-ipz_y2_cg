
namespace WindowsFormsLab3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_Rotate1 = new System.Windows.Forms.Button();
            this.button_Rotate2 = new System.Windows.Forms.Button();
            this.button_Move1 = new System.Windows.Forms.Button();
            this.button_Move2 = new System.Windows.Forms.Button();
            this.button_Scale1 = new System.Windows.Forms.Button();
            this.button_Scale2 = new System.Windows.Forms.Button();
            this.checkBox_X = new System.Windows.Forms.CheckBox();
            this.checkBox_Y = new System.Windows.Forms.CheckBox();
            this.checkBox_Z = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_z = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.comboBox_M = new System.Windows.Forms.ComboBox();
            this.comboBox_N = new System.Windows.Forms.ComboBox();
            this.textBox_z = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.button_set = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(163, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 377);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "front",
            "left",
            "above",
            "dimetry",
            "isometry"});
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(105, 69);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_Rotate1
            // 
            this.button_Rotate1.Location = new System.Drawing.Point(12, 97);
            this.button_Rotate1.Name = "button_Rotate1";
            this.button_Rotate1.Size = new System.Drawing.Size(64, 23);
            this.button_Rotate1.TabIndex = 2;
            this.button_Rotate1.Text = "rotate +";
            this.button_Rotate1.UseVisualStyleBackColor = true;
            this.button_Rotate1.Click += new System.EventHandler(this.button_Rotate1_Click);
            // 
            // button_Rotate2
            // 
            this.button_Rotate2.Location = new System.Drawing.Point(92, 97);
            this.button_Rotate2.Name = "button_Rotate2";
            this.button_Rotate2.Size = new System.Drawing.Size(64, 23);
            this.button_Rotate2.TabIndex = 2;
            this.button_Rotate2.Text = "rotate -";
            this.button_Rotate2.UseVisualStyleBackColor = true;
            this.button_Rotate2.Click += new System.EventHandler(this.button_Rotate2_Click);
            // 
            // button_Move1
            // 
            this.button_Move1.Location = new System.Drawing.Point(12, 126);
            this.button_Move1.Name = "button_Move1";
            this.button_Move1.Size = new System.Drawing.Size(64, 23);
            this.button_Move1.TabIndex = 2;
            this.button_Move1.Text = "move +";
            this.button_Move1.UseVisualStyleBackColor = true;
            this.button_Move1.Click += new System.EventHandler(this.button_Move1_Click);
            // 
            // button_Move2
            // 
            this.button_Move2.Location = new System.Drawing.Point(92, 126);
            this.button_Move2.Name = "button_Move2";
            this.button_Move2.Size = new System.Drawing.Size(64, 23);
            this.button_Move2.TabIndex = 2;
            this.button_Move2.Text = "move -";
            this.button_Move2.UseVisualStyleBackColor = true;
            this.button_Move2.Click += new System.EventHandler(this.button_Move2_Click);
            // 
            // button_Scale1
            // 
            this.button_Scale1.Location = new System.Drawing.Point(12, 155);
            this.button_Scale1.Name = "button_Scale1";
            this.button_Scale1.Size = new System.Drawing.Size(64, 23);
            this.button_Scale1.TabIndex = 2;
            this.button_Scale1.Text = "scale +";
            this.button_Scale1.UseVisualStyleBackColor = true;
            this.button_Scale1.Click += new System.EventHandler(this.button_Scale1_Click);
            // 
            // button_Scale2
            // 
            this.button_Scale2.Location = new System.Drawing.Point(93, 155);
            this.button_Scale2.Name = "button_Scale2";
            this.button_Scale2.Size = new System.Drawing.Size(64, 23);
            this.button_Scale2.TabIndex = 2;
            this.button_Scale2.Text = "scale -";
            this.button_Scale2.UseVisualStyleBackColor = true;
            this.button_Scale2.Click += new System.EventHandler(this.button_Scale2_Click);
            // 
            // checkBox_X
            // 
            this.checkBox_X.AutoSize = true;
            this.checkBox_X.Location = new System.Drawing.Point(124, 13);
            this.checkBox_X.Name = "checkBox_X";
            this.checkBox_X.Size = new System.Drawing.Size(33, 17);
            this.checkBox_X.TabIndex = 3;
            this.checkBox_X.Text = "X";
            this.checkBox_X.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y
            // 
            this.checkBox_Y.AutoSize = true;
            this.checkBox_Y.Location = new System.Drawing.Point(124, 36);
            this.checkBox_Y.Name = "checkBox_Y";
            this.checkBox_Y.Size = new System.Drawing.Size(33, 17);
            this.checkBox_Y.TabIndex = 3;
            this.checkBox_Y.Text = "Y";
            this.checkBox_Y.UseVisualStyleBackColor = true;
            // 
            // checkBox_Z
            // 
            this.checkBox_Z.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_Z.AutoSize = true;
            this.checkBox_Z.Location = new System.Drawing.Point(124, 59);
            this.checkBox_Z.Name = "checkBox_Z";
            this.checkBox_Z.Size = new System.Drawing.Size(33, 17);
            this.checkBox_Z.TabIndex = 3;
            this.checkBox_Z.Text = "Z";
            this.checkBox_Z.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "cylinder",
            "surface"});
            this.comboBox1.Location = new System.Drawing.Point(13, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_set);
            this.panel1.Controls.Add(this.label_z);
            this.panel1.Controls.Add(this.label_y);
            this.panel1.Controls.Add(this.label_x);
            this.panel1.Controls.Add(this.comboBox_M);
            this.panel1.Controls.Add(this.comboBox_N);
            this.panel1.Controls.Add(this.textBox_z);
            this.panel1.Controls.Add(this.textBox_y);
            this.panel1.Controls.Add(this.textBox_x);
            this.panel1.Location = new System.Drawing.Point(13, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 148);
            this.panel1.TabIndex = 5;
            // 
            // label_z
            // 
            this.label_z.AutoSize = true;
            this.label_z.Location = new System.Drawing.Point(12, 95);
            this.label_z.Name = "label_z";
            this.label_z.Size = new System.Drawing.Size(12, 13);
            this.label_z.TabIndex = 6;
            this.label_z.Text = "z";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(12, 69);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(12, 13);
            this.label_y.TabIndex = 6;
            this.label_y.Text = "y";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(12, 43);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(12, 13);
            this.label_x.TabIndex = 6;
            this.label_x.Text = "x";
            // 
            // comboBox_M
            // 
            this.comboBox_M.FormattingEnabled = true;
            this.comboBox_M.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox_M.Location = new System.Drawing.Point(74, 13);
            this.comboBox_M.Name = "comboBox_M";
            this.comboBox_M.Size = new System.Drawing.Size(31, 21);
            this.comboBox_M.TabIndex = 1;
            this.comboBox_M.Text = "0";
            this.comboBox_M.SelectedIndexChanged += new System.EventHandler(this.comboBox_N_SelectedIndexChanged);
            // 
            // comboBox_N
            // 
            this.comboBox_N.FormattingEnabled = true;
            this.comboBox_N.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox_N.Location = new System.Drawing.Point(30, 13);
            this.comboBox_N.Name = "comboBox_N";
            this.comboBox_N.Size = new System.Drawing.Size(33, 21);
            this.comboBox_N.TabIndex = 1;
            this.comboBox_N.Text = "0";
            this.comboBox_N.SelectedIndexChanged += new System.EventHandler(this.comboBox_N_SelectedIndexChanged);
            // 
            // textBox_z
            // 
            this.textBox_z.Location = new System.Drawing.Point(30, 92);
            this.textBox_z.Name = "textBox_z";
            this.textBox_z.Size = new System.Drawing.Size(91, 20);
            this.textBox_z.TabIndex = 0;
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(30, 66);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(91, 20);
            this.textBox_y.TabIndex = 0;
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(30, 40);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(91, 20);
            this.textBox_x.TabIndex = 0;
            // 
            // button_set
            // 
            this.button_set.Location = new System.Drawing.Point(30, 118);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(91, 23);
            this.button_set.TabIndex = 7;
            this.button_set.Text = "set";
            this.button_set.UseVisualStyleBackColor = true;
            this.button_set.Click += new System.EventHandler(this.button_set_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox_Z);
            this.Controls.Add(this.checkBox_Y);
            this.Controls.Add(this.checkBox_X);
            this.Controls.Add(this.button_Scale2);
            this.Controls.Add(this.button_Scale1);
            this.Controls.Add(this.button_Move2);
            this.Controls.Add(this.button_Move1);
            this.Controls.Add(this.button_Rotate2);
            this.Controls.Add(this.button_Rotate1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_Rotate1;
        private System.Windows.Forms.Button button_Rotate2;
        private System.Windows.Forms.Button button_Move1;
        private System.Windows.Forms.Button button_Move2;
        private System.Windows.Forms.Button button_Scale1;
        private System.Windows.Forms.Button button_Scale2;
        private System.Windows.Forms.CheckBox checkBox_X;
        private System.Windows.Forms.CheckBox checkBox_Y;
        private System.Windows.Forms.CheckBox checkBox_Z;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_z;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.ComboBox comboBox_M;
        private System.Windows.Forms.ComboBox comboBox_N;
        private System.Windows.Forms.TextBox textBox_z;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Button button_set;
    }
}

