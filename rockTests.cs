using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoloLearn;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoloLearn.Tests
{
    [TestClass()]
    public class rockTests
    {
        private rock Rock = new rock();
        private String[] weaponList = new String[] { "Rock", "Scissors", "Paper" };

        [TestMethod()]
        public void generateRequestTest()
        {
            String result = rock.generateRequest(weaponList);
            Assert.Equals("Please select 1. Rock 2. Scissors 3. Paper 4. Exit", result);
        }

        [TestMethod()]
        public void determineWinnerRockRockTest()
        {
            String result = rock.determineWinner(weaponList, 0, 0);
            Assert.Equals("Draw both selected Rock", result);
        }
    }
}