using System;
namespace Laboratorio_4
{
    public class PiecesReceiverM : CentralComputer , IFunctions
    {
        public void Reset() {
            Console.WriteLine("Your Memory is Full, reseting the Pieces Receiver Machine...");
        }
        public void On() {
            Console.WriteLine("The Pieces Receiver Machine is now on!");
        }
        public void Off() {
            Console.WriteLine("The Pieces Receiver Machine is now off!");
        }
    }
}
