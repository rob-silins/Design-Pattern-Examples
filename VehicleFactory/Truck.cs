using Console = System.Console;

namespace DesignPatternExamples
{
    public class Truck: IVehicleMaker
    {
        public void Show()
        {
            Console.WriteLine(@"                     ..-------------------.__");
            Console.WriteLine(@"                   .'_______                  `-.");
            Console.WriteLine(@"                  // .-----.\.--------..--------.\");
            Console.WriteLine(@"                  ||'    __'||        ||   ||   || __");
            Console.WriteLine(@"                  ||' .=(_ )|| ====== || ==.|   ||( _)");
            Console.WriteLine(@"                  ||'|    \\||________||________||//");
            Console.WriteLine(@"                  ||'------\) ,--======\\======-._/");
            Console.WriteLine(@"              ____||        |/           = =      `-.");
            Console.WriteLine(@"    _____________ ||'==.    ||   ......      = =     `-.");
            Console.WriteLine(@"   `=============`||        ||_ /////.--.        = =    `. .--.");
            Console.WriteLine(@"   |    .---.     ||        |   .----|==|     \    \ \    \|==|");
            Console.WriteLine(@"   | .'       `.  ||        | .'     '--'.    |-.  | |  .-|'--'`. ");
            Console.WriteLine(@"   .'           \ ||        .'            `.  |-.'-|=|-'.-|      \");
            Console.WriteLine(@"  /    .-==-.    \||       /  _.----.       \ |-.'-|=|-'.-|      |");
            Console.WriteLine(@" |  .' .---. `.  |||       .-' .---. `.     | |-.'-|=|-'.-|      |");
            Console.WriteLine(@" | / .`.- -.`. \ '\_`---- /  .`.- -.`. \    | '  '-|=|-'  '_____/");
            Console.WriteLine(@"[|_|/ /  _  \ \|__________| / /  _  \ \ `_____.......-----'_____]");
            Console.WriteLine(@"    ; : / \ : ;'----------'; :  / \  : ;[_____.......-----'; :");
            Console.WriteLine(@"    : ; \_/ ; : \     / /  ; :  \_/  ; :          \ \     / /");
            Console.WriteLine(@"    \ \     / /. `- -` .    \ \     / /            . `- -` .");
            Console.WriteLine(@"     . `- -` .  `-----`      . `- -` .              `-----`");
            Console.WriteLine(@"      `-----`                 `-----`");
        }
    }
}
