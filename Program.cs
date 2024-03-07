// The player starts with 0 strength
int strength = 0;
// The player does not start with the sword
bool hasSword = false;
// The player does not start with the key
bool hasKey = false;

Console.Clear();
CaveEntrance();

void CaveEntrance()
{
    Console.WriteLine("""
    =-=-=-=-=-=-=-=
    -Cave Entrance-
    =-=-=-=-=-=-=-=

    You stand before a cave. It is well known that an evil dragon slumbers here.
    From time to time, the dragon wakes to terrorize the nearby villages and steal
    their gold. Dare you [enter] the cave in search of riches? Or would you rather
    [run] home to the comfort of your warm bed?

    """);

    Console.Write("What do you do? ");

    string userInput = Console.ReadLine()!;

    if (userInput == "enter")
    {
        Console.WriteLine("You swallow hard and bravely enter the cave.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        MouthOfCave();
    }
    else if (userInput == "run")
    {
        Console.WriteLine($"Scared of the dragon, you run home to your bed where fall asleep.");
        // Environment.Exit(0) will exit the program
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("That is not a valid choice. Try 'run' or 'enter'.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        CaveEntrance();
    }
}

void MouthOfCave()
{
    Console.WriteLine("""
    =-=-=-=-=-=-=-=-=-=
    -Mouth of the Cave-
    =-=-=-=-=-=-=-=-=-=

    You are at the mouth of the cave. It is dark and damp. Luckily, you brought your
    trusty flashlight with you! You can see two paths here. One leads to the [left]
    and the other leads to the [right]. You can also see the [entrance] of the cave.

    """);
    Console.Write("What do you do? ");
    string userInput = Console.ReadLine()!;

    if (userInput == "left")
    {
        Console.WriteLine("You take the path to the left.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        DeadEnd();
    }
    else if (userInput == "right")
    {
        Console.WriteLine("You take the path to the right.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Tunnel();
    }
    else if (userInput == "entrance")
    {
        Console.WriteLine("You return to the entrance of the cave.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        CaveEntrance();
    }
    else
    {
        Console.WriteLine("That is not a valid choice. Try 'left', 'right', or 'entrance'.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        MouthOfCave();
    }
}

void DeadEnd()
{
    Console.WriteLine("""
    =-=-=-=-=-=
    -Dead End -
    =-=-=-=-=-=

    You have reached a dead end. There is a large [boulder] here. A path leads [back] to
    the mouth of the cave.

    """);

    Console.Write("What do you do? ");
    string userInput = Console.ReadLine()!;

    if (userInput == "back")
    {
        Console.WriteLine("You return the way you came.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        MouthOfCave();
    }
    else if (userInput == "boulder" && hasKey is true)
    {
        Console.WriteLine("You already moved the boulder.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        DeadEnd();
    }
    else if (userInput == "boulder" && strength < 10)
    {
        Console.Write("You attempt to lift the boulder");
        Thread.Sleep(250);
        Console.Write(".");
        Thread.Sleep(250);
        Console.Write(".");
        Thread.Sleep(250);
        Console.Write(".");
        Thread.Sleep(250);

        Console.WriteLine("But you are not strong enough.");
        Console.WriteLine("It seems like you need to hit the gym.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        DeadEnd();
    }
    else if (userInput == "boulder" && strength >= 10)
    {
        Console.WriteLine("You attempt to lift the boulder");
        Thread.Sleep(250);
        Console.Write(".");
        Thread.Sleep(250);
        Console.Write(".");
        Thread.Sleep(250);
        Console.Write(".");
        Thread.Sleep(250);
        Console.WriteLine("Success! Beneath the boulder you find a key.");
        Console.WriteLine("You put it in your pocket for safe keeping.");
        hasKey = true;
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        DeadEnd();
    }
    else
    {
        Console.WriteLine("That is not a valid choice. Try 'boulder', or 'back'.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        DeadEnd();
    }
}

void Tunnel()
{
    Console.WriteLine("""
    =-=-=-=-=-=-=-=-=-=-=-=
    -A Long Winding Tunnel-
    =-=-=-=-=-=-=-=-=-=-=-=

    You are in a long winding tunnel. It is pitch black except for the beam emitting
    from your flashlight. You notice a [button] on the wall here. In one direction,
    the tunnel leads to the [mouth] of the cave. In the other, the [tunnel]
    continues.

    """);
    Console.Write("What do you do? ");
    string userInput = Console.ReadLine()!;

    if (userInput == "button")
    {
        Console.Write("You press the button");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine("Ding! The wall next to the button opens revealing an elevator!");
        Console.Write("Entering the elevator, you begin to descend");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine("The elevator door opens and you exit.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Gym();

    }
    else if (userInput == "mouth")
    {
        Console.WriteLine("You return to the mouth of the cave.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        MouthOfCave();
    }
    else if (userInput == "tunnel")
    {
        Console.WriteLine("You continue down the tunnel.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        LargeCave();
    }
    else
    {
        Console.WriteLine("That is not a valid choice. Try 'button', 'mouth', or 'tunnel'");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Tunnel();
    }
}

void Gym()
{
    Console.WriteLine("""
    =-=-=-=-=-=-=
    -Ye Olde Gym-
    =-=-=-=-=-=-=

    You are in a gym filled with exercise equipment. A sign on the wall reads, 'Ye
    Olde Gym'. It appears all of the equipment is in use except for some [weights].
    On the far wall is an [elevator].

    """);
    Console.Write("What do you do? ");
    string userInput = Console.ReadLine()!;

    if (userInput == "elevator")
    {
        Console.Write("You enter the elevator and begin to ascend");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine("Ding! The door opens and you step out into the cave.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Tunnel();
    }
    else if (userInput == "weights" && strength < 10)
    {
        Console.WriteLine("You pick up the weights and do a rep!");
        strength = strength + 6;
        Thread.Sleep(1000);
        Console.WriteLine($"Your strength is now {strength}.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Gym();
    }
    else if (userInput == "weights" && strength >= 10)
    {
        Console.WriteLine("You're feeling pretty beefy already. Maybe you could lift some boulders!");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Gym();
    }
    else
    {
        Console.WriteLine("That is not a valid choice. Try 'weights' or 'elevator'");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Gym();
    }
}

void LargeCave()
{
    Console.WriteLine("""
    =-=-=-=-=-=-=-=-=-=-=-=
    -A Large Natural Cave -
    =-=-=-=-=-=-=-=-=-=-=-=

    You are in a large natural room within a cave. It is unnaturally warm here and
    you can hear what sounds like a giant creature [snoring] around a corner. In the
    center of the room is a [chest]. A [tunnel] leads back toward the mouth of the
    cave.

    """);
    Console.Write("What do you do? ");
    string userInput = Console.ReadLine()!;

    if (userInput == "chest" && hasKey is false)
    {
        Console.WriteLine("The chest is locked!");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        LargeCave();
    }
    else if (userInput == "chest" && hasKey is true)
    {
        Console.WriteLine("You open the chest!");
        if (hasSword is false)
        {
            Console.WriteLine("Inside is an beautiful ornate sword. You take it!");
            hasSword = true;
        }
        else
        {
            Console.WriteLine("The chest is empty.");
        }
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        LargeCave();
    }
    else if (userInput == "tunnel")
    {
        Console.WriteLine("You head back toward the cave entrance.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Tunnel();
    }
    else if (userInput == "snoring")
    {
        Console.WriteLine("You cautiously walk toward the snoring...");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Lair();
    }
    else
    {
        Console.WriteLine("That is not a valid choice. Try 'snoring', 'chest', or 'tunnel'");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        LargeCave();
    }
}

void Lair()
{
    Console.WriteLine("""
    =-=-=-=-=-=-=-=-=-=
    -The Dragon's Lair-
    =-=-=-=-=-=-=-=-=-=

    You are standing inside of a dragon's lair! The air is hot and dank. A tunnel
    leads [back] the way you came. In the center of the room is a massive pile of
    gold atop which a massive red dragon slumbers. Probably best not to [wake] the
    dragon. If you could [slay] it, you would be a hero!

    """);
    Console.Write("What do you do? ");
    string userInput = Console.ReadLine()!;

    if (userInput == "back")
    {
        Console.WriteLine("You head back the way you came.'");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        LargeCave();
    }
    else if (userInput == "wake")
    {
        Console.Write("You wake the dragon");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine("The dragon wakes and snarls, 'Who disturbs my slumber!?' It glares at you with");
        Console.WriteLine("disdain and smiles crookedly before devouring you. The dragon lets out a");
        Console.WriteLine("satisfying belch before closing its eyes and drifting back to sleep.");
        Environment.Exit(0);
    }
    else if (userInput == "slay" && hasSword is false)
    {
        Console.Write("You attempt to pummel the dragon with your fists");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine("The dragon wakes and snarls, 'Who disturbs my slumber!?' It glares at you with");
        Console.WriteLine("disdain and smiles crookedly before devouring you. The dragon lets out a");
        Console.WriteLine("satisfying belch before closing its eyes and drifting back to sleep.");
        Environment.Exit(0);
    }
    else if (userInput == "slay" && hasSword is true)
    {
        Console.Write("You draw your sword to slay the dragon");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine("With your sword in hand, you sneak up to the dragon and drive it into the");
        Console.WriteLine("beast's heart. The evil dragon winces as it realizes its reign of terror is");
        Console.WriteLine("over. Congratulations, you are a hero!");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("That is not a valid choice. Try 'back', 'wake', or 'slay'");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Lair();
    }
}
