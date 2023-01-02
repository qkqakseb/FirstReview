using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsInterface
{
    internal class Description
    {
       
    }
    
    interface ICar  
    {

        void Go();   // 자동차가 앞으로 가라고 지시하는 함수
        /* public void Go()
         * {
                //기존에는 뭔가 내용을 정의 했다
                Console.WriteLine("자동차가 앞으로 간다.");
           }
        */
    }
    class Car : ICar
    {
        public virtual void Go()
        {
            Console.WriteLine("자동차가 앞으로 간다.");
            Console.WriteLine("{0}", "인터페이스를 사용할 때는 정의된 모든 멤버를 반드시 구현해야 한다.");
        }
    }

    class Sonate : Car
    {
        public override void Go()
        {
            base.Go();
            Console.WriteLine("소나타가 앞으로 간다.");
        }  // 정의한 부분이고 상당히 구체적
    }

    interface IAnimal
    {
        void Eat();
    }

    interface IDog
    {
        void Yelp();
    }

    class Dog : IAnimal, IDog
    {
        public void Eat()
        {
            Console.WriteLine("먹다");
        }

        public void Yelp()
        {
            Console.WriteLine("짖다");
        }
    }
}
