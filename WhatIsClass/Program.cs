﻿using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Net.WebSockets;

namespace WhatIsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WhatIsStructure();

            BusinessCard businesscard;
            businesscard.name = "박난주";
            businesscard.age = 26;
            businesscard.adress = "서울시";
        }
        struct Point
        {
            public int x;
            public int y;
            public int myNewNumber;
        }

        // 명함(BusinessCard)이라는 구조체 선언 및 초기화 해보기
        // 이름, 나이, 주소
         struct BusinessCard
         {
           public string name;
           public int age;
           public string adress;
         }

        enum weekday
        {
            SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FEDAY, FRIDAY
        }

        enum Animal
        {
            CHICKEN, DOG, PIG
        }
    static void WhatIsStructure()
        {
            /*
             * 구조체란?
             * 구조체는 이름 하나로 데이터를 묶어 관리하는 역할을 한다. 앞에서 배운 변수는 이름 하나로
             * 공간을 하나 갖고, 배열은 이름 하나로 데이터 형식이 동일한 공간을 여러 개 갖는다.
             * 배열을 확장하여 이름 하나로 데이터 형식을 1개 또는 여러 개 보관하는 그릇 역할을 하는 것이 
             * 바로 구조체이다.
             * 
             * 구조체는 int string 등 서로 다른 자료를 한 집단으로 정의하여 이름 하나로 지정할 수 있는
             * 여러 항목의 모임이다. 즉, 구조체 변수랑 이름 하나로 데이터 형식 1개 이상을 하나로 보관해 놓는
             * 그릇 역할을 하는 것이다. 그리고 구조체 배열은 이름 하나로 데이터 형식 1개이상을 여러개 보관해 
             * 놓는 그릇 역할을 한다. 
             * c#에서는 구조체를 확장한 클래스(class) 개념을 제공하기에 닷넷에 이미 만들어 둔 내장 구조체를 
             * 몇 개 정도 학습한 후 뒤에서 배울 클래스 위주로 사용하면 좋다.
             * 
             * 구조체 만들기
             * 구조체를 만드는 방법은 다음과 같다. 구조체를 의미하는 struct 키워드를 사용하여 구조체를 만들고
             * 중괄호 안에 구조체 멤버들을 생성한다.
             * ex) 
             *   struct [구조체 이름]
             *   {
             *        [데이터 형식] [변수 이름1];
             *        [데이터 형식] [변수 이름2];
             *        [데이터 형식] [변수 이름3];
             *   }
             *   
             *   여기에서 구조체 이름은 새로운 데어터 형식이 되며, 변수를 선언할 때 구조체 이름을 사용할 수 있다. 
             *   구조체를 가리켜 사용자 정의 데이터 타입이라고도 한다.
             *   
             */
            Point point;   // Point 구조체 형식의 변수 선언
            point.x = 100;
            point.y = 200;
            point.myNewNumber = 01088684457;
            Console.WriteLine($"x, y 좌표는 {point.x} {point.y}");

            /*
             * 구조체를 선언할 때는 struct 키워드를 사용한다.여기에서는 struct Point {} 형태로 이름이
             * Point인 구조체를 만들었다. 만든 구조체는 int, string 형식의 변수 선언과 동일한 방법으로
             * 선언한 후 사용할 수 있다. 변수는 값을 하나만 저장하지만, 구조체는 점(.)으로 구분하여 구조체를 
             * 선언할 때 사용한 변수 여러 개를 이름 하나(point)로 묶어 쓸 수 있다.
             */
            BusinessCard businesscard;
            businesscard.age = 26;
            businesscard.adress = "서울시";
            businesscard.name = "박난주";

            BusinessCard[] cards = new BusinessCard[5];
            cards[0].age= 26;
            cards[0].name = "박난주";
            cards[1].adress= "서울시";

            int[] numbers = new int[5];

            /*
             * 내장형 구조체
             * 닷넷 프레임워크에서 이미 내장(Built-in)된 구조체 중에서 날짜 처리를 전담하는 DateTime과
             * TimeSpan 구조체, 문자 관련 처리를 담당하는 char 구조체를 자주 사용한다.
             *  - DateTime 구조체: 시간/날짜 관련 모든 정보를 제공
             *  - TimeSpan 구조체: 시간/날짜 간격에 대한 모든 정보를 제공
             *  - char 구조체: 문자 관련 모든 정보를 제공, 예를 들어 특정 문자가 숫자 형식인지 기호 문자인지
             *                공백 문자인지 등을 판단하는 기능을 제공
             */
            Console.WriteLine($"DateTime now 하면 뭐가 나오나? {DateTime.Now}");
            Console.WriteLine($"DateTime now 하면 뭐가 나오나? {DateTime.Now.Year}");
            Console.WriteLine($"DateTime now 하면 뭐가 나오나? {DateTime.Now.Month}");
            Console.WriteLine($"DateTime now 하면 뭐가 나오나? {DateTime.Now.Day}");
            Console.WriteLine($"DateTime now 하면 뭐가 나오나? {DateTime.Now.Hour}");
            Console.WriteLine($"DateTime now 하면 뭐가 나오나? {DateTime.Now.Minute}");
            Console.WriteLine($"DateTime now 하면 뭐가 나오나? {DateTime.Now.Second}");


            /*
             * 열거형 형식 사용하기
             * C#에서 열거형(Enumeration) 형식은 기억하기 어려운 상수들을 기억하기 쉬운 이름 하나로 묶어
             * 관리하는 표현 방식이다. 일반적으로 열거형을 줄여 말한다. 열거형을 사용하면 값 리스트 여러 개를 
             * 이름 하나로 관리할 수 있는 장점이 있다. 열거형은 enum 키워드를 사용하고, 이늄 또는 이넘으로 
             * 읽는다.
             */

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Green");
            //Console.WriteLine("Green");
            //Console.WriteLine("Green");
            //Console.WriteLine("Green");
            //Console.ResetColor();
            
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Blue 아하 여기가 색이 바뀌는 거군");
            Console.ResetColor();

            weekday myweekday;
            myweekday = weekday.WEDNESDAY;

            // 열거형 예제 실습
            Animal animal = Animal.DOG;

            switch (animal)
            {
                case Animal.CHICKEN:
                    Console.WriteLine("닭은 꼬끼오 하고 운다.");
                    break;
                case Animal.DOG:
                    Console.WriteLine("개은 멍멍 하고 운다.");
                    break;
                case Animal.PIG:
                    Console.WriteLine("돼지는 꿀꿀 하고 운다.");
                    break;
                default:
                    Console.WriteLine("[system] 처리되지 않은 예외 입력입니다.");
                    break;
            }
        }
    }
}