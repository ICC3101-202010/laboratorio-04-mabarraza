using System;
namespace Laboratorio_4
{
    public class AssemblyM : CentralComputer , IFunctions
    {
        public void Reset()
        {
            Console.WriteLine("Reseting the Pieces Assembler Machine...");
        }
        public void On()
        {
            Console.WriteLine("The Pieces Assembler Machine is now on!");
        }
        public void Off()
        {
            Console.WriteLine("The Pieces Assembler Machine is now off!");
        }
        public void Warning()
        {
            Console.WriteLine("WARNING! the memory of the Pieces Assembler Machine is now full!");
        }
    }
}
