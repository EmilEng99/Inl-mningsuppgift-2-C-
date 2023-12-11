Console.WriteLine("Vänligen skriv in ett tal mellan 1-10");
    int svar = int.Parse(Console.ReadLine());
    int i;

    for (i = 1; i <= 10; i++){
        Console.WriteLine("{0} * {1} = {2}",svar,i,(svar * i));
    }
