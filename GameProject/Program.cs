using System;
using System.Threading;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int strength =0;             // 힘
            int speed = 0;               // 민첩
            int intellect = 0;           // 지능
            int charisma = 0;            // 카리스마
            int health = 0;              // 건강
            int wisdom = 0;              // 지혜

            int select = 0;
            string player = "캐릭터";    // 캐릭터



            Console.WriteLine("=======================");
            Console.WriteLine("     모험가 이야기    ");
            Console.WriteLine("=======================");

            Console.WriteLine("     TAP TO START      \n");


            Thread.Sleep(2000);
            Console.WriteLine("캐릭터를 고르세요!");
            Console.WriteLine("여자 :   1.에신  \t 2. 마젯  \t 3. 테리아");   // 여자 캐릭터
            Console.WriteLine("남자 :   4.에나드 \t 5. 마르틴 \t 6. 페르");   // 남자 캐릭터
            int.TryParse(Console.ReadLine(), out select);

            while ( select < 0 || select > 6 )
            {
                Console.WriteLine("다시 입력해 주세요!");
                int.TryParse(Console.ReadLine(), out select);
      
            }


            // 캐릭터 마다 가지고 있는 능력이 다르다.
            Console.WriteLine();
            if (select == 1)
                {
                    player = "에신";
                    Console.WriteLine("에신을(를) 선택하셨습니다!");
                    strength = 9;
                    speed = 7;
                    intellect = 11;
                    charisma = 7;
                    health = 9;
                    wisdom = 9;
                }
                else if (select == 2)
                {
                    player = "마젯";
                    Console.WriteLine("마젯을(를) 선택하셨습니다!");
                    strength = 8;
                    speed = 10;
                    intellect = 12;
                    charisma = 8;
                    health = 8;
                    wisdom = 10;
                }
                else if (select == 3)
                {
                    player = "테리아";
                    Console.WriteLine("테리아을(를) 선택하셨습니다!");
                    strength = 10;
                    speed = 6;
                    intellect = 10;
                    charisma = 9;
                    health = 7;
                    wisdom = 8;
                }
                else if (select == 4)
                {
                    player = "에나드";
                    Console.WriteLine("에나드을(를) 선택하셨습니다!");
                    strength = 11;
                    speed = 8;
                    intellect = 9;
                    charisma = 10;
                    health = 9;
                    wisdom = 10;
                }
                else if (select == 5)
                {
                    player = "마르틴";
                    Console.WriteLine("마르틴을(를) 선택하셨습니다!");
                    strength = 12;
                    speed = 7;
                    intellect = 8;
                    charisma = 11;
                    health = 10;
                    wisdom = 9;
                }
                else if (select == 6)
                {
                    player = "페르";
                    Console.WriteLine("페르을(를) 선택하셨습니다!");
                    strength = 13;
                    speed = 6;
                    intellect = 7;
                    charisma = 12;
                    health = 11;
                    wisdom = 8;
                }


            // 캐릭터 능력치
            Thread.Sleep(1000);

            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("==== 캐릭터 능력치 =====  \n");

            Console.WriteLine($"캐릭터 : {player} ");
            Console.WriteLine($"힘 : {strength} ");
            Console.WriteLine($"민첩 : {speed} ");
            Console.WriteLine($"지능 : {intellect} ");
            Console.WriteLine($"카리스마 : {charisma} ");
            Console.WriteLine($"건강 : {health} ");
            Console.WriteLine($"지혜 : {wisdom}");



        }
    }
}