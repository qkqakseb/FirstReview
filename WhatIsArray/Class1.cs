using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsArray
{
    internal class Class1
    {
        static void Main(string[] args)
        {


            // 야구게임 (마무리 하기)
            // 프로그램이 세가지 숫자를 랜덤해서 가지고 있어야된다.(세자리 각각 다른 숫자가 들어가야 됨)
            // 사용되는 숫자는 0에서 9까지 서로 다른 숫자
            // 0은 사용하지 않는다.
            // 숫자는 맞지만 위치가 틀렸을때는 볼
            // 숫자와 위치가 전부 맞으면 스트라이크
            // 숫자와 위치가 전부 틀리면 "OUT"
            // 틀린 숫자는 제끼고 남은 숫자끼리 조합


            // 프로그램이 세가지 숫자를 랜덤해서 가지고 있어야된다.(세자리 각각 다른 숫자가 들어가야 됨)

            // 사용되는 숫자는 0에서 9까지 서로 다른 숫자

            //Random allprogramNumber = new Random();

            //int programNumber1 = allprogramNumber.Next(0, 10);
            //int programNumber2 = allprogramNumber.Next(0, 10);
            //int programNumber3 = allprogramNumber.Next(0, 10);

            //while (programNumber1 == programNumber2 || programNumber2 == programNumber3 || programNumber3 == programNumber1)
            //{
            //    programNumber1 = allprogramNumber.Next(0, 10);
            //    programNumber2 = allprogramNumber.Next(0, 10);
            //    programNumber3 = allprogramNumber.Next(0, 10); //다시
            //}


            //int userNumber1 = 0;
            //int userNumber2 = 0;
            //int userNumber3 = 0;

            //int loopCount =0;

            //while (loopCount != 9) //loop 횟수를 기록할 변수 선언
            //{
            //    Console.WriteLine("첫번째 숫자를 입력해주세요");
            //    int.TryParse(Console.ReadLine(), out userNumber1);

            //    Console.WriteLine("두번째 숫자를 입력해주세요");
            //    int.TryParse(Console.ReadLine(), out userNumber2);

            //    while (userNumber1 == userNumber2)
            //    {
            //        Console.WriteLine("두번째 숫자를 입력해주세요");
            //        int.TryParse(Console.ReadLine(), out userNumber1);
            //    }

            //    Console.WriteLine("세번째 숫자를 입력해주세요");
            //    int.TryParse(Console.ReadLine(), out userNumber3);

            //    while (userNumber1 == userNumber3 || userNumber2 == userNumber3)
            //    {
            //        Console.WriteLine("세번째 숫자를 입력해주세요");
            //        int.TryParse(Console.ReadLine(), out userNumber1);
            //    }

            //    int strike = 0;
            //    int ball = 0;
            //    int Out = 0;

            //    if (programNumber1 == userNumber1)
            //    {
            //        strike++;
            //    }
            //    else if (userNumber1 == programNumber2 || userNumber1 == programNumber3)
            //    {
            //        ball++;
            //    }
            //    else
            //    {
            //        Out++;
            //    }

            //    if (programNumber2 == userNumber2)
            //    {
            //        strike++;
            //    }
            //    else if (userNumber2 == programNumber1 || userNumber2 == programNumber3)
            //    {
            //        ball++;
            //    }
            //    else
            //    {
            //        Out++;
            //    }

            //    if (programNumber3 == userNumber3)
            //    {
            //        strike++;
            //    }
            //    else if (userNumber3 == programNumber1 || userNumber3 == programNumber2)
            //    {
            //        ball++;
            //    }
            //    else
            //    {
            //        Out++;
            //    }
            //}//while
            //Console.WriteLine("종료합니다.");

            /*
             * 컬렉션
             * 이름 하나로 데이터 여러 개를 담을 수 있는 자료 구조를 컬렉션(Collection) 또는
             * 컨테이너(Container)라고 한다. c#에서 다루는 컬렉션은 배열(Array), 리스트(List),
             * 사전(Dictinary) 등이 있다.
             * 
             * 배열
             * 배열(Array)은 같은 종류의 데이터들이 순차적으로 메모리에 저장되는 자효 구조이다. 각각의 데이터들은
             * 인덱스(번호)를 사용하여 독립적으로 접근된다. 배열을 사용하면 편리하게 데이터를 모아서 관리할 수 있다.
             * 
             * 배열의 특징들
             * 1. 배열 하나에는 데이터 형식 한 종류만 보관할 수 있다.
             * 2. 배열은 메모리의연속된 공간을 미리 할당하고, 이를 대괄호([])와 0부터 시작하는 정수형 인덱스를
             *    사용하여 접근할 수 있다.,
             * 3. 배열을 선언할 때는 new 키워드로 배열을 생성한 후 사용할 수 있다.
             * 4. 배열에서 값 하나는 요소(Element) 또는 항목(Item)으로 표현한다.
             * 5. 필요한 데이터 개수를 정확히 정한다면 메모리를 적게 사용하여 프로그램 크기가 작아지고 성능이
             *    향상된다.
             *    
             *    배열에는 세 가지 종류가 있다.
             *    1차원 배열 : 배열의 첨자를 하나만 사용하는 배열
             *    2차원 배열 : 첨자 2개 이상을 사용하는 배열(2차원, 3차원, .....n차원 배열)
             *    가변(Jagged) 배열: '배열의 배열'이라고도 하며, 이름 하나로 다양한 차원의 배열을 표현할 때 사용한다.
             */

            //배열의 선언과 초기화
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            //int number1 = 1;
            //int number2 = 2;
            //int number3 = 3;
            //int number4 = 4;
            //int number5 = 5;

            Console.WriteLine(numbers); 

            //for (int index = 0; index < numbers.Length; index++)
            //{
            //    Console.WriteLine($"{ numbers[index]}");
            //}
            //foreach (int element in numbers)
            //{
            //    Console.WriteLine($"{element}");
            //}
        }//Main
    } // Class
}
