using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab3
{
    public partial class Form1 : Form
    {
        Graphic_3d curr;

        Cylinder cyl = new Cylinder(200, 200, 40, 100, 150);
        BiezSurface surf;
        
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;

            curr = cyl;

            point3D[] tp = { 
                new point3D(100, 100, 0), new point3D(120, 100, 0), new point3D(140, 100, 0), new point3D(160, 100, 0), 
                new point3D(100, 150, 0), new point3D(120, 150, 0), new point3D(140, 150, 0), new point3D(160, 150, 0), 
                new point3D(100, 200, 0), new point3D(120, 200, 0), new point3D(140, 200, 0), new point3D(160, 200, 0), 
                new point3D(100, 250, 0), new point3D(120, 250, 0), new point3D(140, 250, 0), new point3D(160, 250, 0)
            };

            surf = new BiezSurface(tp);

            comboBox1.SelectedIndex = 0;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            projType[] projs = { projType.front, projType.left, projType.above, projType.dimetry, projType.isometry };
            curr.draw(e.Graphics, projs[listBox1.SelectedIndex]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void button_Rotate1_Click(object sender, EventArgs e)
        {
            if (checkBox_X.Checked == true)
                curr.rotate(10, axe.ox);

            if (checkBox_Y.Checked == true)
                curr.rotate(10, axe.oy);

            if (checkBox_Z.Checked == true)
                curr.rotate(10, axe.oz);
            
            pictureBox1.Refresh();
        }

        private void button_Rotate2_Click(object sender, EventArgs e)
        {
            if (checkBox_X.Checked == true)
                curr.rotate(-10, axe.ox);

            if (checkBox_Y.Checked == true)
                curr.rotate(-10, axe.oy);

            if (checkBox_Z.Checked == true)
                curr.rotate(-10, axe.oz);
            
            pictureBox1.Refresh();
        }

        private void button_Move1_Click(object sender, EventArgs e)
        {
            if (checkBox_X.Checked == true)
                curr.move(10, axe.ox);

            if (checkBox_Y.Checked == true)
                curr.move(10, axe.oy);

            if (checkBox_Z.Checked == true)
                curr.move(10, axe.oz);
            pictureBox1.Refresh();
        }

        private void button_Move2_Click(object sender, EventArgs e)
        {
            if (checkBox_X.Checked == true)
                curr.move(-10, axe.ox);

            if (checkBox_Y.Checked == true)
                curr.move(-10, axe.oy);

            if (checkBox_Z.Checked == true)
                curr.move(-10, axe.oz);
            pictureBox1.Refresh();
        }

        private void button_Scale1_Click(object sender, EventArgs e)
        {
            curr.scale(checkBox_X.Checked ? 1.5 : 1, checkBox_Y.Checked ? 1.5 : 1, checkBox_Z.Checked ? 1.5 : 1);
            pictureBox1.Refresh();
        }

        private void button_Scale2_Click(object sender, EventArgs e)
        {
            curr.scale(checkBox_X.Checked ? 1 / 1.5 : 1, checkBox_Y.Checked ? 1 / 1.5 : 1, checkBox_Z.Checked ? 1 / 1.5 : 1);
            pictureBox1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                curr = cyl;
            else
                curr = surf;

            pictureBox1.Refresh();

            panel1.Visible = comboBox1.SelectedIndex != 0;
        }

        private void comboBox_N_SelectedIndexChanged(object sender, EventArgs e)
        {
            point3D p = surf.points[int.Parse(comboBox_N.Text) * 4 + int.Parse(comboBox_M.Text)];

            textBox_x.Text = p.x.ToString();
            textBox_y.Text = p.y.ToString();
            textBox_z.Text = p.z.ToString();
        }

        private void button_set_Click(object sender, EventArgs e)
        {
            point3D p;

            p.x = double.Parse(textBox_x.Text);
            p.y = double.Parse(textBox_y.Text);
            p.z = double.Parse(textBox_z.Text);

            surf.points[int.Parse(comboBox_N.Text) * 4 + int.Parse(comboBox_M.Text)] = p;

            pictureBox1.Refresh();
        }
    }
}