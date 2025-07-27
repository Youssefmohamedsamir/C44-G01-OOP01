using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Rectangle
    {
        #region Attributes

        private int Width;
        private int Height;
        private int area;


        #endregion

        #region Constructor

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        #endregion

        #region Encapsultion
        public void SetWidth(int width)
        {
            if (width > 0)
            {
                this.Width = width;
            }
            else
            {
                Console.WriteLine("invalid Setter");
            }
        }
        public int GetWidth()
        {
            return this.Width;
        }

        public int GetHeight()
        {
            return this.Height;
        }

        public void SetHight(int hight)

        {
            if (hight > 0)
            {
                this.Height = hight;
            }
            else
            {
                Console.WriteLine("invalid Setter");
            }
        }
           

        public int Area
        {
            get
            {
                area = this.Width * this.Height;
                return area;
            }
            set
            {
                area = this.Width * this.Height;
                
            }
        }

        public override string ToString()

        {
            return $"Your Width is {this.Width}\n and Height is {this.Height}\n and Area is {this.Area}";
        }

        #endregion

    }
}
