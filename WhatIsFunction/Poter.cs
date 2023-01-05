using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    public class Poter
    {
        protected string[,] array;    //!> 맵에 무엇이 있는지 담아두는 변수
        protected int nowX;
        protected int nowY;

        protected int coinCount = 0;                          // 코인($)의 개수를 세는 coinCount 변수를 선언한다.
        protected int eatCoin = 0;                            // 먹은 코인($)의 개수를 나타내는 eatCoin변수를 선언한다.

        protected string poterMap;


        //! 맵을 초기화 하는 함수
        public virtual void Init()
        {
            array = new string[10, 10];     // 2차원 10 x 10 을 만들어 준다.
            nowX = 0;
            nowY = 0;
            poterMap = string.Empty;
        }

        protected void PrintMyMove(string[,] array)
        {
            Console.Clear();                                                  // 화면 정리
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.Write($"{array[y, x]}");
                }
                Console.WriteLine();
            }

            //Console.WriteLine($"먹은 코인($) 개수 : {eatCoin}");
        }       // PrintMyMove()

        public virtual void ArrowKeys()
        {
            char arrowKeys;                                                                           // 방향키를 입력 받을 값을 문자로 선언해준다.
            Console.WriteLine("방향키를 입력해 주세요(왼쪽: a, 오른쪽: d, 윗쪽: w, 아랫쪽: s)");
            char.TryParse(Console.ReadLine(), out arrowKeys);                                        // 방향키(왼쪽: a, 오른쪽: d, 윗쪽: w, 아랫쪽: s)를 입력해달라는 출력문을 나타낸다.
            
            string temp = string.Empty;
            switch (arrowKeys)                                                         // 입력 받은 방향키 문자가
            {
                case 'a':                                                              // 입력 받은 값이 a (왼쪽)이면 
                    if(WallHit(nowY, nowX - 1))
                    {
                        /* 벽이면 안 움직임 */
                    }
                    else if (PoterHit(nowY, nowX - 1))
                    {
                        // 포탈 2로 넘어간다.
                    }
                    else
                    {
                        MoneyLocation(nowY, nowX - 1);
                        temp = array[nowY, nowX - 1];                                   // 이동한 곳의 값을 temp에 임시로 저장   // 지금 위치에 있는 "옷"의 위치와 ". "의 위치를 바꿔주기 위해서 썼다.
                        array[nowY, nowX - 1] = array[nowY, nowX];                       // 지금 위치의 값을 이동한 곳의 값에 대입
                        array[nowY, nowX] = temp;                                       // 이동한 곳의 값의 temp를 지금 위치의 값에 대입
                        nowX--;
                    }
                    break;                                                          // 입력한 a의 경우를 멈춰준다.

                case 'd':
                    if(WallHit(nowY, nowX + 1)) 
                    {
                        /* 벽이면 안 움직임 */
                    }
                    else if (PoterHit(nowY, nowX + 1)) 
                    {
                        // 포탈 2로 넘어간다.
                    }
                    else 
                    {
                        MoneyLocation(nowY, nowX + 1);
                        temp = array[nowY, nowX + 1];
                        array[nowY, nowX + 1] = array[nowY, nowX];
                        array[nowY, nowX] = temp;
                        nowX++;
                    }
                    break;

                case 'w':
                    if (WallHit(nowY - 1, nowX))
                    {
                        /* 벽이면 안 움직임 */
                    }
                    else if (PoterHit(nowY, nowX + 1))
                    {
                        // 포탈 2로 넘어간다.
                    }
                    else
                    {
                        MoneyLocation(nowY - 1, nowX);
                        temp = array[nowY - 1, nowX];
                        array[nowY - 1, nowX] = array[nowY, nowX];
                        array[nowY, nowX] = temp;
                        nowY--;
                    }
                    break;

                case 's':
                    //Console.WriteLine("현재 위치: ({0}, {1}), 갈 위치: ({2}, {3})",
                    //    nowX, nowY, nowX, nowY + 1);
                    if (WallHit(nowY + 1, nowX))
                    {
                        /* 벽이면 안 움직임 */
                    }
                    else if (PoterHit(nowY, nowX + 1))
                    {
                        // 포탈 2로 넘어간다.
                    }
                    else
                    {
                        MoneyLocation(nowY + 1, nowX);
                        temp = array[nowY + 1, nowX];
                        array[nowY + 1, nowX] = array[nowY, nowX];
                        array[nowY, nowX] = temp;
                        nowY++;
                    } 
                    break;
            }       // switch
        }

        public virtual bool WallHit(int moveY, int moveX)
        {
            bool wall = false;
            if (array[moveY, moveX].Equals("■"))                                             // 지금 있는 nowX 값(옷이 위치한 값)에 왼쪽이니까 -1를 해주고 이것이 ■의 위치값 0과 같으면 
            {
                /*Console.WriteLine("벽에 다았다.");*/                             // 벽에 다았다고 출력해준다.
                wall = true;                                                  //  현재 반복을 종료하고 다음 반복을 실행한다.
            }

            //Console.WriteLine("벽 위치 검사 ({0}, {1}), 결과: {2}",
            //    moveX, moveY, wall);
            return wall;
        }

        public virtual bool PoterHit(int moveY, int moveX)
        { 
            bool poter = false; 
            if (array[moveY, moveX].Equals("□"))
            {
                Console.WriteLine("포털에 다았다");
                poter= true;

                Console.WriteLine("사람 위치 : {0}, {1}  다았나? : {2}", moveY, moveX, poter);
            }
            return poter;
        }

        public void MoneyLocation(int moveY, int moveX)
        {
            if (array[moveY, moveX] == "$ ")                                 // 왼쪽으로 간 위치값이 $(코인) 이면 
            {
                
                eatCoin++;                                                    // 먹은 $(코인) 개수를 1씩 증가시켜주고
                array[moveY, moveX] = ". ";                                //  왼쪽으로 간 위치에 있는 값을 . 로 변경시겨주고
                coinCount--;                                                 // coinCount 코인의 개수를 감소 시켜 준다. (2개의 $(코인)이 있었는데 1개를 먹었으니까)
            }
            Console.WriteLine("먹은 개수 : {0}", eatCoin);
        }       // MoneyLocation()
    }       // class Poter
}
