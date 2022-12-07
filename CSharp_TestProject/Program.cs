using System;
using System.Globalization; // permet d'utiliser CultureInfo (voir lignes 10 à 13)

namespace CSharp_TestProject
{
    internal class Program
    {
        /**
         * Version plus sympa visuellement, mais un peu moins évidente.
         * Pour la version un peu simple, regarde le fichier "ProgramEasy.cs".
         */
        static void Main(string[] args)
        {
            // On récupère les informations liées à la culture française.
            // C'est fourni par Microsoft directement dans le framework .NET, c'est assez pratique !
            // C'est ce qui va nous permettre de charger les dates directement en format français, sans avoir à spécifier un format de date précis.
            // Le format de date sera récupéré directement dans cette variable.
            var FrenchCultureInfo = new CultureInfo("fr-FR");

            // On demande la date de naissance, on la transforme en un objet DateTime, et on l'enregistre dans une variable.
            Console.Write("Veuillez saisir votre date de naissance au format JJ/MM/AAAA : ");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "d", FrenchCultureInfo);

            // On réaffiche la date saisie.
            // L'utilisation de la fonction ToShortDateString() est facultatif, c'est surtout pour que ça soit plus sympa visuellement.
            // Affichage de birthDate sans fonction ToShortDateString() : 01/01/2022 00:00:00
            // Affichage birthDate avec fonction ToShortDateString() : 01/01/2022
            Console.WriteLine("Vous avez saisi la date suivante : " + birthDate.ToShortDateString());

            // Pour calculer l'âge, on utilise la date actuelle, que l'on peut récupérer en utilisant la valeur de "DateTime.Now".
            // Ensuite, c'est assez simple pour calculer l'âge.
            var DiffDates = DateTime.Now - birthDate;

            // Pour pouvoir exploiter ça, on doit contourner un peu : on ne peut pas accéder à l'année directement.
            // Donc on part du 1er janvier 1, on y ajoute la différence trouvée au dessus, et on enlève l'année 1 du calcul.
            // Du coup, là, on a notre âge.
            int UserYearsOld = (new DateTime(1, 1, 1) + DiffDates).Year - 1;

            // On affiche l'âge que l'on vient de calculer.
            // "{0]" prévient le programme qu'on attend un argument pour compléter le texte, et c'est ce qu'on passe à la fonction.
            Console.WriteLine("Vous avez donc {0} ans.", UserYearsOld.ToString());
        }
    }
}
