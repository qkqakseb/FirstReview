using System;

namespace WhatsProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // 한줄 주석

            /* 
             * 여러 줄 주석이다.
             * 주석은 메모하고 싶을 때 쓰는 기능이다.
             * 영어로 주석은 comment
             */
            /*
             * 컴퓨터는 하드웨어(Hardware)와 소프트웨어(Software)로 구성된다. 하드웨어는 pc, 스마트폰과 같은
             * 물리적으로 존재하는 장치를 의미한다. 소프트웨어는 이러한 하드웨어에 설치된 운영채제, 앱 등을 의미 한다.
             * 
             * 프로그램(program)이란 우리가 하고자하는 작업을 컴퓨터에게 전달하여 주는 역할을 하는 소프트웨어를
             * 의미한다.
             * 프로그램 안에는 "무엇을 어떤 식으로 해라" 와 같은 형태의 명령어(Instruction) 들이 들어 있다.
             * 
             * 소프트웨어를 만드는 행위를 프로그래밍(Programming) 또는 코딩(coding)이라고 한다.
             * 
             * 컴퓨터가 알아듣는 언어는 한가지 뿐이다.
             * 0과 1의 형태로 구성되어 있으며 기계어(Machine language)라고 부른다.
             * 과거 초기 형태의 컴퓨터는 이러한 기계어를 사용하여 프로그래밍 했었다.
             * 기계어는 인간에게 상당히 불편한(난해한) 언어기 때문에 사람이 이해하기 쉬는 프로그래밍 언어가 만들어지게 된다.
             * 프로그래밍 언어의 예약어(Keyward)와 문법으로 소프트웨어를 만드는 사람을 프로그래머 또는 
             * 개발자(Developer)라고 한다.
             * 
             * 프로그래밍 언어의 문법에 맞게 작성한, 텍스트로 된 명령 집합을 코드(Code) 또는 소스(Source)라고 한다.
             * 소스코드를 기계어로 번역하는 작업을 컴파일이라고 한다. 이러한 작업을 하는 소프트웨어를
             * 컴파일러라고 한다.
             * 
             * 프로그래밍을 하는 과정은 다음과 같다.
             * 1. 텍스트 에디터로 소스를 작성하여 파일로 저장한다.   ex) .cs 파일 같은거
             * 2. 소스 파일을 컴파일하여 실행 프로그램을 생성한다.   ex) .exe 파일 같은거
             * 3. 프로그램을 실행한다. 
             * 이 중 1,2 단계를 합쳐서 흔히 빌드라고 한다.
             * 
             * 프로그래밍 과정 중 발생한 오류를 버그라고 한다. 
             * 오류를 탐색하고 수정하는 과정을 디버그(Debug) 또는 디버깅(Debugging) 또는 트러블슈팅(Trouble shooting)
             * 이라고 한다. 
             * 
             * C#의 경우
             * C# 언어로 코딩 -> IL(Intermediate Language)코드로 변환  -> 기계어
             * ildasm
             * 
             * C#의 특징
             * C#은 .Net(닷넷)을 위한 많은 언어 중 하나로, 마이크로소프트의 닷넷 플랫폼을 기반으로 한다.
             * 절차적 언어와 객체지향적 언어의 특징, 그리고 함수형 프로그래밍 스타일을 제공하는 다중 패러다임
             * 프로그래밍 언어이다.
             * 
             * C#은 C++,Java, Javascript와 기초 문법이 비슷하다.
             * C#은 자동으로 메모리를 관리한다.(Garvage collection 기능을 제공)
             * C#은 컴파일 기반 언어이다.
             * C#은 강력한 형식(Strongly typed)의 언어이다.
             * C#은 Generic 과 LINQ 등 편리한 기능을 제공한다.
             * 
             * .Net(닷넷)
             * 닷넷 프레임워크와 닷넷 코어를 합쳐서 편하게 닷넷이라고 한다.
             * 닷넷은 소프트웨어 프레임워크로, 응용 프로그램의 개발 속도를 높이는 데 도움이 되는
             * API(Application Programming Interface) 및 서비스 모음이다.
             *
             * 프레임워크 : 응용 프로그램의 개발 속도를 높이는 데 도움이 되는
                             API(Application Programming Interface) 및 서비스 모음이다.
             *
             * 함수, 라이브러리, API 이게 뭐지??
             * 함수 : 프로그램에서 사용하기 위한 기능의 단위를 의미한다. 보통 하나의 함수는 하나의 기능을 한다.
             * 라이브러리 : 어떠한 기능을 구현할 때 도움이 되는 기능 , 함수의 모음이다.
             * API : 어떠한 기능을 구현할 때 도움이 되도록 문서와 함께 제공되는 라이브러리, 함수의 모음이다.
             * 
             * 플랫폼 : 프로그램을 실행하기 위한 배경 환경 또는 운영체제를 의미한다.
             *         
             */

            /*
             * C#의 기본 코드 구조
             * C# 프로그램은 class 와 main() 메서드가 반드시 있어야 하고, 하나 이상의 문(Statement)이 있어야 한다.
             * C#의 기본 코드는 위쪽에 네임스페이스 선언부와 main() 메서드가 오고, 중괄호 시작과 끝을 사용하여
             * 프로그램 범위를 구분한다.
             * 
             * 네임스페이스 : 자주 사용하는 네임스페이스를 위쪽에 미리 선언해 둘 수 있다.
             * main()  메서드 : 프로그램의 시작 지점이며, 반드시 있어야 한다.
             * 중괄호 ({}) : 프로그램 범위를 구분 짓는다.
             * 세미콜론 (;): 명령어(문, 문장)의 끝을 나타낸다.
             * 
             * Main()메서드
             * 메서드(Method): 클래스에서 제공하는 멤버 함수를 의미한다. 
             * Main() 앞에 static 키워드가 있어서 개체를 생성하지 않고 바로 실행할 수 있다. 
             * Main() 메서드가 2개이면 "프로그램 진입점이 2개 이상 정의 되어 있습니다." 라는 
             * 에러 메시지가 출력되어 프로그램이 컴파일 되지 않는다.
             * 
             * 대, 소문자 구분하기
             * C#은 대, 소문자를 구분한다. 정확히 입력하지 않으면 에러가 발생한다.
             * 
             * 문법, 스타일, 패턴
             * 문법(Syntex) : 프로그래밍을 하기 위해 반드시 지켜야 하는 규칙(Rule)이다. 언어별로 다르다.
             * 스타일(Style) : 프로그래밍 가이드라인(Guideline)이다.[파스칼 표시법, 다양한 주석 등을 정해서 적는것]
             * 패턴(Pattern) : 자주 사용하는 규칙과 스타일 모음이다.
             * 
             * 정규화된 이름
             * 정규화된 이름(Fully qualified names)은 아래와 같이 네임스페이스 이름과 
             * 형식 이름까지 전체를 지정하는 방식이다.
             * ex) System.Console.WriteLine();
             * 
             */

            /*
             * 출력문 : 명령 프롬프트에 출력하는 구문
             * 주석문 : 실행에 영향을 주지 않는 코드 설명문
             *    - 한 줄 주석
             *    - 여러줄 주석 있음.
             *   
             *   Console.Write("Hello World");   :  한줄로 나옴
             *   Console.WriteLine("Hello World");   : 줄 띄어쓰기 해서 나옴
             *  
             */

            /*
             * 들여쓰기: 프로그램 소스 코드의 가독서응ㄹ 위해서 사용하는 일반적인 들여쓰기 규칙
             *           보통 4칸의 공백(Space)는 Tab을 사용하지만 혼용하면 안된다.
             * 공백처리 : C#에서 명령어 사이, 기호와 괄호 사이으이 공백, Tab, 줄 바꿈은 무시된다.
             *             ex) Console.  WriteLine     (
             *                 "Hello World");
             */

            /*
             * 이스케이프 시퀸스 (\n, \t 등)
             * C#은 WriteLine() 메서드에서 사용할 확장 문자를 제공하는데, 이를
             * 이스케이프 시퀸스(Escapesequence)라고 한다.
             * 역슬래쉬 기호화 특정 문자를 조합하면 특별한 기능을 사용 할 수 있다.
             * 어떤 이스케이프 시퀸스가 있는지 검색하면 알 수 있다.
             *   ex) Console.WriteLine("");
             *       Console.WriteLine("");
             *       Console.WriteLine("");
             *  
             *       Console.Write("Hello World \n");
             *       Console.WriteLine("Hello World");
             */


            /*
             * 문자열 보간법
             * 문자열 보간법(string interpolation) 또는 문자열 템플릿(String template)이라고도 한다.
             * 문자열을 묶어서 처리하기 위한 기능이다. 기존에는 String.Format() 메서드를 주로 사용했었는데,
             * C# 6.0 버전부터 $"{}" 형태로 간결하게 제공하고 있다.
             *  ex) Console.WriteLine("Hello" + "World"); 연산은 되나 느리다.
             *      Console.WriteLine("{0}, {1}", "Hello, World");  이게 더 빠름
             *      Console.WriteLine($"{Hello}, {World}");
             *      
             *      const int THREE_NUMBER = 3;
             *      const string ODD_WORD = "홀수";
             *      Console.WriteLine($"{THREE_NUMBER}은(는) {ODD_WORD}입니다");
             *      
             *      string stringFormat = string.Format("{0}은 {1}입니다",THREE_NUMBER, ODD_WORD);
             *      Console.writeLine(stringFormat);
             *      
             *      //이렇게 문자열을 + 연산하면 특히 느리다.
             *        string stringPlus = THREE_NUMBER + "은" + ODD_WORD + "입니다.";
             *        Console.WriteLine(stringPlus);
             */

            Console.WriteLine("자신의 이름 : 박난주 \n");
            Console.WriteLine("과정명 : (게임콘텐츠제작) 모바일 게임 개발자 양성과정C \n");
            Console.WriteLine("학습교과 : (전공)게임 프로그래밍 기초 기술");

            /*
             * 프로그램에서 값을 다루려면 데이터를 메모리에 잠시 보관해 놓고 사용할 수 있는 임시 저장공간이 필요하다.
             * 이때 변수를 사용한다. 병수를 사용하는 순서는 선언(메모리에 공간을 확보)하고 정의(대입, 할당)하여
             * 사용하는 것이다. 변수는 데이터 형식, 변수의 이름, 대입한 값으로 이루어져 있다.
             * 
             * 변수 선언 :메모리에 데이터를 저장할 공간을 확보하는 것이다.
             * 변수 정의 : 확보한 공간에 값을 저장하는 것이다.
             * 변수 초기화 : 변수를 선언한 직후, 초기값으로 정의하는 것이다. 초기화는 변수의 초기값을 명확하게 정의하여 
             *               원치 않는 물리적인 오류를 방지하는 역할을 한다.
             *               
             *  ex) int number;     //선언
             *      number = 100;   //정의
             *      
             *      int trashValue;
             *      int number2 = 1;   //초기화
             *      
             * //비전공자용 버전
             * 
             *    Console.WritLine("int는 얼마 만큼의 메모리를 할당하나요?  -> {0}byte", sizeof(int));
             *    
             *    bit : 0 또는 1을 표현할 수 있는 최소 단위  
             *          ex) [0] [0]
             *              [0] [1]
             *              [1] [0]
             *              [1] [1]
             *              
             *    byte : 숫자를 세는 단위 8bit =1byte
             *    
             *  
             *  변수 사용할 때 주의사항(규칙)
             *  변수의 이름을 지을 때는 다음 규칙을 지켜야 한다.
             *  변수의 첫 글자는 반드시 문자로 지정한다. 숫자는 변수의 이름의 첫 글자로 사용할 수 없다.
             *  길이는 255자 이하로 하고 공백을 포함할 수 없다.
             *   영문자와 숫자, 언더스코어(_)조합으로 사용하며, 기타 특수 기호는 사용할 수 없다.
             *   C#에서 사용하는 키워드는 사용할 수 없다.
             *   변수는 대, 소문자를 구분하고, 일반적으로 소문자로 시작한다.
             *   변수는 타인이 보더라도 이해할 수 있는 이름으로 사용한다.
             */

            /*
             * 데이터 형식
             * 변수에 저장할 수 있는 데이터의 종류를 자료형(Data type)이라고 한다.
             * int , string, vool, douvle, object 등 c#에서 기본으로 제공하는 데이터 형식을
             * 기본 형식(Primitive type)이라고 한다.
             * 
             * int : 정수형 데이터 타입 (음수, 양수, 0)
             * float : 실수형 데이터 타입 (부동소수점 형태 / 3.14)
             * bool : 논리값을 가지는 데이터 타입 (참, 거짓)
             *       ex)
             *        bool boolType;
             *        boolType = true;
             *        boolType = false;
             *        
             * char : 한 문자를 가지는 데이터 타입 ('a')
             * string : 문자열을 가지는 데이터 타입 ("Hello")
             * object : c#에서 모든 자료형의 부모형 데이터 타입 (모든 데이터를 저장 가능)
             * 
             * 
             * 상수의 리터럴
             * 
             * 상수
             * 변수를 선언할 때 앞에 const 키워드를 붙이면 상수가 된다. 한 번 상수로 선언된 별수는
             * 다시 값을 바꿀 수 없고, 바드시 선언과 동시에 초기화해야 한다. 이러한 const 키워드를 붙인 변수를
             * 상수 또는 지역(Local) 상수라고 한다. 상수는 주로 대문자로 표현한다.
             * 
             * ex)
             *  int number = 0;
             *  Console.WriteLine(number);
             *  number =1;
             *  Console.WriteLine(number);
             *  
             *  const int CONST_FIVE = 5;
             * 
             * 
             * 
             * 리터럴
             * 변수에 저장하기 위해 직접 대입하는 값 가체를 리터럴(Literal)이라고 한다.
             * 정수형 리터럴 : 숫자 그대로 표현한다.    ex) 1234
             * 실수형 리터럴 : 대문자 F 또는 소문자 f 를 접미사로 붙여 표현한다.    ex) 3.14F
             * 문자형 리터럴 : 작은 따옴표로 묶어서 표현한다.      ex) 'A'
             * 문자열 리터럴 : 큰 따옴표로 묶어서 표현한다.        ex) "A"
             * 
             *  ex)
             *   const float PI =3.14F;
             * 
             * 
             * 
             * 숫자 구분자 사용
             * C# 7.0 버전부터는 언더스코어(_) 문자를 사용하는 숫자 구분자(Digit separator)를 제공한다.
             * 숫자 형식을 표현할 때 언더스코어 문자는 무시하낟. 이를 이용하면 긴 숫자를 표시할 때
             * 가독성을 높일 수 있다.
             * 
             *  ex) 
             *  int bigNumber = 110_000;  // _를 넣어도 의미가 변하지 않음
             *  확인
             *  int bigNumber = 110000 - 1000;
             *  Console.WriteLine("Big number - 1000의 값이 변하지 않을까?? {0}", bignumber); 
             */


            //정수형 변수로 반지름을 선언하고 상수로 원주율을 선언한 다음에 원의 넓이 출력
              // 원의 넓이 : 원주율 * 반지름^2
              
            int radius = 10;
            const double PIRATIO = 3;

            double synthesis = PIRATIO * radius * radius;

            Console.WriteLine($"원의 넓이 : {synthesis}");


            /*
             * null 키워드
             * c#에서 null 키워드는 '아무것도 없는 값'을 의미한다.
             * 
             * null 가능 형식(Nullable)
             * 숫자 형식의 변수를 선언할 때 int?, float? 와 같이 물음표(?) 기호를 붙이면 null 가능 형식으로
             * 변경된다. 이러한 null 가능 형식에는 아무런 값도 없음을 의미하는 null을 대힙할 수 있다.
             * 
             * ex)
             *   int? nullNnumber = null;
             *   Console.WriteLine("Null을 눈으로 보고 싶다 -> {0}", nullNumber); // 안나옴
             *   int doNothingNumber = 0;
             *   
             *   string nullString = null; // string은 null이 원래 들어간다.
             */

            /*
             * 자동 타임 추론(Automatic type deduction)
             * 변수에 대입하는 값의 데이터 타입이 명시적이거나 명확할 때, 데이터 타입을 명시하지 않고 생략할 수 있다.
             * 자동 타입 추론이란 컴파일러가 대입하는 값 또는 변수의 데이터 타입으로 다른 한 쪽의 데이터 타입을
             * 추론하는 기능을 의미한다.
             * 
             * default 값
             * c# 6.0 버전부터는 자동 타입 추론으로 기본 형식에 default 값을 대입할 수 있다.
             * 기본 형식마다 정해진 default 값이 존재한다.
             * 
             * ex)
             *   int number_ = default;
             *   string strinValue = default;
             *   char charValue = default;
             *   float floatValue = default;
             *   
             *   var autoVarible = 10; // var 가 int가 됨
             *   var autoVaribleFloat = 3.14F;
             *   Var autoVarivleDouble = 3.14;
             */

            /*
             * 열거형 형식
             * c#에서 열거형(Enumeration) 형식은 기억하기 어려운 상수들을 기억하기 쉬운 이름 하나로 묶어 관리하는
             * 표현 방식이다. 일반적으로 열거형으로 줄여 말한다. 열거형은 enum 키워드를 사용하고 이늄 도는 이념으로
             * 읽는다. 열거형은 클래스 범위 내에 정의해야 하며, 메서드 범위 안에는 정의할 수 없다.
             * 
             * ex)
             *  Align align = Align.TOP;
             *  align = Align.LEFT;
             *  
             *  Console.WriteLine("Enumeration 데이터는 어떻게 보일까 -> {0}", align);
             *  
             */

            /*
             * 입축력에 대해서
             * 프로그램을 실행할 때마다 서로 다른 값을 입력받으려면 콘솔에서 입력한 겂을 변수에 저장할 수 있어야 한다. 
             * 키보드로 입력받고 모니터로 출력하는 일반적인 내용을 표준 입출력(Standard input/output)이라고 한다.
             * 
             * System.Console.ReadLine() : 콘솔에서 한 줄을 입력받는다.(문자열로 입력받고 있다)
             * System.Console.Read()     : 콘솔에서 한 문자를 정수로 입력받는다.
             * System.Console.ReadKey()  : 콘솔에서 다음 문자나 사용자가 누른 기능 키를 가져온다.
             * 
             * ex)
             *  Console.write("이름을 입력하시요:");
             *  string yourName = string.Empty;
             *  yourName = Console.ReadLine();
             *  
             *  Cosole.WriteLine("안녕하세요. {0}님", yourName);
             *  
             *  
             *  형식 변환
             *  Console.ReadLine() 메서드를 사용하여 콘솔에서 입력받은 데이터는 문자열이다. 문자열 대신 정수나 실수
             *  데이터를 입력받고 싶다면 입력된 문자열을 원하는 데이터 형식으로 변환할 수 있어야 한다.
             *  
             *  키워드 : 캐스팅 연산자, 암시적(묵시적) 형변환, 명시적 형변환
             *  
             *  
             *  3가지의 형변환 하는 법
             *  Cosole.WriteLine("숫자를 입력하시요:");
             *  string stringNumber = console.ReadLine();
             *  
             *  1. int intNumber = Covert.TOInt32(stringNumber); // int로 바뀐다
             *  2. int intNumber2 = int.Parse(stringNumber);
             *  3. int intNumber3 = default;
             *     int.TryParse(stringNumber, out intNumber3); // 가장 추천하는 방법이다.
             *     
             *  Console.WriteLine("입력한 숫자 + 10은 {0}입니다.", intNumber +10); 
             *  
             */

            //실수형 변수로 반지름을 사용자 입력받고, 실수형 상수로 원주율을 선언한다음에
            // 구의 겉넓이, 구의 부피 출력하는 프로그램
            /* 출력의 예시
             * 1.사용자에게 무엇을 입력해야 하는지 알려주는 출력문
             * 2. 구의 겉넓이 : 숫자  4파이r^2
             * 3. 구의 부피 : 숫자    4/3*파이r^3
            */

            Console.WriteLine("반지름을 입력하세요");
            string strigndAdius = Console.ReadLine();

            double Adius = default;
            double.TryParse(strigndAdius, out Adius);

            const double PIRATIO1 = 3.14;  // 원주율 구하는 것

            double surface = 4 * PIRATIO1 * Adius * Adius;
            double volume = 4.0 / 3.0 * PIRATIO1 * Adius * Adius * Adius;

            Console.WriteLine($"구의 겉넓이 : {surface} \n구의 부피 : {volume} ");


        }
        //열거형 형식 : enum Align { TOP, BOTTON, LEFT, RIGHT, RANDOM, VALUE };  // Class  안에 넣어서 실행해야 한다.
    }
}