using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delanay
{
    public class Point :IComparable
    {
        public static float pointRadius = 10;
        float x;
        float y;

        public Point (float _x,float _y)
        {
            X = _x;
            Y = _y;
        }
        /// <summary>
        /// 234234
        /// </summary>
        public float X {

            get {
                return x;
            }
            set {
                x = value;
            }
        }
        public float Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public void Draw(System.Drawing.Graphics g)
        {
            g.DrawEllipse(System.Drawing.Pens.Black, X-pointRadius, Y-pointRadius, pointRadius*2, pointRadius*2);
        }


        public float DistanceToPoint(Point p )
        {
            float len = 0;

            len = (float)Math.Sqrt((p.x-this.x ) * (p.x-this.x ) + (p.y-this.y) * (p.y-this.y));


            return len;
        }



        public int CompareTo(object obj)
        {

            if (X < ((Point)obj).X)
            {
                return -1;
            }

            if (X > ((Point)obj).X)
            {
                return 1;
            }

            return 0;
        }
    }
}
