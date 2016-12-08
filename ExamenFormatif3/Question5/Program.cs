using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    /// <summary>
    /// CC : Commentaires?
    /// CC : 12 / 15
    /// </summary>
    class Program
    {


        static void Main(string[] args)
        {
            string key = "popopopopopopopopopopopopopo"; // CC:  ???
            bool[] tableau = new bool[100];
            int nbVraiOuFaux;
            Random rnd = new Random();
            bool vraiOuFaux;
            int positionPerso = 0;
            int tentative = 0;

            for (int i = 0; i < 99; i++)
            {
                nbVraiOuFaux = rnd.Next(1, 3);  // Préférable de générer 0 (faux) ou 1 (vrai)
                if (nbVraiOuFaux == 1)
                {

                    vraiOuFaux = true;
                }
                else
                {
                                                // Ne pas mettre le else vide
                }
                {
                                            
                }                       
                {                               

                    vraiOuFaux = false;         // Pourquoi c'est entre accolades ?
                }

                tableau[i] = vraiOuFaux;

            }

            tableau[0] = true;
            tableau[99] = true;



            while (key != "q")
            {
                Console.WriteLine("Que Faire ? ASD GH ou Y (Entier) ou P (10) ------- Tentatives = " + tentative);

                key = Console.ReadLine();

                // CC : OK. Ajouter un commentaire qui explique ce que tu fais et surtout pourquoi.
                if (tableau[positionPerso + 1] == false && tableau[positionPerso + 2] == false && tableau[positionPerso + 3] == false && tableau[positionPerso + 4] == false)
                {

                    Console.WriteLine("Solution Impossible");
                    key = "q";

                 
    // Mettre l'accolade sur la ligne en dessous. Ça crée un bug majeur quand on fait tab après (fais-moi signe, faut que je te montre!!)
                }else
                {
                    // Il aurait été plus judicieux d'utiliser un case pour les lettres
                    // Bouton A

                    if (key.ToLower() == "a" && positionPerso > 3 && tableau[positionPerso - 3] != false)
                    {

                        positionPerso -= 3;

                    }else if(key.ToLower() == "a")
                    {

                        Console.WriteLine("Impossible");

                    }



                    // Bouton S


                    if (key.ToLower() == "s" && positionPerso > 2 && tableau[positionPerso - 2] != false)
                    {


                        positionPerso -= 2;
                    }else if (key.ToLower() == "s")
                    {

                        Console.WriteLine("Impossible");

                    }




                    //Bouton D


                    if (key.ToLower() == "d" && positionPerso > 1 && tableau[positionPerso - 1] != false )
                    {


                        positionPerso -= 1;
                    }
                    else if (key.ToLower() == "d")
                    {

                        Console.WriteLine("Impossible");

                    }


                    // Bouton G

                    if (key.ToLower() == "g" && positionPerso < 98 && tableau[positionPerso + 2] != false )
                    {


                        positionPerso += 2;
                    }
                    else if (key.ToLower() == "g")
                    {

                        Console.WriteLine("Impossible");

                    }


                    // Bouton H

                    if (key.ToLower() == "h" && positionPerso < 96 && tableau[positionPerso + 4] != false )
                    {


                        positionPerso += 4;
                    }
                    else if (key.ToLower() == "h")
                    {

                        Console.WriteLine("Impossible");

                    }




                }

                // Trop d'espacement


                // Bouton Y


                if (key.ToLower() == "y")
                {
                    Console.Clear();
                    AffichageEntier(tableau, positionPerso);
                    Console.WriteLine("");

                }

                if (key.ToLower() == "p")
                {
                    Console.Clear();
                    Affichage10(tableau, positionPerso);
                    Console.WriteLine("");

                }

                // Bouton Q

                if (key.ToLower() == "q")
                {


                }

                // Indentation
                if ( key != "y" && key != "p" && key != "q")
                {
                tentative++;

                }


            }


            Console.ReadLine();

            
        }



        //-----------------------------------------------------------------------  Fonctions --------------------------------------------------------------------------------


        public static void AffichageEntier(bool[] tableau, int positionPerso)
        {

            for (int i = 0; i < 99; i++)
            {

                if (positionPerso == i)
                {
                    Console.Write(" * ");

                }else if(tableau[i] == true)
                {

                    Console.Write(" _ ");
                }else
                {

                    Console.Write("|");
                }



            }

        }




        public static void Affichage10(bool[] tableau, int positionPerso)
        {


            if (positionPerso >= 90)
            {

                for (int i = positionPerso; i < 99; i++)
                {

                    if (positionPerso == i)
                    {
                        Console.Write(" * ");

                    }
                    else if (tableau[i] == true)
                    {

                        Console.Write(" _ ");
                    }
                    else
                    {

                        Console.Write("|");
                    }



                }



            }else
            {

                for (int i = positionPerso; i < positionPerso + 10; i++)
                {

                    if (positionPerso == i)
                    {
                        Console.Write(" * ");

                    }
                    else if (tableau[i] == true)
                    {

                        Console.Write(" _ ");
                    }
                    else
                    {

                        Console.Write("|");
                    }



                }


            }



        }


    }


}
