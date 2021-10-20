using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsAppLab1
{
    public partial class Form1 : Form {

        const int PIX_IN_ONE = 15; //Пикселей в одном делении оси
        const int ARR_LEN = 10; //Длина стрелки
        double scale = 1; // масштаб графика

        Color p1 = new Color();
        Pen p2 = new Pen(System.Drawing.Color.Black); // LINE COLOR
        Pen p3 = new Pen(System.Drawing.Color.Black); // AXES COLOR
        Pen p4 = new Pen(System.Drawing.Color.Black); // TEXT COLOR
        Pen p5 = new Pen(System.Drawing.Color.Black); // POINT COLOR

        public Form1() {
            InitializeComponent();
            DomainUpDown.DomainUpDownItemCollection collection = this.domainUpDown1.Items;
            collection.Add(1);
            collection.Add(2);
            collection.Add(3);
            collection.Add(4);
            collection.Add(5);

            domainUpDown1.Text = "1";
            DomainUpDown.DomainUpDownItemCollection collection2 = this.domainUpDown2.Items;
            collection2.Add(1);
            collection2.Add(1.2);
            collection2.Add(1.4);
            collection2.Add(1.6);
            collection2.Add(1.8);
            collection2.Add(2);

            domainUpDown2.Text = "1";
        }

        
        private PointF func(double x, double a) {
            
            float y = (float)(a * (Math.Pow(Math.E, x / a) + Math.Pow(Math.E, -x / a))) / 2;

            return new PointF((float)x, y);
        }
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e) {

            pictureBox1.BackColor = p1; // фон в pictureBox1

            double ph1 = System.Convert.ToDouble(textBox_X1.Text);
            double ph2 = System.Convert.ToDouble(textBox_X2.Text);
            double A = System.Convert.ToDouble(textBox_A.Text);

            if (A != 0)
            {
                double del = (ph2 - ph1) / 500; // крок 0.02

                PointF p0 = func(ph1, A);
                float x1 = p0.X, x2 = x1,
                    minY = p0.Y, maxY = minY;

                List<PointF> pts = new List<PointF>();

                PointF p;

                for (double ph = ph1; ph < ph2; ph += del)
                {
                    p = func(ph, A);

                    if (x1 > p.X) x1 = p.X;
                    if (x2 < p.X) x2 = p.X;

                    if (minY > p.Y) minY = p.Y;
                    if (maxY < p.Y) maxY = p.Y;

                    pts.Add(p);
                }

                int h = pictureBox1.Height;
                int w = pictureBox1.Width;

                e.Graphics.TranslateTransform(w / 2, h / 2); // позиционирование по центру
                e.Graphics.ScaleTransform((float)scale, (float)scale); // масштабирование графика 
                DrawXAxis(new Point(-w, 0), new Point(w, 0), e.Graphics); // ось X
                DrawYAxis(new Point(0, h), new Point(0, -h), e.Graphics); // ось Y

                List<PointF> pts_ = new List<PointF>();
                foreach (var pt in pts)
                {
                    int x_ = (int)((pt.X - x1) * w / (x2 - x1)) / 4;
                    int y_ = (int)((maxY - pt.Y) * h / (maxY - minY)) / 4;

                    pts_.Add(new Point(x_ - 102, y_ - 150));
                }

                e.Graphics.DrawLines(p2, pts_.ToArray());

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BorderStyle = BorderStyle.Fixed3D; // 3d рамка
            }
            else
                MessageBox.Show("Коэффициент A не может быть равным нулю!!");
        }

        // Рисование оси X
        private void DrawXAxis(Point start, Point end, Graphics g)
        {
            // Деления в положительном направлении оси
            for (int i = PIX_IN_ONE; i < end.X - ARR_LEN; i += PIX_IN_ONE)
            {
                g.DrawLine(p5, i, -4, i, 4);
                DrawText(new Point(i, 4), (i / PIX_IN_ONE).ToString(), g);
            }
            // Деления в отрицательном направлении оси
            for (int i = -PIX_IN_ONE; i > start.X; i -= PIX_IN_ONE)
            {
                g.DrawLine(p5, i, -4, i, 4);
                DrawText(new Point(i, 4), (i / PIX_IN_ONE).ToString(), g);
            }
            // Ось
            g.DrawLine(p3, start, end);
        }

        // Рисование оси Y
        private void DrawYAxis(Point start, Point end, Graphics g)
        {
            // Деления в отрицательном направлении оси
            for (int i = PIX_IN_ONE; i < start.Y; i += PIX_IN_ONE)
            {
                g.DrawLine(p5, -4, i, 4, i);
                DrawText(new Point(4, i), (-i / PIX_IN_ONE).ToString(), g, true);
            }
            // Деления в положительном направлении оси
            for (int i = -PIX_IN_ONE; i > end.Y + ARR_LEN; i -= PIX_IN_ONE)
            {
                g.DrawLine(p5, -4, i, 4, i);
                DrawText(new Point(4, i), (-i / PIX_IN_ONE).ToString(), g, true);
            }
            // Ось
            g.DrawLine(p3, start, end);
        }

        // Рисование текста
        private void DrawText(Point point, string text, Graphics g, bool isYAxis = false)
        {
            var f = new Font(Font.FontFamily, 6);
            var size = g.MeasureString(text, f);
            var pt = isYAxis
                ? new PointF(point.X + 1, point.Y - size.Height / 2)
                : new PointF(point.X - size.Width / 2, point.Y + 1);
            var rect = new RectangleF(pt, size);
            g.DrawString(text, f, Brushes.Black, rect);
        }

        private void button1_Click(object sender, EventArgs e) {
            p2.Width = System.Convert.ToInt32(domainUpDown1.Text);
            scale = System.Convert.ToDouble(domainUpDown2.Text);
            pictureBox1.Refresh();
        }

        private void button_background_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button_background.BackColor = colorDialog1.Color;
            p1 = colorDialog1.Color;
        }

        private void button_line_color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button_line_color.BackColor = colorDialog1.Color;
            p2 = new Pen(colorDialog1.Color, System.Convert.ToInt32(domainUpDown1.Text));
        }

        private void button_axes_color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button_axes_color.BackColor = colorDialog1.Color;
            p3 = new Pen(colorDialog1.Color);
        }

        private void button_point_color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button_point_color.BackColor = colorDialog1.Color;
            p5 = new Pen(colorDialog1.Color);
        }
    }
}
