using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakkila",30,"New york","USA","he/him") ; 
       Profile jack = new Profile("Jack Drakkila",35) ; 
      Console.WriteLine(jack.ViewProfile());
      sam.SetHobbies(new string[] {"listening to audiobooks and podcasts","playing rec sports like bowling and kickball","writing a speculative fiction novel","reading advice columns"} ) ;
    }
  }
}

