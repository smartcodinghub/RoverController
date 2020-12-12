using Xunit;
using RoverController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverController.Tests
{
    public class CardinalPointShould
    {
        [Fact()]
        public void BeTrueWhenStringValueExists()
        {
            string value = "N";

            Assert.True(CardinalPoint.TryParse(value, out CardinalPoint _));
        }

        [Fact()]
        public void HaveAParsedValueWhenStringValueExists()
        {
            string value = "S";

            CardinalPoint.TryParse(value, out CardinalPoint parsed);

            Assert.Equal(CardinalPoint.South, parsed);
        }

        [Fact()]
        public void BeFalseWhenStringValueDoesNotExists()
        {
            string value = "A";

            Assert.False(CardinalPoint.TryParse(value, out CardinalPoint _));
        }

        [Fact()]
        public void BeFalseWhenStringValueIsInvalid()
        {
            string value = null;

            Assert.False(CardinalPoint.TryParse(value, out CardinalPoint _));
        }

        [Fact()]
        public void BeTrueWhenNumericValueExists()
        {
            int numericValue = 1;

            Assert.True(CardinalPoint.TryParse(numericValue, out CardinalPoint _));
        }

        [Fact()]
        public void HaveAParsedValueWhenNumericValueExists()
        {
            int numericValue = 3;

            CardinalPoint.TryParse(numericValue, out CardinalPoint parsed);

            Assert.Equal(CardinalPoint.West, parsed);
        }

        [Fact()]
        public void BeFalseWhenNumericValueDoesNotExists()
        {
            int numericValue = 6;

            Assert.False(CardinalPoint.TryParse(numericValue, out CardinalPoint _));
        }
    }
}