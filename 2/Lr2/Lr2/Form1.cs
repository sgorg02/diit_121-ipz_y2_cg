using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lr2
{
    public partial class Form1 : Form
    {
        private GraphicImage img = new GraphicImage();
        private Point center = new Point(0, 0);
        
        public Form1()
        {
            InitializeComponent();

            img.AddTriangle("Roof", new Point(150, 100), new Point(233, 50), new Point(315, 100));
            img.AddRectangle("1th column", new Point(150, 100), 15, 100);
            img.AddRectangle("2th column", new Point(180, 100), 15, 100);
            img.AddRectangle("3th column", new Point(210, 100), 15, 100);
            img.AddRectangle("4th column", new Point(240, 100), 15, 100);
            img.AddRectangle("5th column", new Point(270, 100), 15, 100);
            img.AddRectangle("6th column", new Point(300, 100), 15, 100);
            img.AddRectangle("Second stairs", new Point(140, 200), 190, 15);
            img.AddRectangle("First stairs", new Point(120, 215), 230, 15);

            foreach (var n in img.getNames()) // добаляем имя елемента в checkedListBox1
                checkedListBox1.Items.Add(n);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            img.draw(e.Graphics); // рисуем нашу фигуру
            e.Graphics.DrawEllipse(Pens.Red, center.X, center.Y, 4, 4); // рисуем выбраную точку
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            img.rotate(10, center.X, center.Y);
            pictureBox1.Refresh();
        }

        private void buttonRotateAgainst_Click(object sender, EventArgs e)
        {
            img.rotate(-10, center.X, center.Y);
            pictureBox1.Refresh();
        }

        private void buttonScale_Click(object sender, EventArgs e)
        {
            double kX = 1, kY = 1;
            if(checkBoxX.Checked)
                kX = 1.5;
            if (checkBoxY.Checked)
                kY = 1.5;
            img.scale(center.X, center.Y, kX, kY);

            pictureBox1.Refresh();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            img.SetCheck(e.Index, e.NewValue == CheckState.Checked);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            center.X = e.X;
            center.Y = e.Y;
            textBoxPx.Text = (e.X).ToString();
            textBoxPy.Text = (e.Y).ToString();

            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e) // buttonScale-
        {
            double kX = 1, kY = 1;
            if (checkBoxX.Checked)
                kX = 0.5;
            if (checkBoxY.Checked)
                kY = 0.5;
            img.scale(center.X, center.Y, kX, kY);

            pictureBox1.Refresh();
        }

        private void buttonMoveUP_Click(object sender, EventArgs e)
        {
            img.move(0, -10); // двигаем вверх на 10
            pictureBox1.Refresh();
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            img.move(-10, 0); // двигаем влево на 10
            pictureBox1.Refresh();
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            img.move(10, 0); // двигаем вправо на 10
            pictureBox1.Refresh();
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            img.move(0, 10); // двигаем вниз на 10
            pictureBox1.Refresh();
        }

    }
}
