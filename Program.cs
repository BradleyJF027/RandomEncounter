Console.WriteLine("Welcome to Random Encounter!");
string name = string.Empty;
string choice = string.Empty;
int floorNo = 1;
Player player = new Player();
Character character = new Character();

Console.WriteLine("What is your name?");
do {
    name = Console.ReadLine();
    if (string.IsNullOrEmpty(name)) {
        Console.WriteLine("Please enter a valid name.");
    }
}
while (string.IsNullOrEmpty(name));
player.name = name;
Console.WriteLine($"Welcome {player.name}!");

do {
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1 - Start a run.");
    Console.WriteLine("2 - Quit.");
    choice = Console.ReadLine();
    if (choice != "1" && choice != "2") {
        Console.WriteLine("Please enter a valid option.");
    }
}
while (choice != "1" && choice != "2");
switch (choice) {
    case "1":
        Console.Clear();
        Console.WriteLine("=== Random Encounter ===");
        Console.WriteLine("");
        Console.WriteLine("You enter the dungeon...");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"=== FLOOR {floorNo} ===");
        Console.WriteLine("");
        Console.WriteLine("You encounter a goblin!");
        Console.WriteLine("");
        Console.WriteLine("Your stats:");
        Console.WriteLine($"Name: {character.name}");
        Console.WriteLine($"Class: {character.charClass}");
        Console.WriteLine($"Current HP: {character.currentHP}");
        Console.WriteLine($"Max HP: {character.maxHP}");
        Console.WriteLine($"Attack: {character.attack}");
        break;
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    case "2":
        Console.Clear();
        Console.WriteLine("Quitting the game...");
        break;
}