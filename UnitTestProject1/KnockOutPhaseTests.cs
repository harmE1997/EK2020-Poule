using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wk2018_Poule;

namespace UnitTestProject1
{
    [TestClass]
    public class KnockOutPhaseTests
    {
        string[] last16 = new string[16];
        string[] last8 = new string[8];
        string[] last4 = new string[4];
        string[] final = new string[2];

        [TestMethod]
        public void testKnockOutConstructorWithCorrectInput()
        {
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "duitsland", "argentinië");
            Assert.AreEqual(last16, ko.Last16);
            Assert.AreEqual(last8, ko.Last8);
            Assert.AreEqual(last4, ko.Last4);
            Assert.AreEqual(final, ko.Final);
            Assert.AreEqual("duitsland", ko.Bronze);
            Assert.AreEqual("argentinië", ko.Champion);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void testKnockOutConstructorWithWrongArrayNull()
        {
            KnockOutPhase ko = new KnockOutPhase(null, last8, last4, final, "duitsland", "argentinië");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void testKnockOutConstructorWithWrongStringNull()
        {
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, null, "argentinië");
        }

        [TestMethod]
        public void testKnockOutCheckMethodWithWrongInput()
        {
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "duitsland", "argentinië");
            int score = ko.checkKnockoutPhase(null);
            Assert.AreEqual(-1, score);
        }

        [TestMethod]
        public void testKnockOutCheckMethodWithCorrectInput()
        {
            last16[4] = "spanje";
            last8[5] = "frankrijk";
            last4[2] = "argentinië";
            final[0] = "duitsland";
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "duitsland", "argentinië");
            KnockOutPhase answers = new KnockOutPhase(last16, last8, last4, final, "duitsland", "argentinië");
            int score = ko.checkKnockoutPhase(answers);
            Assert.AreEqual(2000, score);
        }
    }
}
