using System;

namespace StringTheory
{
    using System.Linq;

    internal class Program
    {
        public static string Run(string p)
        {
            int vowels = 0;
            int consonant = 0;
            int space = 0;

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == 'a' || p[i] == 'e' || p[i] == 'i' || p[i] == 'o' || p[i] == 'u' || p[i] == 'A' || p[i] == 'E' || p[i] == 'I' || p[i] == 'O' || p[i] == 'U')
                {
                    vowels++;
                }
                else if (char.IsWhiteSpace(p[i]))

                {
                    space++;
                }
                else
                {
                    consonant++;
                }
            }

            string reversedCase = new string(p.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) : c).ToArray());
            string text = System.String.Join(" ", reversedCase.Split(' ').Reverse());
            string minusai = p.Replace(" ", "-");
            string output = p.Replace("a", "pva").Replace("e", "pve").Replace("i", "pvi").Replace("o", "pvo").Replace("u", "pvu").Replace("y", "pvy").Replace("A", "pvA").Replace("E", "pvE").Replace("I", "pvI").Replace("O", "pvO").Replace("U", "pvU").Replace("Y", "pvY");
            string result = string.Concat(vowels, " ", consonant, "::", text, "::", minusai, "::", output);
            Console.WriteLine(result);
            string combined_queries = result;
            return combined_queries;
        }

        private static void Main(string[] args)
        {
            Program.Run("ThIs is p");
            Console.ReadKey();
        }
    }
}