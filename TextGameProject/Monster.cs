using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameProject
{
    public class Monster
    {
        protected string name;
        protected string image;
        protected int hp;
        protected int damage;
        protected int money = 100;
        protected string item;
        protected int mstattack;


        public void Mster()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" 싸울 몬스터를 선택해주세요~!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. 슬라임 (와)과 싸우기");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("2. 오크 (와)과 싸우기");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("3. 좀비 (와)과 싸우기");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("4. 늑대 (와)과 싸우기");
        }
    }

    public class Slime : Monster
    {
        public Slime() 
        {
            this.image = "（∮ｗ∮）";
            this.name = "슬라임";
            this.hp = 20;
            this.damage = 1;
            this.item = "";
            this.mstattack = 0;
        }
    }
    public class Oak : Monster 
    {
        public Oak()
        {
            this.image = "（▶㈂◀）";
            this.name = "오크";
            this.hp = 20;
            this.damage = 2;
            this.item = "";
            this.mstattack = 0;
        }
    }
    public class Zombie : Monster
    {
        public Zombie()
        {
            this.image = "（⊙□⊙）";
            this.name = "좀비";
            this.hp = 30;
            this.damage = 3;
            this.item = "";
            this.mstattack = 0;
        }
    }
    public class Wolf : Monster 
    {
        public Wolf()
        {

            this.image = "（＾．㉦ ．＾）";
            this.name = "늑대";
            this.hp = 35;
            this.damage = 4;
            this.item = "";
            this.mstattack = 0;
        }
    }
}
