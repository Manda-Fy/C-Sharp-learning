using System;
using System.Collections.Generic;

// 1. "Tache" au singulier : représente UNE SEULE tâche
class Tache
{
    public string Nom { get; set; }
    public string Statut { get; set; }

    public Tache(string nom, string statut = "[ ]")
    {
        Nom = nom;
        Statut = statut;
    }

    public void AjouterUneTache(Tache tacheAAjouter)
    {
        GestionnaireDeTaches gestionnaireEphemere = new GestionnaireDeTaches();
        gestionnaireEphemere.TachesEnregistrees.Add(tacheAAjouter);
    }
}

// 2. Renommé pour éviter le conflit avec System.Collections.Generic.List
class GestionnaireDeTaches
{
    // Le conteneur s'appelle explicitement TachesEnregistrees
    public List<Tache> TachesEnregistrees = new List<Tache>();
}

class Program
{
    static void Main()
    {
        bool stopperProgramme = false;

        while (stopperProgramme == false)
        {
            string choixMenu = Console.ReadLine() ?? "2";

            if (choixMenu == "1")
            {
                Console.WriteLine("App start");

                string nomSaisi = Console.ReadLine() ?? "";
                string statutSaisi = Console.ReadLine() ?? "";

                // Instanciation claire d'une seule tâche
                Tache nouvelleTache = new Tache(nomSaisi, statutSaisi);

                // Instanciation de la liste
                GestionnaireDeTaches monGestionnaire = new GestionnaireDeTaches();
                monGestionnaire.TachesEnregistrees.Add(nouvelleTache);

                // La boucle parcourt "chaqueTache" dans "TachesEnregistrees"
                foreach (Tache chaqueTache in monGestionnaire.TachesEnregistrees)
                {
                    Console.WriteLine($"Nom de la taches : {chaqueTache.Nom}, Status : {chaqueTache.Statut}");
                }
            }

            if (choixMenu == "2")
            {
                stopperProgramme = true;
            }
        }

        Console.WriteLine("App stop");
    }
}