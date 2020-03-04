using System;

public class JumpBall: IHaveWeight, ICanMove
{
    int CoordinateY;
    int Velosity;
	public JumpBall(int CurrentWeight, int Height) {
        Weight = CurrentWeight;
        CoordinateY = Height;
        Velosity = 0;
	}
    public override void ChangeWeigh(int newWeight){
        Weight = newWeight;
    }
    public void TimeIsGoing(int Time)
    {
        Height = Height - (Time * Velosity + 10 * Time * Time / 2);
        Velosity = Velosity + 10 * Time;
    }
}
