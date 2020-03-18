using System;

public class Pushingballs : IHaveWeight, ICanMove
{
    public int FirstCoordinateX { private set; get; }
    public int FirstVelosity { private set; get; }
    public int SecondCoordinateX { private set; get; }
    public int SecondVelosity { private set; get; }

    public Pushingballs(int CurrentFirstVelosity, int CurrentSecondVelosity)
	{
        FirstCoordinateX = 0;
        CurrentSecondCoordinateX = 0;
        FirstVelosity = CurrentFirstVelosity;
        SecondVelosity = CurrentSecondVelosity;
    }

}
