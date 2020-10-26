using System;

namespace DesignPatternExamples.Car_Builder
{
    public class Coupe: IVehicleMaker
    {
        public void Show()
        {
            Console.WriteLine(@"                      ___..............._");
            Console.WriteLine(@"             __.. ' _'.   """"""\\""""""""""- .   `-._");
            Console.WriteLine(@" ______.-'         (_) |      \\           ` \\`-. _");
            Console.WriteLine(@"/_       --------------'-------\\---....______\\__`.`  -..___");
            Console.WriteLine(@"| T      _.----._           Xxx|x...           |          _.._`--. _");
            Console.WriteLine(@"| |    .' ..--.. `.         XXX|XXXXXXXXXxx==  |       .'.---..`.     -._");
            Console.WriteLine(@"\_j   /  /  __  \  \        XXX|XXXXXXXXXXX==  |      / /  __  \ \        `-.");
            Console.WriteLine(@" _|  |  |  /  \  |  |       XXX|""'            |      / |  /  \  | |         |");
            Console.WriteLine(@"|__\_j  |  \__/  |  L__________|_______________|_____j |  \__/  | L__________J");
            Console.WriteLine(@"     `'\ \      / ./__________________________________\ \      / /___________\");
            Console.WriteLine(@"        `.`----'.'                                     `.`----'.'");
            Console.WriteLine(@"          `""""""""'                                         `'""""'""");
        }
    }
}
