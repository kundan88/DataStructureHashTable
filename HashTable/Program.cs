using System;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table");
            HashTable<string, int> hashtable = new HashTable<string, int>(5);
            string sentence = "Paranoids are not paranoid because they are paranoid but because the keep putting themselves" +
                "deliberately into paranoid avoidable situation";
            string[] words = sentence.ToLower().Split(' ');
            foreach (string word in words)
            {
                int value = hashtable.Get(word);
                if (value == default)
                {
                    value = 1;
                    hashtable.Add(word, value);
                }
                else
                {
                    value += 1;
                    hashtable.Add(word, value);
                }
            }
            int frequencyParanoid = hashtable.Get("paranoid");
            int frequencyAre = hashtable.Get("are");
            Console.WriteLine(@"Frequency of ""paranoid"" - " + frequencyParanoid);
            Console.WriteLine(@"Frequency of ""are"" - " + frequencyAre);
            Console.WriteLine(@"Frequency of ""situation"" -  " + hashtable.Get("situation"));
        }
    }
}

