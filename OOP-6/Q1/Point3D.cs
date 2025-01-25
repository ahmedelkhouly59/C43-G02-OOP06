using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_6
{
    internal class Point3D:IComparable<Point3D>,ICloneable
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Point3D(int x) {
            X = x;
        }
        
        public Point3D(int x,int y):this(x)
        {
            Y = y;
        }

        public Point3D(int x, int y, int z):this(x,y) {
            Z = z;
        }

        public override string ToString() {
            return $"Point Coordinates : ({X},{Y},{Z})";
        }

        public int CompareTo(Point3D other)
        {
            if (this.X > other.X)
                return 1;
            else if (this.X < other.X)
                return -1;
            else
                return 0;
        }

        public object Clone()
        {
            return new Point3D(X,Y,Z);
        }
    }
}
