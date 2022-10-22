//rozdział_3
//zadanie_3_1
//{
//    double rok;
//    Console.WriteLine("Podaj rok, a sprawdzę czy jest przestępny");
//    rok = double.Parse(Console.ReadLine());
//    if (((rok % 400 == 0) || (rok % 100 != 0)) && (rok % 4 == 0))
//        Console.WriteLine("Podany rok jest przestępny");
//    else
//        Console.WriteLine("Podany rok nie jest przestępny");

//}

//zadanie_3_2
//{
//    double liczba1, liczba2;
//    Console.WriteLine("Proszę podać pierwszą liczbę");
//    liczba1 = double.Parse(Console.ReadLine());
//    Console.WriteLine("Proszę podać drugą liczbę, sprawdzę czy jest dzielnikiem pierwszej");
//    liczba2 = double.Parse(Console.ReadLine());
//    if (liczba1 % liczba2 == 0)
//        Console.WriteLine("Druga liczba jest dzielnikiem pierwszej");
//    else
//        Console.WriteLine("Druga liczba NIE jest dzielnikiem pierwszej!!!");
//}

//ZADANIE_3_3
//{
//    int a, b, c;
//    Console.WriteLine("Proszę podać trzy liczby do porównania");
//    a = int.Parse(Console.ReadLine());
//    b = int.Parse(Console.ReadLine());
//    c = int.Parse(Console.ReadLine());
//    if ((a > b) && (a > c))
//        Console.WriteLine("{0} jest największa z podanych", a);
//    if ((b > c) && (b > a))
//        Console.WriteLine("{0} jest największa z podanych", b);
//    else if ((c  >a) && (c  >b))
//        Console.WriteLine("{0} jest największa z podanych", c);

//}

//zadanie_3_4
//{
//    double a, b, wynik;
//    string c;

//    Console.WriteLine("Proszę podać dwie liczby");
//    a = double.Parse(Console.ReadLine());   
//    b = double.Parse(Console.ReadLine());
//    Console.WriteLine("Proszę podać operator działania matematycznego +, -, * lub /");
//    c = Console.ReadLine();
//    if (c == "+")
//    {
//        wynik = a + b;
//        Console.WriteLine(wynik);
//    }
//    if (c == "-")
//    {
//        wynik = a - b;
//        Console.WriteLine(wynik);
//    }
//    if (c == "*")
//    {
//        wynik = a * b;
//        Console.WriteLine(wynik);
//    }
//    else if (c == "/")
//    {
//        wynik = a / b;
//        Console.WriteLine(wynik);

//    }
//}

//zadanie_3_5
//{
//    int a, b, c;
//    double delta;
//    Console.WriteLine("Proszę podać trzy współczynniki równania kwadratowego: a, b, c");
//    a = int.Parse(Console.ReadLine());
//    b = int.Parse(Console.ReadLine());  
//    c = int.Parse(Console.ReadLine());
//    delta = (b * b) - (4 * a * c);
//    if (delta < 0)
//        Console.WriteLine("Liczba pierwiastków = 0");
//    if (delta == 0)
//        Console.WriteLine("Liczba pierwiastków = 1");
//    else if (delta > 0)
//        Console.WriteLine("Liczba pierwiastków = 2");
//}

//zadanie_3_6_a
//{
//    float masa, wzrost, BMI;
//    Console.WriteLine("Proszę podać masę w kg");
//    masa = float.Parse(Console.ReadLine());
//    Console.WriteLine("Proszę podać wzrost w m");
//    wzrost = float.Parse(Console.ReadLine());  
//    BMI = (masa) / (wzrost * wzrost);

//    if (BMI < 18.5)
//        Console.WriteLine("Niedowaga");
//    if ((BMI >= 18.5) && (BMI <= 24.99))
//        Console.WriteLine("Waga prawidłowa");
//    else if (BMI>=25)
//        Console.WriteLine("Nadwaga");
//}

//zadanie_3_6_b
//{
//    float masa, wzrost, BMI;
//    Console.WriteLine("Proszę podać masę w kg");
//    masa = float.Parse(Console.ReadLine());
//    Console.WriteLine("Proszę podać wzrost w m");
//    wzrost = float.Parse(Console.ReadLine());
//    BMI = (masa) / (wzrost * wzrost);

//    if (BMI < 16)
//        Console.WriteLine("Wygłodzenie");
//    if ((BMI >=16) && (BMI <=16.99))
//         Console.WriteLine("Wychudzenie");
//    if((BMI >=17) && (BMI <=18.49))
//        Console.WriteLine("Niedowaga");
//    if ((BMI >= 18.5) && (BMI <= 24.99))
//        Console.WriteLine("Waga prawidłowa");
//    if ((BMI >= 25) && (BMI <= 29.99))
//        Console.WriteLine("Nadwaga");
//    if ((BMI >=30) && (BMI <= 34.99))
//        Console.WriteLine("Otyłość I stopnia");
//    if ((BMI >=35) && (BMI <=39.99))
//        Console.WriteLine("Otyłość II stopnia(duża)");
//    if (BMI >=40)
//        Console.WriteLine("Otyłość III stopnia(chorobliwa)");
//}

//zadanie_3_7
//{
//    Console.WriteLine("Wpisz nr dnia tygodnia");
//    int numer = int.Parse(Console.ReadLine());
//    switch (numer)
//    {
//        case 1:
//            Console.WriteLine("Poniedziałek");
//            break;
//        case 2:
//            Console.WriteLine("Wtorek");
//            break;
//        case 3:
//            Console.WriteLine("Środa");
//            break;
//        case 4:
//            Console.WriteLine("Czwartek");
//            break;
//        case 5:
//            Console.WriteLine("Piątek");
//            break;
//        case 6:
//            Console.WriteLine("Sobota");
//            break;
//        case 7:
//            Console.WriteLine("Niedziela");
//            break;
//        default:
//            Console.WriteLine("Nie ma takiego dnia tygodnia");
//            break;
//    }
//    Console.ReadKey();
//}

//zadanie_3_8
//{
//    float a, b = 0, c = 350, d = 550;
//    Console.WriteLine("Wpisz swoją średnią z ocen");
//    a = float.Parse(Console.ReadLine());


//    if (a <= 3.99)
//        Console.WriteLine("Stypendium = {0}",b);

//    if ((a <= 4.79) && (a >= 4.00))
//        Console.WriteLine("Stypendium = {0}", c);

//    else if ((a <= 4.80) && (a >= 5.00))
//        Console.WriteLine("Stypendium = {0}", d);


//}

//zadanie_3_9
//a
//{
//    int a;
//    Console.WriteLine("Podaj liczbę całkowitą");
//    a = int.Parse(Console.ReadLine());


//    for (int i = 0; i <= a; i++)
//    {

//        for (int j = 0; j <= i; j++)
//        {
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//}

//b
//{
//    int a;
//    Console.WriteLine("Podaj liczbę całkowitą");
//    a = int.Parse(Console.ReadLine());


//    for (int i = 0; i <= a; i++)
//    {

//        for (int j = a; j >= i; j--)
//        {
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//}

//c
//{
//    int a;
//    Console.WriteLine("Podaj liczbę całkowitą");
//    a = int.Parse(Console.ReadLine());


//    for (int i = a)
//    {

//        for (int j = a)
//        {
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//}

//zadanie_3_10
//{
//    int n, m=1;
//    Console.WriteLine("Podaj liczbę całkowitą, której silnie mam obliczyć");
//    n = int.Parse(Console.ReadLine());
//    for (int i=1; i<=n; i++)
//    {
//        m *= i;

//    }
//    Console.WriteLine(m);
//}

//zadanie_3_11
//{
//    int a =1;
//    int b = 0;
//    int suma = 0;

//    do
//    {

//        a += 1;
//        suma = suma + a;
//        b += 1;


//    } while (suma < 100);
//    Console.WriteLine(b+1);//pokazuje ile razy wykona się pętla
//                           //(tak żeby suma nie przekroczyłą 100)
//                           //+1(żeby suma przekroczyła 100)

//}
//
//zadanie_3_12


//{
//    int a;
//    int s = 0;


//    do
//    {


//        Console.WriteLine("Podaj liczbę całkowitą do zsumowania, albo 0 żeby przewać");
//        a = int.Parse(Console.ReadLine());
//        s = s + a;

//    } while (a != 0);
//    Console.WriteLine(s);
//}

//zadanie_3_13

//{
//    int n;
//    int s = 0;
//    Console.WriteLine("Podaj dowolną liczbę naturalną");
//    n = int.Parse(Console.ReadLine());


//    for (int i = 1; i <= n; i++)
//    {
//        if (i % 2 != 0)
//        {
//            s = s + i;
//        }
//        else if (i % 2 == 0)
//        {
//            s = s + (-1 * i);
//        }
//    }
//    Console.WriteLine(s);

//}

//zadanie_2_14


//{
//    int n;

//    Console.WriteLine("podaj n");
//    n = int.Parse(Console.ReadLine());

//    for (int i = 1; i <= n; i++) //i = 1, 2, ...,i = n
//    {
//        int m = 0;
//        for (int j = 1; j < i; j++)
//            if (i % j == 0)
//                m = m + j;
//        if (m == i)
//            Console.WriteLine("{0} jest doskonała", i);
//    }
//    Console.ReadKey();   

//}

//zadanie_3_15
//{
//    int a = 1;
//    int b = 2;
//    int c = 5;

//   (int i = 1; ; )

//4_1
//{
//        int n;
//        Console.WriteLine("Podaj liczbę całkowitą n");
//        n = int.Parse(Console.ReadLine());
//    int[] liczby;
//    liczby = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine("Podaj {0} liczbę", i + 1);
//            liczby[i] = int.Parse(Console.ReadLine());

//        }
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write(liczby[i] + ",");
//        }
//        Console.ReadKey();
//    }

//4_2
{
    int[] tab1 = new int[10] {0, -1, 2, -4, 4, 6, 7, -3, 5, 8};
    int[] tab2 = new int[10];

}