using System;

namespace DatingProfile
{ 
    class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        // Constructor with full information
        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            Name = name;
            Age = age;
            City = city;
            Country = country;
            Pronouns = pronouns;
            Hobbies = new string[0];
        }

        // Constructor with minimum information (name and age)
        public Profile(string name, int age)
        {
            Name = name;
            Age = age;
            City = "";
            Country = "";
            Pronouns = "they/them";
            Hobbies = new string[0];
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Age must be at least 18 years old.");
                }
            }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Pronouns
        {
            get { return pronouns; }
            set { pronouns = value; }
        }

        public string[] Hobbies
        {
            get { return hobbies; }
            set { hobbies = value; }
        }

        public string ViewProfile()
        {
            string bio = $"Name: {Name}\nAge: {Age}\nCity: {City}\nPronouns: {Pronouns}\nHobbies:\n";
            if (Hobbies.Length == 0)
            {
                bio += "No hobbies listed yet.\n";
            }
            else
            {
                foreach (string hobby in Hobbies)
                {
                    bio += $" - {hobby}\n";
                }
            }
            return bio;
        }

        public void SetHobbies(string[] hobbies)
        {
            Hobbies = hobbies;
        }
    }
}

