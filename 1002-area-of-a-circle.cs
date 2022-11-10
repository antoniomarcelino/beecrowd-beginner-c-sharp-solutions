using System; 

class URI {
    static void Main(string[] args) { 
        const double PI = 3.14159;
        double r = Convert.ToDouble(Console.ReadLine());
        double a = PI * (r * r);
        
        Console.WriteLine($"A={a:F4}");
    }
}