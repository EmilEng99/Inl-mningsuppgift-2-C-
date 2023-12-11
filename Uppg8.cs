Console.WriteLine("Skriv in tal 1:");
    int tal1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Skriv in tal 2:");
    int tal2 = int.Parse(Console.ReadLine());

    if (tal1 == tal2){
        Console.WriteLine("Talen är lika stora");
    } else if (tal1 > tal2){
        Console.WriteLine("Det första talet är större än det andra.");
    } else {
        Console.WriteLine("Det andra talet är större än det första");
    }
