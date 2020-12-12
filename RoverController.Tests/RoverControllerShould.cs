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
            Assert.Throws<ArgumentOutOfRangeException>(() => new RoverController(new Size(0, 0), new Point(0, 1), CardinalPoint.North));
        }

        [Fact]
        public void ThrowWhenTheXCoordinateIsNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new RoverController(new Size(1, 0), new Point(-1, 1), CardinalPoint.North));
        }

        [Fact]
        public void ThrowWhenTheYCoordinateIsNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new RoverController(new Size(1, 0), new Point(1, -1), CardinalPoint.North));
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
        public void BeTrueWhenThePointIsInBounds()
        {
            throw new XunitException("Not Implemented");
        }

        [Fact]
        public void BeFalseWhenThePointIsOutBounds()
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