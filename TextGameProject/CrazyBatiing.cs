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
            // 첫 화면 출력
            Crazy();

            // 첫 화면 아무것이나 입력하면 다음 출력으로 넘어가게 하기
            Console.ReadKey();

            // 화면 정리하고 새로운 화면 나오게 하기
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
                    Console.WriteLine($"{bazzi.GetImage()}");
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
                    Console.WriteLine($"{dao.GetImage()}");
                    Console.WriteLine();
                    Console.WriteLine($" 이름 : {dao.GetName()}");
                    Console.WriteLine($" hp : {dao.GetHp()}");
                    Console.WriteLine($" 데미지 : {dao.GetDamage()}");
                    characters = dao;
                    break;
                case 3:
                    Dizni dizni= new Dizni();
                    Console.WriteLine("디지니 을(를) 선택하셨습니다.");
                    Console.WriteLine();
                    Console.WriteLine($"{dizni.GetImage()}");
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
                    Console.WriteLine($"{ethi.GetImage()}");
                    Console.WriteLine();
                    Console.WriteLine($" 이름 : {ethi.GetName()}");
                    Console.WriteLine($" hp : {ethi.GetHp()}");
                    Console.WriteLine($" 데미지 : {ethi.GetDamage()}");
                    characters = ethi;
                    break;
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
                    Console.WriteLine($"{slime.GetImage()}");
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
                    Console.WriteLine($"{oak.GetImage()}");
                    Console.WriteLine();
                    Console.WriteLine($" 이름 : {oak.GetName()}");
                    Console.WriteLine($" hp : {oak.GetHp()}");
                    Console.WriteLine($" 데미지 : {oak.GetDamage()}");
                    monster = oak;
                    break;
                case 3:
                    Zombie zombie  = new Zombie();

                    Console.WriteLine("좀비 을(를) 선택하셨습니다.");
                    Console.WriteLine();
                    Console.WriteLine($"{zombie.GetImage()}");
                    Console.WriteLine();
                    Console.WriteLine($" 이름 : {zombie.GetName()}");
                    Console.WriteLine($" hp : {zombie.GetHp()}");
                    Console.WriteLine($" 데미지 : {zombie.GetDamage()}");
                    monster = zombie;
                    break;
                case 4:
                    Wolf wolf = new Wolf();

                    Console.WriteLine("늑대 을(를) 선택하셨습니다.");
                    Console.WriteLine();
                    Console.WriteLine($"{wolf.GetImage()}");
                    Console.WriteLine();
                    Console.WriteLine($" 이름 : {wolf.GetName()}");
                    Console.WriteLine($" hp : {wolf.GetHp()}");
                    Console.WriteLine($" 데미지 : {wolf.GetDamage()}");
                    monster = wolf;

                    break;
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{outCharacters} VS {outMonster}");


            // 캐릭터 vs 몬스터 가지고 오기[셋업(설정)]
            batting.Setup(characters, monster);

            while (true)
            {
                // 공격 당했을때 몬스터 데이지 감소, 캐릭터가 먼저 공격
                monster.MonHit(characters.damage);

                // 공격 당했을때 캐릭터 데이지 감소
                characters.ChHit(monster.damage);

                //Bat()[함수]에 있는 정보 출력
                batting.Bat(characters, monster);

                Console.WriteLine($"남은 몬스터 체력 : {monster.hp} ");
                Console.WriteLine($"남은 캐릭터 체력 : {characters.hp} ");
                Console.ReadKey();
                if (monster.hp <= 0)
                {
                    Console.Clear();
                    count++;
                    if (count >= 5)
                    {
                        batting.Endding(characters, monster);
                    }
                    else 
                    {
                        batting.Win(characters, monster);
                    }       
                }
                else if(characters.hp <= 0)
                {
                    Console.Clear();
                    batting.Lose(characters);
                    
                }

                Console.ReadKey();
                Console.Clear();


            }
            
           



        }

        //Console.ReadKey();
        //Console.Clear();
        //store.Stor();




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
            Console.WriteLine("                                                 Welcome Cray Batting            ");
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



