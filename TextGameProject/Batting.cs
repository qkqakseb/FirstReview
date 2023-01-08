using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace TextGameProject
{
    public class Batting
    {
        Characters characters;
        Monster monster;
        Store store = new Store();


        public int money = 100;
        public string item;
        public int chattack;

        int winMoney = 0;
        string winItem = " 물풍선";

        // 이겼을때 이동 경로 선택
        int winMove = 0;

        // 졌을때 이동 경로 선택
        int loseMove = 0;

        //Characters ch;
        //Monster mo;

        public void Bat(Characters ch, Monster mo)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                                                                                     승리시 얻을 돈 : {winMoney}");
            Console.WriteLine($"                                                                                     승리시 얻을 아이템 : {item}");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                    {ch.image}                                               {mo.image} ");
            Console.WriteLine();
            Console.WriteLine($"                        {ch.name}                                                      {mo.name}");
            Console.WriteLine();
            Console.WriteLine($"                      hp   : {ch.hp}                                                     hp   : {mo.hp}");
            Console.WriteLine($"                    데미지 : {ch.damage}                                                    데미지 : {mo.damage}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");

        }

        // 다음 전투로 넘어 가기 위한 함수
        public void Setup(Characters ch, Monster mo)
        {
            characters = ch;
            monster = mo;
        }

        public void Win()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                                      YOU WIN              ");
            Console.WriteLine();
            Console.WriteLine("                                                     ☆(^▽^)☆           ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.Write($"+ {winMoney}");
            Console.WriteLine($"                                                                                              나의 돈 : {money + winMoney}");
            Console.WriteLine($"+ {item}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                   1. 계속하기                      2. 상점 가기 ");
            int.TryParse(Console.ReadLine(), out winMove);
            if (winMove == 1)
            {
                // 다음 전투로 넘어가면 몬스터 hp 4씩 증가
                monster.increaseHp = monster.increaseHp + 4;
                monster.hp = monster.increaseHp;

                // 다음 전투로 넘어가면 캐릭터 hp 5씩 증가
                characters.increaseHp = monster.increaseHp + 5;
                characters.hp = monster.increaseHp;

                // 다음 전투로 넘어가기
                Bat(characters, monster);

                // 캐릭터1,2,3,4 넘어가서 싸우는 거 구현 (캐릭터 hp +5 증가)
                // 캐릭터 이기면 얻는 돈 1씩 증가
                // 캐릭터 이기면 랜덤으로 받은 아이템 증정

            }
            else if (winMove == 2)
            {
                store.Stor();
            }
        }

        public void Lose()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                                    YOU LOSE             ");
            Console.WriteLine();
            Console.WriteLine("                                                   o(ㅠ〓ㅠ)o          ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.Write($" - {winMoney}");
            Console.WriteLine($"                                                                                        나의 돈 : {money - winMoney}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                              1. 맵 가기                 2. 캐릭터 선택 가기 ");
            int.TryParse(Console.ReadLine(), out loseMove);
            if (characters.hp == 0)
            {
                Console.WriteLine("1. 맵 가기  2. 캐릭터 선택 가기");
                int.TryParse(Console.ReadLine(), out loseMove);
                if (loseMove == 1)
                {
                    // 게임에서 지면 캐릭터 hp 3씩 감소
                    characters.decreaseHp = characters.decreaseHp - 3;
                    characters.hp = characters.decreaseHp;

                    monster.Mster();
                }
                else if (loseMove == 2)
                {
                    characters.Chter();
                }
            }
        }
    }
}
