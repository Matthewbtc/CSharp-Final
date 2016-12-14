using System;
public class Enemies 

public string[] Enemy = {"Swoop Bat", "Faned Beast", "Soft Troll", "Sour Mage", "Damped Dragon"};
Random Enemy = new Random ();


//Enemies have health in turns of hits. One hit = 1 health
//damage percentile is the rate wich a CharacterClass can hit an Enemy  
//enemies health default to 1 (chance)

class SwoopBat
{
    health== 1
    attack== 5
    damage percentile== Random (30)
    //unless Lancer
}
class FanedBeast
{
    health== 1
    attack== 7
    damage percentile== Random (80)
}
class SoftTroll
{
    health== 2
    attack== 4
    //unless Mage 6
    damage percentile== Random (90)
}
class SourMage
{
    health== 1
    attack== 12
    //unless Warrior 15
    damage percentile== Random (75)
}
class DampedDragon
{
    health== 3
    attack== 10
    damage percentile== Random (50)
}
