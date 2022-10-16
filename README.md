<h1 align=center>computer-science-ITC-and-programming</h1>
<h1 align=center>IT studies</h1>
<!-- <link rel="stylesheet" href=""> will it work? -->
<h1 align=center>Programowanie z elementami algorytmiki, zajecia #1</h1>

# `extensions:`

- C# Microsoft;
- C# jchannon;
- C# Snippets;

# `terminal:`

- dotnet new console;
- dotnet run;

# `assets`

-   obj             - wynik dzialania kompilatora;
-   bin             - kompilacja
-   prelaunch task  - build (buduje przed run)
-   .vscode         - json config;

# `entry point`

- punkt wejscia, kazdy program go ma

# `podpowiedzi ctrl + space`

# `syntax :`

- C (is assembler extended)
- srednik na koncu kazdej linii, zaszlosc z jezyka C;
- Kotlin, Python, JavaScript nie wymaga;
- bedziemy mieli zajecia z biometrii;

* `zmienna:`

- to element programu posiadajacy wartość;
- do zmiennej odwolujemy sie poprzez jej nazwe;
  - kazda zmienna posiada nazwe;
  - w niektorych jezykach nazwa jest okreslana mianem etykiety, atrybutu...;
- zmienne posiadaja typ, okreslajacy rodzaj przechowywanej wartosci:
  - czasami typ mozna zmieniac;
  - mozliwe jest przeniesienie obowiazku okreslania typu na kompilator lub maszyne wykonawcza;

* silne/slabe typizowanie zmiennych;

- standardem jest obecnie przechowywanie wartosci w 32 bitach (albo komputer przechowuje w bajcie - 8 bit, albo w slowie - wiecej bitow albo w 32 bit albo wiecej);

# `typy zmiennych:`

*        typ        rozmiar           opis

-         int       4 bit             liczby calkowite od -x do +x;
-         long      8 bit             liczby calkowite wieksze;
-         float     4 bajty (32 bit)  liczby ulamkowe do 7 cyfr znaczacych
-         double    8 bajtow          liczby ulamkowe do 15 cyfr znaczacych
-         bool      1 bit             wartosc logiczna true false
-         char      2 bajty (16 bit)  jeden znak, - w dotnet to 2 bajty a nie 1;
-         string    (2 bajty na znak - 16 bit) - sekwencje znakow (kody ASCII) 

## `notacja liczb zmiennoprzecinkowych`

naukowa 1e + 3 => 1 * 10^3, cecha i mantysa;

* slack - 90 days free data storage;


# http://cygnus.tele.pw.edu.pl/olek/doc/syko/www/rozdzial3_1_1.html 
<!-- ref -->

* LSB   - least significant bite
* MSB   - most significant bite

* Kolejnosc bitow - `Big Endian & Little Endian`; 
# https://chortle.ccsu.edu/assemblytutorial/Chapter-15/ass15_3.html
- zupelnie odwrotna kolejnosc odczytu bitow

# `reprezentacja zmiennej w pamieci `


#   `deklarowanie zmiennych`
- <typ> <nazwa> [wartosc][, <nazwa>...];
- przyklady:
  * int liczba = 3;
  * char znak = 'x';
  * int x, y, z;
  * float x1 = 1.3;

* przy podawaniu wartosci - literały:
- całkowite:
  * dziesietne;
  * osemkowe;
  * szesnastkowe;
- rzeczywiste:
  * 3.141231231;
  * 3.2E+23;
  * 7.5D, 3.3F;
- znakowe:
  * 's', '$';
- łancuchowe:
  * "napis przykladowy"

* `co do zasady typ zmiennej mozna modyfikowac bez szkody dla zmiennej`;

# `Autodeklaracja zmiennych:`
*     Jezyk           instrukcja
-     C#              var;
-     C++             auto;
-     Kotlin          var; val=niezmienna wartosc od value;
-     Python          robi to samodzielnie;

# `Operatory:`
*     Operacja           Notacja
-     dodawanie          +
-     odejmowanie        -
-     mnozenie           *
-     dzielenie          /
-     reszta(modulo)     %
-     inkrementacja      ++
-     przypisania        =        :
                        +=        z powiekszeniem;
                        -=        z pomniejszeniem;
-     rowna sie (equal) ==



# `C# VsCode - file>autosave`
-   program do skompilowania musi byc poprawny;
-   jezeli jest blad, nie uda sie skompilowac;
-   czasami zglasza ostrzezenie a nie blad;
-   ctrl + /  - do komentowania w C#; - lepsze niz ctrl+k ctrl+c (dziala w obie strony);
-   przejscie do trybu lancuchowego (string) powoduje ze consola przerobi do ciagu znakow wszystko co wpiszemy, np. Console.WriteLine("Suma to: " + suma + 2); gdy suma = 7 wynik wyjdzie jako string "Suma to: 72"
-   nawiasy;
-   dzielenie w zmiennoprzecinkowych to trzeba dzielnik zapisac zmiennoprzecinkowo  np. 5 / 2.0;
-   modulo tez zadziala na zmiennoprzecinkowych w C#;

#   `Instrukcja if else`
-   if {warotsc logiczna} <instrukcja_prawda>;
esle <instrukcja_falsz>
-   w C# whitespace sie nie liczy;

# `Kod napisany dzisiaj w C#`
*     Proste           Operacje     Na    Zmiennych
-     // string a    =   "Hello";
-     // string b    =   " World!";
-     // string c    =   a + b;


-     // var a    =   "Hello" ;
-     // var b    =   3 ;
-     // var c    =   a + b;
-     
-     // Console.WriteLine(c);
-     
-     // var suma = 3 + 4;
-     // var roznica = 5 -2;
-     // Console.WriteLine(suma);
-     // Console.WriteLine(roznica);
-     
-     
-     // var suma = 3 + 4;
-     // var roznica = "5" - "2";  to sie nie uda;
-     // Console.WriteLine("Suma to: " + suma/2.0);
-     // Console.WriteLine(roznica); to sie nie uda;
-     // Console.WriteLine("Suma to: " + suma % 2.0);
-     
-     // var a = 3;
-     // var b = a++;
-     // // ++ za a powoduje, ze b=3 a=4, zapis ++a to bedzie odwrotnie;
-     // Console.WriteLine(b);
-     
-     
-     // var a = 9993123123123122222;
-     // var b = 222222222222222.0; // bez zera nie pojdzie;
-     
-     // Console.WriteLine(a/b);
-     
-     var y = 20;
-     y -= 10; //od y odejmujemy 10;


-     Console.Write("Podaj swoj wiek: "); //pyta o input;
-     
-     var wiek = Console.ReadLine();
-     int wiekLiczba = int.Parse(wiek);
-     if (wiekLiczba >= 18) {
-         Console.WriteLine ("Masz dostep do programu");
-     }
-     else {
-         Console.WriteLine("Jestes za mlody");
-     }
-     
-     //do poprawki
