namespace Lecture5;

internal class Bike
{
    protected int Cadence;
    protected int Speed;
    protected int Gear;

    public Bike(int cadence, int speed, int gear)
    {
        Cadence = cadence;
        Speed = speed;
        Gear = gear;
    }

    public virtual void PrintDescription()
    {
        Console.WriteLine(
            $"{nameof(Bike)} is in gear {Gear} with a cadence of {Cadence} and traveling at a speed of {Speed}.");
    }

    public virtual void Fix(BasicBikeService service)
    {
        service.Accept(this);
    }
}
