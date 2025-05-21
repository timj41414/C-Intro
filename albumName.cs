using System;

namespace ArrayLength
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] summerStrut;

      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito 2", "Los Angeles"};

      /*if (summerStrut.Length == 8)
      {
        Console.WriteLine("Playlist is ready to go!");
      }
      else if (summerStrut.Length > 8)
      {
        Console.WriteLine("Playlist is too long!");
      }
      else
      {
        Console.WriteLine("Playlist is too short, add stuff!");
      }*/

      string message = summerStrut.Length == 8 ? "Playlist is ready to go!" : "Playlist is not ready!";
      Console.WriteLine(message);

      }
    }
  }