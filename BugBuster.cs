using System;

namespace BugSquasher
{
  class Program
  {
    static void Main(string[] args)
    {
      /* junior */double/*was an "int" not a "double"*/ triple = 38498.3222;

      string/*missing "string"*/ dinosaur = "Barney";

      double key/*was "lock"*/ = 293.000;

      bool isnt,yes/*was "is.yet"*/ = true;

      string band = "The Low Anthem";/*was missing ";"*/

    }
  }
}
