using System;
public class Game {

    public static bool canPlay = true;

    public Game() {
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo.";
        Cave.StartMessage = "You have entered a cave.";
    }
    public void Start (){
        Console.WriteLine("please typr in your name.")
        name = Console.ReadLine();
        Console.WriteLine("Your Player name is " + name);
        Cave.Enter();
        while(Game.canPlay) {
            GameTimer();
            Walk();
        }
        Console.WriteLine("You died.");
        Console.WriteLine("Game Over.");
    }

    private void Walk () {
        Random randomNum = new Random ();

        Cave.Encounter(randomNum.Next(0, Cave.objects.Length));
    }

    public static void GameTimer (){
         System.Threading.Thread.Sleep(2000);
    }

    //Game PowerUps
    private LevelBase Cave = new LevelBase();
    public static LevelBase Underwater = new LevelBase();
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();

    //Game Weapons
    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();
    private WeaponBase Knife = new WeaponBase();

    public string name;
    private int score;
}