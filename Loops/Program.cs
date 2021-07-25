﻿using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Kursu";

            // array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya Başlangıç İçin Temel Kurs", "Java Kursu"};

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
