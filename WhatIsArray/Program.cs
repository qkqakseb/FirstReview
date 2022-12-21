// System 이라는 어셈블리에서 이것 저것 여러 기능을 가져와서 사용 할 거다.
using System;

//네 프로그램 이름이다. 내가 결정함
namespace WhatIsArray
{   
    // 클래스 라는 것인데, c#에서는 모든 요소들이 클래스 안에 있어야 함
    internal class Program
    {
        // 무조건 1개는 있어야 함 -> c# 콘솔(검은 창)을 사용할 때
        static void Main(string[] args)
        {
            //// 프로그램은 여기서부터 읽기 시작한다. 
            //Console.WriteLine("Hello, World!");

            //// 3의 배수를 제외한 수
            //int sumofNumber = 0;
            ////int variable_ = 100;

            //for (int variable_ = 1; variable_ <= 100; variable_++)
            //{
            //    bool isRealMultipleofThree = (variable_ % 3 == 0);
            //    Console.WriteLine($" {variable_} -> isRealMultipleofThree : {isRealMultipleofThree}");


            //    //1~100 숫자 중에서 3의 배수를 제외한 수의 합 구하기
            //    if (isRealMultipleofThree == false)
            //    {
            //        // 3의 배수가 아닌건 다 여기로 온다
            //        // 여기서 값을 계속 더해주면 된다.
            //        sumofNumber += variable_;
            //        Console.WriteLine($"잘 더해지고 있나? : {sumofNumber}");
            //    }
            //    else
            //    {
            //        // 여기로 온다.
            //        // 그러면 여기서 코딩
            //    }

            //    Console.WriteLine();
            //}   // loop: 100번 도는 루프
            //// 루프가 끝나면 여기로 오니까 다 끝날 때까지는 더해서 마지막 값을 눈으로
            //// 보고싶다
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("=================================");
            //Console.WriteLine($"sumofNumber : {sumofNumber}");
            //Console.WriteLine("=================================");



            ////if (/* 여기서 조건문 검사함*/)
            ////{
            ////    // 저 조건문이 참(True)이면 여기로 옴
            ////    // 조건문은 여기서부터 읽기 시작한다.
            ////    // 조건문은 여기서 끝난다.
            ////}
            ////else 
            ////{
            ////    // 저 조건문이 거짓(False)이면 여기로 옴
            ////    // 조건문은 여기서부터 읽기 시작한다.
            ////    // 조건문은 여기서 끝난다.
            ////}
            ////// 조건문을 실행했으면 이제 다시 여기서부터 프로그램 시작한다.
            ////// 프로그램은 여기서 끝난다.



            //string personalGender = "여자";

            //if (personalGender.Equals("남자"))
            //{
            //    // 조건문 A가 참(True)이면 여기로 옴
            //    // 조건문 A가 여기서부터 읽기 시작한다.
            //    Console.WriteLine("남자구나 ok");
            //    // 조건문 A가 여기서 끝난다.
            //}
            //else if (personalGender == "여자")
            //{
            //    // 조건문 B가 참(True)이면 여기로 옴
            //    // 조건문 B가 여기서부터 읽기 시작한다.
            //    Console.WriteLine("여자 구나");
            //    // 조건문 B가 여기서 끝난다.
            //}
            //else
            //{
            //    // 저 조건문이 거짓(False)이면 여기로 옴
            //    // 조건문은 여기서부터 읽기 시작한다.
            //    Console.WriteLine("남자도 여자도 아니구나");
            //    // 조건문은 여기서 끝난다.
            //}

            //for (int index = 1; index <= 50; index++)
            //{
            //    Console.WriteLine();
            //}
            //Console.WriteLine("정말로 콘솔이 정리가되었나?");

            ////프로그램 사용자로부터 양의 정수를 하나 입력 받아서,
            //// 그 수만큼 "Hello world"를 출력하는 프로그램 작성
            //int someNumber = 100;  //어떤 숫자
            //bool isPositiveInteger = (0 < someNumber);

            ///*
            // * 프로그램 사용자로부터 계속해서 정수를 입력 받는다.
            // * 그리고 그 값을 계속해서 더해 나간다. 이러한 작업은
            // * 프로그램 사용가 0을 입력할 때까지 계속되어야 하며,
            // * 0이 입력되면 입력된 모든 정수의 합을 출력하고 프로그램 종료.
            // */
            //bool isNumberZero = (someNumber == 0);

            ////프로그램 사용자로부터 입력 받은 숫자에 해당하는 구구단을 출력하되,
            //// 역순으로 출력하는 프로그램을 작성
            //int userInputNumber = 3;
            //for (int index = 9; 1 <= index; index--)
            //{
            //    Console.WriteLine($"{userInputNumber} + {index} = {userInputNumber * index}");
            //}  // loop : 9번을 도는 루프


            ///*
            // * 프로그램 사용자로부터 입력 받은 정수의 평균을 출력하는 프로그램을 작성하되,
            // * 다음 두 가지의 조건을 만족할 것
            // * - 먼저 몇 개의 정수를 입력할 것인지  프로그램 사용자에게 묻는다.
            // * 그리고 그 수만큼 정수를 입력 받는다.
            // * - 평균 값은 소수점 이하까지 계산해서 출력한다.
            // */

            ///* LAD 1 비밀 코드 맞추기
            // * 컴퓨터가 숨기고 있는 비밀 코드를 추측하는 게임을 작성
            // * 비밀 코드는 a~z 사이의 문자
            // * 컴퓨터는 사용자의 추측을 읽고서 앞에 있는지, 뒤에 있는지를 알려준다.
            // * (즉, 사용자에게 힌트를 준다.)
            // */
            //char scretCode = 'y';
            //char userInputAlphabet = 'c';  // 유저가_입력한_알파벳
            //bool isSmallAlphabet = ('a' <= userInputAlphabet && userInputAlphabet <= 'z');

            //bool isAlphabetFore = (userInputAlphabet <= scretCode);
            //bool isAlphabetBack = (scretCode <= userInputAlphabet);

            //if (isSmallAlphabet) {/* Do nothing */ }
            //else
            //{
            //    Console.WriteLine("{0} {1}", "[System] 당신의 입력은 처리할 수 없습니다.", "알파벳 소문자만을 입력해주세요.");
            //}
            //if (isAlphabetFore)
            //{
            //    Console.WriteLine("당신의 알파벳은 시크릿 코드보다 앞에 있습니다.");
            //}
            //else {/* Do nothing */ }

            //if (isAlphabetBack)
            //{
            //    Console.WriteLine("당신의 알파벳은 시크릿 코드보다 뒤에 있습니다.");
            //}
            //else { /* Do nothing */}

            //// 1~100 숫자 중에서 3의 배수이면서 4의 배수인 정수 합 구하기
            //int sumNumber = 0;
            //int someNumber = 100; // 어떤 수
            //bool isMultipleofThree = (someNumber % 3 == 0);
            //bool isMultipleofFour = (someNumber % 4 == 0);

            //bool isSatisfyCondition = isMultipleofThree && isMultipleofFour;

            //if (isSatisfyCondition)
            //{
            //    sumNumber += someNumber;
            //}     // if: 3의 배수이며서 4의 배수인 값

            //// 별을 100번 찍는 법 1번
            //Console.WriteLine("{0} {1} {2} {3} {4}",
            //    "**********", "**********", "**********", "**********");
            //Console.WriteLine("{0} {1} {2} {3} {4}",
            //    "**********", "**********", "**********", "**********");


            //// 2번
            //for (int index = 1; index <= 100; index++)
            //{
            //    Console.WriteLine("{0}", "*");
            //}



            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////3번
            //for (int index = 1; index <= 10; index++)
            //{
            //    for (int index2 = 1; index2 <= 10; index2++)
            //    {
            //        Console.WriteLine("{0}", "*");
            //    }  // loop: 이건 밖의 루프가 1번 도는 동안 10번을 도는 루프
            //    Console.WriteLine();
            //}    // loop: 이건 10번 도는 루프





            //// 3중 for 문 쓰기
            //int humdredCount = 0;
            //for (int index = 1; index <= 10; index++)
            //{
            //    for (int index2 = 1; index2 <= 10; index2++)
            //    {
            //        for (int index3 = 1; index3 <= 10; index3++)
            //        {
            //            humdredCount++;
            //            if (100 < humdredCount) { break; }
            //            else {/* Do nothing */ }

            //            //여기가 별을 찍는 지점
            //            Console.WriteLine(" {0}", "*");

            //            //여기서 10번마다 한 줄을 띄어 줄거임
            //            if (humdredCount % 10 == 0)
            //            {
            //                Console.WriteLine();
            //            } //if: 별을 10번 찍을 때마다 한 줄 띄어주는 중

            //        }  // loop: 이건 1번 루프가 10번 도는 동안 2번 루프가 10번 돌고
            //        // 그 동안 다시 10번을 도는 루프
            //    }    // loop: 이건 밖의 루프가 1번 도는 동안 10번을 도는 루프
            //}       // loop : 이건 10번을 도는 루프
            //// 프로그램은 여기서 끝난다.





            /* 문제 (마름모 모양도 만들어 보기)
             * 유저 입력 받아서 (1~20 줄 이내로 입력 받음) 유저 입력은 줄, 단의 개수 임.
             * 등차 수열로 한 단이 내려갈 때마다 별 1개씩 추가로 증가하는 프로그램 작성
             * ex) user input: 5
             *     *
             *     **
             *     ***
             *     ****
             *     *****
             */

            //int userInput = 0;

            //Console.WriteLine(" 줄,단을 입력해주세요 : ");
            //int.TryParse(Console.ReadLine(), out userInput);

            //Console.WriteLine();

            //for (int index1 = 1; index1 <= userInput; index1++)
            //{
            //    for (int index2 = 1; index2 <= index1; index2++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //다이아몬드 (미완성)
            int userInput = 0;

            Console.WriteLine(" 줄,단을 입력해주세요 : ");
            int.TryParse(Console.ReadLine(), out userInput);

            Console.WriteLine();

            for (int index1 = 1; index1 <= userInput; index1++)
            {
                for (int index2 = 1; index2 <= (index1 *2); index2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int index1 = 1; index1 >= userInput; index1--)
            {
                for (int index2 = 1; index2 <= ((index1-1)*2); index2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }







        }
    }
}