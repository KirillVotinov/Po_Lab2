using System;

public class FloatingBalls : IHaveWeight, ICanMove
{
	

    public int CoordinateY { private set; get; }
    public int ArhimedPower { private set; get; }
    public override void ChangeWeigh(int newWeight)
    {
        Weight = newWeight;
    }
    public FloatingBalls(int CurrentPower, int CurrentHeight)
    {
        ArhimedPower = CurrentPower;
        CurrentHeight = CoordinateY;
    }
    public void TimeIsGoing(int Time)
    {
        CoordinateY = ArhimedPower * 1000 * 10 - Weight * 10;
    }
}
