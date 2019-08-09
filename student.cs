using System;
namespace objectsGC7
{
    public class student
    {

        public string Name;
        public string Hometown;
        public string FavFood;
        public string FavColor;


 public student(string name, string hometown, string favfood, string favcolor)
        {
            Name = name;
            Hometown = hometown;
            FavFood = favfood;
            FavColor = favcolor;

        }
        public student()
        {
            string empty = System.String.Empty.Trim();

                Console.WriteLine("Enter name: ");
                Name = Console.ReadLine();
            if(Name == empty)
            {
                throw new Exception("Please enter a valid input.");
            }
                Console.WriteLine("Enter hometown: ");
                Hometown = Console.ReadLine();
            if(Hometown == empty)
            {
                throw new Exception("Please enter a valid input.");
            }
                Console.WriteLine("Enter Favorite Food: ");
                FavFood = Console.ReadLine();
            if(FavFood == empty)
            {
                throw new Exception("Please enter a valid input.");
            }
                Console.WriteLine("Enter Favorite Color: ");
                FavColor = Console.ReadLine();
            if(FavColor == empty)
            {
                throw new Exception("Please enter a valid input.");
            }
           
        }



        public string GetName()
        {
            return Name;
        }
        public string GetHometown()
        {
            return Hometown;
        }
        public string GetFavFood()
        {
            return FavFood;
        }
        public string GetFavColor()
        {
            return FavColor;
        }
       
    }
}
