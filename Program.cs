// Mateusz K Wojno
Console.WriteLine("Aby uruchomic dany program prosze usunac komentarze");

// Console.WriteLine("Rozwiazanie zadania numer 1");
// Console.WriteLine("Aby zakonczyc dzialanie programu nacisnij ctrl+c w terminalu");
// while (true)
// {
// Console.WriteLine("Podaj swoj wiek:");
// string userAge_str = Console.ReadLine();
// int userAge = Convert.ToInt16(userAge_str);      
// if (userAge  <18)
// {
//     Console.WriteLine("Jestes za mlody");
// }
// else if (userAge >= 18 && userAge < 70)
// {
//     Console.WriteLine("Mozesz wejsc");
// }
// else 
// {
//     Console.WriteLine("Jestes za stary");    
// }
// } 


// Console.WriteLine("Rozwiazanie zadania numer 2");
// Console.WriteLine("Podaj pierwszy odcinek: ");
//     string firstNum_str = Console.ReadLine();
//     int firstNum = Convert.ToInt16(firstNum_str);
// Console.WriteLine("Podaj drugi odcinek: ");
//     string secondNum_str = Console.ReadLine();
//     int secondNum = Convert.ToInt16(secondNum_str);
// Console.WriteLine("Podaj trzeci odcinek: ");
//     string thirdNum_str = Console.ReadLine();
//     int thirdNum = Convert.ToInt16(thirdNum_str);
// if (firstNum + secondNum < thirdNum || secondNum + thirdNum > firstNum || firstNum + thirdNum > secondNum)
// {
//     Console.WriteLine("Z tych odcinkow mozna zbudowac trojkat");
// }
// else 
// {
//     Console.WriteLine("Z tych odcinkow nie zbudujesz trojkata");
// }



// Pseudo Code - while i  >= 6 && != 22 wypisz i, i++
// Console.WriteLine("Rozwiazanie zadania numer 3");

// int index = 6;
// while (index >=6 && index != 22)
// {
//     Console.WriteLine(index);
//     index++;
// }


// Console.WriteLine("Rozwiazanie zadania numer 4");
// // Pseudo Code -    while i >=12 && <= 50 && %2==0 wypisz i, i+=2
// int index = 12;
// while (index >=12 && index <=50 && index %2 == 0)
// {
//     Console.WriteLine(index);
//     index +=2;
// }
    
// Console.WriteLine("Rozwiazanie zadania numer 5");
// // Pseudo Code - while i <= 20 &&  i >= 5 wypisz i, i--;
// int index = 20;
// while (index <= 20 && index >= 5)
// {
//     Console.WriteLine(index);
//     index--;
// }

// Console.WriteLine("Rozwiazanie zadania numer 6");
// // Pseudo Code - while i >= 10 &&  i <= 99  && %2==0 && %5==0 wypisz i, i+=10 (2*5);
// int index = 10;
// while (index >= 10 && index <= 99 && index %2 ==0 && index % 5==0)
// {
//         Console.WriteLine(index);
//         index+=10;
// }

// Console.WriteLine("Rozwiazanie zadania numer 7");
// // Pseudo Code - while i >= 10 &&  i <= 99  && (i %10 + i/10)== 3 || (i %10 + i/10) == 7 wypisz liczbe i, i++;
// int index = 10;
// while (index >= 10 && index <= 99)
// {
// if (index %10 + index/10 == 3 || index %10 + index/10 == 7) 
//     {
//         Console.WriteLine(index);
//     }
//         index++;
// }

// Console.WriteLine("Rozwiazanie zadania numer 8");
// // Pseudo Code - while (!(i >= 0 && <= 100)) Console.WriteLine("Enter the number: ");
// Console.WriteLine("Guess the number: ");
// string index = Console.ReadLine();
//  int intIndex = Convert.ToInt16(index);

// while (intIndex <0 && intIndex > 100)
// {
//     Console.WriteLine("Guess the number: ");
// }
// if (intIndex >= 0 && intIndex <= 100)
// {
//     Console.WriteLine("Congratulations!");
// }



// Console.WriteLine("Rozwiazanie zadania numer 9");
// // Pseudo Code - while (break != true) ask for 2 int, add them and display output; Nested if loops inside to control while loop;
// int breakWhileLoop = 0;
// while (breakWhileLoop == 0)
// {
//     Console.WriteLine("Enter first number or type 'koniec' to quit");
//     string firstNum_str = Console.ReadLine();
//     string secondNum_str = firstNum_str;
//     if (firstNum_str == "koniec" || secondNum_str == "koniec")
//     {
//         breakWhileLoop = 1; // variable to control loop
//         Console.WriteLine("Good bye then!");
//     }
//     else 
//     {
//         Console.WriteLine("Enter your second number of type 'koniec' to quit");
//         secondNum_str   = Console.ReadLine();
//         int firstNum    = Convert.ToInt32(firstNum_str);
//         int secondNum   = Convert.ToInt32(secondNum_str);
//         Console.WriteLine("Sum of those number is: ");
//         Console.WriteLine(firstNum+secondNum);
//     }

// }

Console.WriteLine("Rozwiazanie zadania numer 10");
// Pseudo Code: while (true = user don't want to quit) check if int is prime number and if it is true return YES
// Prime number is divided by 1 and itself, 0 and 1 are not prime numbers; So prime number doesn't have int square root!

int breakWhileLoop = 0;
while (breakWhileLoop == 0)
{
    Console.WriteLine("This program checks if given number is the Prime Number, enter your number below or press 'q' to quit");
    string primeNumber_str = Console.ReadLine();
    if (primeNumber_str == "q" || primeNumber_str == "0" || primeNumber_str == "1") 
    {
        breakWhileLoop += 1;
        Console.WriteLine("It is not a Prime Number, good bye then!");
    }

    int primeNumber = Convert.ToInt32(primeNumber_str);
    while (primeNumber != 0 || primeNumber != 1)
    {
        
    }

} 