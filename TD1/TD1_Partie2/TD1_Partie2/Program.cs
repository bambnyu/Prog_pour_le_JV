using System;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        int N = 15; //definit le nombre de tour de jeu a survivre 
        Personnage monPerso = new Personnage();
        Ennemi ennemi1 = new Ennemi();
        Allie allie1 = new Allie();
        while (monPerso.getVie() > 0 && N > 0 && ennemi1.getVie() > 0)
        {
            Console.WriteLine("*****TOUR SUIVANT*****");
            monPerso.marche();
            int testattaque_ennemi = ennemi1.attaque(); //tente d'attaquer
            int testattaque_allie = allie1.attaque(); // tente d'attque
                        

            string inputjoueur = Console.ReadLine();
            if (inputjoueur == "H")
            {
                Console.WriteLine("On soigne le personnage");
                monPerso.setVie(monPerso.getVie() + monPerso.getHeal() - (ennemi1.getPointsAttaque()*testattaque_ennemi));
            }
            else if (inputjoueur == "Z")
            {
                Console.WriteLine("On soigne l'allié");
                allie1.setVie(allie1.getVie() + monPerso.getHeal());
                monPerso.setVie(monPerso.getVie() - (ennemi1.getPointsAttaque() * testattaque_ennemi));
            }
            else if (inputjoueur == "D")
            {
                Console.WriteLine("L'allié défend, le Personnage se soigne");
                allie1.setVie(allie1.getVie() - (ennemi1.getPointsAttaque() * testattaque_ennemi));
                monPerso.setVie(monPerso.getVie() + monPerso.getHeal());
            }
            else if (inputjoueur == "A")
            {
                Console.WriteLine("L'allié attaque l'ennemi");
                monPerso.setVie(monPerso.getVie() - (ennemi1.getPointsAttaque() * testattaque_ennemi));
                ennemi1.setVie(ennemi1.getVie() - allie1.getPointsAttaque() * testattaque_allie);
            }
            else
            {
                Console.WriteLine("Le personnage prend les degats");
                monPerso.setVie(monPerso.getVie() - (ennemi1.getPointsAttaque() * testattaque_ennemi));
            }

            //afficher les stats a la fin du tour
            Console.WriteLine("Le personnage a : " + monPerso.getVie() + " points de vie");
            Console.WriteLine("L'allié' a : " + allie1.getVie() + " points de vie");
            Console.WriteLine("L'ennemi a : " + ennemi1.getVie() + " points de vie");
            Console.WriteLine("**************");
            ennemi1.incrementerPointAttaque();
            Console.WriteLine("L'ennemi a : " + ennemi1.getPointsAttaque() + " points d'attaque");
            Console.WriteLine("L'allié a : " + allie1.getPointsAttaque() + " points d'attaque");
            Console.WriteLine("**************");
            if (testattaque_ennemi == 1) { Console.WriteLine(" L'Ennemi réussi a attaquer"); } 
            else { Console.WriteLine(" L'Ennemi échoue a attaquer"); }
            if (testattaque_allie == 1) { Console.WriteLine(" L'allié réussi a attaquer"); }
            else { Console.WriteLine(" L'allié échoue a attaquer"); }
            N = N - 1; // on decremente le nombre de tour
        }
        if (monPerso.getVie() > 0 || N <= 0) { Console.WriteLine("C'est fini. Game Over Vous avez Gagné!"); }
        else { Console.WriteLine("C'est fini. Game Over Vous avez Perdu!"); }
    }


    public class Ennemi
    {
        private int pointsAttaque;
        private double vitesse;
        private int id;
        private int vie;
        public Ennemi()
        {
            vie = 100;
            vitesse = 5;
            pointsAttaque = 25;
            
        }
        public int attaque()
        { //méthode
            Random aleatoireEnnemi = new Random();
            int test = aleatoireEnnemi.Next(0, 1);
            //if ( test == 1) { Console.WriteLine(" L'Ennemi réussi a attaquer: - " + pointsAttaque); } //1 succès   0 échec
            //else { Console.WriteLine(" L'Ennemi échoue a attaquer: - " + pointsAttaque); }
            //Console.WriteLine(" J’attaque: - " + pointsAttaque);  //vieux a delete
            return test;
        }
        public void defend()
        { //méthode
            Console.WriteLine(" Je me défend ");
        }
        public void incrementerPointAttaque()
        { //méthode
            Console.WriteLine("Je prépare mon attaque! ");
            pointsAttaque++;
        }

        public int getVie()
        { //méthode
            return vie;
        }
        public void setVie(int modifieur)
        { //méthode
            vie = modifieur;
        }

        public int getPointsAttaque()
        { //méthode
            return pointsAttaque;
        }
        public void setPointsAttaque(int modifieur)
        { //méthode
            vie = modifieur;
        }



    }

    public class Personnage
    {
        private double vitesse;
        private int id;
        private int vie;
        private int heal;
        public Personnage()
        {
            vie = 75;
            vitesse = 5;
            heal = 15;
        }
        public void marche()
        { //méthode
            Console.WriteLine(" J’avance");
        }
        public void arrete()
        { //méthode
            Console.WriteLine(" J'arrete ");
        }
        public int getVie()
        { //méthode
            return vie;
        }
        public void setVie(int modifieur)
        { //méthode
            vie = modifieur;
        }
        public int getHeal()
        { //méthode
            return vie;
        }
        public void setHeal(int modifieur)
        { //méthode
            heal = modifieur;
        }

    }

    public class Allie
    {
        private int pointsAttaque;
        private int id;
        private int vie;
        public Allie()
        {
            vie = 75;
            pointsAttaque = 10;
        }
        public int attaque()
        { //méthode
            Random aleatoireEnnemi = new Random();
            int test = aleatoireEnnemi.Next(0, 1);
            //if (test == 1) { Console.WriteLine(" L'allié réussi a attaquer: - " + pointsAttaque); } //1 succès   0 échec
            //else { Console.WriteLine(" L'allié échoue a attaquer: - " + pointsAttaque); }
            //Console.WriteLine(" J’attaque: - " + pointsAttaque);  //vieux a delete
            return test;
        }
        public void defendPersonnage()
        { //méthode
            Console.WriteLine(" Je défend ");
        }
        public int getVie()
        { //méthode
            return vie;
        }
        public void setVie(int modifieur)
        { //méthode
            vie = modifieur;
        }
        public void setPointsAttaque(int points)
        { //méthode
            pointsAttaque = points;
        }
        public int getPointsAttaque()
        {
            return pointsAttaque;
        }
    }

}