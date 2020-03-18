using System;

public class Pendilium : IHaveWeight, ICanMove
{
    int CoordinateX;
    int CoordinateY;
    int Velosity;
    public override void ChangeWeigh(int newWeight)
    {
        Weight = newWeight;
    }
    public Pendilium(int Height)
	{
        CoordinateX = 0;
        CoordinateY = 0;
        Velosity = 0;
	}

    public void TimeIsGoing(int Time)
    {
        newHeight = 0;
        newHeight = CoordinateY - Time;
        Velosity = newHeight*20;
        CoordinateY = newHeight;
    }

}
