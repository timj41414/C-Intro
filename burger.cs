using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
    decimal hamburgerCost = 5.99m;
    decimal friesCost = 3.99m;
    decimal shakeCost = 4.99m;
    decimal cashOnHand = 0.00m;

    Console.WriteLine("How much money do you have?");
    string input = Console.ReadLine();
    try {cashOnHand = decimal.Parse(input);}
    catch {Console.WriteLine("Not a valid cash amount");}

    bool canAffordHamburger = (cashOnHand >= hamburgerCost);
    if (canAffordHamburger == true) {
      cashOnHand = cashOnHand - hamburgerCost;
      bool canAffordFries = (cashOnHand >= friesCost);
      if (canAffordFries == true) {
        cashOnHand = cashOnHand - friesCost;
        bool canAffordShake = (cashOnHand >= shakeCost);
        if (canAffordShake == true) {
          Console.WriteLine("Full Meal :)");
          }
        else Console.WriteLine("Burger and Fries, nice!");
        }
      else Console.WriteLine("Burger, alright.");
      }
    else Console.WriteLine("No burger :(");
    }
  }
}
