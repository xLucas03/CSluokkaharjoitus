using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuokkaHarjoitus1
{
    class Hooman
    {
        // Define properties of hooman ie. fields
        string name = "Essi esimerkki";
        int age = 30;
        string gender = "Emäntä";

        // Constructor with 

        Hooman()
        { 
            
        }

        // Constructor with one argument
        Hooman(string name)
        {
            this.name = name;
        }

        // Constructor with 2 arguments

        Hooman(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Constructor with 3 arguments

        Hooman(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
