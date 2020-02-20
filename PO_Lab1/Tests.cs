using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace PO_Lab1
{
    
    [TestFixture]
    class Tests
    {
        /// <summary>Tests for acselleration.</summary>
        [Test]
        public void TestForAcselleration()
        {
            RedBall ball = new RedBall(0,1,5,1);
            Assert.IsTrue(ball.Acseleration == -1);
        }
        /// <summary>Tests for time.</summary>
        [Test]
        public void TestForTime()
        {
            RedBall ball = new RedBall(0, 1, 5, 1);
            ball.TimeIsGoing(20);
            Assert.IsTrue(ball.Acseleration == 0 && ball.Velosity == 0);
        }
    }
}
