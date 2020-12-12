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
        public void BeTrueWhenTheValueExists()
        {
            string value = "N";

            Assert.True(CardinalPoint.TryParse(value, out CardinalPoint _));
        }

        [Fact()]
        public void HaveAParsedValueWhenTheValueExists()
        {
            string value = "S";

            CardinalPoint.TryParse(value, out CardinalPoint parsed);

            Assert.Equal(CardinalPoint.South, parsed);
        }

        [Fact()]
        public void BeFalseWhenTheValueDoesNotExists()
        {
            string value = "A";

            Assert.False(CardinalPoint.TryParse(value, out CardinalPoint _));
        }

        [Fact()]
        public void BeFalseWhenTheValueIsInvalid()
        {
            string value = null;

            Assert.False(CardinalPoint.TryParse(value, out CardinalPoint _));
        }
    }
}