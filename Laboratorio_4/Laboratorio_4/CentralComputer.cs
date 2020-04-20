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
        public void Notification(IFunctions machinetype) {
            machinetype.Warning();
        }
        public void ManualReset(IFunctions machinetype) {
            machinetype.Reset();
        }
    }
}
