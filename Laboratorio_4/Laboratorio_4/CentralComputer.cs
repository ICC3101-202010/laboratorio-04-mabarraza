using System;
namespace Laboratorio_4
{
    public abstract class CentralComputer
    {
        public int Memory { get; set; }
        public void Execute(IFunctions machinetype,int hora) {

            if (hora == 8)
            {
                machinetype.On();
            }
            else if (hora == 18) {

                machinetype.Off();
            }
            else machinetype.Reset();
        }
    }
}
