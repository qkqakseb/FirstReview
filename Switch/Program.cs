using System;
using System.Diagnostics.Metrics;
using System.Transactions;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * 선택문인 switch 문은 값에 따라 다양한 제어를 처리할 수 있다. 조건을 처리할 내용이 많은 경우 유용하다.
             * switch, case, default 키워드로 사용하여 조건을 처리한다.
             */

            //Console.WriteLine("정수 1,2,3, 중에 하나를 입력하시요 :  ");
            //int switchNumber = 0;
            //int.TryParse(Console.ReadLine(), out switchNumber);

            //switch (switchNumber)
            //{
            //    case 1:
            //        Console.WriteLine("1을 입력했습니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("2를 입력했습니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("3을 입력했습니다.");
            //        break;
            //    default:
            //         Console.WriteLine("처리하지 않은 예외 입력입니다.");
            //          break;
            //        // switch

            //}

            /* 중간 점검
             * 1. case 절에서 break 문을 생략하면 어떻게 되는가?  실행된다.
             */

            //Console.WriteLine("가장 좋아하는 프로그래밍 언어는?");
            //Console.Write("1. c \t");
            //Console.Write("2. c++ \t");
            //Console.Write("3. c# \t");
            //Console.Write("4. java \t");

            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch (choice) 
            //{ 
            //    case 1: 
            //        Console.WriteLine("c 선택");
            //        break;
            //    case 2:
            //        Console.WriteLine("c++ 선택");
            //        break;
            //    case 3:
            //        Console.WriteLine("c# 선택");
            //        break;
            //    case 4:
            //        Console.WriteLine("java 선택");
            //        break;
            //    default:
            //        Console.WriteLine("처리하지 않은 예외 입력입니다.");
            //        break;
            //} // switch

            //Console.WriteLine("오늘의 날씨는 어떤가요? (맑음, 흐림, 비, 눈, ...)");
            //string weather = Console.ReadLine();

            //switch (weather)
            //{
            //    case "맑음":
            //        Console.WriteLine("오늘 날씨는 맑군요");
            //        break;
            //    case "흐림":
            //        Console.WriteLine("오늘 날씨는 흐리군요");
            //        break;
            //    case "비":
            //        Console.WriteLine("오늘 날씨는 비가 오는군요");
            //        break;
            //    case "눈":
            //        Console.WriteLine("오늘 날씨는 눈이 오는군요");
            //        break;
            //}

            // while 문은 조건식이 참일 동안 문장을 반복 실행한다.

            //while 문은 반복문인데 5번 실행할 예정
            //int loopCounter = 0;
            //while (loopCounter < 5)
            //{
            //    Console.WriteLine("{0} 반복문이 정말로 5번만 실행되나?", loopCounter +1);
            //    loopCounter++;
            //}     // loop : 5번만 도는 루프

            ////10 ~1 카운트 후 발사 출력하는 프로그램 작성
            //loopCounter = 10;
            //while(loopCounter > 0)
            //{
            //    Console.WriteLine("{0} ", loopCounter);
            //    loopCounter -= 1;
            //}
            //Console.WriteLine("발사");

            // 예제1 - 구구단 출력하는 프로그램 작성. user input 받아서 해당 단을 출력
            //int userGugudan = 0;
            //Console.WriteLine("구구단 중에서 출력하고 싶은 단 입력: ");
            //int.TryParse(Console.ReadLine(), out userGugudan);

            //const int GUGU_LOOP_COUNT = 9;
            //int guguLoopIdx = 1;
            //while (guguLoopIdx <= GUGU_LOOP_COUNT) 
            //{
            //    Console.WriteLine("{0}*{1}={2}", userGugudan, guguLoopIdx, userGugudan * guguLoopIdx);
            //    guguLoopIdx++;    
            //}   // loop: 9번 도는 루프 



            /* 문제1 (while문 연습)
             * 프로그램 사용자로부터 양의 정수를 하나 입력 받아서, 그 수만큼 "Hello world"를 출력하는 프로그램 작성
             * ex) User input -> 3
             *     "Hello word"
             *     "Hello word"
             *     "Hello word"
             */

            //int essence = 0;

            //Console.WriteLine("정수를 하나 입력하세요: ");
            //int.TryParse(Console.ReadLine(), out essence);

            //int count = 0;

            //while (essence <= 0)
            //{

            //        Console.WriteLine("양의 정수를 입력해주세요 : ");
            //        int.TryParse(Console.ReadLine(), out essence);

            //}

            //while (count < essence)
            //{
            //    Console.WriteLine($"Hello world");
            //    count++;

            //}

            /* 문제 2
             * 프로그램 사용자로부터 양의 정수를 하나 입력 받은 다음, 그 수만큼 3의 배수를 출력하는 프로그램 작성
             * ex) User input -> 5
             *     "3, 6, 9, 12, 15"
             */
            //int essence1 = 0;

            //Console.WriteLine("양의 정수를 하나 입력하세요 : ");
            //int.TryParse(Console.ReadLine(), out essence1);


            //int count1 = 0;

            //while (essence1 <= 0)
            //{

            //    Console.WriteLine("양의 정수를 입력해주세요 : ");
            //    int.TryParse(Console.ReadLine(), out essence1);

            //}

            //while (count1 < essence1)
            //{
            //    count1++;
            //    Console.WriteLine($"3의 배수: {count1 * 3}");

            //}


            /* 문제 3
             * 프로그램 사용자로부터 계속해서 정수를 입력 받는다. 그리고 그 값을 계속해서 더해 나간다. 이러한 작업은
             * 프로그램 사용자가 0을 입력할 때까지 계속되어야 하며 0이 입력되면 입력된 모든 정수의 합을 출력하고 프로그램 종료
             * ex) User input -> 1
             *     User input -> 10
             *     User input -> 0
             *     "모든 정수의 합: 11"
             */

            //int essence3 = -1;
            //int sum = 0;

            //while (essence3 != 0)
            //{
            //    Console.WriteLine("정수를 입력해주세요 : ");
            //    int.TryParse(Console.ReadLine(), out essence3);

            //    sum += essence3; 

            //}
            //Console.WriteLine($"정수의 합 : {sum}");
            //Console.WriteLine("종료");


            /* 문제 4
             * 프로그램 사용자로부터 입력 받은 숫자에 해당하는 구구단을 출력하되, 역순으로 출력하는 프로그램을 작성
             * ex) User input -> 2
             *     "18, 36, 14, 12, 10, 8, 6, 4 ,2"
             */

            //int userGugudan = 0;
            //Console.WriteLine("구구단 중에서 출력하고 싶은 단 입력: ");
            //int.TryParse(Console.ReadLine(), out userGugudan);

            //const int GUGU_LOOP_COUNT = 1;
            //int guguLoopIdx = 9;

            //while (guguLoopIdx >= GUGU_LOOP_COUNT)
            //{
            //    Console.WriteLine($" \n {userGugudan * guguLoopIdx}");
            //    guguLoopIdx--;
            //}



            /* 문제 5
             * 프로그램 사용자로부터 입력 받은 정수에 평균을 출력하는 프로그램을 작성하되, 다음 두 가지의 조건을 만족할 것.
             * 조건: 먼저 몇 개의 정수를 입력할 것인지 프로그램 사용자에게 묻는다. 그리고 그 수만큼 정수를 입력 받는다.
             *       평균 값은 소수점 이하까지 계산해서 출력한다.
             * ex) User input -> 3  (loop count)정수
             *     User input -> 10
             *     User input -> 10
             *     User input -> 10
             *     "평균 값: 10.0"
             */

            //int essence4 = 0;
            //int loopCount = 0;
            //int count2 = 0;
            //double average = 0;
            //int sum1 = 0;


            //Console.WriteLine("몇개의 정수를 입력할 것인가요? : ");
            //int.TryParse(Console.ReadLine(), out loopCount);

            //count2 = loopCount;

            //while (loopCount > 0)
            //{
            //    Console.WriteLine("정수를 입력해주세요 : ");
            //    int.TryParse(Console.ReadLine(), out essence4);
            //    loopCount--;

            //    sum1 += essence4;


            //}
            //average = (double)sum1 / count2;

            //Console.WriteLine($"정수의 평균 : {average}");



            // 두 실수(float)를 입력받아서 값이 같은지 다른지 출력하는 프로그램 작성(Equals)등 사용 x)


            //float ffloat = 0;
            //float sfloat = 0;

            //Console.WriteLine("첫번째 실수를 입력해주세요");
            //float.TryParse(Console.ReadLine(), out ffloat) ;

            //Console.WriteLine("두번째 실수를 입력해주세요");
            //float.TryParse(Console.ReadLine(), out sfloat);

            //if (ffloat == sfloat)
            //{
            //    Console.WriteLine("같다.");
            //}
            //else 
            //{
            //    Console.WriteLine("다르다");
            //}



            /*
             * for 문은 일정한 횟수만큼 반복할 때 유용하다.
             * 초기식을 실행한 후에 조건식이 참인 동안, 문장을 반복한다. 한번 반복이 끝날 때마다 증감식이
             * 실행된다.
             */

            // 1~10 까지 정수의 합
            //int sumNumber = 0;
            ////                   5번          7번
            ////        1번        2번          4번
            //for (int index = 1; index <= 10; index++)
            //{
            //    // 3번, 6번
            //    sumNumber += index;
            //}
            //Console.WriteLine($"1부터 10까지의 정수의 합 = {sumNumber}");


            //문제
            // 1~100 숫자 중에서 3의 배수를 제외한 수의 합 구하기

            //int sumnumber1 = 0;
            //for (int index = 1; index <= 100; index++)
            //{

            //    if (index % 3 != 0)
            //    {
            //        sumnumber1 += index;
            //    }
            //}
            //Console.WriteLine($"숫자의 합 = {sumnumber1}");

            /* 
             * Break 문
             * breat 문은 반복 루프를 벗어나기 위해서 사용한다. break 문이 실행되면 반복 루프는 즉시 중단되고
             * 반복 루프 다음에 있는 문장이 실행한다.
             * 
             * continue 문
             * continue 문은 현재 수행하고 있는 반복 과정의 나머지를 건너뛰고 다음 반복 과정을 강제적으로
             * 시작하게 만든다. 반복 루프에서 continue 문은 만나게 되면 continue 문 다음에 있는 후속 코드들은
             * 실행되지 않고 건너뛰게 된다.
             */

            // 1~100 숫자 중에서 3의 배수를 제외한 수의 합 구하기
            //int sumnumber1 = 0;
            //for (int index = 1; index <= 100; index++)
            //{

            //    if (index % 3 == 0) {continue}
            //    else
            //    {
            //        sumnumber1 += index;
            //    }
            //}
            //Console.writeline($"숫자의 합 = {sumnumber1}");

            //for (int index = 1; index <= 10; index++) 
            //{
            //    if (index == 4) { break; }
            //    Console.WriteLine($"현재 인덱스 : {index}");
            //}


            /* 문제
             * 자음과 모음 개수 세기
             * 사용자로부터 영문자를 받아서 자음과 모음의 개수를 세는 프로그램을 작성
             * (대, 소문자 모두 카운트) // 대문자 짜기
             * ex)  a
             *      b
             *      c
             *      d
             *      e
             *      #
             *      모음: 2
             *      자음: 3
            */

            //char english = ' ';
            //int consonant = 0;
            //int gather = 0;

            //while (english != '#')
            //{
            //    Console.WriteLine("영문자를 입력해주세요 : ");
            //    char.TryParse(Console.ReadLine(), out english);


            //    if (english == '#')
            //    {
            //        Console.WriteLine(" \n 종료");
            //    }
            //    else if (english == 'a' || english == 'e' || english == 'i' || english == 'o' || english == 'u')
            //    {
            //        gather++;
            //    }
            //    else
            //    {
            //        consonant++;
            //    }
            //}
            //Console.WriteLine($"모음 개수 : {gather}");
            //Console.WriteLine($"자음 개수 : {consonant}");







            /* 문제
             * 숫자 맞추기 게임
             * 숫자 알아맞히기 게임이다. 프로그램은 1~100 사이의 정수를 저장하고 있음. 사용자는 질문을 통해서
             * 숫자를 알아 맞힌다. 사용자가 답을 제시하면 프로그램은 제시된 정수가 더 낮은 값인지, 높은 값인지
             * 알려준다. 사용자가 알아맞힐 때까지 루프한다.(기본형)
             * 
             * - 프로그램을 수정하여 컴퓨가 생성한 숫자를 사용자가 추측하는 대신에, 사용자가 결정한 번호를 
             *   컴퓨터가 추측하도록 수정한다. 사용자는 컴퓨터가 추측한 숫자가 높거나 낮은지를
             *   컴퓨터에 알려야 한다. 컴퓨터가 맞힐 때까지 반복 (어려운것 1)
             *   
             *   사용자가 결정한 값의 범위는 (1~100) 어떤 숫자를 생각하던 간에 7번 이하의 추측으로 컴퓨터가 맞을 수
             *   있도록 어려운거 1을 수정하시오
             */

            //const int PROGRAM = 50;
            //int number = 0;

            //Console.WriteLine("숫자을 입력하세요 : ");
            //int.TryParse(Console.ReadLine(), out number);

            //while ( number != PROGRAM )
            //{

            //    if (number > PROGRAM)
            //    {
            //        Console.WriteLine("더 크다");
            //    }
            //    else
            //    {
            //        Console.WriteLine("더 작다.");
            //    }

            //    Console.WriteLine("숫자을 입력하세요 : ");
            //    int.TryParse(Console.ReadLine(), out number);


            //}
            //Console.WriteLine("정답입니다.");


            /* 산수 문제 자동 출제
             * 산수 문제를 자동으로 출제하는 프로그램을 작성해보자. 덧셈 문제들을 자동으로 생성하여야 한다.
             * 피연산자는 0~99 사이의 숫자(난수: 랜덤) 한 번이라도 맞으면 종료, 틀리면 리트라이(기본형)
             * 
             * 추가문제
             * 뺄셈, 곱셈, 나눗셈 문제도 출제
             * -> 나눗셈 예외처리(무한대 값 주의)
             */

            //int fpuls = 0;
            //int spuls = 0;


            //Console.WriteLine($"덧셈 문제 {fpuls + spuls}");



            /*
             * foreach 문은 배열(Array)이나 컬렉션(Collection) 같은 값을 여러 개 담고 있는 데이터 구조에서
             * 각각의 데이터가 들어 있는 만큼 반복하는 반복문이다. 데이터 개수나 반복 조건을 처리할 필요가 없다.
             */

            // string 에서 글자를 하나씩 출력
            //string stringText = "Hello world!";

            //int loopCount = 0;  
            //foreach (char oneCharactor in stringText) //텍스트 길이 만큼 캐릭쳐 안에 표시
            //{
            //    Console.Write($"{oneCharactor}");
            //    loopCount++;
            //    // loop : stringText의 길이만큼 도는 루프
            //}
            //Console.WriteLine();    
            //Console.WriteLine($"Loop count : {loopCount}, stringText's length : {stringText.Length}");


            // 1~100 숫자 중에서 3의 배수이면서 4의 배수인 정수 합 구하기

            int sumnumber1 = 0;

            for (int index = 1; index <= 100; index++)
            {

                if (index % 3 == 0 || index % 4 == 0)
                {
                    sumnumber1 += index;
                }
            }
            Console.WriteLine($"3이면서 4의 배수 숫자의 합 = {sumnumber1}");



            /* 두 개의 정수를 입력 받아서 두 수의 차를 출력하는 프로그램 작성
             * - 항상 큰 수에서 작은 수를 뺀 결과를 출력할 것.
             * - 결과는 언제나 0 이상이어야 함
            */

            int essence1 = 0;
            int essence2 = 0;
       

            Console.WriteLine("정수1을 입력해주세요 : ");
            int.TryParse(Console.ReadLine(), out essence1);

            Console.WriteLine("정수2를 입력해주세요 : ");
            int.TryParse(Console.ReadLine(), out essence2);

            if (essence1 < 0 && essence2 < 0)
            {
                Console.WriteLine("");
            }

            int subtraction = essence1 - essence2;

            Console.WriteLine($"두 수의 차 : {subtraction}");



            /*구구단을 출력하되 짝수(2단, 4단, 6단, 8단)만 출력되도록 하는 프로그램을 작성
             * - 2단은 2x2 까지만, 4단은 4x4까지만...,8단은 8x8까지만 출력한다.
             * - break 와 continue를 사용할 것
             */

            /*다음 식을 만족하는 모든 A와 Z를 구하는 프로그램을 작성
             * -       A Z
             *         Z A
             *     ---------
             *         9 9
             */
        }    // Main()
    }
}