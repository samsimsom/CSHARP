
using System;

namespace Packt.Shared
{
    public partial class Person
    {

        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }

        public string FavoriteIceCream { get; set; }

        private string _favoritePrimaryColor;
        public string FavoritePrimaryColor
        {
            get
            {
                return _favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        _favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException($"{value} is not a" + 
                            $"primary color. Choose from: red, green or blue.");
                }
            }
        }

        // a property defined using c# 1 - 5 syntax
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        // two properties defined using c# 6+ lambda expression syntax
        public string Greeting => $"{Name} says Hello!";
    
        public int Age => DateTime.Today.Year - DateOfBirth.Year;

    }
}