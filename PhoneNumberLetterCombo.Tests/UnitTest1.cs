namespace PhoneNumberLetterCombo.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }
    [TestMethod]
    public void TestMethod1()
    {
        bool equal = true;

        string digits = "23";
        IList<string> answer = new List<string>() { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };

        IList<string> result = _test.LetterCombinations(digits);

        for (int i = 0; i <= result.Count - 1; i++)
        {
            if (result[i] != answer[i])
            {
                equal = false;
            }
        }
        Assert.IsTrue(equal);
    }
    [TestMethod]
    public void TestMethod2()
    {
        bool equal = true;

        string digits = "";
        IList<string> answer = new List<string>();

        IList<string> result = _test.LetterCombinations(digits);

        for (int i = 0; i <= result.Count - 1; i++)
        {
            if (result[i] != answer[i])
            {
                equal = false;
            }
        }
        Assert.IsTrue(equal);
    }

    [TestMethod]
    public void TestMethod3()
    {
        bool equal = true;

        string digits = "235";
        IList<string> answer = new List<string>() { "adj", "adk", "adl", "aej", "aek", "ael", "afj", "afk", "afl", "bdj", "bdk", "bdl", "bej", "bek", "bel", "bfj", "bfk", "bfl", "cdj", "cdk", "cdl", "cej", "cek", "cel", "cfj", "cfk", "cfl" };

        IList<string> result = _test.LetterCombinations(digits);

        for (int i = 0; i <= result.Count - 1; i++)
        {
            if (result[i] != answer[i])
            {
                equal = false;
            }
        }
        Assert.IsTrue(equal);
    }
}