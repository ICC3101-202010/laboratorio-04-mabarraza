using System;
namespace Laboratorio_4
{
    public class PackingM : CentralComputer, IFunctions
    {
        public void Reset()
        {
            Console.WriteLine("Reseting the Packing Machine...");
        }
        public void On()
        {
            Console.WriteLine("The Packing Machine is now on!");
        }
        public void Off()
        {
            Console.WriteLine("The Packing Machine is now off!");
        }
        public void Warning() {
            Console.WriteLine("WARNING! the memory of the Packing Machine is now full!");
        }
    }
}
