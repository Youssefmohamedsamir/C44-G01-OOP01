using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Point
    {
        #region Attributes

        public int X;
        public int Y;
        public int? Distance;

        #endregion

        #region Constructor

        //ctor
        public Point(int? x , int? y)
        {
            if (x != null && y != null)
            {
                Distance = x - y;
            }

        }

        #endregion
    }
}
