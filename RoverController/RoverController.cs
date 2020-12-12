using System;
using System.Drawing;

namespace RoverController
{
    public sealed class RoverController
    {
        private readonly Size squareSize;

        public Point CurrentCoordinates { get; private set; }
        public CardinalPoint CurrentOrientation { get; private set; }

        public RoverController(Size squareSize, Point initialCoordinates, CardinalPoint initialOrientation)
        {
            if (squareSize.IsEmpty) throw new ArgumentOutOfRangeException(nameof(squareSize), "Can't be 0, 0");
            if (initialCoordinates.X < 0 || initialCoordinates.Y < 0) throw new ArgumentOutOfRangeException(nameof(initialCoordinates), "Should be 0 or positive.");

            this.squareSize = squareSize;
            this.CurrentCoordinates = initialCoordinates;
            this.CurrentOrientation = initialOrientation;
        }

        public bool Handle(Commands[] command)
        {
            return true;
        }

        private bool Move(Commands command)
        {
            return true;
        }

        private bool IsInSquare(Point point)
        {
            return true;
        }
    }
}
