using System;
namespace objectsGC7
{
    public class student
    {

        public string Name;
        public string Hometown;
        public string FavFood;



 public student(string name, string hometown, string favfood)
        {
            Name = name;
            Hometown = hometown;
            FavFood = favfood;
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
    }
}
