
namespace Lecture5;

internal class RoadBike : Bike
{
    private int TireWidth;

    public RoadBike(int cadence, int speed, int gear, int tireWidth) : base(cadence, speed, gear)
    {
        TireWidth = tireWidth;
    }

    public override void PrintDescription()
    {
        Console.WriteLine(
             $"{nameof(RoadBike)} is in gear {Gear} with a cadence of {Cadence} and traveling at a speed of {Speed} and tire width {TireWidth}.");
    }

    public override void Fix(BasicBikeService service)
    {
        service.Accept(this);
    }
}
