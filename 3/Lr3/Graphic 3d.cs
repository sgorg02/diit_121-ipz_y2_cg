using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsLab3
{
    enum projType { above, left,  front, isometry, dimetry }

    enum axe { ox, oy, oz }

    struct point3D
    {
        public double x, y, z;

        public point3D(double ax, double ay, double az)
        {
            x = ax;
            y = ay;
            z = az;
        }
        public Point project(projType proj)
        {
            switch (proj)
            {
                case projType.above: return new Point((int)x, (int)z);
                case projType.left: return new Point((int)z, (int)y);
                case projType.front: return new Point((int)x, (int)y);
                case projType.dimetry: return new Point(200 + (int)(x * 0.707 - 0.707 * z), 200 + (int)(-0.408 * x + 0.816 * y - 0.408 * z));
                case projType.isometry: return new Point(100 + (int)(x * 0.935 - 0.354 * z), 100 + (int)(-0.118 * x + 0.943 * y - 0.312 * z));
                default: return new Point(0, 0);
            }
        }
    }
    
    class Graphic_3d
    {
        public virtual void draw(Graphics g, projType proj) {}

        public virtual void rotate(double angle, axe ax) {}

        public virtual void move(double mov, axe ax) {}

        public virtual void scale(double sx, double sy, double sz) {}

    }

    class Cylinder: Graphic_3d
    {
        point3D[] points = new point3D[10];

        public Cylinder(int cx, int cz, int rad1, int rad2, int h)
        {
            double ang = 0;
            for (int i = 0; i < 4; i++, ang += 180 / 2)
            {
                double rad = Math.PI * ang / 180;
                points[i] = new point3D(cx + rad1 * Math.Sin(rad), 0, cz + rad1 * Math.Cos(rad));
                points[i + 4] = new point3D(cx + rad2 * Math.Sin(rad), h, cz + rad2 * Math.Cos(rad));
            }
        }

        public override void rotate(double angle, axe ax)
        {
            point3D cnt = center();
            double rad = angle * Math.PI / 180;
            for (int i = 0; i < 10; i++)  // 10 надо может быть будет поменять значение при помтроение
            {
                point3D tmp = points[i];
                switch (ax)
                {
                    case axe.ox:
                        points[i].y = (tmp.y - cnt.y) * Math.Cos(rad) - (tmp.z - cnt.z) * Math.Sin(rad) + cnt.y;
                        points[i].z = (tmp.y - cnt.y) * Math.Sin(rad) + (tmp.z - cnt.z) * Math.Cos(rad) + cnt.z;
                        break;
                    case axe.oy:
                        points[i].x = (tmp.x - cnt.x) * Math.Cos(rad) + (tmp.z - cnt.z) * Math.Sin(rad) + cnt.x;
                        points[i].z = -(tmp.x - cnt.x) * Math.Sin(rad) + (tmp.z - cnt.z) * Math.Cos(rad) + cnt.z;
                        break;
                    case axe.oz:
                        points[i].x = (tmp.x - cnt.x) * Math.Cos(rad) - (tmp.y - cnt.y) * Math.Sin(rad) + cnt.x;
                        points[i].y = (tmp.x - cnt.x) * Math.Sin(rad) + (tmp.y - cnt.y) * Math.Cos(rad) + cnt.y;
                        break;

                }
            }
        }

        public override void move(double mov, axe ax)
        {
            for (int i = 0; i < 10; i++)
            {
                switch (ax)
                {
                    case axe.ox:
                        points[i].x = points[i].x + mov;
                        break;
                    case axe.oy:
                        points[i].y = points[i].y + mov;
                        break;
                    case axe.oz:
                        points[i].z = points[i].z + mov;
                        break;
                }
            }
        }

        public override void scale(double sx, double sy, double sz)
        {
            point3D cnt = center();
            for (int i = 0; i < 8; i++)
            {
                points[i].x = (points[i].x - cnt.x) * sx + cnt.x;
                points[i].y = (points[i].y - cnt.y) * sy + cnt.y;
                points[i].z = (points[i].z - cnt.z) * sz + cnt.z;

            }
        }


            private point3D center()
        {
            point3D c = new point3D(0, 0, 0);
            for (int i = 0; i < 10; i++)
            {
                c.x += points[i].x;
                c.y += points[i].y;
                c.z += points[i].z;
            }

            c.x /= 10;
            c.y /= 10;
            c.z /= 10;

            return c;
        }

        public override void draw(Graphics g, projType proj)
        {
            point3D cntr = new point3D(100, 100, 0);
            point3D cntrX = new point3D(200, 100, 0);
            point3D cntrY = new point3D(100, 0, 0);
            point3D cntrZ = new point3D(100, 100, 100);

            for (int i = 0; i < 4; i++)
            {
                g.DrawLine(Pens.Black, points[i].project(proj), points[(i + 1) % 4].project(proj));// top

                g.DrawLine(Pens.Black, points[i + 4].project(proj), points[(i + 1) % 4 + 4].project(proj)); //bottom

                g.DrawLine(Pens.Black, points[i].project(proj), points[i + 4].project(proj));//edges
            }

            g.DrawLine(Pens.Red, cntr.project(proj), cntrX.project(proj));//Ox
            g.DrawString("Ox", SystemFonts.DefaultFont, Brushes.Black, cntrX.project(proj));

            g.DrawLine(Pens.Blue, cntr.project(proj), cntrY.project(proj));//Oy
            g.DrawString("Oy", SystemFonts.DefaultFont, Brushes.Black, cntrY.project(proj));

            g.DrawLine(Pens.Green, cntr.project(proj), cntrZ.project(proj));//Oz
            g.DrawString("Oz", SystemFonts.DefaultFont, Brushes.Black, cntrZ.project(proj));


        }
    }

    class Matrix
    {
        public double[,] elem = new double[4, 4];
        int n, m;

        public Matrix(int an, int am)
        {
            n = an;
            m = am;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    elem[i, j] = 0;
        }

        public static Matrix operator * (Matrix m1, Matrix m2)
        {
            Matrix res = new Matrix(m1.n, m2.m);
            for (int i = 0; i < res.m; i++) // colomns
            {
                for (int j = 0; j < res.n; j++) // rows
                {
                    double s = 0;
                    for (int k = 0; k < m1.m; k++)
                        s += m1.elem[j, k] * m2.elem[k, i];
                    res.elem[j, i] = s;
                }
            }
            return res;
        }

    }

    class BiezSurface: Graphic_3d
    {
        public point3D[] points = new point3D[16];
        Matrix Mb = new Matrix(4, 4);
        Matrix MbT = new Matrix(4, 4);


        public BiezSurface(point3D[] apoints)
        {
            points = apoints;
            double[,] mb =
            {
                { -1, 3, -3, 1 },
                { 3, -6, 3, 0 },
                { -3, 3, 0, 0 },
                { 1, 0, 0, 0 }
            };
            Mb.elem = mb;

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    MbT.elem[j, i] = Mb.elem[i, j];
        }

        public override void rotate(double angle, axe ax)
        {
            point3D cnt = center();
            double rad = angle * Math.PI / 180;
            for (int i = 0; i < 16; i++)
            {
                point3D tmp = points[i];
                switch (ax)
                {
                    case axe.ox:
                        points[i].y = (tmp.y - cnt.y) * Math.Cos(rad) - (tmp.z - cnt.z) * Math.Sin(rad) + cnt.y;
                        points[i].z = (tmp.y - cnt.y) * Math.Sin(rad) + (tmp.z - cnt.z) * Math.Cos(rad) + cnt.z;
                        break;
                    case axe.oy:
                        points[i].x = (tmp.x - cnt.x) * Math.Cos(rad) + (tmp.z - cnt.z) * Math.Sin(rad) + cnt.x;
                        points[i].z = -(tmp.x - cnt.x) * Math.Sin(rad) + (tmp.z - cnt.z) * Math.Cos(rad) + cnt.z;
                        break;
                    case axe.oz:
                        points[i].x = (tmp.x - cnt.x) * Math.Cos(rad) - (tmp.y - cnt.y) * Math.Sin(rad) + cnt.x;
                        points[i].y = (tmp.x - cnt.x) * Math.Sin(rad) + (tmp.y - cnt.y) * Math.Cos(rad) + cnt.y;
                        break;

                }
            }
        }

        public override void move(double mov, axe ax)
        {
            for (int i = 0; i < 16; i++)
            {
                switch (ax)
                {
                    case axe.ox:
                        points[i].x = points[i].x + mov;
                        break;
                    case axe.oy:
                        points[i].y = points[i].y + mov;
                        break;
                    case axe.oz:
                        points[i].z = points[i].z + mov;
                        break;
                }
            }
        }

        public override void scale(double sx, double sy, double sz)
        {
            point3D cnt = center();
            for (int i = 0; i < 16; i++)
            {
                points[i].x = (points[i].x - cnt.x) * sx + cnt.x;
                points[i].y = (points[i].y - cnt.y) * sy + cnt.y;
                points[i].z = (points[i].z - cnt.z) * sz + cnt.z;

            }
        }


        private point3D center()
        {
            point3D c = new point3D(0, 0, 0);
            for (int i = 0; i < 16; i++)
            {
                c.x += points[i].x;
                c.y += points[i].y;
                c.z += points[i].z;
            }

            c.x /= 16;
            c.y /= 16;
            c.z /= 16;

            return c;
        }

        public override void draw(Graphics g, projType proj)
        {
            Matrix S = new Matrix(1, 4);
            Matrix T = new Matrix(4, 1);
            Matrix Px = new Matrix(4, 4);
            Matrix Py = new Matrix(4, 4);
            Matrix Pz = new Matrix(4, 4);

            for (int i = 0; i < 16; i++)
            {
                Px.elem[i / 4, i % 4] = points[i].x;
                Py.elem[i / 4, i % 4] = points[i].y;
                Pz.elem[i / 4, i % 4] = points[i].z;
            }
            
            double stp = 0.03; // 0.05
            for (double t = 0; t <= 1; t += stp)
            {
                T.elem[0, 0] = t * t * t;
                T.elem[1, 0] = t * t;
                T.elem[2, 0] = t;
                T.elem[3, 0] = 1;
                for (double s = 0; s <= 1; s += stp)
                {
                    S.elem[0, 0] = s * s * s;
                    S.elem[0, 1] = s * s;
                    S.elem[0, 2] = s;
                    S.elem[0, 3] = 1;

                    point3D p;
                    p.x = (S * Mb * Px * MbT * T).elem[0, 0];
                    p.y = (S * Mb * Py * MbT * T).elem[0, 0];
                    p.z = (S * Mb * Pz * MbT * T).elem[0, 0];

                    Point pt = p.project(proj);

                    g.FillEllipse(Brushes.Black, pt.X, pt.Y, 4, 4);
                }
            }
        }
    }
}