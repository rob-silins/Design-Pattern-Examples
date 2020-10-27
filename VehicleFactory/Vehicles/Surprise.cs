using System;

namespace DesignPatternExamples
{
    public class Surprise :IVehicleMaker
    {
        public void Show()
        {
            Console.WriteLine(@"                     `. ___");
            Console.WriteLine(@"                    __,' __`.                _..----....____");
            Console.WriteLine(@"        __...--.'``;.   ,.   ;``--..__     .'    ,-._    _.-'");
            Console.WriteLine(@"  _..-''-------'   `'   `'   `'     O ``-''._   (,;') _,'");
            Console.WriteLine(@",'________________                          \`-._`-','");
            Console.WriteLine(@" `._              ```````````------...___   '-.._'-:");
            Console.WriteLine(@"    ```--.._      ,.                     ````--...__\-.");
            Console.WriteLine(@"            `.--. `-`                       ____    |  |`");
            Console.WriteLine(@"              `. `.                       ,'`````.  ;  ;`");
            Console.WriteLine(@"                `._`.        __________   `.      \'__/`");
            Console.WriteLine(@"                   `-:._____/______/___/____`.     \  `");
            Console.WriteLine(@"                               |       `._    `.    \");
            Console.WriteLine(@"                               `._________`-.   `.   `.___");
            Console.WriteLine(@"                                                  `------'`");
            Console.WriteLine("\nIs this a good surprise??");
        }
    }
}
