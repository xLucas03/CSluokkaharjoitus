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
        public string name = "Essi esimerkki";
        public int age = 30;
        public string gender = "Emäntä";

        // Default constructor w/o arguments
        // No need to define, will be created automatically 

        public Hooman()
        { 
            
        }

        // Constructor with one argument
        public Hooman(string name)
        {
            this.name = name;
        }

        // Constructor with 2 arguments

        public Hooman(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Constructor with 3 arguments

        public Hooman(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;

        }

        // A method to say something
        public void SayOpinion()
        {
            Console.WriteLine("Voi lemmikit ne on elämän suola");
        }

    }

    class CatOwner : Hooman
    {
        public new void SayOpinion()
        { Console.WriteLine("Kissat ovat itsenäisiä ja pitävät hiiret loitolla.");
        }
    }

    class DogOwner : Hooman
    {
        public new void SayOpinion()
        {
            Console.WriteLine("Koirat ovat ihmisen parhaita ystäviä.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create (instantiate) a hooman object from Hooman class
            Hooman owner = new Hooman("Ossi omistaja", 35, "isäntä");

            // Call the SayOpinion method
            owner.SayOpinion();

            //Save owners name property to a variable
            string who = owner.name;

            // Test it by echoing it to a console
            Console.WriteLine("totesi " + who);

        
            // Create a new catowner object
            CatOwner catowner = new CatOwner();

            // Use catowners SayOpinion method
            catowner.SayOpinion();

            // Keep the window open until enter press
            Console.ReadLine();


        }



    }
}
