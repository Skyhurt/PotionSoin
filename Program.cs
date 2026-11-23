namespace Potion_soin;

/*
    CONSIGNES
    Votre personnage possède des points de vie (HP). Il peut utiliser une potion pour récupérer de la santé.
    
    Créez une méthode UsePotion() qui reçoit deux paramètres :
    - healthPoints : les points de vie actuels du personnage.
    - healingAmount : le nombre de points de vie que la potion permet de récupérer.
    
    La méthode doit afficher un message sous la forme : "Le héros possède maintenant 80 PV."

    Dans Main(), testez les situations suivantes :
    1. Le héros possède 50 PV et récupère 30 PV.
    2. Le héros possède 20 PV et récupère 50 PV.
    Pour cet exercice, il n'est pas nécessaire de limiter les PV à 100.
 */
class Program
{
    static void UsePotion(int healthPoints,int healingAmount )
    {
        Console.WriteLine("Le héros possède maintenant " + (healthPoints + healingAmount) + " PV.");
    }
    static void Main(string[] args)
    {     
        UsePotion(50, 30);
        UsePotion(20, 50);
        int healingAmount = 0;
        int healthPoints = 0;

        int choiceHp;
        int choiceHealing;
        
        do
        {
            Console.WriteLine("Choix 1: 30PV ou Choix 2: 50PV ");
            choiceHp = Convert.ToInt32(Console.ReadLine());
            if (choiceHp == 1)
            {
                healthPoints = 30;
            }
                else if (choiceHp == 2)
                    {
                        healthPoints = 50;
                    }
                    else
                        {
                            Console.WriteLine("Choisis entre 1 ou 2 !");
                        }
        } while (choiceHp != 1 && choiceHp != 2);
        do
        {
            Console.WriteLine("Choix 1: Potion qui donne 20PV" + " Choix 2: Potion qui donne 50PV");
            choiceHealing = Convert.ToInt32(Console.ReadLine());
            if (choiceHealing == 1)
            {
                healingAmount = 20;
            }
            else if (choiceHealing == 2)
            {
                healingAmount = 50;
            }
        } while (choiceHealing != 1 && choiceHealing != 2);
        Console.WriteLine("Le héros possède maintenant " + (healthPoints + healingAmount) + " PV");
    }
}