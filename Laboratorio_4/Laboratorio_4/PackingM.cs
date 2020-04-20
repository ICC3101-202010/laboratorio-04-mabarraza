using System;
namespace Laboratorio_4
{
    public class PackingM : CentralComputer , IFunctions
    {
        public void Reset()
        {
            Console.WriteLine("Your Memory is Full, reseting the Packing Machine...");
        }
        public void On()
        {
            Console.WriteLine("The Packing Machine is now on!");
        }
        public void Off()
        {
            Console.WriteLine("The Packing Machine is now off!");
        }
    }
}
