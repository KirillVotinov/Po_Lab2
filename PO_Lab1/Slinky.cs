using System;

public class Slinky : IHaveWeight, ICanMove
{
    public int CoordinateX { private set; get; }
    public int Velosity { private set; get; }
    public Slinky()
	{
        CoordinateX = Coordinate;
        Weight = CurrentWeight;
    }
    public void TimeIsGoing(int Time)
    {
        newHeight = 0;
        newHeight = CoordinateX - Time;
        Velosity = newHeight * 20;
        CoordinateX = newHeight;
    }
}
