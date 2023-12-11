using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Text;

namespace Repetitionsuppgift_2;

class Program
{
    static void Main(string[] args)
    {
        char[] betygArray = {'A', 'B', 'C', 'D', 'E', 'F'}; 

        Console.WriteLine("Vill du beräkna betyg för eleven? (j/n)");
        string decide = (Console.ReadLine());
        string decide2;

            while (decide == "j"){
                Console.WriteLine("Ange elevens poäng: ");
                    int poäng = int.Parse(Console.ReadLine());

                if (decide == "j"){
                    if(poäng <= 100 && poäng >= 90){
                        Console.WriteLine($"Gratulerar! Du fick {poäng} poäng och får betyget {betygArray[0]}");
                    }
                    else if(poäng <= 89 && poäng >= 80){
                        Console.WriteLine($"Gratulerar! Du fick {poäng} poäng och får betyget {betygArray[1]}");
                    }
                    else if(poäng <= 79&& poäng >= 70){
                        Console.WriteLine($"Gratulerar! Du fick {poäng} poäng och får betyget {betygArray[2]}");
                    }
                    else if(poäng <= 69 && poäng >= 60){
                        Console.WriteLine($"Gratulerar! Du fick {poäng} poäng och får betyget {betygArray[3]}");
                    }
                    else if(poäng <= 59 && poäng >= 50){
                        Console.WriteLine($"Gratulerar! Du fick {poäng} poäng och får betyget {betygArray[4]}");
                    }
                    else if(poäng < 50){
                        Console.WriteLine($"Tyvärr, du fick {poäng} poäng och fick betyget {betygArray[5]}\nDetta innebär omprov för dig.");
                    }
                    
                    Console.WriteLine("Vill du fortsätta betygsätta? (j/n)");
                        decide2 = Console.ReadLine();
                        
                        if (decide2 == "n"){
                        Console.WriteLine("Programmet avslutas");
                        Thread.Sleep(1500);
                        Environment.Exit(0);
                        } 
                }
            }

            while (decide == "n"){
                if (decide == "n"){
                        Console.WriteLine("Programmet avslutas");
                        Thread.Sleep(1500);
                        Environment.Exit(0);
                } 
            }


    }
}

