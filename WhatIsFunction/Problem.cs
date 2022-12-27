using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class Problem
    {
        static void Main(string[] args)
        {
            /*
             * 과제

              5 x 5 보드 (사이즈 줘도 ok)

              □ □ □ □ □
              □  .  .  . □
              □  . 옷  . □
              □  .  .  . □
              □ □ □ □ □ 

             .(닷)은 빈 곳, □는 벽을 의미

             빈 곳 중에 아무곳 (정 중앙)이나 사람(이모티콘 또는 옷)을 초기화해서
             w, a, s, d 입력 받아서 빈 곳을 자유롭게 이동하는 프로그램 작성
             - 사람은 빈 곳을 다닐 수 있음.
             - 사람은 벽을 넘어다닐 수 없음

             */



            string[,] array;
            array = new string[5, 5];


            //int middle = array.GetLength(0) / 2;

            int nowX = 2;   
            int nowY = 2;   
            
            

            // 초기화
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (y == 0 || y == 4)
                    {
                        array[y, x] = "■";
                    }
                    else if (x == 0 || x == 4)
                    {
                        array[y, x] = "■";
                    }
                    else
                        array[y, x] = ". ";
                    
                }
                array[2, 2] = "옷";

            }

                // 출력
                for (int y = 0; y < 5; y++)
                {
                for (int x = 0; x < 5; x++)
                {

                    Console.Write($"{array[y, x]}");

                }

                Console.WriteLine();
                }


            while (true)
            {

                char arrowKeys;
                Console.WriteLine("방향키를 입력해 주세요(왼쪽: a, 오른쪽: d, 윗쪽: w, 아랫쪽: s)");
                char.TryParse(Console.ReadLine(), out arrowKeys);


                switch (arrowKeys)
                {
                    case 'a':
                        Console.WriteLine($"{nowX - 1}");
                        break;

                    case 'd':
                        Console.WriteLine($"{nowX + 1}");
                        break;


                        array[nowY, nowX] = "옷";

                }
                for (int y = 0; y < 5; y++)
                {
                    for (int x = 0; x < 5; x++)
                    {

                        Console.Write($"{array[y, x]}");

                    }

                    Console.WriteLine();
                }
            }









        }
    }
}
