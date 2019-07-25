using System;
using System.Collections.Generic;

namespace objectsGC7
{
    class MainClass
    {
        public static void Main(string[] args)
        {



            student s1 = new student("Jill", "Raleigh", "Chicken");
            student s2 = new student("Jaime", "Scranton", "Ketchup");
            student s3 = new student("James", "George Town", "Cheese");
            student s4 = new student("Moise", "Rwanda", "Lasagna");
            student s5 = new student("Manik", "Bangladesh", "Curry Chicken");


            List<student> students = new List<student>();

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);

            int pick = 0;
            bool co = true;





            while (co)
            {
                Console.WriteLine("Which student would you like to learn about?");

                try
                {
                    string input = Console.ReadLine();
                    pick = int.Parse(input);

                }
                catch (FormatException e)
                {
                    Console.WriteLine("A valid int was not given.");
                }
                student s = students[pick];

                Console.WriteLine(s.GetName());

                Console.WriteLine("What would you like to know about " + s.GetName() + "? Enter hometown or Favorite Food.");

                try
                {
                    string input = Console.ReadLine();

                    input.ToLower();
                    if (input == "hometown")
                    {
                        Console.WriteLine (s.GetName() + " hometown is "   + s.GetHometown());
                    }
                    else if (input == "favorite food")
                    {
                        Console.WriteLine(s.GetName() + " favorite food is " + s.GetFavFood());
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter correct syntax. Try again.");
                }


                Console.WriteLine("Would you like to continue? Y or N: ");

                string decision = Console.ReadLine();

                if (decision.ToLower() == "y")
                {
                    co = true;
                }
                else
                {
                    co = false;
                    Console.WriteLine("Goodbye...");
                }
            
            }
        }
    }
}
