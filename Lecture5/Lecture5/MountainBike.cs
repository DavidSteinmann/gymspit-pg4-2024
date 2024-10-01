
namespace Lecture5;

internal class MountainBike : Bike
{
    protected string Suspension;

    public MountainBike(int cadence, int speed, int gear, string suspension) : base(cadence, speed, gear)
    {
        Suspension = suspension;
    }

    public override void PrintDescription()
    {
        Console.WriteLine(
             $"{nameof(MountainBike)} is in gear {Gear} with a cadence of {Cadence} and traveling at a speed of {Speed} with suspension {Suspension}.");
    }

    public override void Fix(BasicBikeService service)
    {
        service.Accept(this);
    }
}
