using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Point
    {
        #region  Attributes

        public int X;
        public int Y;

        #endregion



        #region Constructors OverLooading
        //Is ASpeacial Function 
        //1. The Same Name Function or Struct
        //2. Has No Return Type

       

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Point(int number)
        {
            this.X = this.Y = number;
        }


        #endregion

        #region  Methods

        public override string ToString()
        {
            return $"({X},{Y})"; 
        }

        #endregion

    }
}
