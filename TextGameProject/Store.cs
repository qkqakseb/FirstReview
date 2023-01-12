using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextGameProject
{
    public class Store
    {
        int selectItem = 0;
        public int money = 100;
        string[] winItem = new string[6] { "회복약 ", "바늘    ", "방패    ", "물풍선", "물폭탄", "물광선" };

        Dictionary<string, int> itemCost = new Dictionary<string, int>();


        public Store() {

            itemCost.Add(winItem[0], 3);
            itemCost.Add(winItem[1], 1);
            itemCost.Add(winItem[2], 3);
            itemCost.Add(winItem[3], 2);
            itemCost.Add(winItem[4], 3);
            itemCost.Add(winItem[5], 4);
        }
        // 아이템 선택
        
        public void Stor(Characters characters)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("나의 인벤토리 - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine();
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
            Console.WriteLine();
            Console.WriteLine(); 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                                                                                           나의 돈 :  {characters.money} ");
            Console.WriteLine("상점 = = = ☆ = = = = = = ☆ = = = = = =  ☆ = = = = = = ☆ = = = = = = ☆ = = = = = = ☆ = = = = = = ☆ = = = = = = ☆");
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (i == 0 )
                    {
                        
                        if (j == 1)
                        {
                            Console.Write($"     {i + 1 + (j * 3)}. {winItem[i + (j * 3)]}".PadRight(20, ' ') + $" ({itemCost[winItem[i + (j * 3)]]}원)                     ".PadRight(50, ' '));
                        }
                        else
                        {
                            Console.Write($"     {i + 1 + (j * 3)}. {winItem[i + (j * 3)]}".PadRight(20, ' ') + $"({itemCost[winItem[i + (j * 3)]]}원)                     ".PadRight(49, ' '));
                        }
                    }
                    else
                        Console.Write($"     {i + 1 + (j * 3)}. {winItem[i+ (j * 3)]}".PadRight(20,' ') + $" ({itemCost[winItem[i + (j * 3)]]}원)                       ".PadRight(50,' '));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("= = = ☆ = = = = = = ☆ = = = = = =  ☆ = = = = = = ☆ = = = = = = ☆ = = = = = = ☆ = = = = = = ☆ = = = = = = ☆ = = =");
            Console.Write("                                                                  구매하실 아이템을 골라주세요(1~6 외 입력 시 구매종료)");
            int.TryParse(Console.ReadLine(), out selectItem);

            if (selectItem <= 0 || selectItem > 6)
            {
                Console.WriteLine(" 다음 배틀로 가기");
            }
            else
            {
                if (itemCost[winItem[selectItem - 1]] <= characters.money)
                {
                    characters.inventory[selectItem - 1]++;
                    characters.money -= itemCost[winItem[selectItem - 1]];
                    Console.WriteLine($"{winItem[selectItem - 1]} 을(를) 구매하였습니다.");
                }
            }
               // 나의 돈이 아이템 값보다 크거나 같다를 판단
                // 나의 돈 - 아이템 가격 동시에 고른 아이템 인벤토리에 저장

            
            Console.WriteLine();
           
        }
    }
}
