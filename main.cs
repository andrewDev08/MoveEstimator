using System;

class Program {
  public static void Main (string[] args) {
    int baseRate = 200;
    int perHourRate = 150;
    int perMileRate = 2;
    
    Console.WriteLine("Please enter the number of Hours ");
    var x = Console.ReadLine();

     Console.WriteLine("Please enter the number of Miles ");
    var y = Console.ReadLine();
    
    int totalHours;
    int totalMiles;
    if (int.TryParse(x, out totalHours) && int.TryParse(y, out totalMiles))
    {
      double totalCost = (baseRate) + ( perHourRate * totalHours ) + ( perMileRate * totalMiles);
      Console.WriteLine("${0}", totalCost );
    }
    else {
      Console.WriteLine("Please only put the number" );
    }
  }
}