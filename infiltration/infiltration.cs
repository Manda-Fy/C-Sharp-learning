using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security;

class QuestLogic
{

    public bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake)
        {
        return false;
        }
        return true;
    }
    public bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(knightIsAwake || archerIsAwake || prisonerIsAwake)
        {
            return true; 
        }
        return false;
    }
    public bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(prisonerIsAwake==true && archerIsAwake == false)
        {
            return true; 
        }
        return false; 
    }
    public bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake,bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent && archerIsAwake == false)
        {
            return true; 
        }
        if(petDogIsPresent==false && prisonerIsAwake == true && knightIsAwake == false && archerIsAwake == false)
        {
            return true; 
        }
        return false; 
    }

}
partial class Program
{
    public static void Main()
    {
        QuestLogic questLogic = new QuestLogic(); 
        var knightIsAwake = true;
        Console.WriteLine(questLogic.CanFastAttack(knightIsAwake));
        knightIsAwake = false; 
        var archerIsAwake = true; 
        var prisonerIsAwake = false; 
        Console.WriteLine(questLogic.CanSpy(knightIsAwake,archerIsAwake,prisonerIsAwake));
        archerIsAwake = false; 
        prisonerIsAwake = true;
        Console.WriteLine(questLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake));
        knightIsAwake = false;
        archerIsAwake = true;
        prisonerIsAwake = false;
        var petDogIsPresent = false;
        Console.WriteLine(questLogic.CanFreePrisoner(knightIsAwake,archerIsAwake,prisonerIsAwake,petDogIsPresent ));

    }
}                   