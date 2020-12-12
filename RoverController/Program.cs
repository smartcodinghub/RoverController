using System;
using System.Linq;

namespace RoverController
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rover Controller!");

            try
            {
                string sizeLine = ReadLine("Enter the size of the square (Width Height):");
                Size size = ParseSize(sizeLine);

                string coordinatesLine = ReadLine("Enter the initial coordinates (X, Y):");
                Coordinates coordinates = ParseCoordinates(coordinatesLine);

                string cardinalPointLine = ReadLine($"Enter the initial orientation ({string.Join(", ", CardinalPoint.All.Select(cp => cp.ToString()))}):");
                CardinalPoint cardinalPoint = ParseCardinalPoint(cardinalPointLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static Size ParseSize(string sizeLine)
        {
            string[] splitted = sizeLine.Split(" ");

            if (splitted.Length != 2) throw new ArgumentException("Size must be in (Width Height) format!");

            if (!int.TryParse(splitted[0].Trim(), out int width))
                throw new ArgumentException("Width must be a number!");

            if (!int.TryParse(splitted[1].Trim(), out int height))
                throw new ArgumentException("Height must be a number!");

            return new Size(width, height);
        }

        public static Coordinates ParseCoordinates(string coordinatesLine)
        {
            string[] splitted = coordinatesLine.Split(", ");

            if (splitted.Length != 2) throw new ArgumentException("Coordinates must be in (X, Y) format!");

            if (!int.TryParse(splitted[0].Trim(), out int x))
                throw new ArgumentException("X must be a number!");

            if (!int.TryParse(splitted[1].Trim(), out int y))
                throw new ArgumentException("Y must be a number!");

            return new Coordinates(x, y);
        }

        public static CardinalPoint ParseCardinalPoint(string cardinalPointLine)
        {
            if (!CardinalPoint.TryParse(cardinalPointLine, out CardinalPoint parsed))
                throw new ArgumentException($"The orientation must be one of the following values ({string.Join(", ", CardinalPoint.All.Select(cp => cp.ToString()))})!");

            return parsed;
        }

        private static string ReadLine(string message)
        {
            Console.Write(message + " ");
            return Console.ReadLine();
        }
    }
}
