using System;
//2023-09-15-AndrewHorton-Exercise2.2
class Program {
  public static void Main (string[] args) {
    int baseRate = 200;
    int perHourRate = 150;
    int perMileRate = 2;
    
    Console.WriteLine("Please enter the number of Hours ");
    var x = Console.ReadLine();

     Console.WriteLine("Please enter the number of Miles ");
    var y = Console.ReadLine();
    
    double totalHours;
    double totalMiles;
    if (double.TryParse(x, out totalHours) && double.TryParse(y, out totalMiles))
    {
      double totalCost = (baseRate) + ( perHourRate * totalHours ) + ( perMileRate * totalMiles);
      Console.WriteLine("${0}", totalCost );
    }
    else {
      Console.WriteLine("Please only put the number" );
    }
  }
}