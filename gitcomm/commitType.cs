namespace GitComm;
public class Choix
{
    public static string GiveType(string choix){
        if(int.TryParse(choix, out int choixFinale))
        {
            
        }
        switch(choixFinale)
        {
            case 1:return "feat";
            case 2:return "chore";
            case 3:return "fix";
            case 4:return "refactor";
            case 5:return "docs";
        }
        return "Erreur";
    }
}
