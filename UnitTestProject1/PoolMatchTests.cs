using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wk2018_Poule;

namespace UnitTestProject1
{
    [TestClass]
    public class PoolMatchTests
    {
        [TestMethod]
        public void PoolMatchConstructorTestWithCorrectInputData()
        {
            PoolMatchResult match = new PoolMatchResult(2, 1);
            Assert.AreEqual(2, match.ScoreA);
            Assert.AreEqual(1, match.ScoreB);
            Assert.AreEqual("A", match.Winner);
        }

        [TestMethod]
        public void PoolMatchResultToStringTestWith99()
        {
            PoolMatchResult match = new PoolMatchResult(99, 99);
            Assert.AreEqual( " - ",match.MatchToString());
        }

        [TestMethod]
        public void PoolMatchResultToStringTestWithNormalResult()
        {
            PoolMatchResult match = new PoolMatchResult(2, 2);
            Assert.AreEqual( "2 - 2" ,match.MatchToString());
        }
    }
}
