using System.Linq;

namespace RoverController
{
    /// <summary>
    /// Represents the cardinal points.
    /// </summary>
    public class CardinalPoint
    {
        public enum Rotation { Clockwise = 1, CounterClockwise = -1 }

        public static readonly CardinalPoint North = new("N", 0);
        public static readonly CardinalPoint East = new("E", 1);
        public static readonly CardinalPoint South = new("S", 2);
        public static readonly CardinalPoint West = new("W", 3);

        public static readonly CardinalPoint[] All = new[] { North, East, South, West };
        private static readonly int cardinalPointsCount = All.Length;

        public string Acronym { get; }
        public int Number { get; }

        private CardinalPoint(string acronym, int number)
        {
            this.Acronym = acronym;
            this.Number = number;
        }

        /// <summary>
        /// Parses a string to a CardinalPoint
        /// </summary>
        /// <param name="value">string to parse</param>
        /// <param name="parsed">parsed cardinal point</param>
        public static bool TryParse(string value, out CardinalPoint parsed)
        {
            CardinalPoint found = All.FirstOrDefault(cp => string.Equals(cp.Acronym, value));

            if (found == null)
            {
                parsed = null;
                return false;
            }

            parsed = found;
            return true;
        }

        /// <summary>
        /// Parses a number to a CardinalPoint
        /// </summary>
        /// <param name="numericValue">number to parse</param>
        /// <param name="parsed">parsed cardinal point</param>
        public static bool TryParse(int numericValue, out CardinalPoint parsed)
        {
            CardinalPoint found = All.FirstOrDefault(cp => string.Equals(cp.Number, numericValue));

            if (found == null)
            {
                parsed = null;
                return false;
            }

            parsed = found;
            return true;
        }

        /// <summary>
        /// Rotates the cardinal point
        /// </summary>
        /// <param name="rotation"></param>
        public CardinalPoint Rotate(Rotation rotation)
        {
            int numericValue = this.Number;

            /* Using modulo operator so we are always repeating the same values (0,1,2,3,0,1,2,3) */
            int newCardinalPointNumericValue = (cardinalPointsCount + (numericValue + (int)rotation)) % cardinalPointsCount;

            /* This will always be true in this context */
            TryParse(newCardinalPointNumericValue, out CardinalPoint newCardinalPoint);

            return newCardinalPoint;
        }

        public override string ToString() => this.Acronym;
    }
}
