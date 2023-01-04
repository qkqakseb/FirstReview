using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WhatIsFunction
{
    public class PoterProgram2 : Poter
    {
        public void Poter2()
        {

            // 초기화
            //for (int y = 0; y < 10; y++)       // int y가 0부터 10까지 하나씩 증가 하기위해
            //{
            //    for (int x = 0; x < 10; x++)   // int x가 0부터 10까지 하나씩 증가 하기 위해 
            //    {
            //        if (x == 0 && y >= 3 && y <= 6)
            //        {
            //            array[y, x] = "□";
            //        }
            //        else if (y == 0 || y == 9 ||
            //            x == 0 || x == 9)
            //        {
            //            array[y, x] = "■";      // 만약 y,x 좌표가 0 부터 9까지 이면 ■ 로 표시하고
            //        }
            //        // 포털을 만들기
            //        else if (y == 4 && x == 1)
            //        {
            //            array[y, x] = "옷";      // 만약 y,x 좌표가 5,5 이면 옷을 표시하고
            //            nowX = 1;
            //            nowY = 4;
            //        }
            //        else
            //        {
            //            array[y, x] = ". ";     // 위 두가지 경우가 아니면 .으로 표시한다.
            //        }
            //    }
            //}
        }       // Poter2()

        public override void Init()
        {
            base.Init();

            poterMap = "poter2";

            for (int y = 0; y < 10; y++)       // int y가 0부터 10까지 하나씩 증가 하기위해
            {
                for (int x = 0; x < 10; x++)   // int x가 0부터 10까지 하나씩 증가 하기 위해 
                {
                    if (x == 0 && y >= 3 && y <= 6)
                    {
                        array[y, x] = "□";
                    }
                    else if (y == 0 || y == 9 ||
                        x == 0 || x == 9)
                    {
                        array[y, x] = "■";      // 만약 y,x 좌표가 0 부터 9까지 이면 ■ 로 표시하고
                    }
                    // 포털을 만들기
                    else if (y == 4 && x == 1)
                    {
                        array[y, x] = "옷";
                        nowX = 1;
                        nowY= 4;


                    }
                    else
                    {
                        array[y, x] = ". ";     // 위 두가지 경우가 아니면 .으로 표시한다.
                    }
                }
            }
        }

        //! 맵 정보를 받아서 포털2의 맵 정보로 덮어쓴다
        public void SetPoter2Map(ref string[,] map, ref int nowY_, ref int nowX_)
        {
            for (int y = 0; y < 10; y++)       // int y가 0부터 10까지 하나씩 증가 하기위해
            {
                for (int x = 0; x < 10; x++)   // int x가 0부터 10까지 하나씩 증가 하기 위해 
                {
                    if (x == 0 && y >= 3 && y <= 6)
                    {
                        map[y, x] = "□";
                    }
                    else if (y == 0 || y == 9 ||
                        x == 0 || x == 9)
                    {
                        map[y, x] = "■";      // 만약 y,x 좌표가 0 부터 9까지 이면 ■ 로 표시하고
                    }
                    // 포털을 만들기
                    else if (y == 4 && x == 1)
                    {
                        map[y, x] = "옷";       
                        nowX_ = 1;
                        nowY_ = 4;
                        Console.WriteLine(nowY_ + nowX_);
                    }
                    else
                    {
                        map[y, x] = ". ";     // 위 두가지 경우가 아니면 .으로 표시한다.
                    }
                }
            }
        }       // SetPoter2Map()
    }  // class Problem2
}

