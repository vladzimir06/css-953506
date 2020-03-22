using System;

namespace Lab2Ind1
{
    class Program
    {
        static bool FindChar(char[] array, char letter)
        {
            foreach (var t in array)
                if (letter == t)
                    return true;

            return false;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s = s.ToLower();
            
            char[] myChars = s.ToCharArray();
            char[] vowels = {'a', 'e', 'i', 'o', 'u', 'y'};

            
            if(FindChar( vowels, myChars[0]) )
            {
                if (s[1] >= 'a' && s[1] < 'z')
                    myChars[1]++;
                else if (s[1] == 'z')
                    myChars[1] = 'a';
            }


            for (var i = 2; i < myChars.Length; i++)
            {
                if (FindChar(vowels, s[i - 1]))
                {
                    if (s[i] >= 'a' && s[i] < 'z')
                        myChars[i]++;
                    else if (s[i] == 'z')
                        myChars[i] = 'a';
                }
            }
           
            string result = new string(myChars);
            Console.WriteLine(result);  
        }
    }
}
