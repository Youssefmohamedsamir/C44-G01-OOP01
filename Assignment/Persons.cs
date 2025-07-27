using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Persons
    {
       
            #region Attributes

            public string Name;
            public int Age;

            #endregion
            #region Constructors

            public Persons(string Name, int Age)
            {
                this.Name = Name;
                this.Age = Age;
            }
            public override string ToString()
            {
                return $"({Name},{Age})";
            }

            #endregion
        }
    }
