using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public class Welcome
    {
        public bool SwordSet;
        public string NameSet;
        public int HungerSet;
        public bool ElfSet;

        public Welcome(bool SwordSet, string NameSet, int HungerSet, bool ElfSet)
        {
            this.SwordSet = SwordSet;
            this.NameSet = NameSet;
            this.HungerSet = HungerSet;
            this.ElfSet = ElfSet;
        }

        //SOME QUICK CONDITIONAL SWITCHES
        public void SwordSetOn()
        {
            SwordSet = true;
        }
        public void SwordSetOff()
        {
            SwordSet = false;
        }
        public void ElfSetOn()
        {
            ElfSet = true;
        }
        public void ElfSetOff()
        {
            ElfSet = false;
        }


        //THE GAME BEGINS
        public void WelcomeFirst()
        {
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine(@"   /\                                                        /\");
            Console.WriteLine(@"  |  |                  WELCOME TO THE GAME                 |  |");
            Console.WriteLine(@" /----\      Type you name and press 'enter' to begin      /----\");
            Console.WriteLine(@"[______]                                                  [______]");
            Console.WriteLine(@" |    |         _____                        _____         |    |");
            Console.WriteLine(@" |[]  |        [     ]                      [     ]        |  []|");
            Console.WriteLine(@" |    |       [_______][ ][ ][ ][][ ][ ][ ][_______]       |    |");
            Console.WriteLine(@" |    [ ][ ][ ]|     |  ,----------------,  |     |[ ][ ][ ]    |");
            Console.WriteLine(@" |             |     |/'    ____..____    '\|     |             |");
            Console.WriteLine(@"  \  []        |     |    /'    ||    '\    |     |        []  /");
            Console.WriteLine(@"   |      []   |     |   |o     ||     o|   |     |  []       |");
            Console.WriteLine(@"   |           |  _  |   |     _||_     |   |  _  |           |");
            Console.WriteLine(@"   |   []      | (_) |   |    (_||_)    |   | (_) |       []  |");
            Console.WriteLine(@"   |           |     |   |     (||)     |   |     |           |");
            Console.WriteLine(@"   |           |     |   |      ||      |   |     |           |");
            Console.WriteLine(@" /''           |     |   |o     ||     o|   |     |           ''\");
            Console.WriteLine(@"[_____________[_______]--'------''------'--[_______]_____________]");
            Console.WriteLine("\n\n\n ");


            this.NameSet = Console.ReadLine();
        }
        public void WelcomeSecond()
        {
            Console.WriteLine("Hello, {0}! You are about to begin your journey. \nBe careful! There is danger everywhere...", NameSet);
            Console.WriteLine("Press 'enter' to begin");
            Console.ReadLine();
            Console.Clear();
        }

        //RANDOM START GENERATOR
        public void SplitOne()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            if (randomNumber == 1)
            {
                WakeUpOne();
            }
            else if (randomNumber == 2)
            {
                WakeUpTwo();
            }
            else if (randomNumber == 0)
            {
                WakeUpThree();
            }

        }

        //WAKE UP SEQUENCE
        public void WakeUpOne()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine(@"                   \       /            _\/_");
            Console.WriteLine(@"                     .-'-.              //o\  _\/_");
            Console.WriteLine(@"  _  ___  __  _ --_ /     \ _--_ __  __ _ | __/o\\ _");
            Console.WriteLine(@"=-=-_=-=-_=-=_=-_= -=======- = =-=_=-=_,-'|''''''-|-,_");
            Console.WriteLine(@" =- _=-=-_=- _=-= _--=====- _=-=_-_,-     | ");
            Console.WriteLine(@"=- =- =-= =- = -  -===- -= - .''");
            Console.WriteLine("\n\n");
            Console.WriteLine("You are woken up by an intense pain in your stomach. \nRolling over in pain, you spit out a mouthful of seawater, look\naround at a gray landscape to realize you're laying on a beach.\nYou don't have any idea where you are, just that \nyour name is {0} and that you need food. Badly. \n \nIt's time to get going. \nYou decide you ony really have three options: \n 'Start walking' down a nearby path, 'look around' the beach, \nor 'wait' here for help to come.", NameSet);
            string input = Console.ReadLine();
            Console.Clear();
            if (input.ToLower() == "start walking")
            {
                OldManOne();
            }
            else if (input.ToLower() == "wait")
            {
                Console.WriteLine("You waited too long! For what? I don't know. \n\n\nBut you died. \n\n\nBummer dude.\n\n\n ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"     .... NO! ...                  ... MNO! ...");
                Console.WriteLine(@"   ..... MNO!! ...................... MNNOO! ...");
                Console.WriteLine(@" ..... MMNO! ......................... MNNOO!! .");
                Console.WriteLine(@".... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .");
                Console.WriteLine(@" ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....");
                Console.WriteLine(@"    ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...");
                Console.WriteLine(@"   ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....");
                Console.WriteLine(@"   ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...  ");
                Console.WriteLine(@"    ....... MMMMM..    OPPMMP    .,OMI! ....");
                Console.WriteLine(@"     ...... MMMM::   o.,OPMP,.o   ::I!! ...");
                Console.WriteLine(@"         .... NNM:::.,,OOPM!P,.::::!! ....");
                Console.WriteLine(@"          .. MMNNNNNOOOOPMO!!IIPPO!!O! .....");
                Console.WriteLine(@"         ... MMMMMNNNNOO:!!:!!IPPPPOO! ....");
                Console.WriteLine(@"           .. MMMMMNNOOMMNNIIIPPPOO!! ......");
                Console.WriteLine(@"       ....... MN MOMMMNNNIIIIIO! OO ..........");
                Console.WriteLine(@"    ......... MNO! IiiiiiiiiiiiI OOOO ...........");
                Console.WriteLine(@"  ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........");
                Console.WriteLine(@"   .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........");
                Console.WriteLine(@"   ...... MNNNNO! .. PPPPPPPPP .. MMNON!........");
                Console.WriteLine(@"      ...... OO! ................. ON! .......");
                Console.WriteLine(@"         ................................");

            }
            else if (input.ToLower() == "look around")
            {
                LookAroundOne();
            }
        }
        public void WakeUpTwo()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine(@"                   \       /            _\/_");
            Console.WriteLine(@"                     .-'-.              //o\  _\/_");
            Console.WriteLine(@"  _  ___  __  _ --_ /     \ _--_ __  __ _ | __/o\\ _");
            Console.WriteLine(@"=-=-_=-=-_=-=_=-_= -=======- = =-=_=-=_,-'|''''''-|-,_");
            Console.WriteLine(@" =- _=-=-_=- _=-= _--=====- _=-=_-_,-     | ");
            Console.WriteLine(@"=- =- =-= =- = -  -===- -= - .''");
            Console.WriteLine("\n\n");
            Console.WriteLine("You are woken up by a cold wave hitting you legs. \nRolling over in pain, you spit out a mouthful of seawater, look\naround at a gray landscape to realize you're laying on a beach.\nYou don't have any idea where you are, just that \nyour name is {0} and that you need food. Badly. \n \nIt's time to get going. \nYou decide you ony really have two options: \n 'Start walking' down a nearby path, or 'look around' the beach.", NameSet);
            string input = Console.ReadLine();
            Console.Clear();
            if (input.ToLower() == "start walking")
            {
                OldManOne();
            }

            else if (input.ToLower() == "look around")
            {
                LookAroundOne();
            }
        }
        public void WakeUpThree()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine(@"                   \       /            _\/_");
            Console.WriteLine(@"                     .-'-.              //o\  _\/_");
            Console.WriteLine(@"  _  ___  __  _ --_ /     \ _--_ __  __ _ | __/o\\ _");
            Console.WriteLine(@"=-=-_=-=-_=-=_=-_= -=======- = =-=_=-=_,-'|''''''-|-,_");
            Console.WriteLine(@" =- _=-=-_=- _=-= _--=====- _=-=_-_,-     | ");
            Console.WriteLine(@"=- =- =-= =- = -  -===- -= - .''");
            Console.WriteLine("\n\n");
            Console.WriteLine("You are woken up by a faint animal noise.  \nRolling over in pain, you spit out a mouthful of seawater, look\naround at a gray landscape to realize you're laying on a beach.\nYou don't have any idea where you are, just that \nyour name is {0} and that you need food. Badly. \n \nYou remeber the noise you heard as you struggle to stand \nYou decide to find out what the noise was. \n\n press 'enter' to move forward", NameSet);
            Console.ReadLine();
            Console.Clear();
            HorseOne();
        }

        //FIRST MOVES


        public void LookAroundOne()
        {
            HorseOne();
        }

        public void HorseOne()
        {

            Console.WriteLine("\n\n");
            Console.WriteLine(@"                                 |\    /|");
            Console.WriteLine(@"                                 |\    /|");
            Console.WriteLine(@"                           ---__/ \/    \");
            Console.WriteLine(@"                          __--/     (D)  \");
            Console.WriteLine(@"                          _ -/    (_      \");
            Console.WriteLine(@"                         // /       \_ /  -\");
            Console.WriteLine(@"   __-------_____--___--/           / \_ O o)");
            Console.WriteLine(@"  /                                 /   \__/");
            Console.WriteLine(@" /                                 /");
            Console.WriteLine(@"||          )                   \_/\");
            Console.WriteLine(@"||         /              _      /  |");
            Console.WriteLine(@"| |      /--______      ___\    /\  :");
            Console.WriteLine(@"| /   __-  - _/   ------    |  |   \ \");
            Console.WriteLine(@" |   -  -   /                | |     \ )");
            Console.WriteLine(@" |  |   -  |                 | )     | |");
            Console.WriteLine(@"  | |    | |                 | |    | |");
            Console.WriteLine(@"  | |    < |                 | |   |_/");
            Console.WriteLine(@"  < |    /__\                <  \");
            Console.WriteLine(@"  /__\                       /___\");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("You found a horse! It has saddle bags filled with food \nand you're too hungry to care who it belongs to.\nOnce you've had your fill of food you decide you can either\nmount the horse and 'ride' down a nearby path or \nyou can continue too 'look around' the beach. ");
            string input = Console.ReadLine();
            Console.Clear();
            if (input.ToLower() == "look around")
            {
                Console.WriteLine("\n\n\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"     .... NO! ...                  ... MNO! ...");
                Console.WriteLine(@"   ..... MNO!! ...................... MNNOO! ...");
                Console.WriteLine(@" ..... MMNO! ......................... MNNOO!! .");
                Console.WriteLine(@".... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .");
                Console.WriteLine(@" ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....");
                Console.WriteLine(@"    ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...");
                Console.WriteLine(@"   ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....");
                Console.WriteLine(@"   ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...  ");
                Console.WriteLine(@"    ....... MMMMM..    OPPMMP    .,OMI! ....");
                Console.WriteLine(@"     ...... MMMM::   o.,OPMP,.o   ::I!! ...");
                Console.WriteLine(@"         .... NNM:::.,,OOPM!P,.::::!! ....");
                Console.WriteLine(@"          .. MMNNNNNOOOOPMO!!IIPPO!!O! .....");
                Console.WriteLine(@"         ... MMMMMNNNNOO:!!:!!IPPPPOO! ....");
                Console.WriteLine(@"           .. MMMMMNNOOMMNNIIIPPPOO!! ......");
                Console.WriteLine(@"       ....... MN MOMMMNNNIIIIIO! OO ..........");
                Console.WriteLine(@"    ......... MNO! IiiiiiiiiiiiI OOOO ...........");
                Console.WriteLine(@"  ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........");
                Console.WriteLine(@"   .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........");
                Console.WriteLine(@"   ...... MNNNNO! .. PPPPPPPPP .. MMNON!........");
                Console.WriteLine(@"      ...... OO! ................. ON! .......");
                Console.WriteLine(@"         ................................");
                Console.WriteLine("\n\n");
                Console.WriteLine("Bad move {0}...\nYou were wandering around when suddenly the sun went down.\nIn the darkness, you were an easy snack for wolves. Bummer.\n\nYou died.", NameSet);
            }
            else if (input.ToLower() == "ride")
            {
                ForkOne();
            }
        }

        //OLD MAN SEQUENCE

        public void OldManOne()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine(@"                              z");
            Console.WriteLine(@"                             z");
            Console.WriteLine(@"                              Z");
            Console.WriteLine(@"                    .--.  Z Z");
            Console.WriteLine(@"                   / _(c\   .-.     __");
            Console.WriteLine(@"                  | / /  '-;   \'-'`  `\______");
            Console.WriteLine(@"                  \_\/'/ __/ )  /  )   |      \--,");
            Console.WriteLine(@"                  | \`""`__-/ .'--/   /--------\  \");
            Console.WriteLine(@"                   \\`  ///-\/   /   /---;-.    '-'");
            Console.WriteLine(@"                                (________\  \");
            Console.WriteLine(@"                                          '-'");
            Console.WriteLine("\n\n");
            Console.WriteLine("You walked down the path and found an old man with a horse  \ntied to a tree. He looks old, and you're still starving.  \nYou decide that your options are to 'attack' the old man \nto go through his things, 'steal' his horse and run, \nor 'wake' him up and talk. ");
            string input = Console.ReadLine();
            if (input.ToLower() == "attack")
            {
                Console.Clear();
                Console.WriteLine("\n\n\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"     .... NO! ...                  ... MNO! ...");
                Console.WriteLine(@"   ..... MNO!! ...................... MNNOO! ...");
                Console.WriteLine(@" ..... MMNO! ......................... MNNOO!! .");
                Console.WriteLine(@".... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .");
                Console.WriteLine(@" ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....");
                Console.WriteLine(@"    ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...");
                Console.WriteLine(@"   ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....");
                Console.WriteLine(@"   ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...  ");
                Console.WriteLine(@"    ....... MMMMM..    OPPMMP    .,OMI! ....");
                Console.WriteLine(@"     ...... MMMM::   o.,OPMP,.o   ::I!! ...");
                Console.WriteLine(@"         .... NNM:::.,,OOPM!P,.::::!! ....");
                Console.WriteLine(@"          .. MMNNNNNOOOOPMO!!IIPPO!!O! .....");
                Console.WriteLine(@"         ... MMMMMNNNNOO:!!:!!IPPPPOO! ....");
                Console.WriteLine(@"           .. MMMMMNNOOMMNNIIIPPPOO!! ......");
                Console.WriteLine(@"       ....... MN MOMMMNNNIIIIIO! OO ..........");
                Console.WriteLine(@"    ......... MNO! IiiiiiiiiiiiI OOOO ...........");
                Console.WriteLine(@"  ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........");
                Console.WriteLine(@"   .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........");
                Console.WriteLine(@"   ...... MNNNNO! .. PPPPPPPPP .. MMNON!........");
                Console.WriteLine(@"      ...... OO! ................. ON! .......");
                Console.WriteLine(@"         ................................");
                Console.WriteLine("\n\n");
                Console.WriteLine("Look out {0}! \nThe old man wakes up, and goes berzerk with rage.\nYou're so hungry that you couldn't put up much\nof a fight and died. Bummer.", NameSet);
            }
            else if (input.ToLower() == "steal")
            {
                Console.WriteLine("You made it away with his horse! \nAnd now you have this sweet horse! \nPress 'enter' to continue down the path");
                Console.ReadLine();
                Console.Clear();
                ForkOne();
            }
            else if (input.ToLower() == "wake")
            {
                Console.WriteLine("The old man wakes up, knowing you could have robbed him.\nHe tells you there's a place called hobbit hollow up ahead and \nthat you can find shelter and friends there. He also \nwarns you against entering the forest and gives you his horse \nfor not attacking him in his sleep. What luck! \nPress 'enter' to continue down the path");
                Console.ReadLine();
                Console.Clear();
                ForkOne();
            }

        }




        //SECOND MOVES. Fork in the road.
        public void ForkOne()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine(@"                     .--._..--.");
            Console.WriteLine(@"              ___   ( _'-_  -_.'");
            Console.WriteLine(@"          _.-'   `-._|  - :- |");
            Console.WriteLine(@"      _.-'           `--...__|");
            Console.WriteLine(@"   .-'                       '--..___");
            Console.WriteLine(@"  / `._       Hobbit Hollow -->      \");
            Console.WriteLine(@"   `. `._                             |");
            Console.WriteLine(@"     `. `._   <---Enchanted Forest   /");
            Console.WriteLine(@"       '. `._    :__________....-----'");
            Console.WriteLine(@"         `..`---'    |-_  _- |");
            Console.WriteLine(@"                     |-_  _- |");
            Console.WriteLine(@"     ;;;:::.         |-_  _- |");
            Console.WriteLine(@"         ..       ;::|   - _ |/)     ;;;:::.");
            Console.WriteLine(@"  (o)        ;;::.,  |_ -  - |;;;:");
            Console.WriteLine(@" (\'/)   ::;;   (o)  | -_  -_L     ``::;;;.");
            Console.WriteLine(@" .;;'         (\ '/) |  -_ _ G (o)  ..;;");
            Console.WriteLine(@"        '''    ;:;;.,|(o)  _-B(\'/)");
            Console.WriteLine(@"   ;;;;:::        ;::(\'/);;:|;:; ;'");
            Console.WriteLine("\n\n");
            Console.WriteLine("You arrive at a forK in the road. \nThere is a sign pointing Hobbit Hollow to your left and \nthe Echanted Forest to your right. To enter the hollow you \nmust leave your horse behind. Night is coming fast so you must \nchoose. Spend the night in 'Hobbit Hollow' or the 'Enchanted Forest'.");
            string input = Console.ReadLine();
            if (input.ToLower() == "hobbit hollow")
            {
                Console.WriteLine("You enter the hollow and hear music and laughter. \nEveryone in the hollow is extremely friendly, and they even \ngive you a small sword, citing that the path ahead \nwill be very dangerous. Press 'enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                SwordSetOn();
                ElfOne();
            }

            else if (input.ToLower() == "enchanted forest")
            {
                HorseTwo();
            }
        }

        public void HorseTwo()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine(@"            .        +          .      .          .");
            Console.WriteLine(@"     .            _        .                    .");
            Console.WriteLine(@"  ,              /;-._,-.____        ,-----.__");
            Console.WriteLine(@" ((        .    (_:#::_.:::. `-._   /:, /-._, `._,");
            Console.WriteLine(@"  `                 \   _|`  =:_::.`.);  \ __ / /");
            Console.WriteLine(@"                      ,    `./  \:. `.   )==-'  .");
            Console.WriteLine(@"    .      ., ,-=-.  ,\, +#./`   \:.  / /           .");
            Console.WriteLine(@".           \/:/`-' , ,\ '` ` `   ): , /_  -o");
            Console.WriteLine(@"       .    /:+- - + +- : :- + + -:'  /(o-) \)     .");
            Console.WriteLine(@"  .      ,=':  \    ` `/` ' , , ,:' `'--'.--'---._/`7");
            Console.WriteLine(@"   `.   (    \: \,-._` ` + '\, ,'   _, --._, ---':.__/");
            Console.WriteLine(@"              \:  `  X` _| _,\/'   .-'");
            Console.WriteLine(@".               ':._:`\____ /:'  /      .           .");
            Console.WriteLine(@"                    \::.  :\/:'  /              +");
            Console.WriteLine(@"   .                 `.:.  /:'  }      .");
            Console.WriteLine(@"           .           ):_(:;   \           .");
            Console.WriteLine(@"                      /:. _/ ,  |");
            Console.WriteLine(@"                   . (|::.     ,`                  .");
            Console.WriteLine(@"     .                |::.    {\");
            Console.WriteLine(@"                      |::.\  \ `.");
            Console.WriteLine(@"                      |:::(\    |");
            Console.WriteLine(@"              O       |:::/{ }  |                  (o");
            Console.WriteLine(@"               )  ___/#\::`/ (O ' ==._____   O, (O /`");
            Console.WriteLine(@"          ~~~w/w~'~~,\` `:/, -(~`'~~~~~~~~'~o~\~/ ~w |/ ~");
            Console.WriteLine(@"      ~~~~~~~~~~~~~~~~~~~~~~~\\W~~~~~~~~~~~~\|/~~");
            Console.WriteLine("\n\n");

            Console.WriteLine("The forest is dark and you cn barely see where the trail leads. \nYou have to sleep, and when you wake you find that your horse \nhas been mostly eaten by wolves. Now you're starving and don't\nhave a horse. \nBad day. \nNothing left to do but keep walking. \nPress 'enter' to continue ");
            string input = Console.ReadLine();
            Console.Clear();
            ElfOne();
        }


        //THIRD MOVES. Elf in the road

        public void ElfOne()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine(@"             ..-.--..");
            Console.WriteLine(@"           ,','.-`.-.`.");
            Console.WriteLine(@"          :.',;'     `.\.");
            Console.WriteLine(@"          ||//----,-.--\|");
            Console.WriteLine(@"        \`:|/-----`-'--||'/");
            Console.WriteLine(@"         \\|:    |:'|   |");
            Console.WriteLine(@"          `||      \   |!");
            Console.WriteLine(@"          |!|          ;|");
            Console.WriteLine(@"          !||:.   --  /|!");
            Console.WriteLine(@"         /||!||:.___.|!||\");
            Console.WriteLine(@"        /|!|||!|    |!||!\\:.");
            Console.WriteLine(@"     ,'//!||!||!`._.||!||,:\\\");
            Console.WriteLine(@"    : :: |!|||!| SSt|!||! |!::");
            Console.WriteLine(@"    | |! !||!|||`---!|!|| ||!|");
            Console.WriteLine(@"    | || |!|||!|    |!||! |!||");
            Console.WriteLine("\n\n");

            Console.WriteLine("After some time, you see an elf practicing sword work in the road. \nHe looks proficient, but threatening. You must decide \nif he will be an asset or a threat. Will you 'befriend' him, \nreturn to the 'forest' or sneak by and 'keep walking'?");
            string input = Console.ReadLine();
            if (input.ToLower() == "return to the forest")
            {
                /* DIE#3    */
                Console.Clear();
                Console.WriteLine("You starve, get weak, and get eaten by wolves. \n{0}, you should really have seen that coming. ", NameSet);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n");
                Console.WriteLine(@"     .... NO! ...                  ... MNO! ...");
                Console.WriteLine(@"   ..... MNO!! ...................... MNNOO! ...");
                Console.WriteLine(@" ..... MMNO! ......................... MNNOO!! .");
                Console.WriteLine(@".... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .");
                Console.WriteLine(@" ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....");
                Console.WriteLine(@"    ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...");
                Console.WriteLine(@"   ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....");
                Console.WriteLine(@"   ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...  ");
                Console.WriteLine(@"    ....... MMMMM..    OPPMMP    .,OMI! ....");
                Console.WriteLine(@"     ...... MMMM::   o.,OPMP,.o   ::I!! ...");
                Console.WriteLine(@"         .... NNM:::.,,OOPM!P,.::::!! ....");
                Console.WriteLine(@"          .. MMNNNNNOOOOPMO!!IIPPO!!O! .....");
                Console.WriteLine(@"         ... MMMMMNNNNOO:!!:!!IPPPPOO! ....");
                Console.WriteLine(@"           .. MMMMMNNOOMMNNIIIPPPOO!! ......");
                Console.WriteLine(@"       ....... MN MOMMMNNNIIIIIO! OO ..........");
                Console.WriteLine(@"    ......... MNO! IiiiiiiiiiiiI OOOO ...........");
                Console.WriteLine(@"  ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........");
                Console.WriteLine(@"   .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........");
                Console.WriteLine(@"   ...... MNNNNO! .. PPPPPPPPP .. MMNON!........");
                Console.WriteLine(@"      ...... OO! ................. ON! .......");
                Console.WriteLine(@"         ................................");
            }
            else if (input.ToLower() == "befriend")
            {
                Console.WriteLine("You slowly approach to avoid spooking him. \nYou explain your situation and he says he was heading in the same \ndirection, so you agree to travel together. \nPress 'enter' to continue down your path.");
                Console.ReadLine();
                Console.Clear();
                ElfSetOn();
                BridgeOne();
            }
            else if (input.ToLower() == "keep walking")
            {
                Console.Clear();
                BridgeOne();

            }
        }


        //FOURTH MOVE The Bridge

        public void BridgeOne()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine(@"       ,        ,          ,        ,   ");
            Console.WriteLine(@"  __.-'|'-.__.-'|'-._ __.-'|'-.__.-'|'-.");
            Console.WriteLine(@"  ='=====|========|=='=====|========|===");
            Console.WriteLine(@"  ~_^~-^~~_~^-^~-~~^~_^~-^~~_~^-^~-~~^~~");
            Console.WriteLine("\n\n");
            Console.WriteLine("You come to a clearing, and at the end there's a bridge \nover a massive ravine. It looks old and you're not sure \nif it will be safe. There's also a small path leading along \nthe edge of the ravine, you assume to lead to a safer crossing. \nNeither options seem like a sure bet, but you \n can either 'cross' the bridge or 'go around'");
            string input = Console.ReadLine();
            if (input.ToLower() == "go around")
            {
                DontCrossOne();
            }
            else if (input.ToLower() == "cross")
            {
                TrollOne();
            }
        }
        public void DontCrossOne()
        {
            Console.WriteLine("You travel for five days and find nothing. \nYou're at the tipping point with supplies. \nYou're worried that you might never find a safe crossing... \nbut will you 'turn around' or 'keep walking'?");
            string input = Console.ReadLine();
            if (input.ToLower() == "turn around")
            {
                Console.Clear();
                TrollOne();
            }
            else if (input.ToLower() == "keep walking")
            {
                Console.Clear();
                RobbersOne();
            }
        }


        //FIFTH MOVE PATH 1: The Troll
        public void TrollOne()
        {
            if (ElfSet == (true))
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine(@"               ___   /\   ___");
                Console.WriteLine(@"             ,' `.`-'..`-',' `.");
                Console.WriteLine(@"            (  |\ \      / /|  )");
                Console.WriteLine(@"             `.`|) : __ : (|','");
                Console.WriteLine(@"               \_  | -- |  _/");
                Console.WriteLine(@"              ( _`.|    |,'_ )");
                Console.WriteLine(@"               `.\ `.__,' /,'");
                Console.WriteLine(@"      _ __ _     `..____..'      _ __ _");
                Console.WriteLine(@"  ___(_(__)_\_____)/    \(______/_(__)_)____");
                Console.WriteLine(@" |    `|\|`|      \/)__(\/      |' |/|'     |");
                Console.WriteLine(@" |                 `- --'                   |");
                Console.WriteLine("\n\n");
                Console.WriteLine("Well, you're on a bridge, so there's a troll. Of course. \nYour companion says he's willing to fight it if you dont want, \nbut it might also be helpful to prove your own strength. You can \neither the troll 'alone' for let the 'elf fight' ");
                string input = Console.ReadLine();
                if (input.ToLower() == "alone")
                {
                    TrollTwo();
                }
                else if (input.ToLower() == "elf fight")
                {
                    Console.WriteLine("You run across the bridge, looking back just in time \nto see the elf get eaten. You're safe, but alone \nwhich is never a good thing. \nPress 'enter' to cut your losses and move down the path.");
                    Console.ReadLine();
                    Console.Clear();
                    ElfSetOff();
                    CrystalCityOne();

                }


            }
            else if (ElfSet == (false))
            {
                Console.WriteLine("Well, you're on a bridge, so there's a troll. Of course. \n You're cornered, so you have to fight. \nPress 'enter' to begin.");
                Console.ReadLine();
                Console.Clear();
                TrollTwo();
            }
        }

        public void TrollTwo()
        {
            if (SwordSet == true)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 11);
                if (randomNumber > 2)
                {
                    Console.WriteLine("You remembered you had  sword, and it probably saved your life. \n You look off in the distance and can see the vauge outline of a tower \nIt seems to be as good of a plan as any, so you head towards it. \nPress 'enter' to begin walking again.");
                    Console.ReadLine();
                    Console.Clear();
                    CrystalCityOne();
                }
                else if (randomNumber <= 2)
                {
                    /*DIE AGAIN*/

                    Console.WriteLine("Despite your sweet sword, you died. \nBummer {0}, I had a feeling you were almost there.", NameSet);
                    Console.WriteLine("\n\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"     .... NO! ...                  ... MNO! ...");
                    Console.WriteLine(@"   ..... MNO!! ...................... MNNOO! ...");
                    Console.WriteLine(@" ..... MMNO! ......................... MNNOO!! .");
                    Console.WriteLine(@".... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .");
                    Console.WriteLine(@" ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....");
                    Console.WriteLine(@"    ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...");
                    Console.WriteLine(@"   ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....");
                    Console.WriteLine(@"   ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...  ");
                    Console.WriteLine(@"    ....... MMMMM..    OPPMMP    .,OMI! ....");
                    Console.WriteLine(@"     ...... MMMM::   o.,OPMP,.o   ::I!! ...");
                    Console.WriteLine(@"         .... NNM:::.,,OOPM!P,.::::!! ....");
                    Console.WriteLine(@"          .. MMNNNNNOOOOPMO!!IIPPO!!O! .....");
                    Console.WriteLine(@"         ... MMMMMNNNNOO:!!:!!IPPPPOO! ....");
                    Console.WriteLine(@"           .. MMMMMNNOOMMNNIIIPPPOO!! ......");
                    Console.WriteLine(@"       ....... MN MOMMMNNNIIIIIO! OO ..........");
                    Console.WriteLine(@"    ......... MNO! IiiiiiiiiiiiI OOOO ...........");
                    Console.WriteLine(@"  ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........");
                    Console.WriteLine(@"   .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........");
                    Console.WriteLine(@"   ...... MNNNNO! .. PPPPPPPPP .. MMNON!........");
                    Console.WriteLine(@"      ...... OO! ................. ON! .......");
                    Console.WriteLine(@"         ................................");

                }
            }
            else if (SwordSet == false)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 11);
                if (randomNumber >= 5)
                {
                    Console.WriteLine("You don't have any weapons, but the troll trips on his \nown tail and gets knocked out. Finally, a stroke of luck. \nIn the distance you can see the vauge outline of a tower, and you \ndecide to make it your next destination. \nPress 'enter' to continue walking.");
                    Console.ReadLine();
                    Console.Clear();
                    CrystalCityOne();
                }
                else if (randomNumber < 5)
                {
                    /*DIE AGAIN   */
                    Console.WriteLine("you tried fighting a troll without a weapon? youre dead {0}.", NameSet);
                    Console.WriteLine("\n\n\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"     .... NO! ...                  ... MNO! ...");
                    Console.WriteLine(@"   ..... MNO!! ...................... MNNOO! ...");
                    Console.WriteLine(@" ..... MMNO! ......................... MNNOO!! .");
                    Console.WriteLine(@".... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .");
                    Console.WriteLine(@" ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....");
                    Console.WriteLine(@"    ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...");
                    Console.WriteLine(@"   ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....");
                    Console.WriteLine(@"   ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...  ");
                    Console.WriteLine(@"    ....... MMMMM..    OPPMMP    .,OMI! ....");
                    Console.WriteLine(@"     ...... MMMM::   o.,OPMP,.o   ::I!! ...");
                    Console.WriteLine(@"         .... NNM:::.,,OOPM!P,.::::!! ....");
                    Console.WriteLine(@"          .. MMNNNNNOOOOPMO!!IIPPO!!O! .....");
                    Console.WriteLine(@"         ... MMMMMNNNNOO:!!:!!IPPPPOO! ....");
                    Console.WriteLine(@"           .. MMMMMNNOOMMNNIIIPPPOO!! ......");
                    Console.WriteLine(@"       ....... MN MOMMMNNNIIIIIO! OO ..........");
                    Console.WriteLine(@"    ......... MNO! IiiiiiiiiiiiI OOOO ...........");
                    Console.WriteLine(@"  ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........");
                    Console.WriteLine(@"   .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........");
                    Console.WriteLine(@"   ...... MNNNNO! .. PPPPPPPPP .. MMNON!........");
                    Console.WriteLine(@"      ...... OO! ................. ON! .......");
                    Console.WriteLine(@"         ................................");
                    Console.ReadLine();
                }
            }
        }

        //FIFTH MOVE PATH#2 The Robbers
        public void RobbersOne()
        {
            if (ElfSet == (true))
            {
                Console.WriteLine("\n\n");
                Console.WriteLine(@"      ,__                . .      __");
                Console.WriteLine(@"     ------     _*=_      : .   __==__");
                Console.WriteLine(@"      (``)     ,( ') >      .:.__(~~)");
                Console.WriteLine(@"____ /~::~\ ____'|~)__________`\\/;~\____________");
                Console.WriteLine(@"    `|_::_|'    (` |             (~`\\._");
                Console.WriteLine(@"      _||_      /__|_           _.||[___]");
                Console.WriteLine(@"                                         ");
                Console.WriteLine(@"------------------------------------");
                Console.WriteLine("\n\n");
                Console.WriteLine("You reach a band of robbers, and they are itching for a fight. \nYour elf says he'd be more than willing to fight them for you, but \nnow might be a good time to prove your own strength. \nYou need to choose between fighting 'alone' or letting your 'elf' fight. ");
                string input = Console.ReadLine();
                if (input.ToLower() == "alone")
                {
                    RobbersTwo();
                }
                else if (input.ToLower() == "elf")
                {
                    Console.WriteLine("You make it away, but look back just in time to see your elf \ngetting killed. You're alone now, which is never a good thing. In the\n distance you can see the faint outline of a tower and \ndecide to head towards it \nPress 'enter' to begin walking.");
                    Console.ReadLine();
                    Console.Clear();
                    ElfSetOff();
                    OpalCityOne();
                }


            }
            else if (ElfSet == (false))
            {
                Console.WriteLine("\n\n");
                Console.WriteLine(@"      ,__                . .      __");
                Console.WriteLine(@"     ------     _*=_      : .   __==__");
                Console.WriteLine(@"      (``)     ,( ') >      .:.__(~~)");
                Console.WriteLine(@"____ /~::~\ ____'|~)__________`\\/;~\____________");
                Console.WriteLine(@"    `|_::_|'    (` |             (~`\\._");
                Console.WriteLine(@"      _||_      /__|_           _.||[___]");
                Console.WriteLine(@"                                         ");
                Console.WriteLine(@"------------------------------------");
                Console.WriteLine("\n\n");
                Console.WriteLine("You reach a band of robbers, and they are itching for a fight. \nYou have no choice but to fight. \nPress 'enter' to fight.");
                Console.ReadLine();
                Console.Clear();
                RobbersTwo();
            }
        }

        public void RobbersTwo()
        {
            if (SwordSet == true)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 11);
                if (randomNumber > 2)
                {
                    Console.WriteLine("You manage to wound the leader of the pack and the rest \nrecognize your skill and back off. You are allowed to pass. \nIn the distance you can see castle spires, and that seems as good of \na destination as any. Hopefully a safe one. \nPress ''enter' to continue walking.");
                    Console.ReadLine();
                    Console.Clear();
                    OpalCityOne();
                }
                else if (randomNumber <= 2)
                {
                    /*DIE AGAIN*/
                    Console.WriteLine("\n\n\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"     .... NO! ...                  ... MNO! ...");
                    Console.WriteLine(@"   ..... MNO!! ...................... MNNOO! ...");
                    Console.WriteLine(@" ..... MMNO! ......................... MNNOO!! .");
                    Console.WriteLine(@".... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .");
                    Console.WriteLine(@" ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....");
                    Console.WriteLine(@"    ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...");
                    Console.WriteLine(@"   ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....");
                    Console.WriteLine(@"   ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...  ");
                    Console.WriteLine(@"    ....... MMMMM..    OPPMMP    .,OMI! ....");
                    Console.WriteLine(@"     ...... MMMM::   o.,OPMP,.o   ::I!! ...");
                    Console.WriteLine(@"         .... NNM:::.,,OOPM!P,.::::!! ....");
                    Console.WriteLine(@"          .. MMNNNNNOOOOPMO!!IIPPO!!O! .....");
                    Console.WriteLine(@"         ... MMMMMNNNNOO:!!:!!IPPPPOO! ....");
                    Console.WriteLine(@"           .. MMMMMNNOOMMNNIIIPPPOO!! ......");
                    Console.WriteLine(@"       ....... MN MOMMMNNNIIIIIO! OO ..........");
                    Console.WriteLine(@"    ......... MNO! IiiiiiiiiiiiI OOOO ...........");
                    Console.WriteLine(@"  ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........");
                    Console.WriteLine(@"   .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........");
                    Console.WriteLine(@"   ...... MNNNNO! .. PPPPPPPPP .. MMNON!........");
                    Console.WriteLine(@"      ...... OO! ................. ON! .......");
                    Console.WriteLine(@"         ................................");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Despite your sweet sword, you died. bummer {0}. \nYou had almost made it to safety...", NameSet);
                }
            }
            else if (SwordSet == false)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 11);
                if (randomNumber >= 5)
                {
                    Console.WriteLine(" Despite having no weapons, you punch the leader really hard and the rest \nnervously back off. They allow you to pass. In the distance you can see \ncastle spires, so you head towards them, hoping for safety. \nPress 'enter' to continue your walk...");
                    Console.ReadLine();
                    Console.Clear();
                    OpalCityOne();
                }
                else if (randomNumber < 5)
                {
                    /*DIE AGAIN   */
                    Console.WriteLine("\n\n\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"     .... NO! ...                  ... MNO! ...");
                    Console.WriteLine(@"   ..... MNO!! ...................... MNNOO! ...");
                    Console.WriteLine(@" ..... MMNO! ......................... MNNOO!! .");
                    Console.WriteLine(@".... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .");
                    Console.WriteLine(@" ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....");
                    Console.WriteLine(@"    ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...");
                    Console.WriteLine(@"   ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....");
                    Console.WriteLine(@"   ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...  ");
                    Console.WriteLine(@"    ....... MMMMM..    OPPMMP    .,OMI! ....");
                    Console.WriteLine(@"     ...... MMMM::   o.,OPMP,.o   ::I!! ...");
                    Console.WriteLine(@"         .... NNM:::.,,OOPM!P,.::::!! ....");
                    Console.WriteLine(@"          .. MMNNNNNOOOOPMO!!IIPPO!!O! .....");
                    Console.WriteLine(@"         ... MMMMMNNNNOO:!!:!!IPPPPOO! ....");
                    Console.WriteLine(@"           .. MMMMMNNOOMMNNIIIPPPOO!! ......");
                    Console.WriteLine(@"       ....... MN MOMMMNNNIIIIIO! OO ..........");
                    Console.WriteLine(@"    ......... MNO! IiiiiiiiiiiiI OOOO ...........");
                    Console.WriteLine(@"  ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........");
                    Console.WriteLine(@"   .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........");
                    Console.WriteLine(@"   ...... MNNNNO! .. PPPPPPPPP .. MMNON!........");
                    Console.WriteLine(@"      ...... OO! ................. ON! .......");
                    Console.WriteLine(@"         ................................");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("You tried fighting the whole mob without a weapon? \nYou're dead {0}. Bummer. \nI have a feeling you were almost to safety...", NameSet);
                    Console.ReadLine();
                }
            }
        }

        //MOVE #6 A The Crystal City Gate
        public void CrystalCityOne()
        {
            if (ElfSet == true)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine(@"        ...oO                _.--X~~OO~~X--._                       ...oOO");
                Console.WriteLine(@"                         _.-~   / \ II / \   ~-._");
                Console.WriteLine(@"                    [].-~  \   /   \||/   \   /  ~-.[]    ...o");
                Console.WriteLine(@" ...o           _   ||/     \ /     ||     \ /     \||   _");
                Console.WriteLine(@"               (_)  |X       X      ||      X       X|  (_)");
                Console.WriteLine(@"              _-~-_ ||\     / \     ||     / \     /|| _-~-_");
                Console.WriteLine(@"              ||||| || \   /   \   /||\   /   \   / || |||||");
                Console.WriteLine(@"              |   |_||  \ /     \ / || \ /     \ /  ||_|   |");
                Console.WriteLine(@"              |   |~||   X       X  ||  X       X   ||~|   |");
                Console.WriteLine(@"==============|   | ||  / \     / \ || / \     / \  || |   |==============");
                Console.WriteLine(@"______________|   | || /   \   /   \||/   \   /   \ || |   |______________");
                Console.WriteLine(@"    .     .   |   | ||/     \ /     ||     \ /     \|| |   |  .       .");
                Console.WriteLine(@"       /      |   | |X       X      ||      X       X| |   |    /        /");
                Console.WriteLine(@"  /   .       |   | ||\     / \     ||     / \     /|| |   | .      /   .");
                Console.WriteLine(@".          /  |   | || \   /   \   /||\   /   \   / || |   |   .  .");
                Console.WriteLine(@"    .    .    |   | ||  \ /     \ / || \ /     \ /  || |   |          .");
                Console.WriteLine(@"      /       |   | ||   X       X  ||  X       X   || |   | . / .      /");
                Console.WriteLine(@"  /        .  |   | ||  / \     / \ || / \     / \  || |   |        /");
                Console.WriteLine(@"         /    |   | || /   \   /   \||/   \   /   \ || |   |   .         /");
                Console.WriteLine(@".    .    .   |   | ||/     \ /    /||\    \ /     \|| |   |     /.    .");
                Console.WriteLine(@"              |   |_|X       X    / II \    X       X|_|   |  .     .   /");
                Console.WriteLine(@"==============|   |~II~~~~~~~~~~~~~~OO~~~~~~~~~~~~~~II~|   |==============");
                Console.WriteLine("\n\n");
                Console.WriteLine("You walk to the brink of starvation, but make it to the gate of a \nmassive castle with tall crystal spires. You knock on the door and a slot \nopens. A gravely voice tells you that you must answer a riddle in order \nto be worthy of entering the city. \nYou will get three guesses. The riddle is as follows: \n\n I am light as a feather, yet the strongest man  \ncannot hold me for more than five munutes. \nWhat am I?");
                Console.WriteLine("\n\n Your elf taps you shoulder and says it must have somthing  \nto do with air... \nPlease type your guess and press 'enter'.");

                string riddleOne = Console.ReadLine();
                string riddleAnswer = "breath";
                string userGuess = "a";
                int attempts = 0;

                while (userGuess != riddleAnswer)
                {
                    Console.WriteLine("Enter your guess at the riddle:");
                    userGuess = Console.ReadLine();
                    attempts++;
                    if (userGuess == riddleAnswer)
                    {
                        break;
                    }
                    if (attempts > 2)
                    {
                        //DEAD AGAIN
                        Console.WriteLine("\n\n\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"     .... NO! ...                  ... MNO! ...");
                        Console.WriteLine(@"   ..... MNO!! ...................... MNNOO! ...");
                        Console.WriteLine(@" ..... MMNO! ......................... MNNOO!! .");
                        Console.WriteLine(@".... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .");
                        Console.WriteLine(@" ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....");
                        Console.WriteLine(@"    ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...");
                        Console.WriteLine(@"   ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....");
                        Console.WriteLine(@"   ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...  ");
                        Console.WriteLine(@"    ....... MMMMM..    OPPMMP    .,OMI! ....");
                        Console.WriteLine(@"     ...... MMMM::   o.,OPMP,.o   ::I!! ...");
                        Console.WriteLine(@"         .... NNM:::.,,OOPM!P,.::::!! ....");
                        Console.WriteLine(@"          .. MMNNNNNOOOOPMO!!IIPPO!!O! .....");
                        Console.WriteLine(@"         ... MMMMMNNNNOO:!!:!!IPPPPOO! ....");
                        Console.WriteLine(@"           .. MMMMMNNOOMMNNIIIPPPOO!! ......");
                        Console.WriteLine(@"       ....... MN MOMMMNNNIIIIIO! OO ..........");
                        Console.WriteLine(@"    ......... MNO! IiiiiiiiiiiiI OOOO ...........");
                        Console.WriteLine(@"  ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........");
                        Console.WriteLine(@"   .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........");
                        Console.WriteLine(@"   ...... MNNNNO! .. PPPPPPPPP .. MMNON!........");
                        Console.WriteLine(@"      ...... OO! ................. ON! .......");
                        Console.WriteLine(@"         ................................");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Too bad, you didn't make it within three guesses. \nPoor {0}, such a silly way to die.", NameSet);
                        break;
                    }
                }
                Console.WriteLine("You did it! The gate opens and you enter the Crystal City. \nPress 'enter' to continue...");
                Console.ReadLine();
                Console.Clear();
                EndCredits();
            }
            else if (ElfSet == false)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine(@"        ...oO                _.--X~~OO~~X--._                       ...oOO");
                Console.WriteLine(@"                         _.-~   / \ II / \   ~-._");
                Console.WriteLine(@"                    [].-~  \   /   \||/   \   /  ~-.[]    ...o");
                Console.WriteLine(@" ...o           _   ||/     \ /     ||     \ /     \||   _");
                Console.WriteLine(@"               (_)  |X       X      ||      X       X|  (_)");
                Console.WriteLine(@"              _-~-_ ||\     / \     ||     / \     /|| _-~-_");
                Console.WriteLine(@"              ||||| || \   /   \   /||\   /   \   / || |||||");
                Console.WriteLine(@"              |   |_||  \ /     \ / || \ /     \ /  ||_|   |");
                Console.WriteLine(@"              |   |~||   X       X  ||  X       X   ||~|   |");
                Console.WriteLine(@"==============|   | ||  / \     / \ || / \     / \  || |   |==============");
                Console.WriteLine(@"______________|   | || /   \   /   \||/   \   /   \ || |   |______________");
                Console.WriteLine(@"    .     .   |   | ||/     \ /     ||     \ /     \|| |   |  .       .");
                Console.WriteLine(@"       /      |   | |X       X      ||      X       X| |   |    /        /");
                Console.WriteLine(@"  /   .       |   | ||\     / \     ||     / \     /|| |   | .      /   .");
                Console.WriteLine(@".          /  |   | || \   /   \   /||\   /   \   / || |   |   .  .");
                Console.WriteLine(@"    .    .    |   | ||  \ /     \ / || \ /     \ /  || |   |          .");
                Console.WriteLine(@"      /       |   | ||   X       X  ||  X       X   || |   | . / .      /");
                Console.WriteLine(@"  /        .  |   | ||  / \     / \ || / \     / \  || |   |        /");
                Console.WriteLine(@"         /    |   | || /   \   /   \||/   \   /   \ || |   |   .         /");
                Console.WriteLine(@".    .    .   |   | ||/     \ /    /||\    \ /     \|| |   |     /.    .");
                Console.WriteLine(@"              |   |_|X       X    / II \    X       X|_|   |  .     .   /");
                Console.WriteLine(@"==============|   |~II~~~~~~~~~~~~~~OO~~~~~~~~~~~~~~II~|   |==============");
                Console.WriteLine("\n\n");
                Console.WriteLine("You walk to the brink of starvation, but make it to the gate of a \nmassive castle with tall crystal spires. You knock on the door and a slot \nopens. A gravely voice tells you that you must answer a riddle in order \nto be worthy of entering the city. \nYou will get three guesses. The riddle is as follows: \n\n I am light as a feather, yet the strongest man  \ncannot hold me for more than five munutes. \nWhat am I? \n\nPlese type your guess and press 'enter'.");

                string riddleOne = Console.ReadLine();
                string riddleAnswer = "breath";
                string userGuess = "a";
                int attempts = 0;

                while (userGuess != riddleAnswer)
                {
                    Console.WriteLine("Enter your guess at the riddle:");
                    userGuess = Console.ReadLine();
                    attempts++;
                    if (userGuess == riddleAnswer)
                    {
                        break;
                    }
                    if (attempts > 2)
                    {
                        //DEAD AGAIN
                        Console.WriteLine("\n\n\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"     .... NO! ...                  ... MNO! ...");
                        Console.WriteLine(@"   ..... MNO!! ...................... MNNOO! ...");
                        Console.WriteLine(@" ..... MMNO! ......................... MNNOO!! .");
                        Console.WriteLine(@".... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .");
                        Console.WriteLine(@" ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....");
                        Console.WriteLine(@"    ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...");
                        Console.WriteLine(@"   ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....");
                        Console.WriteLine(@"   ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...  ");
                        Console.WriteLine(@"    ....... MMMMM..    OPPMMP    .,OMI! ....");
                        Console.WriteLine(@"     ...... MMMM::   o.,OPMP,.o   ::I!! ...");
                        Console.WriteLine(@"         .... NNM:::.,,OOPM!P,.::::!! ....");
                        Console.WriteLine(@"          .. MMNNNNNOOOOPMO!!IIPPO!!O! .....");
                        Console.WriteLine(@"         ... MMMMMNNNNOO:!!:!!IPPPPOO! ....");
                        Console.WriteLine(@"           .. MMMMMNNOOMMNNIIIPPPOO!! ......");
                        Console.WriteLine(@"       ....... MN MOMMMNNNIIIIIO! OO ..........");
                        Console.WriteLine(@"    ......... MNO! IiiiiiiiiiiiI OOOO ...........");
                        Console.WriteLine(@"  ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........");
                        Console.WriteLine(@"   .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........");
                        Console.WriteLine(@"   ...... MNNNNO! .. PPPPPPPPP .. MMNON!........");
                        Console.WriteLine(@"      ...... OO! ................. ON! .......");
                        Console.WriteLine(@"         ................................");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Too bad, you didn't make it within three guesses. \nPoor {0}, such a silly way to die.", NameSet);
                        break;
                    }
                }
                Console.WriteLine("You did it! The gate opens and you enter the Crystal City. \nPress 'enter' to continue...");
                Console.ReadLine();
                Console.Clear();
                EndCredits();
            }


        }
        //MOVE #6 B The Opal City Gates
        public void OpalCityOne()
        {
            if (ElfSet == true)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine(@"        ...oO                _.--X~~OO~~X--._                       ...oOO");
                Console.WriteLine(@"                         _.-~   / \ II / \   ~-._");
                Console.WriteLine(@"                    [].-~  \   /   \||/   \   /  ~-.[]    ...o");
                Console.WriteLine(@" ...o           _   ||/     \ /     ||     \ /     \||   _");
                Console.WriteLine(@"               (_)  |X       X      ||      X       X|  (_)");
                Console.WriteLine(@"              _-~-_ ||\     / \     ||     / \     /|| _-~-_");
                Console.WriteLine(@"              ||||| || \   /   \   /||\   /   \   / || |||||");
                Console.WriteLine(@"              |   |_||  \ /     \ / || \ /     \ /  ||_|   |");
                Console.WriteLine(@"              |   |~||   X       X  ||  X       X   ||~|   |");
                Console.WriteLine(@"==============|   | ||  / \     / \ || / \     / \  || |   |==============");
                Console.WriteLine(@"______________|   | || /   \   /   \||/   \   /   \ || |   |______________");
                Console.WriteLine(@"    .     .   |   | ||/     \ /     ||     \ /     \|| |   |  .       .");
                Console.WriteLine(@"       /      |   | |X       X      ||      X       X| |   |    /        /");
                Console.WriteLine(@"  /   .       |   | ||\     / \     ||     / \     /|| |   | .      /   .");
                Console.WriteLine(@".          /  |   | || \   /   \   /||\   /   \   / || |   |   .  .");
                Console.WriteLine(@"    .    .    |   | ||  \ /     \ / || \ /     \ /  || |   |          .");
                Console.WriteLine(@"      /       |   | ||   X       X  ||  X       X   || |   | . / .      /");
                Console.WriteLine(@"  /        .  |   | ||  / \     / \ || / \     / \  || |   |        /");
                Console.WriteLine(@"         /    |   | || /   \   /   \||/   \   /   \ || |   |   .         /");
                Console.WriteLine(@".    .    .   |   | ||/     \ /    /||\    \ /     \|| |   |     /.    .");
                Console.WriteLine(@"              |   |_|X       X    / II \    X       X|_|   |  .     .   /");
                Console.WriteLine(@"==============|   |~II~~~~~~~~~~~~~~OO~~~~~~~~~~~~~~II~|   |==============");
                Console.WriteLine("\n\n");
                Console.WriteLine("You walk to the brink of starvation, but make it to the gate of a \nmassive castle with tall crystal spires. You knock on the door and a slot \nopens. A gravely voice tells you that you must answer a riddle in order \nto be worthy of entering the city. \nYou will get three guesses. The riddle is as follows: \n\n I am light as a feather, yet the strongest man  \ncannot hold me for more than five munutes. \nWhat am I?");
                Console.WriteLine("\n\n Your elf taps you shoulder and says it must have somthing  \nto do with air... \nPlease type your guess and press 'enter'.");

                string riddleOne = Console.ReadLine();
                string riddleAnswer = "breath";
                string userGuess = "a";
                int attempts = 0;

                while (userGuess != riddleAnswer)
                {
                    Console.WriteLine("Enter your guess at the riddle:");
                    userGuess = Console.ReadLine();
                    attempts++;
                    if (userGuess == riddleAnswer)
                    {
                        break;
                    }
                    if (attempts > 2)
                    {
                        //DEAD AGAIN
                        Console.WriteLine("\n\n\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"     .... NO! ...                  ... MNO! ...");
                        Console.WriteLine(@"   ..... MNO!! ...................... MNNOO! ...");
                        Console.WriteLine(@" ..... MMNO! ......................... MNNOO!! .");
                        Console.WriteLine(@".... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .");
                        Console.WriteLine(@" ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....");
                        Console.WriteLine(@"    ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...");
                        Console.WriteLine(@"   ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....");
                        Console.WriteLine(@"   ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...  ");
                        Console.WriteLine(@"    ....... MMMMM..    OPPMMP    .,OMI! ....");
                        Console.WriteLine(@"     ...... MMMM::   o.,OPMP,.o   ::I!! ...");
                        Console.WriteLine(@"         .... NNM:::.,,OOPM!P,.::::!! ....");
                        Console.WriteLine(@"          .. MMNNNNNOOOOPMO!!IIPPO!!O! .....");
                        Console.WriteLine(@"         ... MMMMMNNNNOO:!!:!!IPPPPOO! ....");
                        Console.WriteLine(@"           .. MMMMMNNOOMMNNIIIPPPOO!! ......");
                        Console.WriteLine(@"       ....... MN MOMMMNNNIIIIIO! OO ..........");
                        Console.WriteLine(@"    ......... MNO! IiiiiiiiiiiiI OOOO ...........");
                        Console.WriteLine(@"  ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........");
                        Console.WriteLine(@"   .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........");
                        Console.WriteLine(@"   ...... MNNNNO! .. PPPPPPPPP .. MMNON!........");
                        Console.WriteLine(@"      ...... OO! ................. ON! .......");
                        Console.WriteLine(@"         ................................");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Too bad, you didn't make it within three guesses. \nPoor {0}, such a silly way to die.", NameSet);
                        break;
                    }
                }
                Console.WriteLine("You did it! The gate opens and you enter the Opal City. \nPress 'enter' to continue...");
                Console.ReadLine();
                Console.Clear();
                EndCredits();
            }
            else if (ElfSet == false)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine(@"        ...oO                _.--X~~OO~~X--._                       ...oOO");
                Console.WriteLine(@"                         _.-~   / \ II / \   ~-._");
                Console.WriteLine(@"                    [].-~  \   /   \||/   \   /  ~-.[]    ...o");
                Console.WriteLine(@" ...o           _   ||/     \ /     ||     \ /     \||   _");
                Console.WriteLine(@"               (_)  |X       X      ||      X       X|  (_)");
                Console.WriteLine(@"              _-~-_ ||\     / \     ||     / \     /|| _-~-_");
                Console.WriteLine(@"              ||||| || \   /   \   /||\   /   \   / || |||||");
                Console.WriteLine(@"              |   |_||  \ /     \ / || \ /     \ /  ||_|   |");
                Console.WriteLine(@"              |   |~||   X       X  ||  X       X   ||~|   |");
                Console.WriteLine(@"==============|   | ||  / \     / \ || / \     / \  || |   |==============");
                Console.WriteLine(@"______________|   | || /   \   /   \||/   \   /   \ || |   |______________");
                Console.WriteLine(@"    .     .   |   | ||/     \ /     ||     \ /     \|| |   |  .       .");
                Console.WriteLine(@"       /      |   | |X       X      ||      X       X| |   |    /        /");
                Console.WriteLine(@"  /   .       |   | ||\     / \     ||     / \     /|| |   | .      /   .");
                Console.WriteLine(@".          /  |   | || \   /   \   /||\   /   \   / || |   |   .  .");
                Console.WriteLine(@"    .    .    |   | ||  \ /     \ / || \ /     \ /  || |   |          .");
                Console.WriteLine(@"      /       |   | ||   X       X  ||  X       X   || |   | . / .      /");
                Console.WriteLine(@"  /        .  |   | ||  / \     / \ || / \     / \  || |   |        /");
                Console.WriteLine(@"         /    |   | || /   \   /   \||/   \   /   \ || |   |   .         /");
                Console.WriteLine(@".    .    .   |   | ||/     \ /    /||\    \ /     \|| |   |     /.    .");
                Console.WriteLine(@"              |   |_|X       X    / II \    X       X|_|   |  .     .   /");
                Console.WriteLine(@"==============|   |~II~~~~~~~~~~~~~~OO~~~~~~~~~~~~~~II~|   |==============");
                Console.WriteLine("\n\n");
                Console.WriteLine("You walk to the brink of starvation, but make it to the gate of a \nmassive castle with tall crystal spires. You knock on the door and a slot \nopens. A gravely voice tells you that you must answer a riddle in order \nto be worthy of entering the city. \nYou will get three guesses. The riddle is as follows: \n\n I am light as a feather, yet the strongest man  \ncannot hold me for more than five munutes. \nWhat am I? \n\nPlese type your guess and press 'enter'.");

                string riddleOne = Console.ReadLine();
                string riddleAnswer = "breath";
                string userGuess = "a";
                int attempts = 0;

                while (userGuess != riddleAnswer)
                {
                    Console.WriteLine("Enter your guess at the riddle:");
                    userGuess = Console.ReadLine();
                    attempts++;
                    if (userGuess == riddleAnswer)
                    {
                        break;
                    }
                    if (attempts > 2)
                    {
                        //DEAD AGAIN
                        Console.WriteLine("\n\n\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"     .... NO! ...                  ... MNO! ...");
                        Console.WriteLine(@"   ..... MNO!! ...................... MNNOO! ...");
                        Console.WriteLine(@" ..... MMNO! ......................... MNNOO!! .");
                        Console.WriteLine(@".... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .");
                        Console.WriteLine(@" ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....");
                        Console.WriteLine(@"    ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...");
                        Console.WriteLine(@"   ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....");
                        Console.WriteLine(@"   ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...  ");
                        Console.WriteLine(@"    ....... MMMMM..    OPPMMP    .,OMI! ....");
                        Console.WriteLine(@"     ...... MMMM::   o.,OPMP,.o   ::I!! ...");
                        Console.WriteLine(@"         .... NNM:::.,,OOPM!P,.::::!! ....");
                        Console.WriteLine(@"          .. MMNNNNNOOOOPMO!!IIPPO!!O! .....");
                        Console.WriteLine(@"         ... MMMMMNNNNOO:!!:!!IPPPPOO! ....");
                        Console.WriteLine(@"           .. MMMMMNNOOMMNNIIIPPPOO!! ......");
                        Console.WriteLine(@"       ....... MN MOMMMNNNIIIIIO! OO ..........");
                        Console.WriteLine(@"    ......... MNO! IiiiiiiiiiiiI OOOO ...........");
                        Console.WriteLine(@"  ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........");
                        Console.WriteLine(@"   .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........");
                        Console.WriteLine(@"   ...... MNNNNO! .. PPPPPPPPP .. MMNON!........");
                        Console.WriteLine(@"      ...... OO! ................. ON! .......");
                        Console.WriteLine(@"         ................................");
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Too bad, you didn't make it within three guesses. \nPoor {0}, such a silly way to die.", NameSet);
                        break;
                    }
                }
                Console.WriteLine("You did it! The gate opens and you enter the Opal City. \nPress 'enter' to continue...");
                Console.ReadLine();
                Console.Clear();
                EndCredits();

                EndCredits();
            }




        }
        public void EndCredits()
        {
            Console.WriteLine("n\n");
            Console.WriteLine(@":::8888888888888888888888888888888P''''''48888888888888888888888::::88");
            Console.WriteLine(@"::::8888888888888888888888P   ____.------.____   488888888888888:::888");
            Console.WriteLine(@"::::88888888888888888P __.--''    _._         ''--.__ 4888888888:::888");
            Console.WriteLine(@":::::888888888888P _.-'       .- ~ | ~-.             '-._ 488888:::888");
            Console.WriteLine(@":::::888888888P _-'            |   |   | '                -_ 488::8888");
            Console.WriteLine(@"::::::888888P ,'               |  _:_  |                    .-:~--.._8");
            Console.WriteLine(@"8:::::88888 ,'            .  .-'~~ | ~~'-.                .~  |      |");
            Console.WriteLine(@"88:::::88P /_.-~:.   .   :   |     |     |       .        |   |      |");
            Console.WriteLine(@"888::::8P /|    | `.o    !   |     |     |        :       |   |      |");
            Console.WriteLine(@"8P_..--~:-.|    |  |    d    |     |     | .       o      |   |      |");
            Console.WriteLine(@"8|      |  ~.   |  |    o    |  __.:.__  | ;       b      |   |      |");
            Console.WriteLine(@"8|      |   |   |  |   d8  .-'~~   |   ~~'-.o       8     |   |      |");
            Console.WriteLine(@"8|      |   |  _|.--~:-98  |       |       |8b      8.:~-.|   |      |");
            Console.WriteLine(@"8|      A   | |      |  ~. |       |   _.-:~--._   .' |   |   |      |");
            Console.WriteLine(@"8|      M   | |      |   | |       |  |   |     |  |  |   |   |      |");
            Console.WriteLine(@"8|      C   | |      |   | |       |  |   |     |  |  |   |   O      |");
            Console.WriteLine(@"8|      |   | |      |   | |       |  |   |     |  |  |   |   j      |");
            Console.WriteLine(@"8|      9   | |      |   | |       |  |   |     |  |  |   |   o      |");
            Console.WriteLine(@"8|      9   | |      |   | |       |  |   |     |  |  |   |   |      |");
            Console.WriteLine(@"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\n");
            Console.WriteLine("Congrats! You survived and made it into the city \nYou are warm and safe...for now. \n\n\nEND OF CHAPTER ONE");
            Console.ReadLine();

        }
    }
}


















