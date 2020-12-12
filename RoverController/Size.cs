using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverController
{
    public class Size
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
    }
}
