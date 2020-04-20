using System;
namespace Laboratorio_4
{
    public class StoringM : CentralComputer , IFunctions
    {

        public void Reset()
        {
            Console.WriteLine("Your Memory is Full, reseting the Storing Machine...");
        }
        public void On()
        {
            Console.WriteLine("The Storing Machine is now on!");
        }
        public void Off()
        {
            Console.WriteLine("The Storing Machine is now off!");
        }
    }
}
