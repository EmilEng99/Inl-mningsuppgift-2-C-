Console.WriteLine("Vänligen skriv ett valfritt tal:");
    int tal = int.parse(Console.ReadLine());

    if (tal == 0 ){
        Console.WriteLine("Ditt tal är noll och är varken positivt eller negativt.");
    } else if (tal < 0){
        Console.WriteLine("Ditt tal är negativt.");
    } else {
        Console.WriteLine("Ditt tal är positivt.");
    }
