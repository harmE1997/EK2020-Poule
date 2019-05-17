using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wk2018_Poule;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class PlayerManagerTests
    {
        PoolMatchResult guessmatch = new PoolMatchResult(2, 0);
        PoolMatchResult[] guessmatches = new PoolMatchResult[48];
        string[] last16 = new string[16];
        string[] last8 = new string[8];
        string[] last4 = new string[4];
        string[] final = new string[2];
        Player guess; 

        [TestMethod]
        public void PlayerManagerConsturctorTest()
        {
            PlayerManager manager = new PlayerManager();
            Assert.AreEqual("WK2018", manager.FileName);
            Assert.IsNotNull(manager.Players);
        }


        [TestMethod]
        public void PlayerManagerTestAddWithCorrectInputData()
        {
            PlayerManager manager = new PlayerManager();
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            guess = new Player("guess", guessmatches, ko, bonus, "cash", "test@test.com");
            manager.AddPlayer(guess);
            Assert.AreEqual(guess, manager.Players[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlayerManagerTestAddWithInCorrectInputData()
        {
            PlayerManager manager = new PlayerManager();
            manager.AddPlayer(null);
        }

        [TestMethod]
        public void PlayerManagerTestFindPlayerWithCorrectInputData()
        {
            PlayerManager manager = new PlayerManager();
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            guess = new Player("guess", guessmatches, ko, bonus, "cash", "test@test.com");
            manager.AddPlayer(guess);
            Assert.AreEqual(guess, manager.FindPlayerByName("guess"));
        }

        [TestMethod]
        public void PlayerManagerTestFindPlayerWithCorrectInputButNoExistingPlayer()
        {
            PlayerManager manager = new PlayerManager();
            Assert.IsNull(manager.FindPlayerByName("test"));
        }

        [TestMethod]
        public void PlayerManagerTestFindPlayerWithInputNull()
        {
            PlayerManager manager = new PlayerManager();
            Assert.IsNull(manager.FindPlayerByName(null));
        }

        [TestMethod]
        public void PlayerManagerTestFindPlayerWithInputEmpty()
        {
            PlayerManager manager = new PlayerManager();
            Assert.IsNull(manager.FindPlayerByName(""));
        }

        [TestMethod]
        public void PlayerManagerTestRemovePlayerWithInputEmpty()
        {
            PlayerManager manager = new PlayerManager();
            Assert.IsFalse(manager.removePlayer(""));
        }

        [TestMethod]
        public void PlayerManagerTestRemovePlayerWithInputNull()
        {
            PlayerManager manager = new PlayerManager();
            Assert.IsFalse(manager.removePlayer(null));
        }

        [TestMethod]
        public void PlayerManagerTestRemovePlayerWithCorrectInputButPlayDoesntExist()
        {
            PlayerManager manager = new PlayerManager();
            Assert.IsFalse(manager.removePlayer("test"));
        }

        [TestMethod]
        public void PlayerManagerTestRemovePlayerWithCorrectInputAndExistingPlayer()
        {
            PlayerManager manager = new PlayerManager();
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            guess = new Player("guess", guessmatches, ko, bonus, "cash", "test@test.com");
            manager.AddPlayer(guess);
            Assert.IsTrue(manager.removePlayer("guess"));
        }


        [TestMethod]
        public void testRankplayers()
        {
            PlayerManager manager = new PlayerManager();
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            guess = new Player("guess", guessmatches, ko, bonus, "cash", "test@test.com");
            manager.AddPlayer(guess);
            manager.rankPlayers();
            Assert.AreEqual(1, guess.Ranking);
        }
    }
}
