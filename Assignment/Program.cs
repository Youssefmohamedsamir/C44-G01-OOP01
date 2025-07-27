namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //1.	Define a struct "Person" with properties "Name" and "Age".
            //Create an array of three "Person" objects and populate it with data.
            //Then, write a C# program to display the details of all the persons in the array.


            //object[] ArrPerson = new object[3];

            //ArrPerson[0] = new Persons("Youssef", 20);
            //ArrPerson[1] = new Persons("Ahmed", 30);
            //ArrPerson[2] = new Persons("Amr", 25);


            //for (int i = 0; i < ArrPerson.Length; i++)
            //{
            //    Console.WriteLine($"{ArrPerson[i].ToString()}");
            //}


            #endregion

            #region Q2
            //2.Create a struct called "Point" to represent a 2D point with properties "X" and   "Y".
            //Write a C# program that takes two points as input from the user and calculates the distance between them.


            //Console.WriteLine("Enter the First Number : ");
            //bool isNumber = int.TryParse(Console.ReadLine(), out int FirstNumber);

            //Console.WriteLine("Enter the Secound Number : ");
            //bool isInteger = int.TryParse(Console.ReadLine(), out int SecoundNumber);


            //if (isNumber && isInteger)
            //{
            //    Point P01 = new(FirstNumber, SecoundNumber);
            //    Console.WriteLine($"The Distance Value is : {P01.Distance}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Value (Enter A Number Value :) )");
            //}

            #endregion

            #region Q3

            //3.Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user
            //and displays the name and age of the oldest person.

            //Console.WriteLine("Enter Your Name : ");
            //string Fname = Console.ReadLine();

            //Console.WriteLine("Enter Your Age: ");
            //bool isInteger = int.TryParse(Console.ReadLine(), out int Age);

            //if (isInteger)
            //{
            //    Person P01 = new(Fname, Age);

            //    Console.WriteLine(P01.ToString());
            //}

            #endregion

            #region Q4

            //4.	Create a struct named Rectangle that represents a rectangle with the following fields:

            //width(type: double)
            //height(type: double)

            //Implement encapsulation by making the fields private and provide public properties
            //access and modify these values.Ensure the following conditions are met:
            //The width and height should not be negative. If a negative value is provided,
            //the setter should not update the field and should instead print an error message.
            //Implement a public read-only property Area that calculates and
            //returns the area of the rectangle(Area = width * height).

            //Implement a method DisplayInfo that prints the rectangle's dimensions and area.

            //Write a program to demonstrate the usage of this struct by creating an instance,
            //setting values via properties, and displaying the area.

            //Console.WriteLine("Enter the Width : ");
            //bool one = int.TryParse(Console.ReadLine(), out int FirstNumber);

            //Console.WriteLine("Enter the Height : ");
            //bool two = int.TryParse(Console.ReadLine(), out int SecoundNumber);


            //if (FirstNumber > 0 && SecoundNumber > 0)
            //{
            //    Rectangle Rec01 = new Rectangle(FirstNumber, SecoundNumber);

            //    Console.WriteLine(Rec01.ToString());


            //    Rec01.SetHight(10);

            //    Console.WriteLine($"The Value After Update is {Rec01.GetHeight()}");

            //}
            //else
            //{
            //    Console.WriteLine("Please Enter a Positive Number ");
            //}



            #endregion
        }
    }
}
