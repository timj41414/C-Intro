using System;

namespace BuiltInMethods
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Buddy Holly", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      
      //Lets find the first song that is 3 stars
      int star = Array.IndexOf(ratings, 3); //Indexes the first value of "3"
      star++; //Increments the new integer by 1 to account for 0 indexing
      Console.WriteLine($"Song number {star} is rated 3 stars.");

      Console.WriteLine($"First song is now {summerStrut[0]} and last song is {summerStrut[7]}.");

      Array.Reverse(summerStrut);
      Console.WriteLine($"First song is now {summerStrut[0]} and last song is {summerStrut[7]}.");

      Array.Sort(summerStrut);
      Console.WriteLine($"First song is now {summerStrut[0]} and last song is {summerStrut[7]}.");
    }
  }
}
