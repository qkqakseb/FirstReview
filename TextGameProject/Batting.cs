using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


        public void Bat(Characters ch, Monster mo, int num, int count, ref ConsoleKey userInputKey)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                                                                                     승리시 얻을 돈 : {monster.monGetMoney}");
            Console.WriteLine($"                                                                                     승리시 얻을 아이템 : {winItem[num -1]}");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine($"                                                    {characters.name} VS {monster.name} {count}");
            Console.WriteLine();
            for (int i = 0; i < ch.image.Count; i++)
            {
                if (i < 24)
                {
                    Console.WriteLine($"      {ch.image[i]}                       {mo.image[i]} ");
                }
                else
                {
                    Console.WriteLine($"      {ch.image[i]}");
                }


            }
            Console.WriteLine();
            Console.WriteLine($"                        {ch.name}                                                      {mo.name} {count}");
            Console.WriteLine();
            Console.WriteLine($"                      hp   : {ch.hp}                                                     hp   : {mo.hp}");
            Console.WriteLine($"                    데미지 : {ch.damage}                                                    데미지 : {mo.damage}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            
            
            Console.WriteLine();
            Console.WriteLine("인벤토리 (1. 회복약 2. 바늘 3. 방패 Q. 물풍선 W. 물폭탄 E. 물광선 )- - - - - - - - - - - - - - - - - - - - - - - - - - -");
            //string userSelectItem;
            for (int i = 0; i < characters.inventory.Count; i++)
            {
                if (characters.inventory[i] == 0)
                {
                    // 출력 안함  
                }
                else if (characters.inventory[i] >= 1)
                {
                    Console.WriteLine($"{winItem[i]} :{characters.inventory[i]}");
                }
            }
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");


            ConsoleKeyInfo userInputKeyClass = Console.ReadKey();
            userInputKey = userInputKeyClass.Key;
            switch (userInputKey)
            {
                // 인벤토리에서 1번(회복약)을 누르면 캐릭터 hp + 3 된다.
                case ConsoleKey.D1:
                    if (characters.inventory[0] == 0)
                    {
                        Console.WriteLine("아이템이 없어 기본 공격을 시작합니다.");
                        goto default; 
                    }
                    else
                    {
                        Console.WriteLine("회복약 을(를) 사용하여 hp가 3이 증가하였습니다.");
                        characters.hp += 3;
                        characters.inventory[0]--;
                    }
                    break;
    
                // 인벤토리에서 2번(바늘)을 누르면 몬스터 데미지 1만 받음
                case ConsoleKey.D2:
                    if (characters.inventory[1] == 0)
                    {
                        Console.WriteLine("아이템이 없어 기본 공격을 시작합니다.");
                        goto default;
                    }
                    else
                    {
                        Console.WriteLine("바늘 을(를) 사용하여 몬스터 데미지가 감소됬습니다.");
                        characters.hp += monster.damage - 1;
                        characters.inventory[1]--;
                    }
                    break;

                // 인벤토리에서 3번(방패)을 누르면 몬스터 다음 공격으로 부터 막는다.
                case ConsoleKey.D3:
                    if (characters.inventory[2] == 0)
                    {
                        Console.WriteLine("아이템이 없어 기본 공격을 시작합니다.");
                        goto default;
                    }
                    else
                    {
                        Console.WriteLine("방패 을(를) 사용하여 몬스터의 공격을 막았습니다.");
                        characters.hp += monster.damage;
                        characters.inventory[2]--;
                    }   
                    break;

                // 인벤토리에서 Q(물풍선)를 누르면 하늘색으로 -> 표시 되고 몬스터 hp -6 된다.
                case ConsoleKey.Q:
                    if (characters.inventory[3] == 0)
                    {
                        Console.WriteLine("아이템이 없어 기본 공격을 시작합니다.");
                        goto default;
                    }
                    else
                    {
                        Console.WriteLine("물풍선 을(를) 사용하여 몬스터에게 피해를 줬습니다.");
                        Console.SetCursorPosition(50, 25);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        for (int i = 0; i < 10; i++)
                        {
                            if (i == 7)
                            {
                                Console.SetCursorPosition((i * 2) + 50, 23);
                                Console.Write("■");
                                Console.SetCursorPosition((i * 2) + 50, 28);
                                Console.Write("■");
                            }
                            else if (i == 8)
                            {
                                Console.SetCursorPosition((i * 2) + 50, 24);
                                Console.Write("■");
                                Console.SetCursorPosition((i * 2) + 50, 27);
                                Console.Write("■");
                            }

                            Console.SetCursorPosition((i * 2) + 50, 25);
                            Console.Write("■");
                            Console.SetCursorPosition((i * 2) + 50, 26);
                            Console.Write("■");
                            Thread.Sleep(25);

                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        monster.hp -= 6;
                        characters.inventory[3]--;
                    }
                    break;
                    
      

                // 인벤토리에서 W(물폭탄)을 누르면 빨간색으로 -> 표시 되고 몬스터 hp -7 된다.
                case ConsoleKey.W:
                    if (characters.inventory[4] == 0)
                    {
                        Console.WriteLine("아이템이 없어 기본 공격을 시작합니다.");
                        goto default;
                    }
                    else
                    {
                        Console.WriteLine("물폭탄 을(를) 사용하여 몬스터에게 피해를 줬습니다.");
                        Console.SetCursorPosition(50, 25);
                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int i = 0; i < 10; i++)
                        {
                            if (i == 7)
                            {
                                Console.SetCursorPosition((i * 2) + 50, 23);
                                Console.Write("■");
                                Console.SetCursorPosition((i * 2) + 50, 28);
                                Console.Write("■");
                            }
                            else if (i == 8)
                            {
                                Console.SetCursorPosition((i * 2) + 50, 24);
                                Console.Write("■");
                                Console.SetCursorPosition((i * 2) + 50, 27);
                                Console.Write("■");
                            }

                            Console.SetCursorPosition((i * 2) + 50, 25);
                            Console.Write("■");
                            Console.SetCursorPosition((i * 2) + 50, 26);
                            Console.Write("■");
                            Thread.Sleep(25);

                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        monster.hp -= 7;
                        characters.inventory[4]--;
                    }
                    break;

                // 인벤토리에서 E(물광선)을 누르면 노란색으로 -> 표시 되고 몬스터 hp -8 된다.
                case ConsoleKey.E:
                    if (characters.inventory[5] == 0)
                    {
                        Console.WriteLine("아이템이 없어 기본 공격을 시작합니다.");
                        goto default;
                    }
                    else
                    {
                        Console.WriteLine("물광선 을(를) 사용하여 몬스터에게 피해를 줬습니다.");
                        Console.SetCursorPosition(50, 25);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        for (int i = 0; i < 10; i++)
                        {
                            if (i == 7)
                            {
                                Console.SetCursorPosition((i * 2) + 50, 23);
                                Console.Write("■");
                                Console.SetCursorPosition((i * 2) + 50, 28);
                                Console.Write("■");
                            }
                            else if (i == 8)
                            {
                                Console.SetCursorPosition((i * 2) + 50, 24);
                                Console.Write("■");
                                Console.SetCursorPosition((i * 2) + 50, 27);
                                Console.Write("■");
                            }

                            Console.SetCursorPosition((i * 2) + 50, 25);
                            Console.Write("■");
                            Console.SetCursorPosition((i * 2) + 50, 26);
                            Console.Write("■");
                            Thread.Sleep(25);

                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        monster.hp -= 8;
                        characters.inventory[5]--;
                    }
                    break;
                default:
                    Console.SetCursorPosition(50, 25);
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int i = 0; i < 10; i++)
                    {
                        if (i == 7)
                        {
                            Console.SetCursorPosition((i * 2) + 50, 23);
                            Console.Write("■");
                            Console.SetCursorPosition((i * 2) + 50, 28);
                            Console.Write("■");
                        }
                        else if (i == 8)
                        {
                            Console.SetCursorPosition((i * 2) + 50, 24);
                            Console.Write("■");
                            Console.SetCursorPosition((i * 2) + 50, 27);
                            Console.Write("■");
                        }

                        Console.SetCursorPosition((i * 2) + 50, 25);  
                        Console.Write("■");
                        Console.SetCursorPosition((i * 2) + 50, 26);
                        Console.Write("■");
                        Thread.Sleep(25);

                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    // 공격 당했을때 몬스터 데이지 감소, 캐릭터가 먼저 공격
                    monster.MonHit(characters.damage);
                    break;// 공격하는 걸로 돌아감
            }
            if (monster.hp > 0)
            {
                /// 공격 당했을때 캐릭터 데이지 감소
                characters.ChHit(monster.damage);
            }
            
           

            this.num = num;
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
                Console.WriteLine("= = = ☆ = = = = = = ☆ = = = = = =  ☆ = = = = = = ☆ = = = = = = ☆ = = = = = = ☆ = = = = = = ☆ = = = = = = ☆");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                 __   __  ___   _   _     _    _  _____  _   _ ");
                Console.WriteLine("                                 ` ` / //  _  `| | | |   | |  | ||_   _|| ` | |");
                Console.WriteLine("                                  ` V / | | | || | | |   | |  | |  | |  |  `| |");
                Console.WriteLine("                                   ` /  | | | || | | |   | |/`| |  | |  | . ` |");
                Console.WriteLine("                                   | |  ` `_/ /| |_| |   `  /`  / _| |_ | |`  |");
                Console.WriteLine("                                   |_|   `___/  `___/     `/  `/  `___/ `_| `_/");
                Console.WriteLine();
                Console.WriteLine("                                                     ☆(^▽^)☆           ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("= = = ☆ = = = = = = ☆ = = = = = =  ☆ = = = = = = ☆ = = = = = = ☆ = = = = = = ☆ = = = = = = ☆ = = = = = = ☆");
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
                Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("                               __   __  ___   _   _     _      ___   _____  _____ ");
                Console.WriteLine("                               ` ` / //  _  `| | | |   | |   /  _  `/  ___||  ___|");
                Console.WriteLine("                                ` V / | | | || | | |   | |   | | | |` `--. | |__  ");
                Console.WriteLine("                                 ` /  | | | || | | |   | |   | | | | `--. `|  __| ");
                Console.WriteLine("                                 | |  ` `_/ /| |_| |   | |___` `_/ //`__/ /| |___ ");
                Console.WriteLine("                                 |_|   `___/ `___ /    |____/ `___/ `____/ `____/ "); 
                Console.WriteLine();
                Console.WriteLine("                                                   o(ㅠ〓ㅠ)o          ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =");
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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                             {characters.name} 이(가) {monster.name} 을(를) 이겼습니다!!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            
            Thread.Sleep(2000);

        }
    }
}
