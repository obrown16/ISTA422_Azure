﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Cipher
{
    class Program
    {
        public static char Cipher(char Chara, int key)
        {
            if (!char.IsLetter(Chara))
            {

                return Chara;
            }

            char d = char.IsUpper(Chara) ? 'A' : 'a';
            return (char)((((Chara + key) - d) % 26) + d);


        }


        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += Cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Type a string to encrypt:");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");

            Console.Write("Enter your Key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Encrypted Data: ");

            string cipherText = Encipher(UserString, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.WriteLine("Decrypted Data:");

            string t = Decipher(cipherText, key);
            Console.WriteLine(t);
            Console.Write("\n");




            Console.ReadKey();
        }
    }
}
