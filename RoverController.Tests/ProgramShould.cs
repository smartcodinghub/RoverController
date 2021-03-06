﻿using Xunit;
using RoverController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverController.Tests
{
    public class ProgramShould
    {
        [Fact()]
        public void ParseSizeWhenFormatIsCorrect()
        {
            Assert.Equal(new Size(20, 20), Program.ParseSize("20 20"));
        }

        [Fact()]
        public void ThrowWhenParseSizeWithIncorrectFormat()
        {
            Assert.Throws<ArgumentException>(() => Program.ParseSize("20, 20"));
        }

        [Fact()]
        public void ParseCoordinatesWhenFormatIsCorrect()
        {
            Assert.Equal(new Coordinates(20, 20), Program.ParseCoordinates("20, 20"));
        }

        [Fact()]
        public void ThrowWhenParseCoordinatesWithIncorrectFormat()
        {
            Assert.Throws<ArgumentException>(() => Program.ParseCoordinates("20 20"));
        }

        [Fact()]
        public void ParseCardinalPointWhenFormatIsCorrect()
        {
            Assert.Equal(CardinalPoint.North, Program.ParseCardinalPoint("N"));
        }

        [Fact()]
        public void ThrowWhenParseCardinalPointDoesNotExists()
        {
            Assert.Throws<ArgumentException>(() => Program.ParseCardinalPoint("A"));
        }

        [Fact()]
        public void ParseCommandsWhenFormatIsCorrect()
        {
            Assert.Equal(new[] { Commands.A, Commands.L, Commands.R }, Program.ParseCommands("ALR"));
        }

        [Fact()]
        public void ThrowWhenParseCommandsDoesNotExists()
        {
            Assert.Throws<ArgumentException>(() => Program.ParseCommands("ALRJ"));
        }
    }
}