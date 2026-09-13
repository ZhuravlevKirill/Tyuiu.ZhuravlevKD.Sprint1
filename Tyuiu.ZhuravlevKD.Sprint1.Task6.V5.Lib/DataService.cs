using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task6.V5.Lib;

public class DataService : ISprint1Task6V5
{
    public string WorkWithText(string text)
    {
        string[] words = text.Split(
            new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '(', ')' },
            StringSplitOptions.RemoveEmptyEntries);

        List<string> result = new List<string>();

        foreach (string word in words)
        {
            string cleanWord = word.ToLower();

            char[] chars = cleanWord.ToCharArray();
            Array.Reverse(chars);

            string reversedWord = new string(chars);

            if (cleanWord == reversedWord)
            {
                result.Add(word);
            }
        }

        return string.Join(" ", result);
    }
}