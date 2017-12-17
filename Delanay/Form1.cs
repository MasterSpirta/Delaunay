using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using D = System.Drawing;
namespace Delanay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int numPoints = 1;
        private void button1_Click(object sender, EventArgs e)
        {
          
          

            numPoints++;
            List<Point> points = new List<Point>();

            Random rand = new Random(System.Environment.TickCount);

            Graphics g = this.CreateGraphics();
          
            g.Clear(Color.White);

            float doubleRadius = Point.pointRadius*2;//Чтоб точки не уходили за экран


            bool Intersect = false;
            int numIntersect = 0;
            while (points.Count< numPoints)
            {
                Point newGeneratedPoint = new Point(rand.Next((int)( doubleRadius), 800-(int)(doubleRadius) ), rand.Next((int)( doubleRadius), 600-(int)(doubleRadius))) ;

               
                foreach(var t in points)
                {

                    float distance = t.DistanceToPoint(newGeneratedPoint);

                    if ((distance -Point.pointRadius*2)<=0)
                    {
                        numIntersect++;
                        Intersect = true;
                        break;
                    }

                    

                }

                if (Intersect == true)
                {
                   
                    Intersect = false;
                    continue;
                }

                points.Add(newGeneratedPoint);
            }

            foreach (var t in points)
            {
                t.Draw(g);
            }
            points.Sort();

            
           
            for(int i=0;i<points.Count-1;i++)
            {
                g.DrawLine(Pens.RoyalBlue, new  D.Point((int)points[i].X, (int)points[i].Y), new D.Point((int)points[i+1].X, (int)points[i+1].Y));
            }


            

           





        }
    }
}
