using System;

namespace WhatIsParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Description desc= new Description();

            //int number1 = 10;
            //int number2 = 20;

            ///*desc.valueTypeParam(number1, number2);*/   
            /*desc.reftypeparam(ref number1, ref number2);*/ // 레퍼런스 타입  

            //Console.WriteLine("[Main] first : {0}, second: {1}", number1, number2);

            //int number;
            //desc.OutTypeRaram(out number);
            //Console.WriteLine("[Main] number : {0}", number);

            //string strNumber = "100";
            //int intNumber;
            //int.TryParse(strNumber, out intNumber);
            //Console.WriteLine("{0}", intNumber + 10); // 정상적으로 int로 나옴 아니면 0으로 나온다.

            desc.FlexibleTypeParam(1, 2, 3, 10, 40, 100 );
        }
    }
}