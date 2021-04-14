using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    public class ApplicationManager
    {
        public void StartGame()
        {
            // create a gladiator obj
            Gladiator gladiator = new Gladiator();
            Console.WriteLine("Fight Begins!");
            // Console.WriteLine("Enter your gladiator name: ");
            //string userInput = Console.ReadLine();
            // DisplayMenu();


            // create a enemy obj
            Enemy enemy = new Enemy();
            // Console.ReadKey();


            do
            {
                FightReport(gladiator, enemy);
                switch (SelectAction())
                {
                    case Actions.Attack:
                        gladiator.Attacking(enemy);
                        break;
                    case Actions.Defend:
                        gladiator.Defending();
                        break;
                    case Actions.Heal:
                        gladiator.Healing(5);
                        break;
                    case Actions.Quit:
                        gladiator.QuitTheGame();
                        break;
                    default:
                        Console.WriteLine("Enemy missed!");
                        break;
                }
                if (enemy.Alive)
                {
                    enemy.Attacking(gladiator);
                }

               // Console.WriteLine("Please press enter!");
                //Console.ReadLine();

            } while (gladiator.Alive && enemy.Alive);

            FightResult(gladiator);
            Console.ReadLine();


        }

        public void DisplayMenu()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Choose an action: ");
            Console.WriteLine("1.Attack ");
            Console.WriteLine("2.Defend ");
            Console.WriteLine("3.Use Healing Potion ");
            Console.WriteLine("4.Quit ");
            Console.WriteLine("*************************************");

        }

        public Actions SelectAction()
        {
            DisplayMenu();
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    return Actions.Attack;
                case ConsoleKey.D2:
                    return Actions.Defend;
                case ConsoleKey.D3:
                    return Actions.Heal;
                case ConsoleKey.D4:
                    return Actions.Quit;
                default:
                    return Actions.Quit;
            }
        }

        public void FightReport(Gladiator gladiator, Enemy enemy)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("{0} has {1} health & {2} has {3} health", gladiator.Name, gladiator.Health, enemy.Name, enemy.Health);
            Console.WriteLine("*******************************************");
        }


        public void FightResult(Gladiator gladiator)
        {
            if (gladiator.Alive)
            {
                Console.WriteLine("Gladiatro WON the FIGHT!");
            }
            else
            {
                Console.WriteLine("Gladiator is defeated! & DEAD NOW");
            }
        }


    }
}
