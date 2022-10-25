// Mateusz K Wojno
Console.WriteLine("Rozwiazanie zadania numer 1");
Console.WriteLine("Aby zakonczyc dzialanie programu nacisnij ctrl+c w terminalu");

while (true)
{
Console.WriteLine("Podaj swoj wiek:");
string userAge_str = Console.ReadLine();
int userAge = Convert.ToInt16(userAge_str);      
if (userAge  <18)
{
    Console.WriteLine("Jestes za mlody");
}
else if (userAge >= 18 && userAge < 70)
{
    Console.WriteLine("Mozesz wejsc");
}
else 
{
    Console.WriteLine("Jestes za stary");    
}
}




