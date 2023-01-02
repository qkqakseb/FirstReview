using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsInterface
{
    internal class WhatIsCollection
    {
        public void CollectionDesc()
        {
       
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            inventory.Add("빨간 포션", 10);
            inventory.Add("강철 검", 1);
            
            List<int> intList= new List<int>();
            intList.Add(10);
            intList.Add(3);
            intList.Add(100);
            intList.Add(77);

            intList.Sort();
            intList.Reverse();

            foreach (int number in intList)
            {
                Console.WriteLine(number);
            }
            
         }
        struct Node
        {
            int _index;
            int number;
            int adressNext;
            int adressPrev;

        }
    }
}
