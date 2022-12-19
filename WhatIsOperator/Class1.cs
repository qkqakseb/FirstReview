using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsOperator
{
    internal class Class1
    {
        static void Main(string[] args) 
        {

            //최대한도의 사탕사기

            //  현재 1000원이 있고 사탕의 가격이 300원 일 때, 최대 살 수 있는 사탕의
            //  개수와 나머지 돈은 얼마인지 출력하는 프로그램
            //  EX) 현재 가지고 있는 돈 : 1000 (유저 입력)
            //      캔디의 가격 : 300 (상수)
            //      최대로 살 수 있는 캔디의 개수 : 3
            //      캔디 구입 후 남은 돈 : 100


            int nowMoney;

            Console.WriteLine("현재 가지고 있는 돈은");
            int.TryParse(Console.ReadLine(), out nowMoney);

            const int CANDY_PRICE = 300;


            Console.WriteLine($"최대 살 수 있는 사탕의 개수 : {nowMoney / CANDY_PRICE}");
            Console.WriteLine($"캔디 구입 후 남은 돈 :  {nowMoney % CANDY_PRICE}");




            // 화씨온도를 섭씨온도로 바꾸기
            // 우리나라는 섭씨 온도를 사용하지만, 미국에서는 화씨 온도를 사용한다.
            // 화씨 온도를 섭씨 온도로 바꾸는 프로그램을 작성
            //  EX) 화씨온도 60도는 섭씨온도 ??? 입니다.
            // 화씨온도 5/9(x − 32)


            float Ftemperature;

            Console.WriteLine($"화씨온도는 : ");
            float.TryParse(Console.ReadLine(), out Ftemperature);

            float Ctemperature = (Ftemperature - 32) * (5F / 9F);

            Console.WriteLine($"화씨온도 {Ftemperature}도는 섭씨온도{Ctemperature} 입니다.");

            //다른 방식
            // * const string desc = "섭씨온도 {0}도는 화씨온도 {1}도 입니다."
            // * float fTemp = 0.0f;
            //*console.Write("");
            //*float.TryParse(console.ReadLine(), out fTemp);
            //*float cTemp = (5.0f / 9.0f) * (fTemp - 32.0f);
            //*console.WriteLine(desc, cTemp, fTemp);






            // 주사위 게임
            // 2개의 주사위를 던져서 주사위의 합을 표시하는 프로그램 작성, 주사위를 던지면 랜덤한 수가 나와야 한다.
            // EX) 첫번째 주사위 : {0}
            //     두번쨰 주사위 : {0}
            //     두 주사위 합: {0}


            Random dice = new Random();

            int oneDice = dice.Next(1, 7); // dice.Next(100)로 하면 값이 바꿔지지 않는다.
            int twoDice = dice.Next(1, 7);

            Console.WriteLine($"첫번째 주사위 : {oneDice} ");
            Console.WriteLine($"두번째 주사위 : {twoDice} ");

            Console.WriteLine($"두 주사위 합 : {oneDice + twoDice} ");

            //다른 방법
            // *Random dice1 = new Random();
            //*Random dice2 = new Random();
            //*int dicelValue = dice1.Next(1, 6 + 1;
            //*int dice2Value = dice2.Next(1, 6 + 1);
            //*
            //*Console.WriteLine("주사위의 값 : {0}, {1}", dicelValue, dice2Value);
            //*Console.WriteLine("두 주사위 값의 합 : {0}", dicelValue + dice2Value);



            //*제어문 소개
            //* 프로그램을 이루는 3가지의 중요한 제어 구조에는 순차 구조(순차문), 선택 구조(조건문),
            // *반복 구조(반복문)가 있다.
            // *
            // *순차문
            // * 프로그램은 기본적으로 Main() 메서드 시작 시점부터 끝 지점까지 코드가 나열되면 순서대로
            // *실행 후 종료한다.
            // *
            // *제어문
            // * 프로그램 실행 순서를 제어하거나 프로그램 내용을 반복하는 작업 등을 처리할 때 사용하는 구문으로
            // *조건문과 반복문으로 구분한다.
            // *
            // *조건문(선택문)
            // * 조건의 참 또는 거짓에 따라 서로 다른 명령문을 실해할 수 있는 구조이다.분기문 또는 비교 판단문이라고
            // *하기도 한다.
            // *
            // *반복문
            // * 특정 명령문을 지지ㅓㅇ된 수만큼 반복해서 실행할 때나 조건식이 참일 동안 반복시킬 때 사용한다.




            // * if / else 문
            // * 프로그램 흐름을 여러 가지 갈래로 가지치기(Branching)할 수 있는데, 이때 if문을 사용한다.
            // * if문은 조건을 비교해서 판단하는 구문으로 if, else if, else 세가지 키워드가 있다.


            // 예제 
            // 두개의 정수 중에서 더 큰 수를 찾는 프로그램
            int numberX, numberY;

            Console.WriteLine("x 값을 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out numberX);
            Console.WriteLine("y 값을 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out numberY);

            if (numberY < numberX)
            {
                Console.WriteLine("x가 y보다 큽니다.");
            }
            else
            {
                Console.WriteLine("y가 x보다 큽니다.");
            }
            Console.WriteLine("아무 의미도 없는 출력문");

            // if()
            // else if()

            //중간 예제
            // *컵의 사이즈를 받아서 100ml 미만은 small, 100ml 이상 200ml 미만은 medium, 200ml 이상은
            // *large라고 출력하는 if-else 문을 작성



            int cupSize;

            Console.WriteLine("컵 사이즈를 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out cupSize);

            if (cupSize > 0 && cupSize < 100)  // cupSize > 0 쓰는 이유  -1 을 했을때 나올 수 없으로 나오기 위해
            {
                Console.WriteLine("small");
            }
            else if (100 <= cupSize && cupSize < 200)
            {
                Console.WriteLine("medium");
            }
            else if (cupSize >= 200)
            {
                Console.WriteLine("large");
            }
            else
            {

                Console.WriteLine("나올 수 없음");
            }

            //예제 2
            //* 비밀 코드 맞추기
            // *
            // *컴퓨더가 숨기고 있는 비밀 코드를 추측하는 게임을 작성
            // * 비밀 코드는 a~z 사이의 문자
            // *컴퓨터는 사용자의 추측을 읽고서 앞에 있는지, 뒤에 있는지를 알려준다.(즉, 사용자에게 힌트를 준다.)
            // * ex)  컴퓨터의 비밀코드: h(미리 초기화해서 변수에 가지고 있음)
            // *
            // *비밀코드를 맞춰보세요: { 0} (->User input)
            // *c 뒤에 있음.
            // *---프로그램이 종료됨-- -
            // *비밀코드를 맞춰보세요: { 0} (->User input)
            // *정답입니다.



            const char SECRET_CODE = 'h';

            bool charBiggerTest = false;

            char secetCode;

            Console.WriteLine("비밀 코드(a~z)를 입력해주세요 : ");
            char.TryParse(Console.ReadLine(), out secetCode);

            if (SECRET_CODE == secetCode)
            {
                Console.WriteLine("정답입니다.");
            }
            else if ('a' > secetCode || secetCode > 'z')  //(97 > secetCode || secetCode > 122')
            {
                Console.WriteLine("알파벳을 써주세요!");
            }
            else if (SECRET_CODE < secetCode)
            {
                Console.WriteLine($"{secetCode} 앞에 있습니다.");
            }
            else if (SECRET_CODE > secetCode)
            {
                Console.WriteLine($"{secetCode} 뒤에 있습니다.");
            }



            /* 예제 3
             * 세 개의 정수 중에서 큰 수 찾기
             * 사용자로부터 받은 3개의 정수 중에서 가장 큰 수를 찾는 프로그램 작성
             * ex)   3개의 정수를 입력하시오 : 20 10 30   (어려운 버전 string split 메서드)
             *       1번 정수를 입력하세요: 10
             *       2번 정수를 입력하세요: 20
             *       3번 정수를 입력하세요: 30             (쉬운 버전)
             *       
             *       ================================================
             *       가장 큰 정수는 : 30
             */




            /*Console.WriteLine("세 개의 정수를 입력해 주세요");
            int[] number = new int[3];
            string[] word = Console.ReadLine().Split(' ');
            for (int i = 0; i < word.Length; i++) 
            {
                int.TryParse(word[i], out number[i]);
             }
            Console.WriteLine(number.Max());
            */

            int one, two, three;

            Console.WriteLine("1번 정수를 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out one);

            Console.WriteLine("2번 정수를 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out two);

            Console.WriteLine("3번 정수를 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out three);



            
            if (one == two || two == three || one == three)
            {
                Console.WriteLine("다시 입력해 주세요");
            }
            else if (one > two && one > three)
            {
                Console.WriteLine("가장 큰 정수는 : {0}", one);
            }
            else if (two > one && two > three)
            {
                Console.WriteLine("가장 큰 정수는 : {0}", two);
            }
            else if (three > one && three > two)
            {
                Console.WriteLine("가장 큰 정수는 : {0}", three);

            }


        }  
        
    }
}
