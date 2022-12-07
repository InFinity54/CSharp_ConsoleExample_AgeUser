using System;

namespace CSharp_TestProject
{
    internal class ProgramEasy
    {
        /**
         * Version plus simple à comprendre (je pense).
         * Faut copier le contenu de cette fonction à la place de la fonction "Main" du fichier "Program.cs" pour la compiler.
         */
        static void AlternativeMain(string[] args)
        {
            // On demande la date de naissance, on la transforme en un objet DateTime, et on l'enregistre dans une variable.
            Console.Write("Veuillez saisir votre date de naissance au format JJ/MM/AAAA : ");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            // Pour simplifier encore plus, on peut aussi créer la DateTime en découpant le texte.
            // C'est plus facile à comprendre mais c'est peut-être un peu plus chiant à faire.
            // Faut découper le texte en trois parties, puis les passer dans le constructeur.
            // Exemple avec la date d'aujourd'hui : new DateTime(2022, 12, 07);

            // On réaffiche la date saisie.
            // L'utilisation de la fonction ToShortDateString() est facultatif, c'est surtout pour que ça soit plus sympa visuellement.
            // Affichage de birthDate sans fonction ToShortDateString() : 01/01/2022 00:00:00
            // Affichage birthDate avec fonction ToShortDateString() : 01/01/2022
            Console.WriteLine("Vous avez saisi la date suivante : " + birthDate.ToShortDateString());

            // Pour calculer l'âge, on utilise la date actuelle, que l'on peut récupérer en utilisant la valeur de DateTime.Now
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
