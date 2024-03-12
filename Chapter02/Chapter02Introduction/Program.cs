using System.Linq.Expressions;
using System;

namespace Chapter02Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vriable : value = hamid and identifire = myname
            string myname = "Hamid";
            //or
            string name;
            name = "masoud";

            //-------------------------------------------------------

            var name2 = "akbar";
            // in C# compile language : string name2 = "akbar"

            dynamic name3 = "";
            // in C# compile language : object name3 = "";
            // in JIT determind what type it has.



            //------------------------------------------------------

            // Target-typed new expressions
            //var person = new Person();   => Person p3 = new();


            //------------------------------------------------------

            //const

            const string myName = "hamidreza";
            //myName = "jafar";   => wrong

            //const string novalue; => wrong

            const int sum = 1+1;

            //remove magic number //
            const int numberOfTries = 5;
        }
    }
}
