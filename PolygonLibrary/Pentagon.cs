using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonLibrary
{
    public class Pentagon : IRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public Pentagon(int length)
        {
            NumberOfSides = 5;
            SideLength = length;
        }
        public double GetArea()
        {
            return SideLength * SideLength * (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) / 4);
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
    }
}
