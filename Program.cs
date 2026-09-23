using System;

namespace L_system
{
    class Program
    {

        public delegate string Change(string key, string s1, string s2, string change);

        static void Main(string[] args)
        {

            Change ru = Changing;

            Console.WriteLine("Write 1st UNCHANGEBLE symbol of alphabet. PLS 1 SYMBOL!!!!!!!!!!");
            string s1 = Console.ReadLine(); // it unchange

            Console.WriteLine("Write 2nd CHANGEBLE symbol of alphabet. PLS 1 SYMBOL!!!!!!!!!!");
            string s2 = Console.ReadLine(); // it will change

            Console.WriteLine("Write HOW 2nd part WILL CHANGE");
            string rls = Console.ReadLine(); // it rule, how "s2" will change. Maybe, I can make it a ref, and later it be an iteration code :P

            Console.WriteLine("Write word WITH 1st and 2st parts!!!!!");
            string key = Console.ReadLine(); // this is what will change, AND THIS MUST BE FROM "s1", "s2"!!


            Console.WriteLine(L_system(key, s1, s2, rls, ru));            
        }

        static public string Changing(string key, string s1, string s2, string change)
        {
            string change_word = "";

            for (int i = 0; i < key.Length; i++)
            {
                if (key[i].ToString() == s1)
                    change_word += s1;
                else if (key[i].ToString() == s2)
                    change_word += change;
                else change_word += key[i];
            }

            return change_word;
        }

        static public string L_system(string key, string str1, string str2, string rules, Change cng)
        {
            return cng(key, str1, str2, rules);
        }

    } 
}
