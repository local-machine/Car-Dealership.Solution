using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public string Msg;

  public Car(string makeModel, int price, int miles, string msg)
  {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Msg = msg;
  }

  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    
    return ((Price < maxPrice) && (Miles<maxMiles));
    
  }
}

public class Program
{
  public static void Main()
  {
    
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "A two-wheel drive, four-door, convertible, manufactured and marketed by Volkswagen from 1968 to 1983.");
    Car yugo = new Car("1980 Yugo Koral", 700, 56000, "A supermini hatchback formerly manufactured by Zastava Automobiles, at the time a Yugoslav corporation.");
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "A series of station wagons that was assembled by American automaker Ford.");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "A two-door compact car produced in the United States by the American Motors Corporation from 1975 to 1979.");

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum Miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice,maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
  if (CarsMatchingSearch.Count==0)
      {
        Console.WriteLine("All of our automobiles are out of your budget");
     
      }
    foreach(Car automobile in CarsMatchingSearch)
    {
      
    
       Console.WriteLine(automobile.MakeModel + automobile.Msg);
    
  }
  }
}