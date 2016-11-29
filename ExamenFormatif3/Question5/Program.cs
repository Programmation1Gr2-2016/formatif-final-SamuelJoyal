using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Program
    {
   

        static void Main(string[] args)
        {
            string key = "popopopopopopopopopopopopopo";
            bool[] tableau = new bool[100];
            int nbVraiOuFaux;
            Random rnd = new Random();
            bool vraiOuFaux;

            for (int i = 0; i < 99; i++)
            {
                nbVraiOuFaux = rnd.Next(1, 3);

                if (nbVraiOuFaux == 1)
                {

                    vraiOuFaux = true;
                }else
                {

                    vraiOuFaux = false;
                }



            }



            while (key != "q")
            {
                key = Console.ReadLine();


                if (key == "y");


            }





        }

        void AffichageEntier()
        {

          //  for ()

        }
    }
}
