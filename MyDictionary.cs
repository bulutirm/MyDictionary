using System;
namespace MyDictionary
{
    public class MyDictionary <T>
    {
        T[] words;

        public MyDictionary()
        {
            words = new T[0];
        }

        public void Add(T word)
        {
            T[] tempDictionary = words;
            words = new T[words.Length + 1];
            for(int i = 0; i < tempDictionary.Length; i++)
            {
                tempDictionary[i] = words[i];
            }
            words[words.Length - 1] = word;
        }
    }
}
