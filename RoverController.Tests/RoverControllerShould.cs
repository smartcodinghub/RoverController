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
            RoverController controller = new RoverController(new Size(10, 10), new Coordinates(0, 0), CardinalPoint.North);
            Commands[] commands = new[] { Commands.A, Commands.A, Commands.A };

            Assert.True(controller.Handle(commands));
        }

        [Fact]
        public void BeFalseWhenAnyCommandIsOutBounds()
        {
            RoverController controller = new RoverController(new Size(2, 2), new Coordinates(0, 0), CardinalPoint.North);
            Commands[] commands = new[] { Commands.A, Commands.A, Commands.A };

            Assert.False(controller.Handle(commands));
        }

        [Fact]
        public void MoveToTheNextPositionWithinBounds()
        {
            RoverController controller = new RoverController(new Size(10, 10), new Coordinates(0, 0), CardinalPoint.North);
            Commands[] commands = new[] { Commands.A, Commands.A, Commands.A };

            controller.Handle(commands);

            Assert.Equal(new Coordinates(0, 3), controller.CurrentCoordinates);
        }

        [Fact]
        public void NotMoveToTheNextPositionWhenACommandIsOutOfBounds()
        {
            RoverController controller = new RoverController(new Size(2, 2), new Coordinates(0, 0), CardinalPoint.North);
            Commands[] commands = new[] { Commands.A, Commands.A, Commands.L, Commands.A, Commands.A };

            controller.Handle(commands);

            Assert.Equal(new Coordinates(0, 2), controller.CurrentCoordinates);
        }

        [Fact]
        public void RotateRightFromNorthToEastOnRCommand()
        {
            RoverController controller = new RoverController(new Size(10, 10), new Coordinates(0, 0), CardinalPoint.North);
            Commands[] commands = new[] { Commands.R };

            controller.Handle(commands);

            Assert.Equal(CardinalPoint.East, controller.CurrentCardinalPoint);
        }

        [Fact]
        public void RotateLeftFromWestToSouthOnLCommand()
        {
            RoverController controller = new RoverController(new Size(10, 10), new Coordinates(0, 0), CardinalPoint.West);
            Commands[] commands = new[] { Commands.L };

            controller.Handle(commands);

            Assert.Equal(CardinalPoint.South, controller.CurrentCardinalPoint);
        }

        [Fact]
        public void IncreaseYWhenAdvanceToNorth()
        {
            RoverController controller = new RoverController(new Size(2, 2), new Coordinates(0, 0), CardinalPoint.North);
            Commands[] commands = new[] { Commands.A };

            controller.Handle(commands);

            Assert.Equal(new Coordinates(0, 1), controller.CurrentCoordinates);
        }

        [Fact]
        public void DecreaseYWhenAdvanceToSouth()
        {
            RoverController controller = new RoverController(new Size(2, 2), new Coordinates(0, 1), CardinalPoint.South);
            Commands[] commands = new[] { Commands.A };

            controller.Handle(commands);

            Assert.Equal(new Coordinates(0, 0), controller.CurrentCoordinates);
        }

        [Fact]
        public void IncreaseXWhenAdvanceToEast()
        {
            RoverController controller = new RoverController(new Size(2, 2), new Coordinates(0, 0), CardinalPoint.East);
            Commands[] commands = new[] { Commands.A };

            controller.Handle(commands);

            Assert.Equal(new Coordinates(1,0), controller.CurrentCoordinates);
        }

        [Fact]
        public void DecreaseXWhenAdvanceToWest()
        {
            RoverController controller = new RoverController(new Size(2, 2), new Coordinates(1, 0), CardinalPoint.West);
            Commands[] commands = new[] { Commands.A };

            controller.Handle(commands);

            Assert.Equal(new Coordinates(0, 0), controller.CurrentCoordinates);
        }
    }
}