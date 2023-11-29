using System;

namespace idk
{
    class Program
    {
        public static int code(int Essai)
        {
            int S, nbr;
            S = 1;

            while (Essai > 255 && S < 3)
            {
                S = S + 1;

                Console.WriteLine("Veuillez introduire un nombre inférieur à 255");
                Console.ReadLine();
            }

            nbr = Essai;

            return Essai;
        }
        public static void Donnebinaire(int Essai, out int binaire)
        {
            string nbbinaire;

            nbbinaire = Convert.ToString(Essai, 2);
            binaire = Convert.ToInt32(nbbinaire);
        }
        static void Main(string[] args)
        {
            int binaire, Essai, S, nbr;
            S = 3;

            Console.WriteLine("Ecrivez un nombre inferieur à 255");
            Essai = Int32.Parse(Console.ReadLine());

            nbr = code(Essai);

            while (Essai < 255)
            {
                Console.WriteLine("Le nombre correct que vous avez saisi est : " + Essai);

                Donnebinaire(Essai, out binaire);
                Console.WriteLine("Le nombre " + Essai + " vaut " + binaire + " en binaire");
                Console.ReadLine();
            }

            while (S == 3)
            {
                Console.WriteLine("Les nombres introduits sont supérieur à 255, donc invalide");
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
