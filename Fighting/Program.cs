using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int playerHealth = 100;
            int playerEnergy = 100;

            int enemyHealth = 100;
            int enemyEnergy = 100;

            int action = -1;

            while (true)
            {
                Console.Clear();

                Console.WriteLine(@"   Жизни: {0}              Жизни огненного элементаля:{1}", playerHealth, enemyHealth);
                Console.WriteLine(@"   Мана: {0}              Мана огненного элементаля:{1}", playerEnergy, enemyEnergy);

                Console.WriteLine();

                Console.WriteLine("1. Плеснуть водой (20 урона, -10 маны)  ");
                Console.WriteLine("2. Призвать цунами (30 урона, -40 маны)  ");
                Console.WriteLine("3. Медитация (+20 маны)  ");
                Console.WriteLine("4. Съесть фрукт с дерева  (+30 жизни, -20 маны)  ");

                Console.WriteLine();

                // Определение победы или поражение
                if (playerHealth <= 0)
                {
                    Console.WriteLine("Элементаль выйграл");
                    break;
                }

                if (enemyHealth <= 0)
                {
                    Console.WriteLine("Ты выйграл");
                    break;
                }

                action = int.Parse(Console.ReadLine());

                // Описание скиллов игрока
                if (action == 1)
                {
                    if (playerEnergy >= 10)
                    {
                        enemyHealth -= 20;
                        playerEnergy -= 10;
                    }
                    else
                    {
                        Console.WriteLine("Не достаточно маны. Ты пропустил этот ход!");
                        Console.ReadLine();
                    }
                }
                if (action == 2)
                {
                    if (playerEnergy >= 40)
                    {
                        enemyHealth -= 30;
                        playerEnergy -= 40;
                    }
                    else
                        Console.WriteLine("Не достаточно маны.Ты пропустил этот ход!");
                    Console.ReadLine();
                }


                if (action == 3)
                {
                    playerEnergy += 20;

                }


                if (action == 4)
                {
                    if (playerEnergy >= 20)
                    {
                        playerHealth += 30;
                        playerEnergy -= 20;
                    }
                    else
                    {
                        Console.WriteLine("Не достаточно маны.Ты пропустил этот ход!");
                        Console.ReadLine();
                    }
                }

                action = rnd.Next(1, 4);
                if (enemyHealth <= 20)
                {
                    action = 2;
                }
            //Скиллы противника
            if (action == 1)
            {
                if (enemyEnergy >= 12)
                {
                    playerHealth -= 15;
                    enemyEnergy -= 12;
                        Console.WriteLine("Вы получили 15 урона");
                        Console.ReadLine();
                    }

            }

            if (action == 2)
                {
                    if (enemyEnergy >= 10)
                    {
                        enemyHealth += 30;
                        Console.WriteLine("Противник полечился на 30 HP");
                        Console.ReadLine();
                    }

                }

                if (action == 3)
            {
                if (enemyEnergy >= 20)
                {
                    playerHealth -= 25;
                    enemyEnergy -= 20;
                        Console.WriteLine("Вы получили 25 урона");
                        Console.ReadLine();
                    }
            }
                if (action == 4)
                {
                    if (enemyEnergy == 0)
                    {
                        enemyEnergy += 20;
                        Console.WriteLine("Противник восстановил 20 энергии");
                        Console.ReadLine();
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
