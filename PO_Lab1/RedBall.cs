using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Lab1
{
    class RedBall : IHaveWeight, ICanMove
    {
        public int CoordinateX { private set; get; }
        public int Velosity { private set; get; }
        public int Acseleration { private set; get; }
        public override void ChangeWeigh(int newWeight)
        {
            Weight = newWeight;
        }

        /// <summary>Initializes a new instance of the <see cref="RedBall"/> class.</summary>
        /// <param name="Coordinate">The coordinate.</param>
        /// <param name="CurrentVelosity">The current velosity.</param>
        /// <param name="AppliedStrength">The applied strength.</param>
        /// <param name="CurrentWeight">The current weight.</param>
        public RedBall(int Coordinate, int CurrentVelosity, int AppliedStrength, int CurrentWeight)
        {
            CoordinateX = Coordinate;
            Velosity = CurrentVelosity;
            Weight = CurrentWeight;
            Acseleration =  Convert.ToInt32((AppliedStrength - 0.6 * 10 * Weight) / Weight);
        }

        public void TimeIsGoing(int Time)
        {
            CoordinateX = CoordinateX + Velosity * Time + Acseleration * Time * Time / 2;
            int newVelosity = Velosity + Acseleration * Time;
            if(Time > Velosity/Acseleration)
            {
                int newTime = Velosity / Acseleration;
                CoordinateX = CoordinateX + Velosity * newTime + Acseleration * newTime * newTime / 2;
                Velosity = 0;
                Acseleration = 0;
            }
        }
        public void Stop()
        {
            Velosity = 0;
            Acseleration = 0;
        }
    }
}

