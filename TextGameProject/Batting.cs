using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameProject
{
    public class Batting
    {
        Chacter chacter = new Chacter();
        Monster monster = new Monster();
        public void Bat()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                                                                     승리시 얻을 돈 : ");
            Console.WriteLine("                                                                                     승리시 얻을 아이템 : ");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("  캐릭터 이모티콘");
            Console.WriteLine("                    몬스터 이모티콘");
            Console.WriteLine();
            Console.Write("  캐릭터 이름");
            Console.WriteLine("                          몬스터 이름");
            Console.Write("  캐릭터 체력");
            Console.WriteLine("                          몬스터 체력");
            Console.Write("  캐릭터 데미지");
            Console.WriteLine("                        몬스터 데미지");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");

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
            Console.Write("+ 얻은돈");
            Console.WriteLine("                                                                                              나의 돈 : ");
            Console.WriteLine("+ 얻은 아이템");
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                   1. 계속하기                      2. 상점 가기 ");
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
            Console.Write(" - 잃은돈");
            Console.WriteLine("                                                                                        나의 돈 : ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                              1. 맵 선택 하기                 2. 캐릭터 선택 하기 ");
        }
    }
}
