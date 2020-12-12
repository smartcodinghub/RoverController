using System;

namespace RoverController
{
    public class Coordinates : IEquatable<Coordinates>
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

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
