﻿using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //toplu coment ctrlk crtlc
            //toplu uncomment ctrlk ctrlu
            //string[] isimler = new string[] { "Ömer", "Anıl", "Ahmet", "Salih" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Ali";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> {"Ömer", "Anıl", "Ahmet", "Salih" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ali");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
