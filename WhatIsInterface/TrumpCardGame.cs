using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

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

            int i = 0;
            string[] allCard = { "◆ A", "◆ 2", "◆ 3", "◆ 4", "◆ 5", "◆ 6", "◆ 7", "◆ 8", "◆ 9", "◆ 10", "◆ J", "◆ Q", "◆ K" };
            CFunc.ShuffleStrArray(allCard, 200);
            

            while (i < allCard.Length)
            { 
                Console.WriteLine(allCard[i]);
                i++;
            }
         } 
    }

}   

                                                                                                                          





    


    



