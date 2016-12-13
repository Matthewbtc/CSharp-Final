using System;


public class BattleSystem
{
public string StartMessage;
public bool enterenceOpen = true;
public string[] Enemy = {"Swoop Bat", "Faned Beast", "Soft Troll", "Sour Mage", "Damped Dragon"};

public void Enter (){
    Console.WriteLine(StartMessage);
}

public void Encounter (int i){
        switch(i)
        {
            case 0:
                Console.WriteLine("You stumbled upon a " + enemy[i] + "its your move..." );
                //summon RandomEnemy
                //reference BattleScene
            break;

            case 1:

            break;

            case 2:
                Console.WriteLine("You stumbled upon a " + enemy[i] + "its your move...");
                Game.GameTimer();
                Random RandomEnemy = new Random ();
                (randomNum.Next(0, Game.Underwater.objects.Length));
            break;

            case 3:
            //Lava kills and ends game
                Console.WriteLine("You've walked into " + objects[i]);
                Game.canPlay = false;
            break;

            default:
                Console.WriteLine("Your path is clear");
            break;
        }
}
}