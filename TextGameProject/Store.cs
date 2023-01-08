using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameProject
{
    internal class Store
    {
        // 방어 아이템
        string recoveryMedicine = "회복약";
        string needle = "바늘";
        string shield = "방패";

        // 공격 아이템
        string waterBalloon = "물풍선";
        string waterBomb = "물폭탄";
        string waterRays = "물광선";

        // 아이템 선택
        int selectItem = 0;

        public void Stor()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("나의 인벤토리 (4개 까지 보관 가능) =====================================================================================");
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
            Console.WriteLine("                                                                                           나의 돈 : ");
            Console.WriteLine("상점 ====================================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" 아이템을 선택해주세요.");
            int.TryParse(Console.ReadLine(), out selectItem);
            Console.Write("          1. 회복 약 ");
            Console.WriteLine("                4. 물 풍선");
            Console.WriteLine();
            Console.Write("          2. 바늘 ");
            Console.WriteLine("                   5. 물 폭탄");
            Console.WriteLine();
            Console.Write("          3. 방패 ");
            Console.WriteLine("                   6. 물 광선 ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.Write("                                                                                        다음 배틀 가기 (B를 눌러주세요)");
        }
    }
}
