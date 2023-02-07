using System.Collections;

namespace PhoneNumberLetterCombo;
public class Class1
{
    public IList<string> LetterCombinations(string digits)
    {
        IList<string> result = new List<string>();
        IList<int> digitIterate = new List<int>();
        IList<int> digitIterateRev = new List<int>();

        if (digits == "")
        {
            return result;
        }

        int parsedDigits;

        bool parsable = int.TryParse(digits, out parsedDigits);

        if (!parsable)
        {
            return result;
        }

        var letters = new Hashtable() {
            {2, "abc"},
            {3, "def"},
            {4, "ghi"},
            {5, "jkl"},
            {6, "mno"},
            {7, "pqrs"},
            {8, "tuv"},
            {9, "wxyz"}
        };

        while (parsedDigits > 0)
        {
            int remainder = parsedDigits % 10;
            parsedDigits /= 10;
            digitIterate.Add(remainder);
        }

        foreach (int i in digitIterate.Reverse())
        {
            digitIterateRev.Add(i);
        }

        switch (digitIterateRev.Count)
        {
            case 1:
                for (int i = 0; i < digitIterateRev.Count; i++)
                {
                    string stringI = letters[digitIterateRev[i]].ToString();
                    for (int j = 0; j < stringI.Length; j++)
                    {
                        result.Add(stringI[j].ToString());
                    }
                }
                break;
            case 2:
                for (int i = 0; i < letters[digitIterateRev[0]].ToString().Length; i++)
                {
                    string stringOne = letters[digitIterateRev[0]].ToString();
                    string stringTwo = letters[digitIterateRev[1]].ToString();

                    for (int j = 0; j < letters[digitIterateRev[1]].ToString().Length; j++)
                    {
                        result.Add(stringOne[i].ToString() + stringTwo[j].ToString());
                    }
                }
                break;
            case 3:
                for (int i = 0; i < letters[digitIterateRev[0]].ToString().Length; i++)
                {
                    string stringOne = letters[digitIterateRev[0]].ToString();
                    string stringTwo = letters[digitIterateRev[1]].ToString();
                    string stringThree = letters[digitIterateRev[2]].ToString();

                    for (int j = 0; j < letters[digitIterateRev[1]].ToString().Length; j++)
                    {

                        for (int k = 0; k < letters[digitIterateRev[2]].ToString().Length; k++)
                        {
                            result.Add(stringOne[i].ToString() + stringTwo[j].ToString() + stringThree[k].ToString());
                        }

                    }
                }
                break;
            case 4:
                for (int i = 0; i < letters[digitIterateRev[0]].ToString().Length; i++)
                {
                    string stringOne = letters[digitIterateRev[0]].ToString();
                    string stringTwo = letters[digitIterateRev[1]].ToString();
                    string stringThree = letters[digitIterateRev[2]].ToString();
                    string stringFour = letters[digitIterateRev[3]].ToString();

                    for (int j = 0; j < letters[digitIterateRev[1]].ToString().Length; j++)
                    {

                        for (int k = 0; k < letters[digitIterateRev[2]].ToString().Length; k++)
                        {

                            for (int l = 0; l < letters[digitIterateRev[3]].ToString().Length; l++)
                            {

                                result.Add(stringOne[i].ToString() + stringTwo[j].ToString() + stringThree[k].ToString() + stringFour[l].ToString());

                            }
                        }

                    }
                }
                break;
            default:
                break;
        }




        return result;
    }
}
