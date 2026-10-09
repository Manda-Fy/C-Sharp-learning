using GitComm;
Console.WriteLine("========================== GITCOMM =======================");
Console.Write("|");
Console.WriteLine("Veuiller choisire le type de commit que vous allez faire |");
Console.Write("|");
Console.WriteLine("(1)feat / (2)chore / (3)fix / (4)refactor / (5)docs      |");
Console.Write("|");
Console.Write("Entrez votre choix : ");
string typeUtilisateur = Console.ReadLine()??"";
Console.Write("|");
string type = Choix.GiveType(typeUtilisateur);
Console.Write("Ecrivez la description du commit : ");
string descriptionUtilisateur = Console.ReadLine()??"";
Console.Write("|");
string description = Description.GiveDescription(descriptionUtilisateur);
string finaleCommit = $"git commit -m \"{type}: {description}\"";
Console.WriteLine("Voici votre commit finale                                |");
Console.WriteLine("========================= COMMIT =========================");
Console.Write("|");
Console.WriteLine($"{finaleCommit}");
Console.WriteLine($"==========================================================");


