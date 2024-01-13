using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       string[] characters ={"Vox Akuma", "Luca Kaneshiro", "Mysta Rias", "Ike Eveland", "Shu Yamino"};
       string[] ability ={"Voice Demon", "Mafia", "Fox", "Time Traveler", "Sorcerer"};
       string[] equipments = {"Blue-Diamond Pen", "Purple Flames", "Pomu Leaf", "Dragoon", "Purple Flamed Fire"};
       
        string story = $"In the Royal Flash Kingdom, 5 lads possessed different magical powers and capabilities.\n"+
             $"{characters[0]},  the {ability[0]}, has the power to influence others with his voice..\n"+ 
             $"{characters[1]}, the mean and evil {ability[1]} boss from the past\n"+
             $"{characters[2]}, the genius detective, is also a {ability[2]} in nature.\n"+
             $"{characters[3]}, is a novelist who is a {ability[3]} using his {equipments[0]}.\n"+
             $"And finally, {characters[4]}, a {ability[4]} with the ability to control his victim’s\n"+
             $"minds through his magical {equipments[1]}.\n"+
             $"They are heroes. As they ventured through Diamond City Lights, \n"+
             $"they were met with various elements that affected their powers gradually,\n"+
             $"the {equipments[2]}, remnants of Pomu Fairies who died because of a so-called angel,\n"+
             $"Enna Alouette. Enna Alouette used the Pomu Leaf to lure the five lads to her.\n"+
             $"However, before they arrive in Enna’s kingdom, they met a flaming purple {equipments[3]},\n"+
             $"Selen Tatsuki. Selen attacked the five lads,\n"+
             $"and they fought their hardest to defend and attack.\n"+ 
             $"But, Selen’s{equipments[4]} was so powerful, and Mysta sacrificed himself.\n"+ 
             $"Taking the attack, to help save his friends. Mysta died."+ 
        
        Console.WriteLine(story);
        Console.WriteLine("=============================================");
        
    }
}
// still has error sa pagprint 
