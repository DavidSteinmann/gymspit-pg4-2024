namespace Lecture5;

// Polymorphism excersize

/*
 * Create a base class Bike with parameters
 * - protected int Cadence
 * - protected int Speed
 * - protected int Gear
 * - public void PrintDescription()
 * "Bike is in gear 1 with a cadence of 20 and traveling at a speed of 10."
 * 
 * Create a constructor that takes all the parameters (cadence, speed, gear).
 * 
 * -----
 * Create classes RoadBike and MountainBike that inherit from Bike.
 * Road bike has an extra parameter
 * - int TireWidth
 * 
 * MountainBike has an extra parameter
 * - string Suspension
 * 
 * Create a constructor for the new classes that takes an extra parameter and calls base()
 * Override the PrintDescription() method to include the new parameters.
 * 
 * Create multiple variable of type Bike and assign different types and print their description.
 * 
 * 
 * 
 * --------
 * 
 * Create a BasicBikeService class that can fix an instance of Bike.
 * It will have a method
 * - void Accept(Bike)          -> prints "Fixing bike"
 * - void Accept(RoadBike)      -> prints "can't fix"
 * - void Accept(MountainBike)  -> prints "can't fix"
 * 
 * Create classes RoadBikeService and MountainBikeService that inherit from BasicBikeService.
 * The RoadBikeService will override the method Accept(RoadBike) to print "Fixing RoadBike".
 * 
 * The MountainBikeService will override method Accept(MountainBike) to print "Fixing MountainBike".
 * 
 * 
 * 
 * Try creating different instances of BikeService and try fixing different types of bikes.
 * 
 * 
 */

internal class Program
{
    // Generic method
    public static void Operate<T>(T parameter)
    {
        Console.WriteLine(parameter);
    }

    static void Main(string[] args)
    {
        Operate("Hello");
        Operate(123);

        int result = Calculator.Add(4, 6);
        float result2 = Calculator.Add(1.4f, 5.7f);

        double result3 = Calculator.Subtract(5, 7);




        Bike bike1 = new Bike(30, 60, 7);
        Bike bike2 = new RoadBike(20, 50, 6, 80);
        Bike bike3 = new MountainBike(15, 45, 5, "Dual");

        bike1.PrintDescription();
        bike2.PrintDescription();
        bike3.PrintDescription();



        BasicBikeService service1 = new BasicBikeService();
        BasicBikeService service2 = new RoadBikeService();
        BasicBikeService service3 = new MountainBikeService();

        Console.WriteLine();
        Console.WriteLine("BasicBikeService");
        service1.Accept(bike1);
        service1.Accept(bike2);
        service1.Accept(bike3);
        bike1.Fix(service1);
        bike2.Fix(service1);
        bike3.Fix(service1);

        Console.WriteLine();
        Console.WriteLine("RoadBikeService");
        service2.Accept(bike1);
        service2.Accept(bike2);
        service2.Accept(bike3);
        bike1.Fix(service2);
        bike2.Fix(service2);
        bike3.Fix(service2);


        Console.WriteLine();
        Console.WriteLine("MountainBikeService");
        service3.Accept(bike1);
        service3.Accept(bike2);
        service3.Accept(bike3);
        bike1.Fix(service3);
        bike2.Fix(service3);
        bike3.Fix(service3);
    }
}