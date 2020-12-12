using System;
using System.Collections.Generic;
using System.Text;

namespace RoverController
{
    /// <summary>
    /// Represents the cardinal points.
    /// </summary>
    public class CardinalPoint
    {
        public static readonly CardinalPoint North = new("N", 0);
        public static readonly CardinalPoint East = new("E", 1);
        public static readonly CardinalPoint South = new("S", 2);
        public static readonly CardinalPoint West = new("W", 3);

        public static readonly CardinalPoint[] All = new[] { North, East, South, West };

        public string Acronym { get; }
        public int Number { get; }

        private CardinalPoint(string acronym, int number)
        {
            this.Acronym = acronym;
            this.Number = number;
        }

        /// <summary>
        /// Parses an string to a CardinalPoint
        /// </summary>
        /// <param name="value">string to parse</param>
        /// <param name="parsed">parsed cardinal point</param>
        public static bool TryParse(string value, out CardinalPoint parsed)
        {
            parsed = North;
            return true;
        }
    }
}
