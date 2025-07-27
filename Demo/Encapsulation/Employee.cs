using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct Employee
    {
        #region Attributes

        //private int id;
        //private string? Name;
        //private decimal empsalary;
        //private decimal deduction; // Derived Attribute  

        #endregion

        #region Constructors
        public Employee(int id , string? name , int salary)
        {
            this.id = id;
            this.Name = name;
            this.Salary = salary;
        }

        #endregion

        //Encaosulation
        //Separate Data Definiton [Attributes] From its Use [Setter , Getter , Property]
        // 1. Attribute Private
        // 2. Apply Encapsulation [Getter , Setter , Property Apptoach]

        #region 01 Appliying Encapsulation Using Old Approach Getter and Setter and Property

        //public string? GetName()
        //{
        //    return this.Name;
        //}
        //public void SetName(string ? name)
        //{
        //    this.Name = name?.Length > 10 ? name.Substring(0, 10) : name ;
        //}
        // Full Property
        //public decimal Salary
        //{
        //    get
        //    {
        //        return empsalary;
        //    }
        //    set
        //    {
        //        empsalary = value < 10000 ? 10000 : value;
        //    }
        //}

        

        // 1.2 Automatic Property
        // when we need Business Logic

        //public int Age { get; set; }

        // Compiler Generate backing Field [Il] "Private Hidden Attribute"
        
         public decimal Deduction //Read only Property
        {

            get
            {
                return Salary * 0.1M;
            }
            
        }
        #endregion 

        #region Method

        //public override string ToString()
        //{
        //    return $"ID id {this.id}\n and Name is " +
        //        $"{this.Name}\n and Salary is {this.Salary : c}";
        //}
        #endregion
    }
}
