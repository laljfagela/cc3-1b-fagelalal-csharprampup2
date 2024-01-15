// Programmed by: FAGELA, Lucci Ania Luisse J.
// ACTIVITY: Ramp Up 2 
// Date of Submission: January 17, 2024 

using System;

namespace RampUp2
{
  class Program
  {
    static void Main(string[] args)
    {
        // Pounds to Kilograms 
      Console.Write("Input weight in pounds: ");
      double weight_in_Pounds = Convert.ToDouble(Console.ReadLine());
      
      double weight_in_Kilograms = weight_in_Pounds * 0.453592;
      
      Console.WriteLine("Weight in Pounds(lb): " + weight_in_Pounds);
      Console.WriteLine("Weight converted to Kilograms(kg): " + weight_in_Kilograms);
      Console.WriteLine("=============================================");
      
      // Miles to Kilometers 
      Console.Write("Input length in miles: ");
      double length_in_Miles = Convert.ToDouble(Console.ReadLine());
      
      double length_in_Kilometers = length_in_Miles * 1.60934;
      
      Console.WriteLine("Lenght in Miles(ml): " + length_in_Miles);
      Console.WriteLine("Length converted to Kilometers(km): " + length_in_Kilometers);
      Console.WriteLine("=============================================");
      
      // Fahrenheit to Celsius
      Console.Write("Input temperature in Fahrenheit: ");
      double temp_in_Fahrenheit = Convert.ToDouble(Console.ReadLine());
      
      double temp_in_Celsius = (temp_in_Fahrenheit-32) / 1.8;
      
      Console.WriteLine("Temperature in Fahrenheit(°F): " + temp_in_Fahrenheit);
      Console.WriteLine("Temperature converted to Celsius(°C): " + temp_in_Celsius);
      Console.WriteLine("=============================================");

      // wag mo na gagalawin yung nasa taas tapos na yan 
      // Student Age 
      Console.WriteLine("Enter each student age: ");
      int[] studentAges = new int[10];
      for (int i = 0; i < 10; i++)
        {
            Console.Write($"Student {i+1}: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int age))
            {
                studentAges[i] = age;
            }
        }
        double averageAge = CalculateAverageStudentAge(studentAges);
        Console.WriteLine($"Average Age: {averageAge}");
    static double CalculateAverageStudentAge(int[] studentAges)
    {
        if(studentAges.Length == 0)
        {
            return 0; 
        }
        int sum = 0;
        
        foreach(int age in studentAges)
        {
            sum += age; 
        }
        return (double)sum / studentAges.Length; 
        Console.WriteLine("=============================================");
    }
      
      // Story
      Console.Write("Story");
       string[] characters ={"Vox Akuma", "Luca Kaneshiro", "Mysta Rias", "Ike Eveland", "Shu Yamino"};
       string[] ability ={"Voice Demon", "Mafia", "Fox", "Time Traveler", "Sorcerer"};
       string[] equipments = {"Blue-Diamond Pen", "Purple Flames", "Pomu Leaf", "Dragoon", "Purple Flamed Fire"};
       
        Console.WriteLine($@"In the Royal Flash Kingdom, 5 lads possessed different magical powers and capabilities.
            {characters[0]},  the {ability[0]}, has the power to influence others with his voice.
             {characters[1]}, the mean and evil {ability[1]} boss from the past
             {characters[2]}, the genius detective, is also a {ability[2]} in nature.
             {characters[3]}, is a novelist who is a {ability[3]} using his {equipments[0]}.
             And finally, {characters[4]}, a {ability[4]} with the ability to control his victim’s
             minds through his magical {equipments[1]}.
             They are heroes. As they ventured through Diamond City Lights,
             they were met with various elements that affected their powers gradually,
             the {equipments[2]}, remnants of Pomu Fairies who died because of a so-called angel,
             Enna Alouette. Enna Alouette used the Pomu Leaf to lure the five lads to her.
             However, before they arrive in Enna’s kingdom, they met a flaming purple {equipments[3]},
             Selen Tatsuki. Selen attacked the five lads,
             and they fought their hardest to defend and attack.
             But, Selen’s{equipments[4]} was so powerful, and Mysta sacrificed himself. 
             Taking the attack, to help save his friends. Mysta died.");
        
        Console.WriteLine("=============================================");
    }
  }
}

using System;
public class RightTriangle
{
    public static void Main(){
        int i, j, rows; 
        
        Console.WriteLine("Right Triangle");
        
        Console.WriteLine("Input number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine()));
        for(i=1; i <=rows;i++)
        {
            for(j=1;j<=i;j++)
            Console.WriteLine("{0}", j, );
            Console.WriteLine("\n");
        }
    }
}

// generates error 
