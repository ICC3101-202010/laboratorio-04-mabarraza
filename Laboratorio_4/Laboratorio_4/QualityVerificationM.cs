using System;
namespace Laboratorio_4
{
    public class QualityVerificationM : CentralComputer , IFunctions
    {
        public void Reset()
        {
            Console.WriteLine("Your Memory is Full, reseting the Quality Verification Machine...");
        }
        public void On()
        {
            Console.WriteLine("The Quality Verification Machine is now on!");
        }
        public void Off()
        {
            Console.WriteLine("The Quality Verification Machine is now off!");
        }
    }
}
