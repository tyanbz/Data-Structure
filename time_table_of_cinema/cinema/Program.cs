using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int halls=0, filmsCount=0;

            halls = GetCountHalls(halls);
            filmsCount = GetCountFilms(filmsCount);

            int[] timeFilms = new int[filmsCount];
            string[] nameFilms = new string[filmsCount];

            for (int i = 0; i < filmsCount; i++)
            {
                Console.Write("Введите название фильма: ");
                nameFilms[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Введите продолжительность в минутах: ");
                timeFilms[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nФильмы записаны!\n");

            Program.Distribute(halls, timeFilms, nameFilms);
        }

        public static int GetCountHalls(int halls)
        {
            Console.WriteLine("Введите количество залов:");
            halls = Convert.ToInt32(Console.ReadLine());
            return halls;
        }

        public static int GetCountFilms(int filmsCount)
        {
            Console.WriteLine("Введите количество фильмов:");
            filmsCount = Convert.ToInt32(Console.ReadLine());
            return filmsCount;
        }

        public static void Distribute(int halls, int[] timeFilms, string[] nameFilms)
        {
            int filmNum = 0, time = 600;
            for (int i=1; i<=halls; i++)
            {
                Console.WriteLine("ЗАЛ №" + i + ":");
                while (time+ timeFilms[filmNum] < 1200)
                {
                    if (filmNum == timeFilms.Length)
                    {
                        break;
                    }
                    Console.WriteLine("Фильм: " + nameFilms[filmNum]);
                    Console.WriteLine("Начало: " + time / 60 + ":" + time % 60);
                    time += timeFilms[filmNum];
                    Console.WriteLine("Kонец: " + time / 60 + ":" + time % 60);
                    Console.WriteLine();
                    filmNum += 1;
                }
                time = 600;
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}

/*
 *  
*/