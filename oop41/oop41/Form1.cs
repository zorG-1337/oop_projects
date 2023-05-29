using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop41
{
    public partial class Form1 : Form
    {
        public bool Cntrl = false;
        public bool SwitchAll = false;
        private List<CCircle> circles = new List<CCircle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (CCircle circle in circles)
            {
                circle.SelfDraw(e.Graphics);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(!Cntrl)
            {
                foreach (CCircle circle in circles)
                {
                    circle.setCondition(false);
                }
                CCircle newcircle = new CCircle(e.X, e.Y, 75);
                newcircle.setCondition(true);
                circles.Add(newcircle);
                Refresh();
            }

            else if(Cntrl)
            {
                bool canplace = true;
                foreach (CCircle Circle in circles)
                {
                    if (Circle.MouseCheck(e))
                    {
                        Circle.setCondition(true);
                        canplace = false;
                        break;
                    }
                }
                if (canplace == true)
                {
                    CCircle newcircle = new CCircle(e.X, e.Y, 25);
                    newcircle.setCondition(true);
                    circles.Add(newcircle);
                }
                Refresh();
            }

            if (SwitchAll)
            {
                foreach (CCircle Circle1 in circles)
                {
                    Circle1.MouseCheck(e);
                }
            }

            Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Cntrl = checkBox1.Checked;
            foreach(CCircle circle in circles)
            {
                circle.Cntrl = Cntrl;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SwitchAll = checkBox2.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelCircles();
        }

        void DelCircles()
        {
            for (int i = 0; i < circles.Count; i++)
            {
                if (circles[i].condition == true)
                {
                    circles.Remove(circles[i]);
                    i--;
                }
            }
            Refresh();
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(Control.ModifierKeys == Keys.Control)
            {
                checkBox1.Checked = true;
            }
            if(e.KeyCode == Keys.Delete)
            {
                DelCircles();
            }
        }
    }
    public class CCircle
    {
        private Point coords;
        private int rad = 0;
        public bool condition = false;
        public bool Cntrl = false;

        Color colorT = Color.CornflowerBlue;
        Color colorF = Color.Purple;
        public CCircle(int x, int y, int rad)
        {
            coords.X = x;
            coords.Y = y;
            this.rad = rad;
        }

        public void setCondition(bool cnd)
        {
            condition = cnd;
        }


        public void SelfDraw(Graphics g)
        {
            if (condition == true)
                g.DrawEllipse(new Pen(colorT, 3), coords.X - rad, coords.Y - rad, rad * 2, rad * 2);
            else
                g.DrawEllipse(new Pen(colorF, 3), coords.X - rad, coords.Y - rad, rad * 2, rad * 2);
        }

        public bool MouseCheck(MouseEventArgs e)
        {
            if (Cntrl)
            {
                if (Math.Pow(e.X - coords.X, 2) + Math.Pow(e.Y - coords.Y, 2) <= Math.Pow(rad, 2) && !condition)
                {
                    condition = true;
                    return true;
                }
            }
            return false;
        }

    }
}