using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string name = "Bentley";
      string wizard = "Igarune";
      string beginning = "Once upon a time,";
      string middle = $"After a long and tiring battle, {name} defeated the evil wizard {wizard}";
      string end = $"Everyone and {name} lived happily ever after.";

      // Interpolate the string and the variables
      string story = $"{beginning}, there was this wicked wizard {wizard}, and he terrorized the kingdom and stole the MacGuffin. {name} set out on a quest to defeat {wizard}. {middle} and acquired the MacGuffin. {end}";

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}
