using System;
using System.Collections.Concurrent;
using System.IO;

namespace WhatIsOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Convert.Toint32  -> 8로 나누면 4byte이므로 32를 썼다.

            string stringBinary = Convert.ToString(10,2); // 10진수 -> 2진수
            Console.WriteLine(stringBinary);
            int intBinary = Convert.ToInt32("0111", 2);  // 7 
            Console.WriteLine(intBinary);

            /*
             * 연산자
             * 데이터로 연산 작업을 수행할 떄는 연산자(Operator)를 사용한다. 연산자는 기능에 따라 대입, 산술,
             * 관계, 논리, 증감, 조건, 비트, 시프트 연산자 등으로 나누며, 이용 형태에 따라 항 1개로 연산을 하는
             * 단항(Unary) 연산자와 항 2개로 연산을 하는 이행(Sinary) 연산자, 항 3개로 연산을 하는 삼행(Ternary)
             * 연산자로 나눈다.
             * 
             * 단항 연산자
             * 단항 연산자는 연산자와 피연산자 하나로 식을 처리한다.
             * ex) [연산자] [피연산자]
             * + 연산자: 특정 정수형 변수 값을 그대로 출력한다.
             * - 연산자: 특정 정수형 변수 값을 음수로 변경하여 출력한다. 음수 값이 들어 있다면 양수로 변환해서
             *           반환한다.
             * 
             * 이항 연산자
             * 이항 연산자는 연산자와 피연산자 2개로 식을 처리한다.
             * ex) [피연산자1] [연산자] [피연산자2]
             * 
             * 삼항 연산자
             * 삼항 연산자는 식 1개의 항(Expression)과 그 결과에 따른 피연자 각 1개씩 총 2개 항으로 식을 처리한다.
             * ex) (식) ? 피연산자1 : 피연산자2
             * 
             * 식과 문
             * 값 하나 또는 연산을 진행하는 구문의 계산식을 식(Expresstion) 또는 표현식이라고 한다. 표현식을 사용하여
             * 명령 하나를 진행하는 구문을 문(Sratement) 또는 문장이라고 한다.
             */

            // 단항 연산자
            const int PLUS_FIVE = +5;
            const int MINUS_FIVE = -5;
            const int MINUS_FIVE2 = -5;   
            Console.WriteLine(intBinary);  // 확인

            // 이항 연산자
            const int PLUS_TEN = 5 + 5;  // +, = 연산자

            // 삼항 연산자
            string compereTen = (PLUS_FIVE > 10) ? "{0}은(는) 10 보다 크다" : "{0}은(는) 10 보다 크지 않다";
            Console.WriteLine(compereTen, PLUS_FIVE);

            // 변환 연산자
            // () 기호를 사용하여 특정 값을 원하는 데이터 형식으로 변활할 수 있다.
            const int PT_INT = (int)3.141592;
            const float PI_FLOAT = (float)3.151592;

            Console.WriteLine("PT_INT : {0}, PT_FLOAT : {1}", PT_INT, PI_FLOAT );

            /*
             * 산술, 관계, 논리, 증감, 조건, 비트, 시프트 연산자
             * 
             * 산술 연산자
             * 더하기(ADD),뺴기(Subtract). 곱하기(Multiply), 나누기(Divide) 나머지(Remainder, Modules) 등
             * 수학적 연산을 하는 데 사용한다. 보통 정수 형식과 실수 형식의 산술 연산에 사용한다.
             * ex) +, -, *, /, %
             * 
             * 문자열 연결 연산자
             * 산술 연산자 중 하나인 + 연산자는 피연산자의 데이터 타입에 따라 산술 연산 또는 문자열 연결 연산을 
             * 수행한다.
             * 
             * + 연산자: 두 항이 숫자일 때는 산술(+) 연산 가능, 문자열일 때는 문자열 연결
             */

            string addMessage = "string" + "plus" + "string";
            Console.WriteLine(addMessage);

            /*
             * 할당 연산자
             * 할당 연산자(Assigment operator)는 변수에 데이터를 대입하는 데 사용한다. 할당 연산자를 대입 연산자
             * 라고도 한다. c#에서 = 기호는 같다는 의미가 아니라 오른쪽에 있는 값 또는 식의 결과를 왼쪽 변수에
             * 할당하려고 지시하는 것이다.
             * 
             * ex) = += -= *= /= %=
             * 
             * 증감 연산자(Increment / Decrement operator)
             * 변수 값을 1 증가시키거나 1 감소시키는 연산자이다. 증감 연산자가 변수 앞에 위치하느냐, 뒤에 위치하느냐에 
             * 따라 연산 처리 우선순위가 결정된다.
             * 
             * ++(증가 연산자) : 변수 값에 1을 더한다.
             * --(감소 연산자) ; 변수 값에 1을 뺀다.
             * 
             * 증감 연산자가 앞에 붙으면 전위 증감 연산자라고 하며, 변수 뒤에 붙으면 후휘 증감 연산자라고 한다.
             * 
             * 전위(Prefix) 증감 연산자 : 정수형 변수 앞에 연산자가 위치하여 변수 값을 미리 증감한 후 나머지 연산을
             *                            수행한다.
             * 후위(Postfix) 증감 연산자 : 정수형 변수 뒤에 연사자가 위치하여 연산식(대입)을 먼저 실행한 후 나중에
             *                             변수 값을 증감한다.
             */

            int number = 3;
            number += 2; 
            Console.WriteLine(number);

            int number1 = 3;
            Console.WriteLine(number1++);
            Console.WriteLine(number1);

            int number2 = 0;
            number2 = number2++;  // 쉽게 하면 number2 += 1; ,number2 = (number2++);  
            Console.WriteLine(number2);

            /*
             * 관계형 연산자
             * 관계형 연산자(Relational operator) 또는 비교 연산자(CComperatiove operator)는 두 항이 큰지, 작은지
             * 도는 같은지 등을 비교하는 데 사용한다. 관계형 연산자의 결과값은 논리 데이터 형식인 참(true), 또는
             * 거짓(false)으로 출력된다.
             * ex)< <= > >= == !=
             * 
             * 논리 연산자
             * 논리 연산자(Logical operator)는 논리곱(and), 논리합(or),, 논리부정(not)의 조건식에 대한 논리 연산을
             * 수행한다. 연산의결과값은 참 또는 거짓의 bool 형시으로 반환되어 Boolean 연산자라고도 한다.
             * ex) && || !
             * 
             * 비트 연산자
             * 비트 연산자(Bit operator)는 정수형 데이터의 값을 이진수 비트 단위로 연산을 수행할 때 사용한다.
             * ex) &,|,^, ~
             * 
             * 시프트 연산자
             * 시프트 연산자(Shift operator)는 정수 데이터가 담겨 있는 메모리의 비트를 왼쪽 또는 오른쪽으로 지정한
             * 비트만큼 이동시킨다.(암호화에서 많이 쓰인다.)
             * ex) <<, >>
             * 
             * 조건 연산자
             * 조건 연산자(Conditional operator)는 조건에 따라서 참일 때와 거짓일 때 결과를 다르게 반환하며, 
             * (조건식) ? (식1 또는 값1) : (식2 또는 값2) 형태의 연산자이다. if=else 문의 축약형이기도 하다.
             */

            bool isBigger = false;
            isBigger = (5 == 10) && (5 < 10);
            Console.WriteLine(isBigger);   // 관계형 연산자

            isBigger = !isBigger;
            Console.WriteLine(isBigger);  // 논리 연산자

            int bitNumber = 10;
            int bitResult = 0;    
            bitResult = bitNumber & 0b0100;
            Console.WriteLine("bitNumberrk 0010 상태를 가지고 있나요 -> {0}",bitResult);   //비트 연산자

            int bitNumber1 = 10;
            int bitResult1 = 0;
            bitResult1 = bitNumber1 << 1;
            Console.WriteLine(bitResult1);   // 시프트 연산자


            //나열(콤마) 연산자
            // 콤마를 구분자로 하여 한 문장에 변수 여러 개를 선언할 때 사용한다.
            int intNumber1, intNumber2, intNumber3;


            /*
             * sizeof 연산자
             * sizeof 연산자는 단항 연산자로 데이터 형식 자체의 크기를 구하는 데 사용한다.
             * sizeof([데이터 타입]) 형태로 사용하며, 운영 체제와 cpu  아키텍쳐의 종류에 따라 결과값이
             * 다르게 나올 수 있다.
             */
            Console.WriteLine("int의 메모리 크기는 {0} 바이트입니다.", sizeof(Int32));

            /*
             *  연산자 우선순위
             *  연산자 여러 개를 함께 사용할 때는 연산자 우선순위(Precedence)에 따라 계산된다.
             *  연산자 우선순위를 잘 모를 때는 일단 괄호 연산자부터 잘 사용하도록 연습하는 게 좋다.
             */

            // 사용자에게 주어, 동사, 목적어를 각각 물어보고 이것들을 합하여(주어+ 동사+ 목적어)형태로 출력하는 프로그램 작성
            //  *출력문에 관사 붙어 있음

            //  ex) 주어 : I
            //      동사 : have
            //      목적어 : book
            //     out -> I have book

            Console.WriteLine("주어를 입력하세요");
            string strigSubject = Console.ReadLine();

            Console.WriteLine("동사를 입력하세요");
            string stringVerb = Console.ReadLine();

            Console.WriteLine("목적어를 입력하세요");
            string stringDirect = Console.ReadLine();

            Console.WriteLine($"{strigSubject} {stringVerb} a {stringDirect}");


            // 사용자의 나이를 물어보고 10년 후에 몇 살이 되는지를 출력하는 프로그램 작성
            //  ex)  나이: 20
            //       -> 10년 후에는 30살이 됩니다.

            Console.WriteLine("사용자 나이를 입력해주세요");
            string stringAge = Console.ReadLine();

            int intAge;

            int.TryParse(stringAge, out intAge);


            Console.WriteLine($"10년 후에는 {intAge + 10}살이 됩니다.");


            // 직각 삼각형의 양변 길이(양 변은 빗변이 아님)를 읽어서 빗변의 길이를 계산하는 프로그램 작성
            //  ex)  첫 번쨰 변 : 3
            //       두 번째 변 : 4
            //       -> 빗변길이: ???
            //     A^2 + B^2 = C^2

            Console.WriteLine("첫 번째 변을 입력해주세요");
            string stringHypotenuse = Console.ReadLine();

            int Hypotenuse;
            int.TryParse(stringHypotenuse, out Hypotenuse);

            Console.WriteLine("두 번째 변을 입력해주세요");
            string stringHypotenuse1 = Console.ReadLine();

            int Hypotenuse1;
            int.TryParse(stringHypotenuse1, out Hypotenuse1);

            double hypotenuseLength = Hypotenuse * Hypotenuse + Hypotenuse1 * Hypotenuse1;
            
            Console.WriteLine($"빗변 길이: {Math.Sqrt(hypotenuseLength)}"); // 루트 계산하는 수학 함수




            //상자의 길이(Length), 너비(Width), 높이(Height)를 입력하라는 메시지를 표시
            // 상자의 부피와,표면적을 계산해서 출력하는 프로그램
            //   ex)  길이 : 3
            //        너비 : 4
            //        높이 : 5
            //        -> 상자의 부피 : 길이 * 너비 * 높이
            //        -> 상자의 표면적(겉넓이) : 2(길이*너비 + 너비*높이 + 길이*높이)

            Console.WriteLine("길이를 입력해주세요");
            string stringLength = Console.ReadLine();

            int Length;
            int.TryParse(stringLength,out Length);

            Console.WriteLine("너비를 입력해주세요");
            string stringWidth = Console.ReadLine();

            int Width;
            int.TryParse(stringWidth,out Width);

            Console.WriteLine("높이를 입력해주세요");
            string stringHeight = Console.ReadLine();

            int Height;
            int.TryParse(stringHeight,out Height);



            int volume = Length * Width * Height;
            int surface = 2 * (Length* Width + Width* Height + Length * Height);
           

          
            Console.WriteLine($"상자의 부피 : {volume}");
            Console.WriteLine($"상자의 겉넓이 : {surface}");



            //우리나라에서 많이 사용되는 면적의단위인 평을 평방미터로 환산하는 프로그램 작성
            // 여기서 1평은 3.3058m^2
            //   ex)  평 : 25.0
            //        -> 평방미터 :


            // 사용자의 입력을 받는 입력부
            const float ONE_PYUNG = 3.3058F;
            float userInput = 0.0F;

            //여기서 입력을 받았음
            Console.WriteLine("평을 입력하세요 :");
            float.TryParse(Console.ReadLine(), out userInput);

            //결과를 출력할 출력부
            Console.WriteLine($"평방미터: {userInput * 3.3058F}");





            // 시, 분, 초로 표현된 시간을 초 단위의 시간으로 변환하는 프로그램을 작성
            //  ex)  시 : 1
            //       분 : 1
            //       초 : 1
            //       -> 전체 초:

            int hour, minute, second;
            
            Console.WriteLine("시 : ");
            int.TryParse(Console.ReadLine(), out hour);

            Console.WriteLine("분 : ");
            int.TryParse(Console.ReadLine(), out minute);

            Console.WriteLine("초 : ");
            int.TryParse(Console.ReadLine(), out second);

            int allSecond = minute * 60 + 60 * 60 * hour + second;

            Console.WriteLine($"전체 초 :  {allSecond}");



            //퀴즈, 중간고사, 기말고사의 성적을 사용자로부터 입력받아서 성적 총합을 계산하는 프로그램 작성
            //   ex)   퀴즈  #1   성적: 10
            //         퀴즈  #2   성적: 20
            //         퀴즈  #3   성적: 30
            //         중간고사   성적: 80
            //         기말고사   성적: 80
            //        =======================
            //         성적 총합:
            //        ========================

            int record1, record2, record3, midtermExam, Finals;
           

            Console.WriteLine("#1 : ");
            int.TryParse(Console.ReadLine(), out record1);

            Console.WriteLine("#2 : ");
            int.TryParse(Console.ReadLine(), out record2);

            Console.WriteLine("#3 : ");
            int.TryParse(Console.ReadLine(), out record3);

            Console.WriteLine("중간고사 : ");
            int.TryParse(Console.ReadLine(), out midtermExam);

            Console.WriteLine("기말고사 : ");
            int.TryParse(Console.ReadLine(), out Finals);


            Console.WriteLine($"성적 총 합: {record1 + record2 + record3 + midtermExam + Finals} ");
            



        }
    }
}