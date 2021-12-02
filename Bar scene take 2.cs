// See https://aka.ms/new-console-template for more information
Console.Title = "Bar Scene Take 2";

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Welcome to 'Bar Scene'.\nPress any + ENTER to begin.");
Console.ReadLine();
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Narrator: You walk into your local bar.\nIt's been a long day at work.\nIt's pouring outside and you forgot your jacket at home.");
// Bartender
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Bartender: Looks like you've seen bettah days...\nWhat can I get ya to drink?");
// User 
{Console.ForegroundColor = ConsoleColor.Green;

var userDrink = Console.ReadLine();

//Bartender
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Bartender: " + userDrink + ", that sure sounds refreshin'. Comin' right up.\n*leaves to make drink*");
}
// Narrator
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Press any key + ENTER to continue.");
// user
Console.ForegroundColor = ConsoleColor.Green;
Console.ReadLine();

// Bartender
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Bartender: *serves the drink*\nY'know, I don't think I've evah seen yah here before. What's yah name?");
// user 
{
// user 
    Console.ForegroundColor = ConsoleColor.Green;
    var userName = Console.ReadLine();

// Bartender
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Bartender: " + userName + "... I don't beleive I've heard of yah.\nWher're yah from?");
}
{
// User
    Console.ForegroundColor = ConsoleColor.Green;
    var userOrigin = Console.ReadLine();

// bartender
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Bartender: " + userOrigin + "... That's pretty far, right?");
}
Console.WriteLine("Well, it's always nice to see a new face every once in a while.\nNice talkin' to yah, I gotta go clean glasses >:(\n*leaves to clean glasses*");
// Narrator
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Press any key + ENTER to continue.");
// user
Console.ForegroundColor = ConsoleColor.Green;
Console.ReadLine();

// narrator
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("After a few sips of your drink, a big, burly man sits 2 seats down from you.\nYou look at him for a splt second before quickly looking back at your drink");
// Brutus
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Man: What's a shrimp like you doin' here?");
// narrator
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("What will you say?");
Console.WriteLine("1 - Minding my own business. You should try it.\n2 - Fuck off");
// user 
Console.ForegroundColor = ConsoleColor.Green;
var option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        // Brutus
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Man: Mind my own business, huh?");
        break;
    case 2:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Man: What did you just say to me?");
        break;
}
// Bartender
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Bartender: Now, now, Brutus. There's no need to get hostile.");
// Brutus
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Brutus: Oh, shut up you chump.");
// Narrator
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Some of Brutus' goons from around the bar stand up to help their hulking leader");
Console.WriteLine("What will you do?\n1 - Run away\n2 - Stay and fight like your dad would want you to.");
// User
Console.ForegroundColor = ConsoleColor.Green;
var option2 = Convert.ToInt32(Console.ReadLine());

switch (option2)
{
    case 1:
        // Narrator
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("You make it only 2 feet.");
        // Brutus
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Brutus: *grabs your collar from the back*\nWhere do you think you're goin'?!");
        break;
    case 2:
        // Brutus
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Brutus: *cracks his comically large knuckles before schlogging you square in the face*");
        Console.WriteLine("*laughs*\nIs that all you got?");
        break;
}
// Narrator
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Press any key + ENTER to continue.");
// user
Console.ForegroundColor = ConsoleColor.Green;
Console.ReadLine();

// narrator
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Out of Nowhere, a full bottle slams into Brutus' head and knocks him out.\nHe lands on the wooden floor with a thunderous boom.");
Console.WriteLine("You look towards the direction from whence the bottle came and see a woman with a leather jacket\nShe grabs your arm and drags you outside.");
Console.WriteLine("What will you say?\n1 - Who are you?\n2 - Where are you taking me?");
// User
Console.ReadLine();

// Woman
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Woman: Just wait.");
// narrator
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("She drags you to a car.\nAs you get in, you hear a bullet hit the metal right above your head.");
Console.WriteLine("What will you do?\n1 - Look back and redicule the thugs.\n2 - Get in and get out of this place.");
// User
Console.ForegroundColor = ConsoleColor.Green;
var option3 = Convert.ToInt32(Console.ReadLine());

switch (option3)
{
    case 1:
        // User's character
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You: *you look back at them*\nWhat the hell is wrong with you? Are you cra-?");
        // Woman
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Woman: GET IN NOW!\n*grabs your arm and pulls you in*\nWe need to leave!");
        break;
    case 2:
        // User's character
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You: Holy shit!\n*you get in the car");
        break;
}
// Woman
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Woman: *slams on the gas*");
// Narrator
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("What will you ask?\n1 - Who are you?\n2 - Where are you taking me?");
// User
Console.ForegroundColor = ConsoleColor.Green;
var option4 = Convert.ToInt32(Console.ReadLine());

switch (option4)
{
    case 1:
        // Uranus
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Uranus: Call me Uranus. That's my code name.");
        // narrator
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("You look at her tying to stifle a laugh\nShe looks at you with a disgusted face.");
        // Narrator
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Press any key + ENTER to continue.");
        // user
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ReadLine();

        // Uranus
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Uranus: I'm taking you someplace safe. You just got involved with some very dangerous people.");
        // User's character
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You: What kind of dangerous people?");
        // Narrator
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Press any key + ENTER to continue.");
        // user
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ReadLine();

        // Uranus
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Uranus: The kind of people who can get you killed.");
        Console.WriteLine(" ");
        //Narrator
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("To be continued..."); 
        break;
    case 2:
        // Woman 
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Woman: I'm taking you someplace safe. You just got involved with some very dangerous people.\nAlso, call me 'Uranus'. That's my code name.");
        // narrator
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("You look at her tying to stifle a laugh\nShe looks at you with a disgusted face.");
        // Narrator
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Press any key + ENTER to continue.");
        // user
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ReadLine();
        
        // User's character
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You: Um, what kind of dangerous people?");
        // Narrator
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Press any key + ENTER to continue.");
        // user
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ReadLine();
        
        // Uranus
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Uranus: The kind of people who can get you killed.");
        Console.WriteLine(" ");
        //Narrator
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("To be continued..."); 

        break;
}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(" ");
Console.WriteLine("Thank you for participating! Press any key to leave.");
// wait before closing
Console.ReadKey(); 