using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorphism
{
    public class Geometry
    {
        public virtual double Area()
        {            
            return 0;
        }
    }
    public class Square : Geometry
    {
        public double _Side;
        public Square()
        {
            _Side = 7.34;
        }
        public override double Area()
        {
            return _Side * _Side;
        }
    }
    public class Circle : Geometry
    {
        public double _Radius;
        public Circle()
        {
            _Radius = 4;
        }
        public override double Area()
        {
            return Math.PI * _Radius * _Radius;
        }
    }
    public class Rectangle : Geometry
    {
        public double _Length;
        public double _Width;

        public Rectangle()
        {
            _Length = 9.65;
            _Width = 5.36;
        }
        public override double Area()
        {
            return _Length * _Width;
        }
    }
}
