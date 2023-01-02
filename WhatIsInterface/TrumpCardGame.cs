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

namespace WhatIsInterface
{
    internal class TrumpCardGame
    {
        public void TrumpGame()
        {
            // 전체카드  string allCard;
            int nowPlayerMoney = 0;    // 현재 플래이어 돈
            int batting = 0;           // 플래이어가 배팅할 금액
            int minBatting = 0;        // 최소 배팅 금액
            string selectCard1 = " ";
            string selectCard2 = " ";
            string selectCard3 = " ";   // 최소배팅금액 보다 큰배팅인지 판단하기 위한 카드1,2,3
            int goalPoint = 0;         // 목표치 포인트(게임 종료할때)

            int[] array = new int[52]; // array 52번까지 선언
            string[] shape = new string[4];

            shape[0] = "◆";
            shape[1] = "♠";
            shape[2] = "♥";
            shape[3] = "♣";
            
   
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = i + 1;


            }   // array 할당
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Console.Write(shape[i]);
                    Console.Write(array[j + 13 * i] - i * 13);
                }
                Console.WriteLine();

            }

            CFunc.Shuffle(array, 200);













            


        } 
    }

}   

                                                                                                                          





    


    



