using System;

namespace RoverController
{
    public class Size : IEquatable<Size>
    {
        public int Height { get; private set; }
        public int Width { get; private set; }

        public bool IsEmpty => this.Height == 0 && this.Width == 0;

        public Size(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public bool IsWithinBounds(Coordinates point) => point.X >= 0 && point.Y >= 0 &&
            point.X <= this.Width && point.Y <= this.Height;


        public override int GetHashCode() => HashCode.Combine(this.Height, this.Width);

        public override bool Equals(object obj)
        {
            if (obj is Size other) return Equals(other);

            return base.Equals(obj);
        }

        public bool Equals(Size other) => this.Width == other.Width && this.Height == other.Height;
    }
}
