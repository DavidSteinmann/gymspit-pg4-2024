
namespace Lecture5;

internal class BasicBikeService
{
    public virtual void Accept(Bike bike)
    {
        Console.WriteLine("fixing bike");
    }

    public virtual void Accept(RoadBike bike)
    {
        Console.WriteLine("can't fix road bike");
    }

    public virtual void Accept(MountainBike bike)
    {
        Console.WriteLine("can't fix mountain bike");
    }
}
