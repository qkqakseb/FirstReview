using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
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


            //char key = ' ';
            //string[] map = new string[10];
            //for(int i = 0; i < 10; i++)
            //{
            //    if (i == 0 || i == 9)
            //    {
            //        map[i] = "□";
            //    }
            //    else if(i == 5)
            //    {
            //        map[i] = "옷";
            //    }
            //    else
            //    {
            //        map[i] = " . ";
            //    }
            //    Console.Write($"{map[i]}");
            //}
            //int index = 5;

            //while (true)
            //{
            //    Console.WriteLine("방향을 입력해 주세요( 왼쪽: a, 오른쪽: d ) : ");
            //    char.TryParse(Console.ReadLine(), out key);
            //    string temp;

            //    switch (key)
            //    {

            //        case 'a':
            //            temp = map[index - 1];
            //            map[index - 1] = map[index];
            //            map[index] = temp;
            //            index--;
            //            break;

            //        case 'd':
            //            temp = map[index + 1];
            //            map[index + 1] = map[index];
            //            map[index] = temp;
            //            index++;
            //            break;
            //        default:

            //            break;
            //    }
            //    // map 의 모든 요소 출력
            //    for(int i = 0; i < 10; i++)
            //    {
            //        Console.Write($"{map[i]}");
            //    }

            //   if(key == 'h')
            //    {
            //        break;
            //    }
            //}
            /*
             * 과제

              10 x 10 보드 (사이즈 줘도 ok)

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
             - c 누르면 $(코인)이 랜덤하게 나타난다.
             - 코인을 먹으면 먹은 개수 나타내기
            

             */


            //start
            string[,] array;
            array = new string[10, 10];     // 2차원 10 x 10 을 만들어 준다. 

            int nowX = 5;
            int nowY = 5;                  // "옷"이 있는 위치를 선정해 주기 위해 변수를 nowX, nowY 를 int로 선언
            int coinX = 0;
            int coinY = 0;                // 코인($) 위치를 선정해 주기 위해 변수를 coinX, coinY 를 int로 선언 

            Random coin = new Random();    // 코인($)을 랜덤으로 나오게 하기 위해 Random coin = new Random() 썼다.

            // 초기화
            for (int y = 0; y < 10; y++)       // int y가 0부터 10까지 하나씩 증가 하기위해
            {
                for (int x = 0; x < 10; x++)   // int x가 0부터 10까지 하나씩 증가 하기 위해 
                {
                    if (y == 0 || y == 9 ||    
                        x == 0 || x == 9)
                    {
                        array[y, x] = "■";      // 만약 y,x 좌표가 0 부터 9까지 이면 ■ 로 표시하고
                    }
                    else if (y == 5 && x == 5)
                    {
                        array[y, x] = "옷";      // 만약 y,x 좌표가 5,5 이면 옷을 표시하고
                    }
                    else
                    {
                        array[y, x] = ". ";     // 위 두가지 경우가 아니면 .으로 표시한다.
                    }
                }
            }

            // 출력
            for (int y = 0; y < 10; y++)                
            {
                for (int x = 0; x < 10; x++)
                {

                    Console.Write($"{array[y, x]}");

                }                                          // array[y, x] 값을 넣어 ■, 옷, . 을 출력한다.

                Console.WriteLine();                      // 한줄을 띄운다.
            }

            int coinCount = 0;                          // 코인($)의 개수를 세는 coinCount 변수를 선언한다.
            int eatCoin = 0;                            // 먹은 코인($)의 개수를 나타내는 eatCoin변수를 선언한다.

            while (true)                                // 진실이면 루프를 계속 돌린다.   
            {
                if (coinCount == 0)                     // 만약 코인($)의 개수를 세는 coinCount 가 0이면 (while 문 start)
                {
                    while (coinCount < 2)              //  코인($)의 개수를 세는 coinCount이 0부터 2까지(0~1) 반복할때
                    {
                        coinY = coin.Next(1, 8 + 1);        // coinY 좌표는 1~9까지 나타낸다.(랜덤)  
                        coinX = coin.Next(1, 8 + 1);         // coinX 좌표는 1~9까지 나타낸다.(랜덤)   
                        if (array[coinY, coinX] == ". ")      // 만약 coinY, coinX의 좌표 배열에 . 이 있으면 
                        {
                            array[coinY, coinX] = "$ ";      // coinY, coinX의 좌표 배열을 $로 나타낸다.
                            coinCount++;                     // coinCount 코인 개수를 증가시켜준다.            // 코인(coin)을 생성해준다.
                        }
                        else
                        {
                            continue;                       //  현재 반복을 종료하고 다음 반복을 실행한다.
                        }

                        Console.Clear();                    // 화면 정리
                        if (coinCount == 2)                 // 만약 coinCount 코인 개수가 2개 이면
                        {
                            for (int y = 0; y < 10; y++)         // int y가 0부터 10까지 1씩 증가 하고 
                            {
                                for (int x = 0; x < 10; x++)           // int x가 0부터 10까지 1씩 증가한다면
                                {
                                    Console.Write($"{array[y, x]}");    // array[y, x] 좌표를 출력한다.
                                }
                                Console.WriteLine();                          // 한줄 띄우기
                            }
                        }                                                           // 코인 생성된 map을 보여준다.
                        Console.WriteLine($"먹은 코인($) 개수 : {eatCoin}");      // 먹은 코인($) 개수를 출력해준다.
                    }
                }
                char arrowKeys;                                                                           // 방향키를 입력 받을 값을 문자로 선언해준다.
                Console.WriteLine("방향키를 입력해 주세요(왼쪽: a, 오른쪽: d, 윗쪽: w, 아랫쪽: s)");      
                char.TryParse(Console.ReadLine(), out arrowKeys);                                        // 방향키(왼쪽: a, 오른쪽: d, 윗쪽: w, 아랫쪽: s)를 입력해달라는 출력문을 나타낸다.
                string temp;

                switch (arrowKeys)                                                         // 입력 받은 방향키 문자가
                {
                    case 'a':                                                              // 입력 받은 값이 a (왼쪽)이면 
                        if (nowX - 1 == 0)                                                 // 지금 있는 nowX 값(옷이 위치한 값)에 왼쪽이니까 -1를 해주고 이것이 ■의 위치값 0과 같으면 
                        {
                            Console.WriteLine("벽에 다았다.");                             // 벽에 다았다고 출력해준다.
                            continue;                                                      //  현재 반복을 종료하고 다음 반복을 실행한다.
                        }
                        if (array[nowY, nowX - 1] == "$ ")                                 // 왼쪽으로 간 위치값이 $(코인) 이면 
                        {
                            eatCoin++;                                                    // 먹은 $(코인) 개수를 1씩 증가시켜주고
                            array[nowY, nowX - 1] = ". ";                                //  왼쪽으로 간 위치에 있는 값을 . 로 변경시겨주고
                            coinCount--;                                                 // coinCount 코인의 개수를 감소 시켜 준다. (2개의 $(코인)이 있었는데 1개를 먹었으니까)
                        }
                        temp = array[nowY , nowX - 1];                                   // 이동한 곳의 값을 temp에 임시로 저장   // 지금 위치에 있는 "옷"의 위치와 ". "의 위치를 바꿔주기 위해서 썼다.
                        array[nowY, nowX - 1] = array[nowY,nowX];                       // 지금 위치의 값을 이동한 곳의 값에 대입
                        array[nowY, nowX] = temp;                                       // 이동한 곳의 값의 temp를 지금 위치의 값에 대입
                        nowX--;                                                         // 현재 nowX 좌표를 -1을 했기때문에 nowX를 감소시켜준다. 
                        break;                                                          // 입력한 a의 경우를 멈춰준다.

                    case 'd':
                        if (nowX + 1 == 9) 
                        {
                            Console.WriteLine("벽에 다았다.");
                            continue; 
                        }
                        if (array[nowY, nowX + 1] == "$ ")
                        {
                            eatCoin++;
                            array[nowY, nowX + 1] = ". ";
                            coinCount--;
                        }
                        temp = array[nowY, nowX + 1];
                        array[nowY, nowX + 1] = array[nowY, nowX];
                        array[nowY, nowX] = temp;
                        nowX++;
                        break;
                    case 'w':
                        if(nowY -1 == 0) 
                        {
                            Console.WriteLine("벽에 다았다.");
                            continue; 
                        }
                        if (array[nowY - 1, nowX] == "$ ")
                        {
                            eatCoin++;
                            array[nowY - 1, nowX] = ". ";
                            coinCount--;
                        }
                        temp = array[nowY - 1, nowX];
                        array[nowY - 1, nowX] = array[nowY, nowX];
                        array[nowY, nowX] = temp;
                        nowY--;
                        break;
                    case 's':
                        if(nowY + 1 == 9) 
                        {
                            Console.WriteLine("벽에 다았다.");
                            continue;
                        }
                        if (array[nowY + 1, nowX] == "$ ")
                        {
                            eatCoin++;
                            array[nowY + 1, nowX] = ". ";
                            coinCount--;
                        }
                        temp = array[nowY + 1 , nowX];
                        array[nowY + 1, nowX] = array[nowY, nowX];
                        array[nowY, nowX] = temp;
                        nowY++;
                        break;
                }

                PrintMyMove(array, eatCoin);
                //Console.Clear();                                                    // 화면 정리
                //for (int y = 0; y < 10; y++)                                        
                //{
                //    for (int x = 0; x < 10; x++)
                //    {
                //        Console.Write($"{array[y, x]}");
                //    }
                //    Console.WriteLine();
                //}                                                                  // 이동한 값들을 출력해준다.
                //Console.WriteLine($"먹은 코인($) 개수 : {eatCoin}");               // break가 걸려서 먹은 코인($)의 개수가 안출력되기 때문에 한번 더 출력해준다.
            }// loop : while 게임 루프
            //end
            
            






        }

        public static void PrintMyMove(string[,] array, int eatCoin) 
        {
            Console.Clear();
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.Write($"{array[y, x]}");
                }
                Console.WriteLine();
            }                                                                  // 이동한 값들을 출력해준다.
            Console.WriteLine($"먹은 코인($) 개수 : {eatCoin}");
        }
    }
}
