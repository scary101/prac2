using Microsoft.Win32.SafeHandles;
using System.Reflection.Metadata;

namespace prac2
{
    internal class Program
    {
        static void Main()
        {

            while (true) 
            { 
                Console.WriteLine("Выберите действие:" +
                    "\n 1. Игра угадай число" +
                    "\n 2. Таблица умножения" +
                    "\n 3. Найти делитель числа" +
                    "\n 4. Выйти из прогрмаммы");
                string user_motion = Console.ReadLine();
                if (user_motion == "1")
                {
                    game();
                }
                else if (user_motion == "2")
                {
                    tabl();
                }
                else if (user_motion == "3")
                {
                    del();
                }
                else if (user_motion == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR, try again");
                    continue;
                }

            }




        static void game()
            {
                Random a = new Random();
                int rand = a.Next(100);
                int user;
                Console.WriteLine("Введите число");
                do
                {
                    user = Convert.ToInt32(Console.ReadLine());
                    if (user == rand)
                    {
                        Console.WriteLine("Вы угадали");

                    }
                    else if (rand > user)
                    {
                        Console.WriteLine("Не верно, загаданное число больше");
                    }
                    else if (rand < user)
                    {
                        Console.WriteLine("Не верно, загаданное число меньше");
                    }

                }
                while (user != rand);
            }

        static void tabl()
            {
                int[,] tabl = new int[9, 9];

                for (int i = 0; i <= 8; i++)
                {
                    for (int j = 0; j <= 8; j++)
                    {
                        tabl[i, j] = (i + 1) * (j + 1);
                    }
                }


                for (int i = 0; i < tabl.GetLength(0); i++)
                {
                    for (int j = 0; j < tabl.GetLength(1); j++)
                    {
                        Console.Write(tabl[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

        static void del()
            {
                Console.WriteLine("Введите число, делители которого нужно найти:");
                
                do
                {
                    string user1 = Console.ReadLine();
                    if (user1 == "hub")
                    {
                        break;
                    }
                    int user = Convert.ToInt32(user1);
                    List<int> delitel = new List<int>();
                    for (int i = 1; i <= user; i++)
                    {
                        if (user % i == 0)
                        {
                            delitel.Add(i);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    Console.WriteLine("Делителями числа " + user + " являются:");
                    foreach (int i in delitel)
                    {
                        Console.Write(i + "\t");
                    }
                    Console.WriteLine("\nВведите 'hub' чтобы выйти в меню или еще одно число");
                   
                } while(true);
            }



        }
    }
}