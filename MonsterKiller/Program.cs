// See https://aka.ms/new-console-template for more information
using MonsterKiller.Models;

 static void Main()
{
    Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

    Mummy tuts = new Mummy();
    VonRimmersmark.Ignite(tuts);    
    
    Ghost ghost = new Ghost();
    VonRimmersmark.SplashWater(ghost);
    VonRimmersmark.Ignite(ghost);


   
}