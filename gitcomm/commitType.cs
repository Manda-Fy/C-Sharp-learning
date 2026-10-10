namespace GitComm;
public class Choix
{
    public static string GiveType(int choix){

            switch(choix)
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
