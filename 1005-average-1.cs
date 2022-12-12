using System; 

class URI {
    static void Main(string[] args) { 
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double aWeight = 3.5;
        double bWeight = 7.5;
        double weightsSum = aWeight + bWeight;
        double weighedA = a * aWeight;
        double weighedB = b * bWeight;
        double weighedNumbersSum = weighedA + weighedB;
        double average = weighedNumbersSum / weightsSum;
        
        Console.WriteLine($"MEDIA = { average.ToString("0.00000")}");
    }
}