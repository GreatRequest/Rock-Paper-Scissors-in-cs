using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        char tlcl = (char)0x250C;   //  ┌
        char tlcd = (char)0x2554;   //  ╔

        char hl__ = (char)0x2500;   //  ─
        char hd__ = (char)0x2550;   //  ═

        char trcl = (char)0x2510;   //  ┐
        char trcd = (char)0x2557;   //  ╗

        char vl__ = (char)0x2502;   //  │
        char vd__ = (char)0x2551;   //  ║

        char brcl = (char)0x2518;   //  ┘
        char brcd = (char)0x255D;   //  ╝

        char blcl = (char)0x2514;   //  └
        char blcd = (char)0x255A;   //  ╚

        bool again = true;

        static int inputPlayer, inputCPU, randomInt, playerScore = 0, CPUScore = 0;
        bool round = true;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.game();
        }
        public void game()
        {
            Program p = new Program();
            while (again == true)
            {
                playerScore = 0;
                CPUScore = 0;
                while (round == true)
                {
                    p.score();
                    Console.Write("Choose between:\n\t1) Rock\n\t2) Paper\n\t3) Scissors\n\n\tEnter your choice: ");
                    inputPlayer = Convert.ToInt32(Console.ReadLine());

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = 1;
                            if (inputPlayer == 1)
                            {
                                Console.WriteLine("Computer Chose Rock.\nIt's a DRAW!");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (inputPlayer == 2)
                            {
                                Console.WriteLine("Computer Chose Rock.\nYou Won!");
                                playerScore++;
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (inputPlayer == 3)
                            {
                                Console.WriteLine("Computer Chose Rock.\nYou Lost!");
                                CPUScore++;
                                Console.ReadLine();
                                Console.Clear();
                            }
                            break;
                        case 2:
                            inputCPU = 2;
                            if (inputPlayer == 1)
                            {
                                Console.WriteLine("Computer Chose Paper.\nYou Lost!");
                                CPUScore++;
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (inputPlayer == 2)
                            {
                                Console.WriteLine("Computer Chose Paper.\nIt's a DRAW!");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (inputPlayer == 3)
                            {
                                Console.WriteLine("Computer Chose Paper.\nYou WON!");
                                playerScore++;
                                Console.ReadLine();
                                Console.Clear();
                            }
                            break;
                        case 3:
                            inputCPU = 3;
                            if (inputPlayer == 1)
                            {
                                Console.WriteLine("Computer Chose Scissors.\nYou Won!");
                                playerScore++;
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (inputPlayer == 2)
                            {
                                Console.WriteLine("Computer Chose Scissors.\nYou Lost!");
                                CPUScore++;
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (inputPlayer == 3)
                            {
                                Console.WriteLine("Computer Chose Scissors.\nIt's a DRAW!");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            break;
                    }
                    if (CPUScore == 3)
                    {
                        Console.WriteLine("CPU Score 3,\n\tYou Lost!");
                        round = false;
                    }
                    else if (playerScore == 3)
                    {
                        Console.WriteLine("You Score 3,\n\tYou Won!");
                        round = false;
                    }
                }
                if (CPUScore == 3 || playerScore == 3)
                {
                    Console.WriteLine("Would you like to Play again?\n\ty) YES\n\tn) NO");
                    char ans = Console.ReadKey().KeyChar;
                    if (ans == 'y')
                    {
                        again = true;
                        Console.Clear();
                        p.game();
                    }
                    else
                    {
                        again = false;
                        Console.Clear();
                    }
                }
            }
        }
        public void score()
        {
            Console.Write("{0}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{2}\n", tlcl, hl__, trcl);
            Console.Write("{0}\tPlayer Score:\t{1}\t{2}\n", vl__, playerScore, vl__);
            Console.Write("{0}\tComputer Score:\t{1}\t{2}\n", vl__, CPUScore, vl__);
            Console.Write("{0}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{1}{2}\n", blcl, hl__, brcl);

        }
    }
}
