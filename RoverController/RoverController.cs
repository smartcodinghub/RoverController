using System;
using System.Linq;

namespace RoverController
{
    public sealed class RoverController
    {
        private readonly Size squareSize;

        public Coordinates CurrentCoordinates { get; private set; }
        public CardinalPoint CurrentOrientation { get; private set; }

        public RoverController(Size squareSize, Coordinates initialCoordinates, CardinalPoint initialOrientation)
        {
            if (squareSize.IsEmpty) throw new ArgumentOutOfRangeException(nameof(squareSize), "Can't be 0, 0");
            if (initialCoordinates.X < 0 || initialCoordinates.Y < 0) throw new ArgumentOutOfRangeException(nameof(initialCoordinates), "Should be 0 or positive.");

            this.squareSize = squareSize;
            this.CurrentCoordinates = initialCoordinates;
            this.CurrentOrientation = initialOrientation;
        }

        public bool Handle(Commands[] command) => command.All(Move);

        private bool Move(Commands command)
        {
            switch (command)
            {
                case Commands.A:
                    //Coordinates newCoordinates = this.CurrentCoordinates + new Point();

                    break;
                case Commands.L:
                    this.CurrentOrientation = this.CurrentOrientation.Rotate(CardinalPoint.Rotation.CounterClockwise);
                    break;
                case Commands.R:
                    this.CurrentOrientation = this.CurrentOrientation.Rotate(CardinalPoint.Rotation.Clockwise);
                    break;
                default:
                    return false;
            }
            return true;
        }

        private bool IsInSquare(Coordinates point) => point.X >= 0 && point.Y >= 0 &&
            point.X <= this.squareSize.Width && point.Y <= this.squareSize.Height;
    }
}
