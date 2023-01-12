using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextGameProject
{
    public class CrazyBatting
    {
        Characters characters = new Characters();
        Monster monster = new Monster();
        Batting batting = new Batting();
        Store store = new Store();

        // 입력한 캐릭터
        int inputChacter;

        // 출력한 캐릭터
        string outCharacters;

        // 입력한 몬스터
        int inputMonster;

        // 출력한 몬스터
        string outMonster;


        // 이겼을때 이동 경로 선택
        int winChMove = 0;

        // 졌을때 이동 경로 선택
        int loseMove = 0;

        // 몬스터 세기(몬스터 1,2~)
        int count = 1;


        // 출력하는 순서
        public void Run()
        {
            Console.SetWindowSize(120,45);

            // 첫 화면 출력
            Crazy();

            // 첫 화면 아무것이나 입력하면 다음 출력으로 넘어가게 하기
            Console.ReadKey();

            // 화면 정리하고 새로운 화면 나오게 하기
            

            while (true)
            {
                Console.Clear();
                // chter()[함수]에 있는 정보 출력
                characters.Chter();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("캐릭터를 선택해주세요 (1. 배찌   2. 다오  3. 디지니  4. 에띠)");
                int.TryParse(Console.ReadLine(), out inputChacter);

                Console.Clear();
                switch (inputChacter)
                {
                    case 1:
                        Bazzi bazzi = new Bazzi();
                        Console.WriteLine("배찌 을(를) 선택하셨습니다.");
                        Console.WriteLine();
                        for (int i = 0; i < bazzi.image.Count; i++)
                        {
                            Console.WriteLine($"{bazzi.image[i]}");
                        }
                        Console.WriteLine();
                        Console.WriteLine($" 이름 : {bazzi.GetName()}");
                        Console.WriteLine($" hp : {bazzi.GetHp()}");
                        Console.WriteLine($" 데미지 : {bazzi.GetDamage()}");
                        characters = bazzi;

                        break;
                    case 2:
                        Dao dao = new Dao();
                        Console.WriteLine("다오 을(를) 선택하셨습니다.");
                        Console.WriteLine();
                        for (int i = 0; i < dao.image.Count; i++)
                        {
                            Console.WriteLine($"{dao.image[i]}");
                        }
                        Console.WriteLine();
                        Console.WriteLine($" 이름 : {dao.GetName()}");
                        Console.WriteLine($" hp : {dao.GetHp()}");
                        Console.WriteLine($" 데미지 : {dao.GetDamage()}");
                        characters = dao;
                        break;
                    case 3:
                        Dizni dizni = new Dizni();
                        Console.WriteLine("디지니 을(를) 선택하셨습니다.");
                        Console.WriteLine();
                        for (int i = 0; i < dizni.image.Count; i++)
                        {
                            Console.WriteLine($"{dizni.image[i]}");
                        }
                        Console.WriteLine();
                        Console.WriteLine($" 이름 : {dizni.GetName()}");
                        Console.WriteLine($" hp : {dizni.GetHp()}");
                        Console.WriteLine($" 데미지 : {dizni.GetDamage()}");
                        characters = dizni;
                        break;
                    case 4:
                        Ethi ethi = new Ethi();
                        Console.WriteLine("에띠 을(를) 선택하셨습니다.");
                        Console.WriteLine();
                        for (int i = 0; i < ethi.image.Count; i++)
                        {
                            Console.WriteLine($"{ethi.image[i]}");
                        }
                        Console.WriteLine();
                        Console.WriteLine($" 이름 : {ethi.GetName()}");
                        Console.WriteLine($" hp : {ethi.GetHp()}");
                        Console.WriteLine($" 데미지 : {ethi.GetDamage()}");
                        characters = ethi;
                        break;
                    default:
                        Console.WriteLine("1~4 수를 입력해 주세요");
                        Thread.Sleep(500);
                        Console.Clear();
                        continue;
                }
                Console.ReadKey();
                Console.Clear();


                // Mster()[함수]에 있는 정보 출력
                monster.Mster();

                Console.WriteLine("몬스터를 선택해주세요 (1. 슬라임   2. 오크  3. 좀비  4. 늑대)");
                int.TryParse(Console.ReadLine(), out inputMonster);


                Console.Clear();

                switch (inputMonster)

                {
                    case 1:
                        Slime slime = new Slime();

                        Console.WriteLine("슬라임 을(를) 선택하셨습니다.");
                        Console.WriteLine();
                        for( int i = 0; i < slime.image.Count; i++)
                        {
                            Console.WriteLine($"{slime.image[i]}");
                        }
                        
                        Console.WriteLine();
                        Console.WriteLine($" 이름 : {slime.GetName()}");
                        Console.WriteLine($" hp : {slime.GetHp()}");
                        Console.WriteLine($" 데미지 : {slime.GetDamage()}");
                        monster = slime;
                        break;
                    case 2:
                        Oak oak = new Oak();

                        Console.WriteLine("오크 을(를) 선택하셨습니다.");
                        Console.WriteLine();
                        for (int i = 0; i < oak.image.Count; i++)
                        {
                            Console.WriteLine($"{oak.image[i]}");
                        }
                        Console.WriteLine($" 이름 : {oak.GetName()}");
                        Console.WriteLine($" hp : {oak.GetHp()}");
                        Console.WriteLine($" 데미지 : {oak.GetDamage()}");
                        monster = oak;
                        break;
                    case 3:
                        Zombie zombie = new Zombie();

                        Console.WriteLine("좀비 을(를) 선택하셨습니다.");
                        Console.WriteLine();
                        for (int i = 0; i < zombie.image.Count; i++)
                        {
                            Console.WriteLine($"{zombie.image[i]}");
                        }
                        Console.WriteLine($" 이름 : {zombie.GetName()}");
                        Console.WriteLine($" hp : {zombie.GetHp()}");
                        Console.WriteLine($" 데미지 : {zombie.GetDamage()}");
                        monster = zombie;
                        break;
                    case 4:
                        Wolf wolf = new Wolf();

                        Console.WriteLine("늑대 을(를) 선택하셨습니다.");
                        Console.WriteLine();
                        for (int i = 0; i < wolf.image.Count; i++)
                        {
                            Console.WriteLine($"{wolf.image[i]}");
                        }
                        Console.WriteLine();
                        Console.WriteLine($" 이름 : {wolf.GetName()}");
                        Console.WriteLine($" hp : {wolf.GetHp()}");
                        Console.WriteLine($" 데미지 : {wolf.GetDamage()}");
                        monster = wolf;

                        break;
                    default:
                        Console.WriteLine("잘못된 수를 입력했습니다. 캐릭터를 다시 입력해주세요");
                        Thread.Sleep(500);
                        Console.Clear();
                        continue;
                }
                Console.ReadKey();
                Console.Clear();

                


                // 캐릭터 vs 몬스터 가지고 오기[셋업(설정)]
                batting.Setup(characters, monster);

                Random random = new Random();
                int randomNum = random.Next(1, 7);
                ConsoleKey userInputKey = ConsoleKey.NoName;
                while (true)
                {
                    //Bat()[함수]에 있는 정보 출력
                    batting.Bat(characters, monster,randomNum, count, ref userInputKey);

                    



                    //Console.Write($" 남은 몬스터 체력 : {monster.hp} \n 남은 캐릭터 체력 : {characters.hp}");
                    if (monster.hp <= 0)
                    {

                        Console.Clear();
                        count++;
                        if (count >= 5)
                        {
                            batting.Endding(characters, monster);
                            break;
                        }
                        else
                        {
                            batting.Win(characters, monster);
                            randomNum = random.Next(1, 7);
                        }
                    }
                    else if (characters.hp <= 0 || characters.hp == monster.hp)
                    {
                        Console.Clear();
                        batting.Lose(characters);

                    }
                    Thread.Sleep(200);
                    Console.Clear();
                }
            }
        }

        public void Crazy()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                          _____                           ______         _    _    _               ");
            Console.WriteLine("                         /  __ `                          | ___ `       | |  | |  (_)              ");
            Console.WriteLine("                         | /  `/ _ __   __ _  ____ _   _  | |_/ /  __ _ | |_ | |_  _  _ __    __ _ ");
            Console.WriteLine("                         | |    | '__| / _` ||_  /| | | | | ___ ` / _` || __|| __|| || '_ `  / _` |");
            Console.WriteLine("                         | `__/`| |   | (_| | / / | |_| | | |_/ /| (_| || |_ | |_ | || | | || (_| |");
            Console.WriteLine("                          `____/|_|    `__,_|/___| `__, | `____/  `__,_| `__| `__||_||_| |_| `__, |");
            Console.WriteLine("                                                   __ / |                                     __/ |");
            Console.WriteLine("                                                   | ___/                                     |___/");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                                        START                         ");

        }
    } // class CrazyBatting()
 }



