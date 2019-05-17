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
    public class BonusQuestionTests
    {
        [TestMethod]
        public void testBonusConstructorWithCorrecInput()
        {
            BonusQuestions bonus = new BonusQuestions(150, 5, 100, 20, "messi");
            Assert.AreEqual(150, bonus.nrGoals);
            Assert.AreEqual(5, bonus.nrOwnGoals);
            Assert.AreEqual(100, bonus.nrYellowCards);
            Assert.AreEqual(20, bonus.nrRedCards);
            Assert.AreEqual("messi", bonus.Topscorer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void testBonusConstructorThrowsExceptionWhenTopscorerIsEmpty()
        {
            BonusQuestions bonus = new BonusQuestions(150, 5, 100, 20, "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void testBonusConstructorThrowsExceptionWhenTopscorerIsNull()
        {
            BonusQuestions bonus = new BonusQuestions(150, 5, 100, 20, null);
        }

        [TestMethod]
        public void testBonusCheckMethodWithCorrectInput()
        {
            BonusQuestions bonus = new BonusQuestions(150, 5, 100, 20, "messi");
            BonusQuestions answers = new BonusQuestions(135, 12, 117, 16, "messi");
            int score = bonus.checkQuestions(answers);
            Assert.AreEqual(392, score);
            //140+0+132+20+100 = 392
        }

        [TestMethod]
        public void testBonusCheckMethodWithWrongInput()
        {
            BonusQuestions bonus = new BonusQuestions(150, 5, 100, 20, "messi");
            int score = bonus.checkQuestions(null);
            Assert.AreEqual(-1, score);
            //70+100+66+20+100 = 356
        }
    }
}
