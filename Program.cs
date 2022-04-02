using rpg.src.Entities;

Knight arus = new Knight("Arus", 42, "Knight", 749, 469, 72, 72);
Ninja wedge = new Ninja("Wedge", 42, "Ninja", 574, 292, 89, 89);
Wizard jenica = new Wizard("Jenica", 42, "White Wizard", 601, 325, 482, 474);
Wizard topapa = new Wizard("Topapa", 42, "Black Wizard", 385, 106, 641, 611);

Console.WriteLine(arus.ToString());
Console.WriteLine(wedge.ToString());
Console.WriteLine(jenica.ToString());
Console.WriteLine(topapa.ToString());

Console.WriteLine();

Console.WriteLine(arus.Attack(3));
Console.WriteLine(wedge.Attack(5));
Console.WriteLine(jenica.Attack(2));
Console.WriteLine(topapa.Attack(7));
