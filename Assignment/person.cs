using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Person
    {
        #region Attributes

        public string Name;
        public int Age;

        #endregion

        #region Constructor

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {
            return $"Name is {this.Name} and Age {this.Age}";
        }

        #endregion
    }
}
