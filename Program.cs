using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = {"Little red fox Likes red box Red box is Big", "Big dog is scary"};
            var dictionary = CountWordFrequence(phrases);
            foreach (KeyValuePair<string, int> keyValue in dictionary) {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }

        static public Dictionary<string, int> CountWordFrequence(string[] phrases)
        {
            string[] words = {};
            string temp = "";
            foreach(string phrase in phrases) {
                temp += phrase.ToLower() + " ";
            }
            temp = temp.TrimEnd();
            words = temp.Split(new char[] { ' ' });

            string[] distinctWord = words.Distinct().ToArray();
            int i = 0;
            var dictionary = new Dictionary<string,int>();
            foreach(string dWord in distinctWord) {
                foreach(string word in words) {
                    if(dWord == word){
                        i += 1;
                    }
                    
                }
                // Console.WriteLine(i);
                dictionary.Add(dWord, i);
                i = 0;
            }
            return dictionary;
        }
    }
}
