using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class SlideGame
    {
        public static void Main()
        {

            /* 과제
             * 슬라이딩 퍼즐 게임 만들기
             */

            string[,] array;
            array = new string[3,3];
            
            

            array[0, 0] = "8";
            array[0, 1] = "5";
            array[0, 2] = "3";
            array[1, 0] = "6";
            array[1, 1] = "1";
            array[1, 2] = "7";
            array[2, 0] = "4";
            array[2, 1] = "2";
            array[2, 2] = " ";

            

            Console.WriteLine("===================");
            for (int y = 0; y < 9; y++)
            {
                for(int x = 0; x < 9; x++)
                Console.Write($"{array[y,x]} \t");

                if (y % 3 == 2)
                {

                    Console.WriteLine();

                }
            }
            Console.WriteLine("===================");



            char arrowKeys;

            Console.WriteLine("방향키를 입력해 주시오 (1. w  2. a  3. s  4. d )");
            char.TryParse(Console.ReadLine(), out arrowKeys);

            switch (arrowKeys)
            {
                case'w':
                    Console.WriteLine();
                    break;
                case 'a':
                    Console.WriteLine();
                    break;
                case 's':
                    Console.WriteLine();
                    break;
                case 'd':
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("다시 입력하세요");
                    break;
            }
            

            


        }
    }
}
