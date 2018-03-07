using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCsharp6
{
    class Program
    {
       /* void textnombre(string nbre)
        {
            int i;
            int p;

            for (i=1; i <= (nbre.Length) ; i++)
            {
                if (char.IsDigit(nbre, i))
                {
                    p = 1;
                }
                else
                {
                    p = 0;
                }
                Console.WriteLine(p);
            }*/
            
        

        void Accueil()
        {
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("BIENVENUE POUR FAIRE UN CALCUL VEILLER CHOISIR LE TYPE D'OPERATION");
            Console.WriteLine();
            Console.WriteLine("Pour choisir une option entrer le numero devant l'option et appuyer sur 'Entrer'");
            Console.WriteLine();
            Console.WriteLine("1- Addition");
            Console.WriteLine("2- Soustraction");
            Console.WriteLine("3- Multiplication");
            Console.WriteLine("4- Division");
            Console.WriteLine("5- Quitter");
        }
       /*
        void Addition(double a, double b)
        {
            double s = 0;
            s = a + b;
            Console.WriteLine(s);
        }

        void Soustraction(double a, double b)
        {
            double s = 0;
            s = a - b;
            Console.WriteLine(s);
        }

        void Multiplication(double a, double b)
        {
            double s = 0;
            s = a * b;
            Console.WriteLine(s);
        }

        void Division(double a, double b)
        {
            double s = 0;
            s = a / b;
            Console.WriteLine(s);
        }*/
        static void Main(string[] args)
        {
           
            Program accueil = new Program();
            accueil.Accueil();
            Console.WriteLine();
            int choix = Int32.Parse(Console.ReadLine());

           
            switch (choix)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("-------------------- ADDITION --------------------");
                    Console.WriteLine("Veuillez saisir le premier et le deuxieme nombre");
                    double n1 = double.Parse(Console.ReadLine());
                    double n2 = double.Parse(Console.ReadLine());
                    double s = n1 + n2;
                    Console.WriteLine(n1 + " " + "+" + " " + n2 + "=" + s);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("-------------------- SOUSTRACTION --------------------");
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("-------------------- SOUSTRACTION --------------------");
                    Console.WriteLine("Vous avez choisi la SOUSTRACTION veuillez saisir le premier et le deuxieme nombre");
                    double n3 = double.Parse(Console.ReadLine());
                    double n4 = double.Parse(Console.ReadLine());
                    double s2 = n3 + n4;
                    Console.WriteLine(n3 + " " + "+" + " " + n4 + "=" + s2);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("-------------------- MULTIPLICATION --------------------");
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("-------------------- MULTIPLICATION --------------------");
                    Console.WriteLine("Vous avez choisi la MULTIPLICATION veuillez saisir le premier et le deuxieme nombre");
                    double n5 = double.Parse(Console.ReadLine());
                    double n6 = double.Parse(Console.ReadLine());
                    double s3 = n5 + n6;
                    Console.WriteLine(n5 + " " + "+" + " " + n6 + "=" + s3);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("-------------------- DIVISION --------------------");
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("-------------------- DIVISION --------------------");
                    Console.WriteLine("Vous avez choisi la DIVISION veuilez saisir le premier et le deuxieme nombre");
                    double n7 = double.Parse(Console.ReadLine());
                    double n8 = double.Parse(Console.ReadLine());
                    double s4 = n7 / n8;
                    Console.WriteLine(n7 + " " + "/" + " " + n8 + "=" + s4);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadLine();
        }
    }
}
