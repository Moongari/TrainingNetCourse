﻿using System;

namespace Jeu_de_maths
{
    class Program
    {

        static bool isReponseValid = false;
        static int firstNumber, secondNumber,iOperation;
        static Random rndNumber;
        static Random rndOperation;
        static int questionMax = 5;
        static int questionMin = 1;
        static int score = 0;
        static int reponseOperation = 0;
        static bool isResultValid = false;
        



        public enum MyOperation
        {
            addition=1,
            soustraction=2,
            multiplication=3
        }



        public enum ReponseScore 
        {
            bad =1,
            good = 2,
            excellent =3
        }


        static void PoserQuestion()
        {
            //rndNumber = new Random();
            //rndOperation = new Random();
            //iOperation = rndOperation.Next(1, 3);
            
            //firstNumber = rndNumber.Next(0, 10);
            //secondNumber = rndNumber.Next(0, 10);




            int iReponse = 0;
            Console.Write("========= JEU DE MATHS =========");
            Console.WriteLine();
            while (questionMin <= questionMax & !isReponseValid)
            {

                rndNumber = new Random();
                rndOperation = new Random();
                iOperation = rndOperation.Next(1, 3);

                firstNumber = rndNumber.Next(0, 10);
                secondNumber = rndNumber.Next(0, 10);


                //Console.WriteLine("=== Question de mathematique === ");
                Console.WriteLine();
                Console.WriteLine($"=== Question : {questionMin}/{questionMax} === ");

                typeOperationARealise();
                Console.WriteLine("indiquez votre réponse : ");
                string reponse = Console.ReadLine();

                try
                {
                    iReponse = int.Parse(reponse);
                    questionMin++;
                    if (questionMin == questionMax)
                    {
                        Console.WriteLine($"====== votre score est de  :  {score} ");
                        MessageScore(score);
                        Console.WriteLine("====== FIN DU JEU DE MATHS =====");
                        isReponseValid = true;
                    }


                }
                catch (Exception)
                {
                    
                    Console.WriteLine("ERREUR :  vous avez saisie une mauvaise valeur");
                    // ici on considere que si l'utilisateur se trompe on revient en arriere sur la question
                    questionMin--;



                }
            }
          
        }



        // permet de definir de maniere aleatoire un type d'operation
        static void typeOperationARealise()
        {
            Console.WriteLine($" valeur aleatoire du type d'operation : {iOperation}");
            Console.WriteLine();

            switch (iOperation)
            {
                case (int)MyOperation.addition:
                    Console.WriteLine($"l'operation {MyOperation.addition}  a été choisie");
                    Console.WriteLine($"Resolvez l'operation suivante : {firstNumber} + {secondNumber}");

                    Console.WriteLine();
                    break;
                case (int)MyOperation.soustraction:
                    Console.WriteLine($"l'operation {MyOperation.soustraction}  a été choisie");
                    Console.WriteLine($"Resolvez l'operation suivante : {firstNumber} - {secondNumber}");
                    Console.WriteLine();
                    break;
                case (int)MyOperation.multiplication:
                    Console.WriteLine($"l'operation {MyOperation.multiplication}  a été choisie");
                    Console.WriteLine($"Resolvez l'operation suivante : {firstNumber} * {secondNumber}");

                    Console.WriteLine();
                    break;

                default:
                    break;
            }
        }




        /// <summary>
        /// Message a l'utilisateur en fonction du nombre de points obtenus
        /// </summary>
        /// <param name="score"></param>
        static void MessageScore(int score)
        {
            switch (score)
            {
                case 0 :
                    Console.WriteLine();
                    Console.WriteLine($"Hummm  tu dois reviser  ton niveau est : {ReponseScore.bad}");
                    break;
                case 1:
                case 2:
                case 3:
                    Console.WriteLine();
                    Console.WriteLine($"Hummm  tu dois reviser  ton niveau est : {ReponseScore.good}");
                    break;
               
                case 4:
                case 5:
                    Console.WriteLine();
                    Console.WriteLine($"Hummm  tu dois reviser  ton niveau est : {ReponseScore.excellent}");
                    break;

                default:
                    break;
            }
        }

        // en fonction du type d'operation on va verifier le resultat de l'utilisateur 
        static void controlOperation(int operation,int firstNumber, int secondNumber,string saisieUtilisateur)
        {

            switch (operation)
            {
                case (int)MyOperation.addition:
                    
                    reponseOperation = firstNumber + secondNumber;
                    if (int.Parse(saisieUtilisateur) == reponseOperation)
                    {
                      
                        score++;
                    }
                    else
                    {
                     
                    }

                    break;
                case (int)MyOperation.soustraction:
                    reponseOperation = firstNumber - secondNumber;



                    break;
                case (int)MyOperation.multiplication:
                    reponseOperation = firstNumber * secondNumber;
                    break;


                default:
                    break;
            }

        


        }



        static void Main(string[] args)
        {


            PoserQuestion();



        }
    }
}
