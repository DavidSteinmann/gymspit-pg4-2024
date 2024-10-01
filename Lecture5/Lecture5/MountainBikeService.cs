
namespace Lecture5;

internal class MountainBikeService : BasicBikeService
{
    public override void Accept(MountainBike bike)
    {
        Console.WriteLine("fixing mountain bike");
    }
}
