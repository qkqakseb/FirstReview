using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatisDelegate
{
    internal class Description
    {
        // void 리턴타입과, 매개변수를 받지 않는 함수를 저장할 수 있는 
        // 데이터 타입을 선언한 것 , 함수에다가 변수를 담았다.

        //delegate float SayDelegate(int int float);
        delegate void SayDelegate();
        //delegate bool SayDelegate();
        
        public void DelegateDasc()
        {
            SayDelegate sayDelegate = Hi;
            sayDelegate.Invoke();
        }  // DeleagateDasc()
        public void Hi()
        {
            Console.WriteLine("안녕하세요");
        }
    }
}
