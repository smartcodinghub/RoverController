using System;

namespace RoverController
{
    /// <summary>
    /// Represents the X, Y coordinates in a 2D space.
    /// </summary>
    public class Coordinates : IEquatable<Coordinates>
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Adds two coordinates and returns a new one.
        /// </summary>
        /// <param name="toAdd"></param>
        /// <returns></returns>
        public Coordinates Add(Coordinates toAdd) => new Coordinates(this.X + toAdd.X, this.Y + toAdd.Y);

        public override int GetHashCode() => HashCode.Combine(this.X, this.Y);

        public override bool Equals(object obj)
        {
            if (obj is Coordinates other) return Equals(other);

            return base.Equals(obj);
        }

        public bool Equals(Coordinates other) => this.X == other.X && this.Y == other.Y;

        public override string ToString() => $"({this.X}, {this.Y})";
    }
}
