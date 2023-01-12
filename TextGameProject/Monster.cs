using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameProject
{
    public class Monster
    {
        public string name;
        public List<string> image = new List<string>();
        public int hp;
        public int damage;
        protected int money = 100;
        protected int[] item;
        protected int inputMonster;
        public int increaseHp;
        public int monGetMoney;


        public void Mster()
        {

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
            Console.WriteLine();
            Console.WriteLine();
        }

        #region 몬스터의 정보를 가져오는 함수
        public string GetName()
        {
            return this.name;
        }
        public List<string> GetImage()
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
        #endregion      // 몬스터의 정보를 가져오는 함수

        public void MonHit(int damage)
        {

            hp = hp - damage;
        }
    }

    public class Slime : Monster
    {
        public Slime() 
        {
            this.image.Add("                         @@@            ");
            this.image.Add("        @@@            @     @          ");
            this.image.Add("       @   @          @@      @         ");
            this.image.Add("       @   @         @  @      @        ");
            this.image.Add("       @  @          @  @      @        ");
            this.image.Add("        @ @         @    @      @       ");
            this.image.Add("        @         @       @     @       ");
            this.image.Add("        @       @           @  .@       ");
            this.image.Add("        @     @               @         ");
            this.image.Add("         @. @                   @       ");
            this.image.Add("         @                       @      ");
            this.image.Add("       @   @@        @ @          @     ");
            this.image.Add("      @   @★@      @ ★ @         @    ");
            this.image.Add("     @    @  @      @    @          @   ");
            this.image.Add("     @     @@        @ @            @   ");
            this.image.Add("     @                              @   ");
            this.image.Add("     @                              @   ");
            this.image.Add("      @                             @   ");
            this.image.Add("       @                           @    ");
            this.image.Add("        @                         @     ");
            this.image.Add("         @                       @      ");
            this.image.Add("           @                    @       ");
            this.image.Add("             @                @         ");
            this.image.Add("               @@@@@@@@@@@@@            ");
            this.name = "슬라임";
            this.hp = 20;
            this.damage = 1;
            this.item = new int[6] {0,1,2,3,4,5};
            this.monGetMoney = 1;
            this.increaseHp = 20;
        }
    }
    public class Oak : Monster 
    {
        public Oak()
        {
            this.image.Add("                       ;=#@#*:          ");
            this.image.Add("        ::-           :;,   ,;!         ");
            this.image.Add("       -   ,         ~*,      :*        ");
            this.image.Add("      -:   .        =:  ,      #        ");
            this.image.Add("       =  -         ,:  :      ~~       ");
            this.image.Add("        * :        ~:    !      @       ");
            this.image.Add("        -        =-       $    ,@       ");
            this.image.Add("        $     ;:~~         ,;  ,@       ");
            this.image.Add("        ;*  ~!,~             ~,*:       ");
            this.image.Add("         *=                   !$        ");
            this.image.Add("         !                      =       ");
            this.image.Add("        :: ;$!      -,-,         ,      ");
            this.image.Add("        ~ $ !=:     :=#;         #      ");
            this.image.Add("       :, ;$@:      =,,#         #      ");
            this.image.Add("       #,           $~=#         ,      ");
            this.image.Add("       #,                        -      ");
            this.image.Add("       #,                        ,,     ");
            this.image.Add("        ~-                       #      ");
            this.image.Add("        -                       ,=      ");
            this.image.Add("        !,                      :       ");
            this.image.Add("         !                     !-       ");
            this.image.Add("          *,                   =        ");
            this.image.Add("           ::;,             ;:          ");
            this.image.Add("              **--~~~-,!=*              ");
            this.name = "오크";
            this.hp = 20;
            this.damage = 2;
            this.item = new int[6] { 0, 1, 2, 3, 4, 5 };
            this.monGetMoney = 2;
            this.increaseHp = 20;
        }
    }
    public class Zombie : Monster
    {
        public Zombie()
        {
            this.image.Add("                       ;=#@#*:          ");
            this.image.Add("        ::-           :;,   ,;!         ");
            this.image.Add("       -   ,         ~*,      :*        ");
            this.image.Add("      -:   .        =:  ,      #        ");
            this.image.Add("       =  -         ,:  :      ~~       ");
            this.image.Add("        * :        ~:    !      @       ");
            this.image.Add("        -        =-       $    ,@       ");
            this.image.Add("        $     ;:~~         ,;  ,@       ");
            this.image.Add("        ;*  ~!,~             ~,*:       ");
            this.image.Add("         *=                   !$        ");
            this.image.Add("         !                      =       ");
            this.image.Add("        :: ;$!      -,-,         ,      ");
            this.image.Add("        ~ $ !=:     :=#;         #      ");
            this.image.Add("       :, ;$@:      =,,#         #      ");
            this.image.Add("       #,           $~=#         ,      ");
            this.image.Add("       #,                        -      ");
            this.image.Add("       #,                        ,,     ");
            this.image.Add("        ~-                       #      ");
            this.image.Add("        -                       ,=      ");
            this.image.Add("        !,                      :       ");
            this.image.Add("         !                     !-       ");
            this.image.Add("          *,                   =        ");
            this.image.Add("           ::;,             ;:          ");
            this.image.Add("              **--~~~-,!=*              ");
            this.name = "좀비";
            this.hp = 30;
            this.damage = 3;
            this.item = new int[6] { 0, 1, 2, 3, 4, 5 };
            this.monGetMoney = 3;
            this.increaseHp = 30;
        }
    }
    public class Wolf : Monster 
    {
        public Wolf()
        {

            this.image.Add("                       ;=#@#*:          ");
            this.image.Add("        ::-           :;,   ,;!         ");
            this.image.Add("       -   ,         ~*,      :*        ");
            this.image.Add("      -:   .        =:  ,      #        ");
            this.image.Add("       =  -         ,:  :      ~~       ");
            this.image.Add("        * :        ~:    !      @       ");
            this.image.Add("        -        =-       $    ,@       ");
            this.image.Add("        $     ;:~~         ,;  ,@       ");
            this.image.Add("        ;*  ~!,~             ~,*:       ");
            this.image.Add("         *=                   !$        ");
            this.image.Add("         !                      =       ");
            this.image.Add("        :: ;$!      -,-,         ,      ");
            this.image.Add("        ~ $ !=:     :=#;         #      ");
            this.image.Add("       :, ;$@:      =,,#         #      ");
            this.image.Add("       #,           $~=#         ,      ");
            this.image.Add("       #,                        -      ");
            this.image.Add("       #,                        ,,     ");
            this.image.Add("        ~-                       #      ");
            this.image.Add("        -                       ,=      ");
            this.image.Add("        !,                      :       ");
            this.image.Add("         !                     !-       ");
            this.image.Add("          *,                   =        ");
            this.image.Add("           ::;,             ;:          ");
            this.image.Add("              **--~~~-,!=*              ");
            this.name = "늑대";
            this.hp = 35;
            this.damage = 4;
            this.item = new int[6] { 0, 1, 2, 3, 4, 5 };
            this.monGetMoney = 4;
            this.increaseHp = 35;
        }
    }
}
