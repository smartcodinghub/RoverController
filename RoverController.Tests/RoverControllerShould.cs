using System;
using System.Drawing;
using Xunit;
using Xunit.Sdk;

namespace RoverController.Tests
{
    /// <summary>
    /// RoverController should fulfill all this requirements.
    /// </summary>
    public class RoverControllerShould
    {
        [Fact]
        public void ThrowWhenTheSquareIsTooSmall()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new RoverController(new Size(0, 0), new Coordinates(0, 1), CardinalPoint.North));
        }

        [Fact]
        public void ThrowWhenTheXCoordinateIsNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new RoverController(new Size(1, 0), new Coordinates(-1, 1), CardinalPoint.North));
        }

        [Fact]
        public void ThrowWhenTheYCoordinateIsNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new RoverController(new Size(1, 0), new Coordinates(1, -1), CardinalPoint.North));
        }

        [Fact]
        public void BeTrueWhenAllCommandsIsInBounds()
        {
            throw new XunitException("Not Implemented");
        }

        [Fact]
        public void BeFalseWhenAnyCommandIsOutBounds()
        {
            throw new XunitException("Not Implemented");
        }

        [Fact]
        public void ThrowWhenCommandIsInvalid()
        {
            throw new XunitException("Not Implemented");
        }

        [Fact]
        public void BeTrueWhenPointIsInSquare()
        {
            RoverController controller = new RoverController(new Size(10, 10), new Coordinates(0, 0), CardinalPoint.North);

            throw new XunitException("Not Implemented");
        }

        [Fact]
        public void BeTrueWhenPointIsNotInSquare()
        {
            throw new XunitException("Not Implemented");
        }

        [Fact]
        public void MoveToTheNextPositionIfInBounds()
        {
            throw new XunitException("Not Implemented");
        }

        [Fact]
        public void MoveToTheNextPositionWithinBounds()
        {
            throw new XunitException("Not Implemented");
        }
    }
}