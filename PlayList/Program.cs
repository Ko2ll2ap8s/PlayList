using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp28
{
    public interface Song
    {
        public string Name { get; set; }
        public string Executor { get; set; }
        public void Display()
        {

        }
    }
    public class Playlist : Song
    {
        string name;
        string executor;
        public string Name { get => name; set => name = value; }
        public string Executor { get => executor; set => executor = value; }
        public int Time { get; set; }   //длительность
        public int Year { get; set; } //выпуск

        public Playlist(string _name, string _executor, int _time, int _year)
        {
            Name = _name;
            Executor = _executor;
            Time = _time;
            Year = _year;
        }
        public void Display()
        {
            Console.WriteLine(Name + ", " + Executor + ", " + Time + "," + Year);
        }

    }

    public class People : Song
    {
        string name;
        string executor;
        public string Executor { get => executor; set => executor = value; }
        public string Name { get => name; set => name = value; }

        bool abult;


        public string Abult
        {
            get => abult == true ? "Совершеннолетний" : "Несовершеннолетний";
            set => abult = value == "Несовершеннолетний" ? true : false;
        }
        public People(string _name, string _abult)
        {
            Name = _name;
            Abult = _abult;
        }

        public void Display()
        {
            Console.WriteLine(Name + ", " + Abult);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Playlist rework = new Playlist("Зеркала", "Свит Шот", 170, 2020);
            People kollaps = new People("Елена", "Совершеннолетний");
            List<Song> spisok = new List<Song>();
            spisok.Add(rework);
            spisok.Add(kollaps);
            foreach (var item in spisok)
            {
                item.Display();
            }


        }
    }
}
