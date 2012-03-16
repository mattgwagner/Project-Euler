using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Euler59 : EulerProblem
    {
        string alphabet = "abcdefghijklmnopqrtuvwxyz";

        List<string> decrypted = new List<string>();

        public override object Solution()
        {
            var cipherText = GetCipherText();

            int sum = 0;

            foreach (char a in alphabet)
            {
                foreach (char b in alphabet)
                {
                    foreach (char c in alphabet)
                    {
                        StringBuilder sb = new StringBuilder();

                        int curr = 0;

                        // go through each char and get the XOR'd value, adding it to the SB
                        foreach (char x in cipherText)
                        {
                            if (curr % 3 == 0)
                            {
                                sb.Append((char)(x ^ a));
                            }
                            else if (curr % 3 == 1)
                            {
                                sb.Append((char)(x ^ b));
                            }
                            else
                            {
                                sb.Append((char)(x ^ c));
                            }

                            curr++;
                        }

                        string content = sb.ToString();

                        // check for some common english words
                        if (content.Contains(" the ") && content.Contains(" a ") && content.Contains(" and "))
                        {
                            sum = content.Sum(ch => ch);
                        }
                    }
                }
            }

            return sum;
        }

        protected int Sum(string str)
        {
            return str.Sum(c => (int)c);
        }

        protected String GetCipherText()
        {
            List<char> chars = new List<char>();

            using (StreamReader rdr = new StreamReader("Euler59.txt"))
            {
                string cipherText = rdr.ReadToEnd();

                foreach (string s in cipherText.Split(','))
                {
                    chars.Add((char)int.Parse(s));
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (char c in chars) sb.Append(c);

            return sb.ToString();
        }
    }
}
