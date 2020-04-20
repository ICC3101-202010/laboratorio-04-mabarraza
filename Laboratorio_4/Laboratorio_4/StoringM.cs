using System;
namespace Laboratorio_4
{
    public class StoringM : CentralComputer , IFunctions
    {

        public void Reset()
        {
            Console.WriteLine("Reseting the Storing Machine...");
        }
        public void On()
        {
            Console.WriteLine("The Storing Machine is now on!");
        }
        public void Off()
        {
            Console.WriteLine("The Storing Machine is now off!");
        }
        public void Warning()
        {
            Console.WriteLine("WARNING! the memory of the Storing Machine is now full!");
        }
    }
}
