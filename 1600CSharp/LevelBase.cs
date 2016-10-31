using System;


public class LevelBase
{
public string StartMessage;
public bool enterenceOpen = true;
public string[] environment = {"Cold", "Wet", "Dark" };
public string[] objects = {"Rock", "Ravine", "River", "Lava"};

public void Enter (){
    Console.WriteLine(StartMessage);
}

public void Encounter (int i){
        switch(i)
        {
            case 0:
                Console.WriteLine("You've walked into " + objects[i]);
            break;

            case 1:

            break;

            case 2:
                Console.WriteLine("You've walked into " + objects[i]);
                Game.GameTimer();
                Random randomNum = new Random ();
                Game.Underwater.Encounter(randomNum.Next(0, Game.Underwater.objects.Length));
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