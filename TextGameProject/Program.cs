using System;
using System.Threading;

namespace TextGameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 맵 선택
            // - 전투를 한다

            // 상점에 가면 ?
            // - 무기, 포션을 살 수 있다.


            // 캐릭터을 나열
            // 배찌, 다오, 디지니



            // 유저는 체력, 공격, 속도를 갖고, 직업별로 조금씩 다르다!
            int hp = 10;
            int waterstr = 0;
            int speed = 0;
            string player = "캐릭터";


            // 캐릭터 마다 가지고 있는 능력이 다르다.

            Console.WriteLine("크레이지 아케이드에 온걸 환영합니다~!");

            Console.WriteLine("캐릭터를 고르세요!");
            Console.WriteLine("1. 배찌 \t 2. 다오 \t 3. 디지니");
            var select = Console.ReadLine();

            if (select == "1")
            {
                player = "배찌";
                Console.WriteLine("배찌를 선택하셨습니다!");
                hp = 500;
                waterstr = 100;
                speed = 5;
            }
            else if (select == "2")
            {
                player = "다오";
                Console.WriteLine("다오를 선택하셨습니다!");
                hp = 300;
                waterstr = 120;
                speed = 3;
            }
            else if (select == "3")
            {
                player = "디지니";
                Console.WriteLine("디지니를 선택하셨습니다!");
                hp = 400;
                waterstr = 80;
                speed = 10;
            }

            // 유저 능력치
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("--- User Status ---");

            Console.WriteLine("캐릭터 : " + player);
            Console.WriteLine("HP : " + hp);
            Console.WriteLine("waterstr : " + waterstr);
            Console.WriteLine("Speed : " + speed);


            // 유저의 선택을 제공
            Console.WriteLine();
            Console.WriteLine("무엇을 할것인가요?");

            Console.WriteLine("1. 맵 선택 \t  2. 상점");
            select = Console.ReadLine();

            if (select == "1")
            {
                Console.WriteLine("맵을 선택해주세요!");
            }
            else if (select == "2")
            {
                Console.WriteLine("상점에 진입합니다!");
            }


            //맵을 선택시 맵 고르기

            Console.WriteLine();
            Console.WriteLine("맵을 선택해주세요!");

            Console.WriteLine("1. 팩토리 \t 2. 무덤 \t 3. 캠프");
            select = Console.ReadLine();



            if (select == "1")
            {
                player = "팩토리";
                Console.WriteLine("팩토리에 진입합니다!");

            }
            else if (select == "2")
            {
                player = "무덤";
                Console.WriteLine("무덤에 진입합니다!");

            }
            else if (select == "3")
            {
                player = "캠프";
                Console.WriteLine("캠프에 진입합니다.!");

            }


            //상점 선택시 

            Console.WriteLine();
            Console.WriteLine("무기를 고르세요!");

            Console.WriteLine("1. 물풍선 \t 2. 바늘 \t 3. 방패");
            select = Console.ReadLine();


            if (select == "1")
            {
                player = "물풍선";
                Console.WriteLine("물풍선을 구입하셨습니다!");

            }
            else if (select == "2")
            {
                player = "바늘";
                Console.WriteLine("바늘을 구입하셨습니다!");

            }
            else if (select == "3")
            {
                player = "방패";
                Console.WriteLine("방패를 구입하셨습니다!");

            }
        }
    }
}
    
