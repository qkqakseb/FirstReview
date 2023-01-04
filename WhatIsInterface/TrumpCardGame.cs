using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks.Dataflow;
using System.Diagnostics.Tracing;

namespace WhatIsInterface
{
    internal class TrumpCardGame
    {
        public void TrumpGame()
        {
            // 전체카드  string allCard;
            int nowPlayerMoney = 10000;    // 현재 플래이어 돈
            int batting = 0;           // 플래이어가 배팅할 금액
            int minBatting = 0;        // 최소 배팅 금액
            string selectCard1 = " ";
            string selectCard2 = " ";
            string selectCard3 = " ";   // 최소배팅금액 보다 큰배팅인지 판단하기 위한 카드1,2,3
            int goalPoint = 0;         // 목표치 포인트(게임 종료할때)
            bool flag = true;
            List<int> allCard = new List<int>();            // allcard[0] = 0 -> "A", allcard[12] = 12 -> "K" 
                                                            //string[] shape = new string[4];       //

            List<int> computerCard = new List<int>(); //int형을 가지는 computerCard List 배열 선언
            List<int> playerCard = new List<int>();

            string[] shape = new string[4];
            string[] character = {"A","J", "Q", "K" };

            shape[0] = "♠";
            shape[1] = "♣";
            shape[2] = "◆";
            shape[3] = "♥";



            for (int i = 0; i < 52; i++)   // 0부터 allCard.Length 까지 1씩증가하고 반복한다.
            {

                allCard.Add(i);                     // i에 1을 더해주고 allCard[i]에 저장한다.

            }   // array 할당

            CFunc.Shuffle(allCard);
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 13; j++)
            //    {
            //        //Console.Write(shape[i]);
            //        Console.Write(allCard[j + 13 * i]+", ");
            //    }
            //    Console.WriteLine();

            //}
            for (int i = 0; i < 5; i++)
            {

                computerCard.Add(allCard[i]);
                allCard.Remove(allCard[i]);
                playerCard.Add(allCard[i]);
                allCard.Remove(allCard[i]);



            }
            computerCard.Sort();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("컴퓨터 카드 : \n");
                
                if (computerCard[i] % 13 == 0)
                {
                    Console.WriteLine(shape[computerCard[i] / 13] + character[computerCard[i] % 13] + " ");
                }
                else if (computerCard[i] % 13 > 9)
                {
                    Console.WriteLine(shape[computerCard[i] / 13] + character[computerCard[i] % 13 - 9] + " ");
                }else
                {
                    Console.WriteLine(shape[computerCard[i] / 13] + (computerCard[i] % 13 + 1) + ", ");
                }

            }
            Console.WriteLine();
            playerCard.Sort();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("사용자 카드 : \n");
                if (playerCard[i] % 13 == 0)
                {
                    Console.WriteLine(shape[playerCard[i] / 13] + character[playerCard[i] % 13] + " ");
                }
                else if (playerCard[i] % 13 > 9)
                {
                    Console.WriteLine(shape[playerCard[i] / 13] + character[playerCard[i] % 13 - 9] + " ");
                }
                else
                {
                    Console.WriteLine(shape[playerCard[i] / 13] + (playerCard[i] % 13 + 1) + ", ");
                }
            }

            Console.WriteLine("배팅 금액 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out batting);

            while (flag)
            {
                
                if (batting < nowPlayerMoney)
                {
                    break;
                }
                Console.WriteLine("다시 입력하세요 : ");
                int.TryParse(Console.ReadLine(), out batting);
                
                
            }
            nowPlayerMoney = nowPlayerMoney - batting;
            Console.WriteLine($"남은 금액 : {nowPlayerMoney}");

            computerCard.Add(allCard[0]);
            allCard.Remove(allCard[0]);
            computerCard.Add(allCard[0]);
            allCard.Remove(allCard[0]);

            computerCard.Sort();
            for (int i = 0; i < computerCard.Count; i++)
            {
                Console.Write("컴퓨터 카드 : \n");

                if (computerCard[i] % 13 == 0)
                {
                    Console.WriteLine(shape[computerCard[i] / 13] + character[computerCard[i] % 13] + " ");
                }
                else if (computerCard[i] % 13 > 9)
                {
                    Console.WriteLine(shape[computerCard[i] / 13] + character[computerCard[i] % 13 - 9] + " ");
                }
                else
                {
                    Console.WriteLine(shape[computerCard[i] / 13] + (computerCard[i] % 13 + 1) + ", ");
                }

            }
            int changeCard1 = 0;
            int changeCard2 = 0;

            while (flag)
            {
                Console.WriteLine("  첫번째 바꿀 카드 내놔라 : ");
                int.TryParse(Console.ReadLine(), out changeCard1);

                if (changeCard1 <= 5 && changeCard1 > 0)
                {
             
                    Console.WriteLine("  두번째 바꿀 카드 내놔라 : ");
                    int.TryParse(Console.ReadLine(), out changeCard2);

                    if (changeCard2 <= 5 && changeCard2 > 0)
                    {
                        playerCard.Remove(playerCard[changeCard1 - 1]);
                        playerCard.Add(allCard[0]);
                        allCard.Remove(allCard[0]);
                        playerCard.Remove(playerCard[changeCard2 - 1]);
                        playerCard.Add(allCard[0]);
                        allCard.Remove(0);
                        break;
                    }
                    
                }
                else
                { // do  nothing
                 }
                
            }
            playerCard.Sort();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("사용자 카드 : \n");
                if (playerCard[i] % 13 == 0)
                {
                    Console.WriteLine(shape[playerCard[i] / 13] + character[playerCard[i] % 13] + " ");
                }
                else if (playerCard[i] % 13 > 9)
                {
                    Console.WriteLine(shape[playerCard[i] / 13] + character[playerCard[i] % 13 - 9] + " ");
                }
                else
                {
                    Console.WriteLine(shape[playerCard[i] / 13] + (playerCard[i] % 13 + 1) + ", ");
                }
            } TopCheck(playerCard, computerCard);
        }
         bool TopCheck(List<int> computerCard, List<int> playerCard)
        {
            bool topcheck = true;
            int max1 = 0;
            int max2 = 0;

            int shape1 = 0;
            int shape2 = 0;

            for(int i = 0; i < playerCard.Count; i++)
            {
                if (max1 < playerCard[i] % 13)
                {
                    max1 = playerCard[i] % 13;
                }
                if (playerCard[i] % 13 == 0)
                {
                    max1 = 13;
                }
             
                
            }
            Console.WriteLine(max1);
            return topcheck;
        }
    }

}   

                                                                                                                          





    


    



