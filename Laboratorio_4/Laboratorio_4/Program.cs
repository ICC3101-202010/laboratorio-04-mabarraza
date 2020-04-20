using System;

namespace Laboratorio_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random m1 = new Random() , m2 = new Random(), m3 = new Random(), m4 = new Random(), m5 = new Random();
            PiecesReceiverM PRM = new PiecesReceiverM();
            StoringM SM = new StoringM();
            AssemblyM AM = new AssemblyM();
            QualityVerificationM QVM = new QualityVerificationM();
            PackingM PM = new PackingM();
            Console.WriteLine("Son las {0}:00", 8);
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
                Console.WriteLine("Son las {0}:00", i);
                if (i == 18)
                {
                    PRM.Execute(PRM, i);
                    SM.Execute(SM, i);
                    AM.Execute(AM, i);
                    QVM.Execute(QVM, i);
                    PM.Execute(PM, i);
                    break;
                }
                if (PRM.Memory == 5)PRM.Execute(PRM, i);
                else if(SM.Memory==7)SM.Execute(SM, i);
                else if (AM.Memory==10)AM.Execute(AM, i);
                else if (QVM.Memory==13)QVM.Execute(QVM, i);
                else if(PM.Memory==18)PM.Execute(PM, i);
            }
        }
    }
}
