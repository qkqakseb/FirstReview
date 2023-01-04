using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsParameter
{
    internal class Description
    {
        public void ParameterDesc()
        {

        } // ParameterDesc()
        public void valueTypeParam(int firstNumber, int secondNumber) // 형
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("first : {0}, second: {1}", firstNumber, secondNumber);  
        }
        
        public void RefTypeParam(ref int firstNumber, ref int secondNumber)   // 레퍼런스 타입
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("first : {0}, second: {1}", firstNumber, secondNumber);
        }

        public void OutTypeRaram(out int number)
        {
            number = 10;
        }

        public void FlexibleTypeParam(params int[] numbers)
        {
            foreach(int number in numbers)
            {
                Console.WriteLine("{0}", number);
            }
            Console.WriteLine();
        }
    }
}
