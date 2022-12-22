using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;
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
            //int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            //int number1 = 1;
            //int number2 = 2;
            //int number3 = 3;
            //int number4 = 4;
            //int number5 = 5;

            //Console.WriteLine(numbers);

            //for (int index = 0; index < numbers.Length; index++)
            //{
            //    Console.WriteLine($"{ numbers[index]}");
            //}
            //foreach (int element in numbers)
            //{
            //    Console.WriteLine($"{element}");
            //}

            //int number = 1_0821;
            //Console.WriteLine($"64로 Mod 연산: {number % 64}");

            ///*
            // * 다차원 배열
            // * 2차원 배열, 3차원 배열처럼 차원이 2개 이상인 배열을 다차원 배열이라고 한다.
            // * c#에서 배열을 선언할 때는 콤마를 기준으로 차원을 구분한다.
            // */
            //int[] oneArray = new int[2] { 1, 2 };
            //int[,] twoArray = new int[2, 3] { { 1, 2, 3 } , { 3 , 4, 5 } }; // [a,b] : a는 {} 수, b는{} 들어가는 수
            //int[,,] threeArray = new int[2, 2, 2]
            //{
            //    { { 1 , 2}, { 3 , 4} },
            //    { { 1 , 2}, { 3 , 4} }
            //};

            // 3행 3열짜리 배열에서 행과 열이 같으면 1, 다르면 0을 출력
            //twoArray = new int[3, 3];

            //for (int y = 0; y < 3; y++)
            //{
            //    for (int x = 0; x < 3; x++)
            //    {
            //        if (x == y) { twoArray[y, x] = 1; }
            //        else { twoArray[y, x] = 0; }
            //    }
            //} // loop: 값을 대입하는 루프

            //for (int y = 0; y <= twoArray.GetUpperBound(0); y++)
            //{
            //    for (int x = 0; x <= twoArray.GetUpperBound(1); x++)
            //    {
            //        Console.WriteLine($"{twoArray[y, x]}");
            //    }
            //    Console.WriteLine();
            //} // loop: 값을 대입하는 루프

            /*
             * 가변 배열
             * 차원이 2개 이상이 배열은 다차원 배열이고, 배열 길이가 가변 길이인 배열은 가변 배열이라고 한다.
             */

            //int[][] zagArray = new int[2][];
            //zagArray[0] = new int[2] { 1, 2 };
            //zagArray[1] = new int[3] { 3, 4, 5 };

            //for (int y = 0; y < 2; y++)
            //{
            //    for (int x = 0; x < zagArray[y].Length; x++)
            //    {
            //        Console.WriteLine($"{zagArray[y][x]}");
            //    }
            //    Console.WriteLine();
            //}

            //int[] intArray;           // int 형 데이터 타입의 intArray 라는 배열을 선언
            //intArray = new int[3];    // int 형 데이터 타입의 변수를 3개 메모리에 할당

            //intArray[0] = 1;         // intArray 0번째 인텍스에 1이라는 정수값을 대입
            //intArray[1] = 2;         // intArray 0번째 인텍스에 2이라는 정수값을 대입
            //intArray[2] = 3;         // intArray 0번째 인텍스에 3이라는 정수값을 대입

            ////배열 직접 출력해본다.
            //for (int index = 0; index < 3; index++)
            //{
            //    Console.WriteLine($"{index} 번째 인덱스의 값 - > {intArray[index]}");
            //}   // loop: 3번 도는 루프
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////intArray 배열에서 int 형 데어터 타입의 값을 하나씩 뽑아서 index에 저장 할거다.
            //foreach (int index in intArray)
            //{
            //    Console.WriteLine($"intArray 베열에서 뽑아온 값 - > {index}");
            //}   //loop: intArray 배열의 길이만큼 도는 루프


            /* 문제
             * 배열을 사용하여 국어 점수의 총점과 평균 구하기
             * 학생 3명의 점수를 저장하는 배열 선언해서, 각 학생별로 점수를 할당하고 (범위는 1~100점)
             * 모든 점수의 총점과 평균을 구해서 출력하는 프로그램(기본형)
             *    - User input 받아서 프로그램 작성 해볼것 (번형)
             *    - 유저 인풋은 3회(3명의 학생이니까)
             *    - 점수 범위 (범위는 1~100 점)
             *    - 이상한 입력 예외처리
             */

            //int[] Student;
            //Student = new int[3];

            //Student[0] = 0;
            //Student[1] = 0;
            //Student[2] = 0;

            //int sum = 0;
            //float everage = 0;


            //for (int index = 0; index < 3; index++)
            //{
            //    sum += Student[index];

            //}
            //Console.WriteLine($"국어 점수 총점 : {sum}");

            //everage = (float)sum / 3;

            //Console.WriteLine($"국어 점수 평균 : {everage}");




            // 변형
            //Console.Write("첫번째 학생의 국어 점수를 입력해주세요 : ");
            //int.TryParse(Console.ReadLine(), out Student[0]);

            //while (Student[0] == 0 || Student[0] > 100)
            //{
            //    Console.Write("첫번째 학생의 국어 점수를 입력해주세요 : ");
            //    int.TryParse(Console.ReadLine(), out Student[0]);
            //}


            //Console.Write("두번째 학생의 국어 점수를 입력해주세요 : ");
            //int.TryParse(Console.ReadLine(), out Student[1]);

            //while (Student[1] == 0 || Student[1] > 100)
            //{
            //    Console.Write("두번째 학생의 국어 점수를 입력해주세요 : ");
            //    int.TryParse(Console.ReadLine(), out Student[1]);
            //}

            //Console.Write("세번째 학생의 국어 점수를 입력해주세요 : ");
            //int.TryParse(Console.ReadLine(), out Student[2]);

            //while (Student[2] == 0 || Student[2] > 100)
            //{
            //    Console.Write("세번째 학생의 국어 점수를 입력해주세요 : ");
            //    int.TryParse(Console.ReadLine(), out Student[2]);
            //}


            //for (int index = 0; index < 3; index++)
            //{
            //    sum += Student[index];

            //}
            //Console.WriteLine($"국어 점수 총점 : {sum}");

            //everage = (float)sum / 3;

            //Console.WriteLine($"국어 점수 평균 : {everage}");



            /* LAB 1 배열에서 최대값 찾기
             * 크기가 100인 배열을 1부터 100 사이의 난수로 채우고 배열 요소 중에서 최대값을 찾는 프로그램 작성
             *   
             */

            int[] array;                                      // int[]의 이름을 array라고 선언하였다.
            array = new int[100];                             // 크기가 100인 배열을 선언하였다.

            Random random = new Random();                    // 랜덤을 쓰기 위해 선언해준다.
            array[0] = random.Next(1, 101);                  // 1~100사이 숫자를 랜덤으로 나타내서 배열에 대입해 준다.

            int max = 0;                                    // 최댓값을 선언해준다.

            for (int index = 0; index < 100; index++)       // []안에 0부터 100번까지 1씩 증가하면서 반복한다.
            {
                array[index] = random.Next(1, 101);         // 랜덤으로 나온 숫자를 array[index]에 대입한다.

                if (max < array[index])                    // 만약 max가 랜덤으로 나온 숫자보다 작으면
                {
                    max = array[index];                    //  랜덤으로 나온 숫자를 max에 대입한다.
                }
            }       // loop: 랜덤 값 넣고 max 찾는 루프

            //for (int i = 0; i < 10; i++)                   
            //{
            //    Console.WriteLine($"{array[i]}");
            //}
            Console.WriteLine($"최댓값 : {max}");          // 최댓값 max를 출력한다.








            /* LAB 2 사과를 제일 좋아하는 사람찾기
             * 사람들 5명(사람1, 사람2,....사과5)에게 아침에 먹는 사과 개수를 입력하도록 요청하는 프로그램 작성
             * 데이터 입력이 마무리 되면 누가 가장 많은 사과를 아침으로 먹었는지 출력한다.(기본형)
             *   - 이상한 입력 예외처리
             *   - 제일 적게 먹은 사람도 찾도록 수정해보기 (변형 1)
             *   - 먹은 사과의 개수 순으로 정렬. 정렬 알고리즘은 본인 사용한 것으로 하되
             *         - 알고리즘을 잘 모르겠다면 버블 정렬을 도전 해볼 것.(변형 2)   
             *         - 알고리즘을 잘 알겠다면 Merge sort 도전 해볼 것 (어려운 버전)
             *              - 정렬 도전 시 유저 입력 x
             *              - 데어터는 난수로 100 ~1000개 정도의 값
             *              - 중복 제거
             *              - 시간초는 전혀 상관 없음
             */

            // (기본형)

            int[] apple;                               // int[]의 이름을 apple 이라고 선언해준다.
            apple = new int[5];                        // apple에 크기가 5인 배열을 대입한다.


            int max = 0;                              // max를 최대값으로 지정해주고 선언하였다.
            int eatPeopleNumber = 0;                  // 먹은 사람 번호를 지정해 주기 위해 선언하였다.


            apple[0] = 0;                            // 먹은 사과 갯수  0번째의 번호를 매겼다. (0이라는 배열을 선언)
            apple[1] = 0;                            // 먹은 사과 갯수  1번째의 번호를 매겼다. (1이라는 배열을 선언)
            apple[2] = 0;                           // 먹은 사과 갯수  2번째의 번호를 매겼다.  (2이라는 배열을 선언)
            apple[3] = 0;                           // 먹은 사과 갯수  3번째의 번호를 매겼다.  (3이라는 배열을 선언)
            apple[4] = 0;                           // 먹은 사과 갯수  4번째의 번호를 매겼다.  (4이라는 배열을 선언)


            Console.WriteLine("사람1 이(가) 아침에 먹은 사과 개수 : ");     // 사람1이 먹은 사과 개수를 유저가 입력한 값을 출력하게 한다.
            int.TryParse(Console.ReadLine(), out apple[0]);                 // 유저가 입력한 값이 정수로 변환했는지 확인다.

            Console.WriteLine("사람2 이(가) 아침에 먹은 사과 개수 : ");     // 사람2이 먹은 사과 개수를 유저가 입력한 값을 출력하게 한다.
            int.TryParse(Console.ReadLine(), out apple[1]);                 // 유저가 입력한 값이 정수로 변환했는지 확인다.

            Console.WriteLine("사람3 이(가) 아침에 먹은 사과 개수 : ");    // 사람3이 먹은 사과 개수를 유저가 입력한 값을 출력하게 한다.
            int.TryParse(Console.ReadLine(), out apple[2]);                // 유저가 입력한 값이 정수로 변환했는지 확인다.

            Console.WriteLine("사람4 이(가) 아침에 먹은 사과 개수 : ");    // 사람4이 먹은 사과 개수를 유저가 입력한 값을 출력하게 한다.
            int.TryParse(Console.ReadLine(), out apple[3]);                // 유저가 입력한 값이 정수로 변환했는지 확인다.

            Console.WriteLine("사람5 이(가) 아침에 먹은 사과 개수 : ");   // 사람5이 먹은 사과 개수를 유저가 입력한 값을 출력하게 한다.
            int.TryParse(Console.ReadLine(), out apple[4]);               // 유저가 입력한 값이 정수로 변환했는지 확인다.


            for (int i = 0; i < 5; i++)                                   // int i가 0부터 5까지 1씩 증가하면
            {
                if ( max < apple[i])                                      // apple[i] 값이 max보다 큰면
                {
                    max = apple[i];                                       // max에 값을 넣는다.
                    
                }                                                        // 유저가 입력한 값 중 가장 큰 값을 찾기 위한 반복문이다.

                if ( max == apple[i])                                    // 만약 apple[i]의 값이 max와 같다면
                {
                    eatPeopleNumber = i + 1;                             // i가 1씩 더한 값을 eatPeopleNumber에 대입한다. 
                }                                                        // 제일 많이 먹은 사람을 번호로 나타내어 출력하기 위함이다.


                
            }
            Console.WriteLine($"제일 많이 먹은 사람은  사람{eatPeopleNumber} 이다.");    // 유저가 입력한 값 중 가장 큰 값을 찾아 제일 많이 먹은 사람의 번호를 출력하는 출력문을 썼다.


        }//Main
    } // Class
}
