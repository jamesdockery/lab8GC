using System;
using System.Collections.Generic;

namespace objectsGC7
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /* Here I created my objects. These are student objects who derive their characteristics from the student class properties that I've defined.
             * The different characteristics/behaviours of my student object is a Name, a Hometown, and a favorite food.           
             *            
             */

            student s1 = new student("Jill", "Raleigh", "Chicken", "Blue");
            student s2 = new student("Jaime", "Scranton", "Ketchup", "Orange");
            student s3 = new student("James", "George Town", "Cheese", "Purple");
            student s4 = new student("Moise", "Rwanda", "Lasagna", "Green");
            student s5 = new student("Manik", "Bangladesh", "Curry Chicken", "Red");



            /* Here I created a "List" to store my student objects. A "List" is just a 
             * reference to a specific piece of data. In this case that reference is my student object.
             */

            List<student> students = new List<student>();

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);

            int pick = 0;
            bool co = true;




            Console.WriteLine("Would you like to add a student? Y or N: ");
            string response = Console.ReadLine();

            if (response.ToLower().Trim() == "y")
            {
                student create = new student();
                Console.WriteLine(create);
                students.Add(create);

            }

            Console.WriteLine("Would you like to continue? Y or N: ");
            string answer = Console.ReadLine();

            if(answer.ToLower().Trim() == "y")
            {

                while (co)
                {




                    Console.WriteLine("Which student would you like to learn about?");
                    Console.WriteLine("Enter 0 - " + (students.Count-1));
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

                    Console.WriteLine("What would you like to know about " + s.GetName() + "? Enter hometown, Favorite Food, or Favorite Color.");



                    try
                    {
                        string input = Console.ReadLine();

                        input.ToLower();
                        if (input == "hometown")
                        {
                            Console.WriteLine(s.GetName() + " hometown is " + s.GetHometown());
                        }
                        else if (input == "favorite food")
                        {
                            Console.WriteLine(s.GetName() + " favorite food is " + s.GetFavFood());
                        }
                        else if (input == "favorite color")
                        {
                            Console.WriteLine(s.GetName() + " favorite color is " + s.GetFavColor());

                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Please enter correct Syntax. Please try again.");
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
                        Console.WriteLine("Thank you for participating. Goodbye...");
                    }
                }

            }



        }
        }
    }

