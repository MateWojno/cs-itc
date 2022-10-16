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

`co do zasady typ zmiennej mozna modyfikowac bez szkody dla zmiennej`;

# `Autodeklaracja zmiennych:`
*     Jezyk           instrukcja
-     C#              var;
-     C++             auto;
-     Kotlin          var; val=niezmienna wartosc od value;
-     Python          robi to samodzielnie;

