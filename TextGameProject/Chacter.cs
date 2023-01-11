using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameProject
{
    public class Characters
    {
        public string name;
        //public string image;
        public List<string> image = new List<string>();
        public int hp;
        public int damage;
        public int money = 100;
        public string item;
        public int increaseHp;
        public List<int> inventory;
   

        public void Chter ()
        {

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
        #endregion      // 캐릭터의 정보를 가져오는 함수

        // 캐릭터가 공격
        public void ChHit(int damage)
        {
            
            hp = hp - damage;
        }
    }

    public class Bazzi : Characters
    {
        public Bazzi() 
        {
            this.image.Add("   @***$#;~                  ~@@#=**$   ");
            this.image.Add("  @       @=~#$$~@@@@@@~$##~=@#      @  ");
            this.image.Add(" $         @                 @        @ ");
            this.image.Add("@       @                     @        @");
            this.image.Add("@      $                       $       @");
            this.image.Add("@     #                          @     @");
            this.image.Add(" @   @                            @    @");
            this.image.Add(" @  @                              @   @");
            this.image.Add(" @ @                                @ @ ");
            this.image.Add("  @#                                @@  ");
            this.image.Add(" ;@                                  @  ");
            this.image.Add(" *@           ,@@@@@@@@@:,          -@, ");
            this.image.Add(" *@         =@#==@;;;;*==#@~         @* ");
            this.image.Add(" #$       @#~=@##*;;;;**$@$~$~       @# ");
            this.image.Add(" #*     :$=@=@@@@**==*=@*@@=@=;      =@ ");
            this.image.Add(" #*    ~$=*;     *-  ;=-    :*=;     =@ ");
            this.image.Add(" $=    *$#:       @  *-      -##:    ## ");
            this.image.Add(" @@   ~@-;-        $#:        ~~#    @* ");
            this.image.Add("  @   **=:,        *@:        ,~$,  ,@  ");
            this.image.Add("  @*  $@#:,        -;:         =@@  ;#  ");
            this.image.Add("  =$  $@@=======================@*  #=  ");
            this.image.Add("   @* $@*,     @   $;   @      ,=~ =@   ");
            this.image.Add("   *@  #-~        ,=#         * @  @*   ");
            this.image.Add("    =@;$@=~       *  =       -:#;-@@:   ");
            this.image.Add("     =@@#@*:    ~@    $-    :@=*-@@     ");
            this.image.Add("     @=@;$$;$$=$@      =$=$#;@=~#:      ");
            this.image.Add("        @@;                 =,@#        ");
            this.image.Add("         #@$               #$@#         ");
            this.image.Add("          #:!@@#========#@@!:#          ");
            this.name = " 배찌";
            this.hp = 30;
            this.damage = 3;
            this.item = "";
            this.increaseHp = 30;
            this.inventory = new List<int>();
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
        }
        
    }

    public class Dao : Characters
    {
        public Dao() 
        {
            this.image.Add(",,:!***$#;~.,.,~;;;;;;;;~,,,,~!@#=**$:,,");
            this.image.Add(".;!......=@=~#$$~......~$##~=@#::::-.:=,");
            this.image.Add(":$........=@-..............*@$::::::-.!:");
            this.image.Add("*:......*@-.................,;@$::::~..#");
            this.image.Add("@:-...,$:......................$#;::~..@");
            this.image.Add("@::-.-#:........................;@!:-..@");
            this.image.Add("@!::;@~..........................~@;...@");
            this.image.Add("!@::@:............................,@-.#!");
            this.image.Add(":@=#=:...........      ............=$;@;");
            this.image.Add(";=@#::.......              .........@@!;");
            this.image.Add(";;#*::,....       .,,.       .......;#~~");
            this.image.Add("!*@::::..    .,!@@@@@@@@:,    ......-@,-");
            this.image.Add("!*@::::-   .=@#==!;;;;*==#@~.  ......@*:");
            this.image.Add("!#$::::~..!#~=@##*;;;;**$@$~$~  .....@#~");
            this.image.Add(":#*::::-:$=!=!!!@**==*=@*!!=!=;  ....=@:");
            this.image.Add("-#*:::~~$=*;.....*-..;=-....:*=; ....=@;");
            this.image.Add(":$=:::~*$#:.......! .*-......-##: ...##!");
            this.image.Add(";!@:::~@-;-........$#:........~~#....@*;");
            this.image.Add(";;@:::**=:,........*!:........,~$,..,@::");
            this.image.Add(";;@*::$!#:,........-;:.........=!!..;#::");
            this.image.Add(";;=$::$!@!!!**#@@=$#==$@@#$$$$$=!*..#=:;");
            this.image.Add("::;@*:$!*,    !@.  $;  #@-    .,=~.=@!!!");
            this.image.Add(";;;*@::#-~        ,=#.        *.@..@*!!;");
            this.image.Add(";::;=@;$!=~       * ,=.      -:#;-@!:~~:");
            this.image.Add(":;;;:=@!#!*:    ~!,@$~$-    :!=*-@!..-;:");
            this.image.Add(":::::!=@;$$;$$=$!  $=  =$=$#;@=~#:,,--~:");
            this.image.Add(":;:::::;@@;@@;......    .,#@=,@#-.  ... ");
            this.image.Add(":;;:::::#@$@#!;=######@$;:;$#$@#-,,.  ..");
            this.image.Add(";!;;;;;#*,~:!@@#========#@@!:,.*#,......");
            this.name = " 다오";
            this.hp = 35;
            this.damage = 4;
            this.item = "";
            this.increaseHp = 35;
            this.inventory = new List<int>();
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
        }
    }

    public class Dizni: Characters
    {
        public Dizni()
        {
            this.image.Add(",,:!***$#;~.,.,~;;;;;;;;~,,,,~!@#=**$:,,");
            this.image.Add(".;!......=@=~#$$~......~$##~=@#::::-.:=,");
            this.image.Add(":$........=@-..............*@$::::::-.!:");
            this.image.Add("*:......*@-.................,;@$::::~..#");
            this.image.Add("@:-...,$:......................$#;::~..@");
            this.image.Add("@::-.-#:........................;@!:-..@");
            this.image.Add("@!::;@~..........................~@;...@");
            this.image.Add("!@::@:............................,@-.#!");
            this.image.Add(":@=#=:...........      ............=$;@;");
            this.image.Add(";=@#::.......              .........@@!;");
            this.image.Add(";;#*::,....       .,,.       .......;#~~");
            this.image.Add("!*@::::..    .,!@@@@@@@@:,    ......-@,-");
            this.image.Add("!*@::::-   .=@#==!;;;;*==#@~.  ......@*:");
            this.image.Add("!#$::::~..!#~=@##*;;;;**$@$~$~  .....@#~");
            this.image.Add(":#*::::-:$=!=!!!@**==*=@*!!=!=;  ....=@:");
            this.image.Add("-#*:::~~$=*;.....*-..;=-....:*=; ....=@;");
            this.image.Add(":$=:::~*$#:.......! .*-......-##: ...##!");
            this.image.Add(";!@:::~@-;-........$#:........~~#....@*;");
            this.image.Add(";;@:::**=:,........*!:........,~$,..,@::");
            this.image.Add(";;@*::$!#:,........-;:.........=!!..;#::");
            this.image.Add(";;=$::$!@!!!**#@@=$#==$@@#$$$$$=!*..#=:;");
            this.image.Add("::;@*:$!*,    !@.  $;  #@-    .,=~.=@!!!");
            this.image.Add(";;;*@::#-~        ,=#.        *.@..@*!!;");
            this.image.Add(";::;=@;$!=~       * ,=.      -:#;-@!:~~:");
            this.image.Add(":;;;:=@!#!*:    ~!,@$~$-    :!=*-@!..-;:");
            this.image.Add(":::::!=@;$$;$$=$!  $=  =$=$#;@=~#:,,--~:");
            this.image.Add(":;:::::;@@;@@;......    .,#@=,@#-.  ... ");
            this.image.Add(":;;:::::#@$@#!;=######@$;:;$#$@#-,,.  ..");
            this.image.Add(";!;;;;;#*,~:!@@#========#@@!:,.*#,......");
            this.name = " 디지니";
            this.hp = 25;
            this.damage = 3;
            this.item = "";
            this.increaseHp = 25;
            this.inventory = new List<int>();
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
        }
    }

    public class Ethi : Characters
    {
        public Ethi()
        {
            this.image.Add(",,:!***$#;~.,.,~;;;;;;;;~,,,,~!@#=**$:,,");
            this.image.Add(".;!......=@=~#$$~......~$##~=@#::::-.:=,");
            this.image.Add(":$........=@-..............*@$::::::-.!:");
            this.image.Add("*:......*@-.................,;@$::::~..#");
            this.image.Add("@:-...,$:......................$#;::~..@");
            this.image.Add("@::-.-#:........................;@!:-..@");
            this.image.Add("@!::;@~..........................~@;...@");
            this.image.Add("!@::@:............................,@-.#!");
            this.image.Add(":@=#=:...........      ............=$;@;");
            this.image.Add(";=@#::.......              .........@@!;");
            this.image.Add(";;#*::,....       .,,.       .......;#~~");
            this.image.Add("!*@::::..    .,!@@@@@@@@:,    ......-@,-");
            this.image.Add("!*@::::-   .=@#==!;;;;*==#@~.  ......@*:");
            this.image.Add("!#$::::~..!#~=@##*;;;;**$@$~$~  .....@#~");
            this.image.Add(":#*::::-:$=!=!!!@**==*=@*!!=!=;  ....=@:");
            this.image.Add("-#*:::~~$=*;.....*-..;=-....:*=; ....=@;");
            this.image.Add(":$=:::~*$#:.......! .*-......-##: ...##!");
            this.image.Add(";!@:::~@-;-........$#:........~~#....@*;");
            this.image.Add(";;@:::**=:,........*!:........,~$,..,@::");
            this.image.Add(";;@*::$!#:,........-;:.........=!!..;#::");
            this.image.Add(";;=$::$!@!!!**#@@=$#==$@@#$$$$$=!*..#=:;");
            this.image.Add("::;@*:$!*,    !@.  $;  #@-    .,=~.=@!!!");
            this.image.Add(";;;*@::#-~        ,=#.        *.@..@*!!;");
            this.image.Add(";::;=@;$!=~       * ,=.      -:#;-@!:~~:");
            this.image.Add(":;;;:=@!#!*:    ~!,@$~$-    :!=*-@!..-;:");
            this.image.Add(":::::!=@;$$;$$=$!  $=  =$=$#;@=~#:,,--~:");
            this.image.Add(":;:::::;@@;@@;......    .,#@=,@#-.  ... ");
            this.image.Add(":;;:::::#@$@#!;=######@$;:;$#$@#-,,.  ..");
            this.image.Add(";!;;;;;#*,~:!@@#========#@@!:,.*#,......");
            this.name = " 에띠";
            this.hp = 20;
            this.damage = 2;
            this.item = "";
            this.increaseHp = 20;
            this.inventory = new List<int>();
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
            inventory.Add(0);
        }
    }




}
