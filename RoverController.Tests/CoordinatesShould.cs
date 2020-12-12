using Xunit;
using RoverController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverController.Tests
{
    public class CoordinatesShould
    {
        [Fact()]
        public void AddCorrectlyPositiveValues()
        {
            Coordinates coordinates = new Coordinates(0, 5);
            Coordinates toAdd = new Coordinates(1, 3);

            Assert.Equal(new Coordinates(1, 8), coordinates.Add(toAdd));
        }

        [Fact()]
        public void AddCorrectlyNegativeValues()
        {
            Coordinates coordinates = new Coordinates(0, 5);
            Coordinates toAdd = new Coordinates(1, -3);

            Assert.Equal(new Coordinates(1, 2), coordinates.Add(toAdd));
        }

        [Fact()]
        public void AddCorrectlyZero()
        {
            Coordinates coordinates = new Coordinates(0, 5);
            Coordinates toAdd = new Coordinates(0, -3);

            Assert.Equal(new Coordinates(0, 2), coordinates.Add(toAdd));
        }
    }
}