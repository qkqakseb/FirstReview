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
    public class PoterProgram1 : Poter
    {
        protected int coinX;
        protected int coinY;                // 코인($) 위치를 선정해 주기 위해 변수를 coinX, coinY 를 int로 선언 

        protected Random coin;              // 코인($)을 랜덤으로 나오게 하기 위해 Random coin = new Random() 썼다.
        protected PoterProgram2 poter2;
        protected PoterProgram2 poter1;
        public void Poter1()
        {
            /* 과제
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

            // start
            Init();

            // 출력
 
            coinCount = 0;                          // 코인($)의 개수를 세는 coinCount 변수를 선언한다.
            eatCoin = 0;                            // 먹은 코인($)의 개수를 나타내는 eatCoin변수를 선언한다.

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
                        
                    }
                }

                Console.WriteLine($"먹은 코인($) 개수 : {eatCoin}");      // 먹은 코인($) 개수를 출력해준다.

                ArrowKeys();

                PrintMyMove(array);
            }// loop : while 게임 루프
             //end
        } // Poter1()

        public override void Init()
        {
            base.Init();

            nowX = 5;
            nowY = 5;                  // "옷"이 있는 위치를 선정해 주기 위해 변수를 nowX, nowY 를 int로 선언

            coinX = 0;
            coinY = 0;                // 코인($) 위치를 선정해 주기 위해 변수를 coinX, coinY 를 int로 선언 

            coin = new Random();    // 코인($)을 랜덤으로 나오게 하기 위해 Random coin = new Random() 썼다.

            poterMap = "poter1";

            poter2 = new PoterProgram2();
            poter2.Init();

            // 초기화
            for (int y = 0; y < 10; y++)       // int y가 0부터 10까지 하나씩 증가 하기위해
            {
                for (int x = 0; x < 10; x++)   // int x가 0부터 10까지 하나씩 증가 하기 위해 
                {
                    if (x == 9 && (y >= 3 && y <= 6))
                    {
                        array[y, x] = "□";
                    }
                    else if ((y == 0 || y == 9) ||
                        (x == 0 || x == 9))
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
            }       // loop: Poter1의 초기 화면을 생성하는 루프
        }       // Init()


        //! 맵 정보를 받아서 포털1의 맵 정보로 덮어쓴다
        public void SetPoter1Map(ref string[,] map, ref int nowY_, ref int nowX_)
        {
            for (int y = 0; y < 10; y++)       // int y가 0부터 10까지 하나씩 증가 하기위해
            {
                for (int x = 0; x < 10; x++)   // int x가 0부터 10까지 하나씩 증가 하기 위해 
                {
                    if (x == 9 && y >= 3 && y <= 6)
                    {
                        map[y, x] = "□";
                    }
                    else if (y == 0 || y == 9 ||
                        x == 0 || x == 9)
                    {
                        map[y, x] = "■";      // 만약 y,x 좌표가 0 부터 9까지 이면 ■ 로 표시하고
                    }
                    // 포털을 만들기
                    else if (y == nowY && x == 8)
                    {
                        map[y, x] = "옷";      // 만약 y,x 좌표가 5,5 이면 옷을 표시하고
                        nowX_ = 8;
                        nowY_ = nowY;
                    }
                    else
                    {
                        map[y, x] = ". ";     // 위 두가지 경우가 아니면 .으로 표시한다.
                    }
                }
            }
        }       // SetPoter1Map()

        public override bool PoterHit(int moveY, int moveX)
        {
            bool poter = base.PoterHit(moveY, moveX);
            if(poter == true)
            {
                if(poterMap == "poter1")
                {
                    /* poter 2 로 간다 */
                    poter2.SetPoter2Map(ref array, ref nowY, ref nowX);
                    poterMap = "poter2";
                    Console.WriteLine("사람위치 : {0}, {1}  벽 다았나 : {2}", nowY, nowX, poter);
                }
                else if(poterMap == "poter2")
                {
                    /* poter 1 로 간다 */
                    SetPoter1Map(ref array, ref nowY, ref nowX);
                    poterMap = "poter1";
                }
            }       // if: poter 밟았을 때
            return poter;
        }
    } // class Program
}
