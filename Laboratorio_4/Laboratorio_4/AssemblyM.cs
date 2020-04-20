using System;
namespace Laboratorio_4
{
    public class AssemblyM : CentralComputer , IFunctions
    {
        public void Reset()
        {
            Console.WriteLine("Your Memory is Full, reseting the Pieces Assembler Machine...");
        }
        public void On()
        {
            Console.WriteLine("The Pieces Assembler Machine is now on!");
        }
        public void Off()
        {
            Console.WriteLine("The Pieces Assembler Machine is now off!");
        }
    }
}
