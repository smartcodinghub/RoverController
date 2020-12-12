using System;
using System.Linq;

namespace RoverController
{
    public sealed class RoverController
    {
        private readonly Size squareSize;

        public Coordinates CurrentCoordinates { get; private set; }
        public CardinalPoint CurrentCardinalPoint { get; private set; }

        public RoverController(Size squareSize, Coordinates initialCoordinates, CardinalPoint initialOrientation)
        {
            if (squareSize.IsEmpty) throw new ArgumentOutOfRangeException(nameof(squareSize), "Can't be 0, 0");
            if (initialCoordinates.X < 0 || initialCoordinates.Y < 0) throw new ArgumentOutOfRangeException(nameof(initialCoordinates), "Should be 0 or positive.");

            this.squareSize = squareSize;
            this.CurrentCoordinates = initialCoordinates;
            this.CurrentCardinalPoint = initialOrientation;
        }

        public bool Handle(Commands[] command) => command.All(Move);

        public override string ToString() => $"{this.CurrentCardinalPoint}, {this.CurrentCoordinates}";

        private bool Move(Commands command)
        {
            switch (command)
            {
                case Commands.A:

                    /* Check if we have to increase/decrease X or Y coordinate.  */
                    int x = this.CurrentCardinalPoint == CardinalPoint.West ? -1 : this.CurrentCardinalPoint == CardinalPoint.East ? 1 : 0;
                    int y = this.CurrentCardinalPoint == CardinalPoint.South ? -1 : this.CurrentCardinalPoint == CardinalPoint.North ? 1 : 0;
                    Coordinates toAdd = new Coordinates(x, y);

                    Coordinates newCoordinates = this.CurrentCoordinates.Add(toAdd);

                    if (this.squareSize.IsWithinBounds(newCoordinates))
                    {
                        this.CurrentCoordinates = newCoordinates;
                        return true;
                    }

                    return false;
                case Commands.L:
                    this.CurrentCardinalPoint = this.CurrentCardinalPoint.Rotate(CardinalPoint.Rotation.CounterClockwise);
                    return true;
                case Commands.R:
                    this.CurrentCardinalPoint = this.CurrentCardinalPoint.Rotate(CardinalPoint.Rotation.Clockwise);
                    return true;
                default:
                    return false;
            }
        }
    }
}
