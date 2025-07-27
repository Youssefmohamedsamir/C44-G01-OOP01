using Demo.Encapsulation;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Strcut

            #region Example 1

            //Point P1;
            //Declare For Variable(Object From Type Point)
            //CLR Will Allocate 8 Uninitialized Bytes At Stack

            // P1 = new Point();//Defult Constructor (0,0)

            ////new => is just for Constructor Selection That will used To initialized P1 Attributes
            // P1 = new (10 , 20);// Syntax Sugar
            //P1 = new Point(10, 20);

            //P1 = new Point(100);
            //Console.WriteLine($"P1.X = {P1.X}");// 0
            //Console.WriteLine($"P1.Y = {P1.Y}");// 0

            //Point P2 = new Point(100);
            //Console.WriteLine($"P1.X = {P2.X}");// 100
            //Console.WriteLine($"P1.Y = {P2.Y}");// 100


            //Console.WriteLine(P1); //Call Function that in WriteLine And Call ToStreing()
            //Console.WriteLine(P1.ToString()); // default Namespace.datatype And Call ToStreing()

            // Change in behavior of ToString() in C#
            // Point inherites From Function of ToString()
            //We Need Overriding ToString()

            #endregion

            #region  Example 2

            //Point P1 = new Point(1, 2);
            //Console.WriteLine($"P1 = {P1}");

            //Point P2 = new Point(100, 200);
            //Console.WriteLine($"P2 = {P2}");

            //P2 = P1 ;

            //Console.WriteLine("After Assign P2 = P1");
            //Console.WriteLine($"P1 = {P1}");
            //Console.WriteLine($"P2 = {P2}");


            //P1.X = 500;
            //P2.Y = 500;
            //Console.WriteLine("After Changes P1");
            //Console.WriteLine($"P1 = {P1}");
            //Console.WriteLine($"P2 = {P2}");

            #endregion

            #endregion

            #region OOP Concepts

            #region Encapsulation Getter and Setter and Property


            //Employee Emp1 = new Employee(10 , "Youssef" , 1000);
            //Console.WriteLine(Emp1);
            //Employee Emp2 = new Employee(id : 20,name : "Yousef",salary: 2000);
            //Console.WriteLine(Emp1);

            //Emp1.SetName("Amr"); //Set Id Directly Through Attribute
            //Console.WriteLine(Emp1.GetName()); // Get Id Directly Through Attribute



            //Emp02.Salary = 2000; //Set Salary Using Property As A Setter
            //Console.WriteLine(Emp02.Salary);//Get Salary Using Property As A Getter

            //Employee Emp02 = new Employee(name: "Safaa", id: 10, salary: 3000);
            //Console.WriteLine(Emp02.Deduction);

            #endregion

            #endregion

            #region PhoneNoteBook
          

            //int YoussefNumber = PN.GetNumber("Youssef");
            //Console.WriteLine(YoussefNumber);

            //PN.SetNumber("Youssef", 10010);

            //PN["Youssef"] = 999; // Set using indexer As a setter
            //Console.WriteLine(PN["Amr"]); // Get using indexer As a Getter


            //string name = "Route";
            //Console.WriteLine(name[0]);
            //name[0] = 'L' // Invalid


            //PhoneNoteBook PN = new PhoneNoteBook(3);
            //Console.WriteLine(PN.Size);

            //PN.AddPerson(0, "Ali", 123);
            //PN.AddPerson(1, "Youssef", 456);
            //PN.AddPerson(2, "Amr", 789);

            //for (int i = 0; i <PN.Size ; i++)
            //{
            //    Console.WriteLine(PN[i]);
            //}

            //foreach (var item in PN)
            //{
            //    Console.WriteLine(item);
            //}
            //This Need interface or Function Enumerator() or IEnumerator As Interface
            #endregion
        }
    }
}
