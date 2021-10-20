using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lr2
{
    public interface GraphicOperations
    {
        void draw(Graphics gr); // рисование елемента
        void move(int delX, int delY); // двигаться в стороны
        void rotate(int angle, int px, int py); // вращение
        void scale(int px, int py, double w, double h); // масштаб
    }

    class GraphElem : GraphicOperations
    {
        protected List<Point> points = new List<Point>(); // масив точек
        protected String name; // имя елемента
        public override String ToString()
        {
            return name;
        }

        public void draw(Graphics gr) 
        {
            gr.DrawLines(Pens.Black, points.ToArray());
        }

        public void move(int delX, int delY)
        {
            for (int i = 0; i < points.Count; i++)
                points[i] = new Point(points[i].X + delX, points[i].Y + delY);
        }

        public void rotate(int angle, int px, int py)
        {
            double rad = angle * Math.PI / 180;
            for (int i = 0; i < points.Count; i++)
            {
                int x = (int)((points[i].X - px) * Math.Cos(rad) - (points[i].Y - py) * Math.Sin(rad) + px);
                int y = (int)((points[i].X - px) * Math.Sin(rad) + (points[i].Y - py) * Math.Cos(rad) + py);

                //int x = (int)(points[i].X * Math.Cos(rad) - points[i].Y * Math.Sin(rad) - px * Math.Cos(rad) + py * Math.Sin(rad) + px);
                //int y = (int)(points[i].X * Math.Sin(rad) + points[i].Y * Math.Cos(rad) - px * Math.Sin(rad) - py * Math.Cos(rad) + py);
                points[i] = new Point(x, y);
            }
        }

        public void scale(int px, int py, double w, double h)
        {
            for (int i = 0; i < points.Count; i++)
            {
                int x = (int)(points[i].X * w - w * px + px);
                int y = (int)(points[i].Y * h - h * py + py);
                points[i] = new Point(x, y);
            }
        }
    }

    class Line : GraphElem
    {
        public Line(String aname, Point p1, Point p2)
        {
            points.Add(p1);
            points.Add(p2);
            name = aname;
        }
    }

    class Circle : GraphElem
    {
        public Circle(String aname, Point cntr, int rd)
        {
            name = aname;
            for(int alpha = 0; alpha <= 360; alpha += 6)
            {
                int x = (int)(cntr.X + rd * Math.Sin(alpha * Math.PI / 100));
                int y = (int)(cntr.Y + rd * Math.Cos(alpha * Math.PI / 100));

                points.Add(new Point(x, y));
            }
        }
    }

    class Rectangle : GraphElem
    {
        public Rectangle(String aname, Point cntr, int width, int height)
        {
            points.Add(cntr);
            points.Add(new Point(cntr.X + width, cntr.Y));
            points.Add(new Point(cntr.X + width, cntr.Y + height));
            points.Add(new Point(cntr.X, cntr.Y + height));
            points.Add(cntr);
            name = aname;
        }
    }

    class Triangle : GraphElem
    {
        public Triangle(String aname, Point lf, Point up, Point rh)
        {
            points.Add(lf);
            points.Add(up);
            points.Add(rh);
            points.Add(lf);
            name = aname;
        }
    }

    class GraphicImage : GraphicOperations
    {
        private List<GraphElem> items = new List<GraphElem>();
        private List<bool> SelectedCheck = new List<bool>();

        public List<String> getNames()
        {
            List<String> lst = new List<String>();
            foreach (var x in items)
                lst.Add(x.ToString());
            return lst;
        }

        public void draw(Graphics gr)
        {
            foreach (var x in items)
                x.draw(gr);
        }

        public void move(int delX, int delY)
        {
            for (int x = 0; x < items.Count; x++)
            {
                if(SelectedCheck[x])
                    items[x].move(delX, delY);
            }
        }

        public void rotate(int angle, int px, int py)
        {
            for (int x = 0; x < items.Count; x++)
            {
                if (SelectedCheck[x])
                    items[x].rotate(angle, px, py);
            }
        }

        public void scale(int px, int py, double w, double h)
        {
            for (int x = 0; x < items.Count; x++)
            {
                if (SelectedCheck[x])
                    items[x].scale(px, py, w, h);
            }

        }

        public void AddLine(String name, Point p1, Point p2)
        {
            items.Add(new Line(name, p1, p2));
            SelectedCheck.Add(false);
        }

        public void AddCircle(String name, Point p1, int r)
        {
            items.Add(new Circle(name, p1, r));
            SelectedCheck.Add(false);
        }

        public void AddRectangle(String name, Point cntr, int width, int height)
        {
            items.Add(new Rectangle(name, cntr, width, height));
            SelectedCheck.Add(false);
        }

        public void AddTriangle(String name, Point lf, Point up, Point rh)
        {
            items.Add(new Triangle(name, lf, up, rh));
            SelectedCheck.Add(false);
        }

        public void SetCheck(int index, bool val)
        {
            SelectedCheck[index] = val;
        }
    }
}
