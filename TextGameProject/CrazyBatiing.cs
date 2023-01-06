using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextGameProject
{
    public class CrazyBatiing
    {
        Chacter chacter = new Chacter();
        Monster monster= new Monster(); 
        Batting batting= new Batting();
        Store store= new Store();
        Bazzi bazzi = new Bazzi();
        Dao dao = new Dao();
        Dizni dizni = new Dizni();
        Ethi ethi = new Ethi();

        protected int inputNumber;

        public void Run()
        {
            Crazy();
            Console.ReadKey();
            Console.Clear();

            chacter.User();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("캐릭터를 선택해주세요 (1. 배찌   2. 다오  3. 디지니  4. 에띠)");
            int.TryParse(Console.ReadLine(), out inputNumber);

            switch (inputNumber)
            {
                case 1:
                    Console.WriteLine("배찌 을(를) 선택하셨습니다.");
                    Console.WriteLine();
                    Console.WriteLine($"{bazzi.GetImage()}");
                    Console.WriteLine();
                    Console.WriteLine($" 이름 : {bazzi.GetName()}");
                    Console.WriteLine($" hp : {bazzi.GetHp()}"); 
                    Console.WriteLine($" 데미지 : {bazzi.GetDamage()}");
                    break;
                case 2:
                    Console.WriteLine("다오 을(를) 선택하셨습니다.");
                    break;
                case 3:
                    Console.WriteLine("디지니 을(를) 선택하셨습니다.");
                    break;
                case 4:
                    Console.WriteLine("에띠 을(를) 선택하셨습니다.");
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            monster.Mster();

            Console.ReadKey();
            Console.Clear();
            batting.Bat();

            Console.ReadKey();
            Console.Clear();
            batting.Win();

            Console.ReadKey();
            Console.Clear();
            store.Stor();

            Console.ReadKey();
            Console.Clear();
            batting.Bat();

            Console.ReadKey();
            Console.Clear();
            batting.Lose();



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
    }
}


