using System;

namespace MoneyMaker

{

  class MainClass

  {

    public static void Main(string[] args)

    {

      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount of money to convert to coins:");

      string amountMoney = Console.ReadLine();
      double money = Convert.ToDouble(amountMoney);
      Console.WriteLine($"{amountMoney} cents is equal to...");

      // define value 
      int gold = 10;
      int silver = 5;
      // find the maximun number that fits gold
      double goldCoins = Math.Floor(money/gold);
      double leftOver = money % gold;
      // find the maximun number that fits silver
      double silverCoins = Math.Floor(leftOver/silver);
      leftOver = goldCoins % gold;

      Console.WriteLine($"Gold coins: {goldCoins}");

      Console.WriteLine($"Silver coins: {silverCoins}");

      Console.WriteLine($"Bronze coins: {leftOver}");

    }

  }

}