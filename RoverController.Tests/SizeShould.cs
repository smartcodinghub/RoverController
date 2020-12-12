using Xunit;
using RoverController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverController.Tests
{
    public class SizeShould
    {
        [Fact()]
        public void BeTrueIfIsWithinBounds()
        {
            Size size = new Size(10, 10);
            Coordinates coordinates = new Coordinates(5, 5);

            Assert.True(size.IsWithinBounds(coordinates));
        }
        [Fact()]
        public void BeTrueIfIsOnTheLimitOfBounds()
        {
            Size size = new Size(10, 10);
            Coordinates coordinates = new Coordinates(10, 10);

            Assert.True(size.IsWithinBounds(coordinates));
        }

        [Fact()]
        public void BeFalseIfXIsOutOFBounds()
        {
            Size size = new Size(10, 10);
            Coordinates coordinates = new Coordinates(11, 5);

            Assert.False(size.IsWithinBounds(coordinates));
        }

        [Fact()]
        public void BeFalseIfYIsOutOFBounds()
        {
            Size size = new Size(10, 10);
            Coordinates coordinates = new Coordinates(8, 11);

            Assert.False(size.IsWithinBounds(coordinates));
        }
    }
}