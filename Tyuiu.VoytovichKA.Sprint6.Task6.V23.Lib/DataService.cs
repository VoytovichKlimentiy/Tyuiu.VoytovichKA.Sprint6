using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VoytovichKA.Sprint6.Task6.V23.Lib
{
    public class DataService : ISprint6Task6V23
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using StreamReader sr = new StreamReader(path);
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (word.Contains('s'))
                        {
                            res = res + word + " ";
                        }
                    }
                }
            }
            res = res.Trim();
            return res;
        }
    }
}
