// See https://aka.ms/new-console-template for more information
/* Inspiration:
 * https://youtube.com/watch?v=1PDkwZeUWh8&list=PLlLacQjlPI0pRy2siKx024PygHZFQWuj7&index=36
 * https://www.youtube.com/watch?v=d6Si3GAPeXY
 */
Console.WriteLine("--- The 100 The Text Game ---");
Console.WriteLine();
// Scene 1
Console.WriteLine("--- Clarke Griffin (you) sits at a table in the Mess Hall of the Ark with her best friend Wells Jaha eating lunch. ---");
Console.WriteLine();

Console.WriteLine("Wells: Hows your sandwich today?");
Console.WriteLine("Clarke: Disgusting.");
Console.WriteLine("Wells: You say that everyday.");
Console.WriteLine("Clarke: Well, it is.");
Console.WriteLine("Wells: Are you okay? You seem distracted today.");
Console.WriteLine("Clarke: Actually I am.");
Console.WriteLine("Clarke: I overheard my parents talking earlier. Apparently there is something wrong with the life support systems on the Ark.");
Console.WriteLine("Wells: What do you mean?");
Console.WriteLine("Clarke: I don't know, I'm not even supposed to know, but apparently there is only a few months of oxygen left up here.");
Console.WriteLine("Wells: Clarke, this is not the first time they've come across some kind of issue with the ship. The counsil always finds a way to fix it.");
Console.WriteLine("Clarke: I know, but from the sounds of it they might not be able to fix it this time. My dad seem pretty nervous. He's talking about going public with the info and hoping all the citizens of the Ark can put there minds to a solution.");
Console.WriteLine("Wells: Clarke he can't do that. He'd get floated.");
Console.WriteLine("Clarke: I know. Wells you can't tell anyone about this.");
Console.WriteLine("Wells: Your secrets safe with me Clarke.");
Console.WriteLine();

// Scene 2
Console.WriteLine("--- THE NEXT DAY ---");
Console.WriteLine();

Console.WriteLine("Scene: Clarke Griffin (you) walks in on her Dad recording a video to play throughout the Ark explaining the life support falure and asking for help.");
Console.WriteLine();

Console.WriteLine("Clarke: Dad! What are you doing?! You can't send that video out. You know they will float you.");
Console.WriteLine();
Console.WriteLine("--- Jake Griffin (Clarkes Dad) stares blankly at Clarke ---");
Console.WriteLine("Clarke: Dad, I know. I overheard you and Mom talking.");
Console.WriteLine("Jake: Ok so you know. Clarke I have to do this. They need to know. I feel like this could bring out the best in all of us and we can all work toward a solution together.");
Console.WriteLine("Clarke: So what are you planning? Are you gonna break into the comms system and play your video to all of the Ark?");
Console.WriteLine("Dad, no! Please.");
Console.WriteLine();
Console.WriteLine("--- Just then 6 gaurds break in and haul Jake away. ---");
Console.WriteLine("Gaurd: Jake Griffin you are under arrest for treason.");
Console.WriteLine("--- As the gaurds pull Jake out of the room, 2 of the gaurds take control over a fighting Clarke, stopping her from interfering with the arrest");
Console.WriteLine("--- They pull Jake into the airlock and put clarke into a Skybox jail cell. With the press of a button, Jake is gone, ejected into the dark void of space, dead.");

// Scene 3
Console.WriteLine();
Console.WriteLine("--- Clarke gets pulled from the Skybox and belted into a dropship. ---");
Console.WriteLine("--- The dropship launches from the Ark with the 100 prisoners of the Skybox each with a high tech wristband headed for the nuked planet Earth. The counsil hopes that in light of Jakes discovery of the failing life support the prisoners on Earth can survive long enough to prove that Earth is safe again for survival. ---");
Console.WriteLine("--- After landing the prisoners step out of the dropships and take there first steps on Earth in over 100 years. None of the prisoners are feeling any negative effects yet so for the time being Earth is safe ---");
Console.WriteLine();

// Scene 4
Console.WriteLine("CHOOSE YOU PATH (Type a number): Should Clarke:");
Console.WriteLine("1. Help fix the comms that got fried during landing.");
Console.WriteLine("2. Start building a base.");
Console.WriteLine("3. Find sources of food and water.");
Console.WriteLine("4. Explore Earth");
int selection = int.Parse(Console.ReadLine());
if(selection > 0 && selection < 5)
{
    if(selection == 1)
    {
        Console.WriteLine("--- Raven, another prisoner on the dropship and a zero G mechanic from the Ark, comes up to Clarke with a problem. ---");
        Console.WriteLine("Raven: Clarke, we've got a problem. We can't talk to the Ark. The rough landing we endured caused panels on the roof to fly off and the heat destroyed the wires.");
    }
    else if(selection == 2)
    {
        Console.WriteLine("--- Clarke starts exploring the woods surrounding the landing site for wood or debris from the dropship during the rough landing. ---");
    }
    else if (selection == 3)
    {
        Console.WriteLine("--- Food and water first. Remembering the video message from Chancellor Jaha that played in the dropship during landing, there is a chance of getting supplies from Mount Weather. Mount Weather was built before the apocalypse to survive a nuclear war. ---");
    }
    else if (selection == 4)
    {
        Console.WriteLine("--- After being locked up in the Skybox and trapped in space all her life, Clarke starts exploring Earth. ---");
    }
}