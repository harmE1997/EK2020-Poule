using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wk2018_Poule;

namespace UnitTestProject1
{
    [TestClass]
    public class PlayerTests
    {
        PoolMatchResult[] guessmatches = new PoolMatchResult[48];
        PoolMatchResult match = new PoolMatchResult(2, 0);
        PoolMatchResult[] matches = new PoolMatchResult[48];
        Player guess;
        Player player;
        string[] last16 = new string[16];    
        string[] last8 = new string[8];
        string[] last4 = new string[4];
        string[] final = new string[2];


        [TestMethod]
        public void PlayerConstructorTest()
        {
            PoolMatchResult guessmatch = new PoolMatchResult(2, 0);
            PoolMatchResult[] guessmatches = new PoolMatchResult[48];
            guessmatches[0] = guessmatch;
            last16[0] = "Nederland";
            last8[0] = "Nederland";
            last4[0] = "Nederland";
            final[0] = "Nederland";
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            guess = new Player("guess", guessmatches, ko, bonus, "cash", "test@test.com");
            Assert.AreEqual("guess", guess.Name);
            Assert.AreEqual(guessmatches, guess.Results);
            Assert.AreEqual(ko, guess.KnockOut);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlayerConstructorTestwithEmptyString()
        {
            PoolMatchResult guessmatch = new PoolMatchResult(2, 0);
            PoolMatchResult[] guessmatches = new PoolMatchResult[48];
            guessmatches[0] = guessmatch;
            last16[0] = "Nederland";
            last8[0] = "Nederland";
            last4[0] = "Nederland";
            final[0] = "Nederland";
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            player = new Player("", guessmatches, ko, bonus, "cash", "test@test.com");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlayerConstructorTestwithNullString()
        {
            PoolMatchResult guessmatch = new PoolMatchResult(2, 0);
            PoolMatchResult[] guessmatches = new PoolMatchResult[48];
            guessmatches[0] = guessmatch;
            last16[0] = "Nederland";
            last8[0] = "Nederland";
            last4[0] = "Nederland";
            final[0] = "Nederland";
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            player = new Player(null , guessmatches, ko, bonus, "cash", "test@test.com");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlayerConstructorTestwithNullClass()
        {
            last16[0] = "Nederland";
            last8[0] = "Nederland";
            last4[0] = "Nederland";
            final[0] = "Nederland";
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            player = new Player("guess", guessmatches, null, bonus, "cash", "test@test.com");
        }

        [TestMethod]
        public void TestPlayerCheckMethodWithFullyCorrectMatch()
        {
            PoolMatchResult guessmatch = new PoolMatchResult(2, 0);        
            matches[0] = match;
            guessmatches[0] = guessmatch;         
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            player = new Player("host", matches, ko, bonus, "cash", "test@test.com");
            guess = new Player("guess", guessmatches, ko, bonus, "cash", "test@test.com");
            bool check = guess.Check(player);
            Assert.AreEqual(true, check);
            Assert.AreEqual(2800,guess.Score);       
        }

        [TestMethod]
        public void TestPlayerCheckMethodWithCorrectWinnerAndOneCorrectScore()
        {
            PoolMatchResult guessmatch = new PoolMatchResult(2, 1);
            matches[0] = match;
            guessmatches[0] = guessmatch;
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            player = new Player("host", matches, ko, bonus, "cash", "test@test.com");
            guess = new Player("guess", guessmatches, ko, bonus, "cash", "test@test.com");
            bool check = guess.Check(player);
            Assert.AreEqual(true, check);
            Assert.AreEqual(2780, guess.Score);
        }

        [TestMethod]
        public void TestPlayerCheckMethodWithCorrectWinnerAndnoCorrectScores()
        {
            PoolMatchResult guessmatch = new PoolMatchResult(3, 1);
            matches[0] = match;
            guessmatches[0] = guessmatch;
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            player = new Player("host", matches, ko, bonus, "cash", "test@test.com");
            guess = new Player("guess", guessmatches, ko, bonus, "cash", "test@test.com");
            bool check = guess.Check(player);
            Assert.AreEqual(true, check);
            Assert.AreEqual(2760, guess.Score);
        }

        [TestMethod]
        public void TestPlayerCheckMethodWithWrongWinnerAndOneCorrectScore()
        {
            PoolMatchResult guessmatch = new PoolMatchResult(2, 3);
            matches[0] = match;
            guessmatches[0] = guessmatch;
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            player = new Player("host", matches, ko, bonus, "cash", "test@test.com");
            guess = new Player("guess", guessmatches, ko, bonus, "cash", "test@test.com");
            bool check = guess.Check(player);
            Assert.AreEqual(true, check);
            Assert.AreEqual(2720, guess.Score);
        }

        [TestMethod]
        public void TestPlayerCheckMethodWithFullyWrongMatch()
        {
            PoolMatchResult guessmatch = new PoolMatchResult(1, 3);
            matches[0] = match;
            guessmatches[0] = guessmatch;
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            player = new Player("host", matches, ko, bonus, "cash", "test@test.com");
            guess = new Player("guess", guessmatches, ko, bonus, "cash", "test@test.com");
            bool check = guess.Check(player);
            Assert.AreEqual(true, check);
            Assert.AreEqual(2700, guess.Score);
        }

        [TestMethod]
        public void TestPlayerCheckMethodWithWrongInput()
        {
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            guess = new Player("guess", guessmatches, ko, bonus, "cash", "test@test.com");
            Assert.AreEqual(false, guess.Check(null));
        }

        [TestMethod]
        public void TestPlayerCheckMethodAfterCheckHasAlreadyBeenPerformedOnce()
        {
            PoolMatchResult guessmatch = new PoolMatchResult(2, 0);
            matches[0] = match;
            guessmatches[0] = guessmatch;
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            player = new Player("host", matches, ko, bonus, "cash", "test@test.com");
            guess = new Player("guess", guessmatches, ko, bonus, "cash", "test@test.com");
            bool check = guess.Check(player);
            Assert.AreEqual(true, check);
            Assert.AreEqual(2800, guess.Score);
            check = guess.Check(player);
            Assert.AreEqual(true, check);
            Assert.AreEqual(2800, guess.Score);
        }

        [TestMethod]
        public void TestPlayerToString()
        {
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            guess = new Player("guess", guessmatches, ko, bonus, "cash", "test@test.com");
            Assert.AreEqual("0.\tguess\t\t0", guess.playerToString());
        }

        [TestMethod]
        public void TestPlayerSetRanking()
        {
            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "Duitsland", "Nederland");
            BonusQuestions bonus = new BonusQuestions(150, 3, 100, 5, "messi");
            guess = new Player("guess", guessmatches, ko, bonus, "cash", "test@test.com");
            guess.setRanking(1);
            Assert.AreEqual(1, guess.Ranking);
        }
    }
}
