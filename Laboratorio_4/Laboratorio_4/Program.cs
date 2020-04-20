using System;

namespace Laboratorio_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string respuesta , respuesta2 , respuesta3;
            Random m1 = new Random() , m2 = new Random(), m3 = new Random(), m4 = new Random(), m5 = new Random();
            PiecesReceiverM PRM = new PiecesReceiverM();
            StoringM SM = new StoringM();
            AssemblyM AM = new AssemblyM();
            QualityVerificationM QVM = new QualityVerificationM();
            PackingM PM = new PackingM();
            Console.WriteLine("Time:{0}:00", 8);
            PRM.Execute(PRM, 8);
            SM.Execute(SM, 8);
            AM.Execute(AM, 8);
            QVM.Execute(QVM, 8);
            PM.Execute(PM, 8);
            for (int i = 9; i < 19; i++)
            {
                PRM.Memory = Convert.ToInt32(m1.Next(1, 6));
                SM.Memory = Convert.ToInt32(m2.Next(3, 8));
                AM.Memory = Convert.ToInt32(m3.Next(6, 11));
                QVM.Memory = Convert.ToInt32(m4.Next(9, 14));
                PM.Memory = Convert.ToInt32(m5.Next(12, 17));
                Console.WriteLine("Time:{0}:00", i);
                if (i == 18)
                {
                    PRM.Execute(PRM, i);
                    SM.Execute(SM, i);
                    AM.Execute(AM, i);
                    QVM.Execute(QVM, i);
                    PM.Execute(PM, i);
                    break;
                }
                if ((PRM.Memory == 5)|| (SM.Memory == 7)|| (AM.Memory == 10)|| (QVM.Memory == 13)|| (PM.Memory == 18))
                {
                    if (PRM.Memory == 5) PRM.Notification(PRM);
                    else if (SM.Memory == 7) SM.Notification(SM);
                    else if (AM.Memory == 10) AM.Notification(AM);
                    else if (QVM.Memory == 13) QVM.Notification(QVM);
                    else if (PM.Memory == 18) PM.Notification(PM);
                    while (true)
                    {
                    pregunta:
                        Console.WriteLine("Do you wish to reset any machine?\n Y/N");
                        respuesta = Console.ReadLine();
                        if (respuesta == "Y")
                        {
                        pregunta2:
                            Console.WriteLine("Which machine do you mant to reset? Press:\n");
                            Console.WriteLine("1 to reset the Pieces Receiver Machine ");
                            Console.WriteLine("2 to reset the Storing Machine ");
                            Console.WriteLine("3 to reset the Pieces Assembler Machine ");
                            Console.WriteLine("4 to reset the Quality Verifier Machine ");
                            Console.WriteLine("5 to reset the Packing Machine ");
                            respuesta2 = Console.ReadLine();
                            if (respuesta2 == "1") PRM.ManualReset(PRM);
                            else if (respuesta2 == "2") SM.ManualReset(SM);
                            else if (respuesta2 == "3") AM.ManualReset(AM);
                            else if (respuesta2 == "4") QVM.ManualReset(QVM);
                            else if (respuesta2 == "5") PM.ManualReset(PM);
                            else
                            {
                                Console.WriteLine("Error, try again");
                                goto pregunta2;
                            }
                            Console.WriteLine("Do you wish to reset another machine?\n Y/N");
                            respuesta3 = Console.ReadLine();
                            if (respuesta3 == "Y") goto pregunta2;
                            else break;
                        }
                        else if (respuesta == "N")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error, try again");
                            goto pregunta;
                        }
                    }
                    if (respuesta == "N") { 
                        if (PRM.Memory == 5) PRM.Execute(PRM,i);
                        else if (SM.Memory == 7) SM.Execute(SM,i);
                        else if (AM.Memory == 10) AM.Execute(AM,i);
                        else if (QVM.Memory == 13) QVM.Execute(QVM,i);
                        else if (PM.Memory == 18) PM.Execute(PM,i);
                    }
                }
            }
        }
    }
}
