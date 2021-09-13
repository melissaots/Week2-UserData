using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolist;

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOFBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOFBirth;

            //Console.WriteLine("Oled " + userAge + " aastat vana.");

            //string interpolation

            Console.WriteLine($"Oled {userAge} aastat vana.");

        }
    }
}
