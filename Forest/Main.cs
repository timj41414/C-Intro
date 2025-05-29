using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.name = "Frozen Borealis";
      f.biome = "Tundra";
      f.species = "Spruce";
      f.trees = 650;
      f.age = 425;
      
      Console.WriteLine($"{f.name} the {f.biome} with {f.trees} {f.species} trees, that has existed for {f.age} years.");
    }
  }
}
