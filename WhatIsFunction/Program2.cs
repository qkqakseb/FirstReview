using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class Program2
    {
        public static void Main()
        {
            /* 문제
             *1. 3개의 정수 중에서 최대값을 찾는 함수 Maximum(x, y, z)를 정의할 것
             * 
             *2. 화면에 "Hello"를 출력하는 SayHello()함수를 작성
             *    - int 타입 매개변수 받아서 그 횟수만큼 "Hello"를 반복해서 출력
             * 
             *3. 다른 두 변이 주어 졌을 때 직각 삼각형의 빗변을 계산하는 함수 Hypot()를 정의할 것
             *   - 매개변수는 2개, 타입은 double 형
             *   - 리턴 타입도 double형
             *
             *4. 주어진 숫자가 소수인지 여부를 찾는 함수 Prime()을 작성
             *   - 판별할 값의 범위는 2~100 사이의 값 중에서 소수는 모두 출력
             *   
             *5. 사용자가 입력하는 전화번호에서 소괄호를 삭제한 형태로 출력하는 프로그램 작성(함수 사용)
             *   - 전화번호를 입력 받는다. -> 소괄호를 삭제한 형태로 출력한다.
             *   - quit 입력하면 프로그램을 종료한다.
             *   - 프로그램 종료 전까지 전화번호를 입력 받는다.
             */


            // 1번 문제
            //int x = 0;
            //int y = 0;
            //int z = 0;

            //int max = 0;

            //Console.WriteLine("x의 값을 입력하세요 : ");
            //int.TryParse( Console.ReadLine(), out x );
            //Console.WriteLine("y의 값을 입력하세요 : ");
            //int.TryParse( Console.ReadLine(), out y );
            //Console.WriteLine("z의 값을 입력하세요 : ");
            //int.TryParse( Console.ReadLine(), out z );

            //max = Maximum(x, y, z);
            //Console.WriteLine($" 최대값은 : {max}");



            // 2번 문제
            //int number1 = 0;


            //Console.WriteLine("횟수를 말해주세요 : ");
            //int.TryParse(Console.ReadLine(), out number1);

            //SayHello(number1);




            // 3번 문제
            //double hypot1 = 0;
            //double hypot2 = 0;
            //double hypotLength = 0;

            //Console.WriteLine("첫번째 변을 입력해주세요 : ");
            //double.TryParse(Console.ReadLine(), out hypot1);
            //Console.WriteLine("두번째 변을 입력해주세요 : ");
            //double.TryParse(Console.ReadLine(), out hypot2);


            //Hypot(hypot1, hypot2);



            // 4번 문제


            Prime();



        }

        // 1번 문제 함수
        //static int Maximum(int x, int y, int z)
        //{
        //    if( x < y  && z < y)
        //    {
        //        return y;
        //    }
        //    else if ( y < x && z < x)
        //    {
        //        return x;
        //    }
        //    else if( x < z && y < z)
        //    {
        //        return z;
        //    }
        //    return 0;
        //}


        // 2번 문제 함수
        //static void SayHello(int sh)
        //{
        //    for(int i =0; i < sh; i++)
        //    {
        //        Console.WriteLine("Hello");

        //    }

        //}

        // 3번 문제 함수
        //static double Hypot(double x, double y)
        //{
        //    double hypotLength = x * x + y * y;
        //    Console.WriteLine($"빗변의 길이 : {Math.Sqrt(hypotLength)}");
        //    return 0;
        //}



        // 4번 문제 함수

        static void Prime()
        {
            for (int i = 2; i <= 100; i++)
            {
                int check = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        //Console.WriteLine("소수가 아닙니다.");
                        check++;
                        break;
                    }
                }
                if (check == 0)
                    Console.WriteLine($"{i}");
            }
        }

        // 선생님 코드(4번)
        //static void Prime()
        //{
        //    Console.WriteLine("2~100 사이의 값 중에서 소수 출력하는 프로그램");
        //    for (int index = 2; index <= 100; index++)
        //    {
        //        if (FindPrime(index))
        //        {
        //            Console.WriteLine($"{index}");
        //        }
        //    }
        //}

        //static bool FindPrime(int number)
        //{
        //    bool isPrime = true;

        //    for(int index = number - 1; 2 <= index; index--)
        //    {
        //        if (number % index == 0)
        //        {
        //            isPrime = false;
        //            break;
        //        }
        //        else { continue; }
        //    }
        //    return isPrime;
        //}


        // 5번 문제 함수




        // 문제 6
        // "Hello world" 거꾸로 출력하기
     
    }
}
