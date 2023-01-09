using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameProject
{
    public class Store
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
        public int money = 100;
        

        public void Stor(Characters characters)
        {
            characters.inventory.Add(1);
            characters.inventory.Add(1);
            characters.inventory.Add(1);
            characters.inventory.Add(1);
            characters.inventory.Add(1);
            characters.inventory.Add(2);
            int count = 1;
            int tmp = 0;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("나의 인벤토리 (4개 까지 보관 가능) =====================================================================================");
            Console.WriteLine();
            //for (int i = 0; i < characters.inventory.Count; i++)
            //{
            //    for (int j = i +1; j < characters.inventory.Count - 1; j++)
            //    {
                   

            //        if (characters.inventory[i] == characters.inventory[j])
            //        {
            //            count++;
            //            i = j;
            //            tmp = j;
            //        }   
                    
                    
            //    }
                
                
                

            //}
            //Console.WriteLine("{1} {0}개", count, tmp);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                                                                                           나의 돈 :  {characters.money} ");
            Console.WriteLine("상점 ====================================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("          1. 회복 약 (1원) ");
            Console.WriteLine("                4. 물 풍선 (1원)");
            Console.WriteLine();
            Console.Write("          2. 바늘 (1원) ");
            Console.WriteLine("                   5. 물 폭탄 (1원)");
            Console.WriteLine();
            Console.Write("          3. 방패 (1원) ");
            Console.WriteLine("                   6. 물 광선 (1원) ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.Write("                                                                                        다음 배틀 가기 (아무거나 눌러주세요)");
            int.TryParse(Console.ReadLine(), out selectItem);

            if (selectItem <= 0 || selectItem > 6)
            {
                Console.WriteLine(" 다음 배틀로 가기");
            }
            else 
            {   // 나의 돈이 아이템 값보다 크거나 같다를 판단
                // 나의 돈 - 아이템 가격 동시에 고른 아이템 인벤토리에 저장
               
            }
            Console.WriteLine();
           
        }
    }
}
