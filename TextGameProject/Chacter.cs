using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameProject
{
    public class Chacter
    {
        protected string name;
        protected string image;
        protected int hp;
        protected int damage;
        protected int money = 100;
        protected string item;
        protected int chattack;
        protected int inputNumber;

        public void User()
        {
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(" 당신의 캐릭터를 선택해주세요~! (1. 배찌   2. 다오  3. 디지니  4. 에띠)");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            
            Console.WriteLine($"1. 배찌 : 게으르고 잠이 많은 장난꾸러기 항상 사고를 치고 다닌다.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"2.다오 : 정의롭고 착한 의리남 불의를 보면 못참는다.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"3. 디지니 : 말이 없고 부끄럼이 많은 수줍음쟁이 혼자 놀기를 좋아한다.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"4. 에띠 : 늘 책을 끼고 사는 공부벌레 아는건 많지만 헛똑똑이다.");
        }

        #region 캐릭터의 정보를 가져오는 함수
        public string GetName()
        {
            return this.name;
        }
        public string GetImage()
        {
            return this.image;
        }
        public int GetHp() 
        {
            return this.hp;
        }
        public int GetDamage() 
        {
            return this.damage;
        }
        #endregion      // 캐릭터의 정보를 가져오는 함수
    }

    public class Bazzi : Chacter
    {
        public Bazzi() 
        {
            this.image = "（＠º○º＠）";
            this.name = " 배찌";
            this.hp = 30;
            this.damage = 3;
            this.item = "";
            this.chattack = 0;

            //Console.WriteLine($"1.              {this.chName}");
            //Console.WriteLine($"                {this.chImage}");
            //Console.WriteLine("게으르고 잠이 많은 장난꾸러기 항상 사고를 치고 다닌다.");
        }
        
    }

    public class Dao : Chacter 
    {
        public Dao() 
        {
            this.image = "（０∇０）";
            this.name = " 다오";
            this.hp = 35;
            this.damage = 4;
            this.item = "";
            this.chattack = 0;

            //Console.WriteLine($"2.         {this.chName}");
            //Console.WriteLine($"           {this.chImage}");
            //Console.WriteLine("정의롭고 착한 의리남 불의를 보면 못참는다.");
        }
    }

    public class Dizni: Chacter
    {
        public Dizni()
        {
            this.image = "（.＞ｗ＜.）";
            this.name = " 디지니";
            this.hp = 25;
            this.damage = 1;
            this.item = "";
            this.chattack = 0;

            //Console.WriteLine($"3.                  {this.chName}");
            //Console.WriteLine($"                    {this.chImage}");
            //Console.WriteLine("말이 없고 부끄럼이 많은 수줍음쟁이 혼자 놀기를 좋아한다.");
        }
    }

    public class Ethi : Chacter
    {
        public Ethi()
        {
            this.image = "［ ºㅿº？］";
            this.name = " 에띠";
            this.hp = 20;
            this.damage = 2;
            this.item = "";
            this.chattack = 0;

            //Console.WriteLine($"4.                 {this.chName}");
            //Console.WriteLine($"                   {this.chImage}");
            //Console.WriteLine("늘 책을 끼고 사는 공부벌레 아는건 많지만 헛똑똑이다.");
        }
    }




}
