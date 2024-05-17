using CSP001_guess_the_number;
namespace GuessTheNumber.Tests;
/* private int RandomNumberGenerator()
        {
            return new Random().Next(1, 101);
        }

        private bool CheckGuess(int guess, int targetNumber)
        {
            return guess == targetNumber;
        }
    }
} */
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestCheckGuessTrue()
    {
        var GameObject = new Game("Connie");
        var Result = GameObject.CheckGuess(2, 2);
        Assert.IsTrue(Result);
    }
    [TestMethod]
    public void TestCheckGuessFalse()
    {
        var GameObject = new Game("Connie");
        var Result = GameObject.CheckGuess(2, 3);
        Assert.IsFalse(Result);
    }
    [TestMethod]
    public void TestRandomNumber()
    {
        var GameObject = new Game("Connie");
        var Result = GameObject.RandomNumberGenerator();
        Assert.IsTrue(Result > 0 && Result < 100);
    }
}