﻿using System;
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


        // 각 몬스터 들이 가지고 있는 돈(승리 시 지급)
        static int monGetMoney;

        // 패배시 잃을 돈
        public int loseMoney ;

        // 승리시 얻을 아이템 (랜덤)
        string[] winItem = new string[6] { "회복약", "바늘", "방패", "물풍선", "물폭탄", "물광선" };
        static Random random = new Random();
        int num;
        


        // 승리 시 이동 경로 선택
        int winMove = 0;

        // 패배 시 이동 경로 선택
        int loseMove = 0;


        public void Bat(Characters ch, Monster mo, int num, int count)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                                                                                     승리시 얻을 돈 : {monster.monGetMoney}");
            Console.WriteLine($"                                                                                     승리시 얻을 아이템 : {winItem[num -1]}");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine($"                                            {characters.name} VS {monster.name} {count}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                    {ch.image}                                               {mo.image} ");
            Console.WriteLine();
            Console.WriteLine($"                        {ch.name}                                                      {mo.name} {count}");
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
            this.num= num;
        }

        // 캐릭터  vs 몬스터 출력되기 위한 함수
        public void Setup(Characters ch, Monster mo)
        {
            characters = ch;
            monster = mo;
        }

        public void Win(Characters characters, Monster monster)
        {
            if (monster.hp <= 0)
            {
                characters.money = characters.money + monster.monGetMoney;

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
                Console.Write($"+ {monster.monGetMoney}");
                Console.WriteLine($"                                                                                              나의 돈 : {characters.money}");
                characters.inventory[num - 1]++;
                Console.WriteLine($"+ {winItem[num - 1]}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                while (true)
                {
                    Console.WriteLine("                                   1. 계속하기                      2. 상점 가기 ");
                    int.TryParse(Console.ReadLine(), out winMove);
                    if (winMove == 1)
                    {
                        // 다음 전투로 넘어가면 몬스터 hp 4씩 증가
                        monster.increaseHp = monster.increaseHp + 4;
                        monster.hp = monster.increaseHp;

                        // 다음 전투로 넘어가면 캐릭터 hp 5씩 증가
                        characters.increaseHp = characters.increaseHp + 5;
                        characters.hp = characters.increaseHp;


                        // 캐릭터1,2,3,4 넘어가서 싸우는 거 구현 (캐릭터 hp +5 증가)

                        break;
                    }
                    else if (winMove == 2)
                    {
                        Console.Clear();
                        store.Stor(characters);

                        // 다음 전투로 넘어가면 몬스터 hp 4씩 증가
                        monster.increaseHp = monster.increaseHp + 4;
                        monster.hp = monster.increaseHp;

                        // 다음 전투로 넘어가면 캐릭터 hp 5씩 증가
                        characters.increaseHp = characters.increaseHp + 5;
                        characters.hp = characters.increaseHp;


                        break;
                    }
                    else
                    {
                        Console.WriteLine("다시 입력해주세요");
                    }
                }
            }
        }

        public void Lose(Characters characters)
        {
            if (characters.hp == 0)
            {
                characters.money = characters.money - monster.monGetMoney;

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
                Console.Write($" - {monster.monGetMoney}");
                Console.WriteLine($"                                                                                        나의 돈 : {characters.money}");
                Console.WriteLine();
                Console.WriteLine();
                while (true)
                {
                    Console.WriteLine("                              1. 맵 가기                 2. 캐릭터 선택 가기 ");
                    int.TryParse(Console.ReadLine(), out loseMove);
                    if (loseMove == 1)
                    {
                        // 게임에서 지면 캐릭터 hp 3씩 감소
                        characters.increaseHp = characters.increaseHp - 3;
                        characters.hp = characters.increaseHp;

                        monster.Mster();

                        break;
                    }
                    else if (loseMove == 2)
                    {
                        characters.Chter();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("다시 입력해주세요");
                    }

                }

            }

        }

        public void Endding(Characters characters, Monster monster)
        {
            Console.WriteLine($"{characters.name} 이(가) {monster.name} 을(를) 이겼습니다!!");

        }
    }
}
