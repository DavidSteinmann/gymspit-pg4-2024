
namespace Lecture5;

internal class RoadBikeService : BasicBikeService
{
    public override void Accept(RoadBike bike)
    {
        Console.WriteLine("fixing road bike");
    }
}
