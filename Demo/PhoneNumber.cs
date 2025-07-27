using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct PhoneNoteBook
    {
        #region Attributes
        private string[]? names;
        private int[]? numbers;
        private int size;
        #endregion

        #region Constructor
        public PhoneNoteBook(int notesize)
        {
            size = notesize;
            names = new string[size];
            numbers = new int[size];

        }
        #endregion


        #region Getter Setter
        public int GetNumber(string name)
        {
            if(names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }
                    
                }  
            }
            return -1;
        }

        public void SetNumber(string name , int newNumber)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = newNumber;  
                        //return; // getout the function
                    }
                    break; //out for loop only and  Compelete another code
                }
            }
        }

        #endregion

        #region indexer
        //Is a Speacial Property Named with KeyWord This
        //Can Take Parameter

        //PN["Youssef"] 

        public int this[string name]
        {
            get
            {
                if (names is not null && numbers is not null)
                
                    for (int i = 0; i < names.Length; i++)
                    
                        if (names[i] == name)
                        
                            return numbers[i];
                        

                    
                
                return -1;
            }
            set
            {
                if (names is not null && numbers is not null)
                
                    for (int i = 0; i < names.Length; i++)
                    
                        if (names[i] == name)
                        
                            numbers[i] = value;
                            return; // getout the function
                        
                        //break; //out for loop only and  Compelete another code
                    
                
            }

        }
        
        public string this[int index]
        {
            get
            {
                return $"Page = {index+1} :: Name = {names[index]} :: Number = {numbers[index]}";
            }
           
        }


        #endregion


        #region Properties
        public int Size
        { //Read only Property 
            get
            {
                return size;
            }
           
        }

        #endregion


        #region Methods
        public void AddPerson(int position , string name , int number)
        {
            if(names is not null && numbers is not null)
            {
                if (position < size && position >= 0)
                {
                    names[position] = name;
                    numbers[position] = number;
                }
            }
        }

        #endregion

    }
}
