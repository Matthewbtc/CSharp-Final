using System;
public class Enemies 

public string[] Enemy = {"Swoop Bat", "Faned Beast", "Soft Troll", "Sour Mage", "Damped Dragon"};
Random Enemy = new Random ();


//characters effect the class chance of attacking, enemy attack, and class special attack 
//enemies health default to 1 (chance)
public class Warrior
{
Classes SwoopBat = new Classes(30, 5, 90);
Classes FanedBeast = new Classes(90, 7, 100);
Classes SoftTroll = new Classes(90, 10, 100);
Classes SourMage = new Classes(100, 15, 80);
Classes DampedDragon = new Classes(40, 15, 0);
}