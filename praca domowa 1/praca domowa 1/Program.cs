//Zad. 2.1/str.54
//{
//    double C, F;
//    Console.WriteLine("Podaj temperaturę w stopniach Celsjusza");
//    C = double.Parse(Console.ReadLine());
//    F = 32 + 9*C/5;
//    Console.WriteLine(F);
//    Console.ReadKey();
//}

//Zad. 2.2/str.54
//{
//    int a, b, c;
//    double d;
//    Console.WriteLine("Proszę podać wartość współczynnika a");
//    a = int.Parse(Console.ReadLine());
//    Console.WriteLine("Proszę podać wartość współczynnika b");
//    b = int.Parse(Console.ReadLine());
//    Console.WriteLine("Proszę podać wartość współczynnika c");
//    c = int.Parse(Console.ReadLine());
//    d = b * b - 4 * a * c;
//    Console.WriteLine(d);
//    Console.ReadKey();


//}

//Zad. 2.3/str.54
//{
//    double masa, wzrost, BMI;
//    Console.WriteLine("Podaj masę w kg");
//    masa = double.Parse(Console.ReadLine());
//    Console.WriteLine("Podaj wzrost w m");
//    wzrost = double.Parse(Console.ReadLine());
//    BMI = masa / (wzrost * wzrost);
//    Console.WriteLine(BMI);
//    Console.WriteLine("Twoje BMI wynosi" + " " + "{0,0:F2}",BMI);
//    Console.ReadKey();

//}

//Zad. 2.4/str.54
//odp.a) 202

//{
//    int x = 100;
//    Console.WriteLine(++x * 2);

//}

//Zad. 2.5/str.55
//odp. d) x=12

//{
//    int x = 2, y = 3;
//    Console.WriteLine(x *= y * 2);
//}

//Zad. 2.6/str.55
//odp. x = 3

//{
//    int x, y = 4;
//    Console.WriteLine(x = (y -= 2));
//    Console.WriteLine(x = y++);    
//    Console.WriteLine(x = y--);
//    Console.WriteLine(x);
//}

//Zad. 2.7/str.55
//odp. y = 7

//{
//    int x, y = 5;
//    x = ++y * 2;                 //x=12, y=6
//    Console.WriteLine(x);
//    Console.WriteLine(y);
//    x = y++;                     //x=6, y=7
//    Console.WriteLine(x);
//    Console.WriteLine(y);
//    x = y--;                     //x=7, y=6
//    Console.WriteLine(x);
//    Console.WriteLine(y);
//    Console.WriteLine(++y);     //y=7
//}

//Zad. 2.8/str.55
//odp. a)
//{
//    bool x;
//    int y = 1, z = 1;
//    x = (y == 1 && z++ == 1);
//    Console.WriteLine(x);
//    Console.WriteLine(y);   
//    Console.WriteLine(z);   
//}

//Zad. 2.9/str.56
//a) wynik = false, x=2, y=4, z=2
//{
//    int x = 1, y = 4, z = 2;
//    bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
//    Console.WriteLine("Wynik={0} x={1} y={2} z={3}", wynik, x, y, z); 
//    //pierwszy element fałszywy, pozostałe nie są sprawdzane
//}

//b) wynik = false , x=2 , y=5 , z=2
//{
//    int x = 1, y = 4, z = 2;
//    bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
//    Console.WriteLine("Wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
//}

//c) wynik= false, x=2 , y=5 , z=1
//{
//    int x = 1, y = 4, z = 2;
//    bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
//    Console.WriteLine("Wynik={0} x={1} y={2} z={3}", wynik, x, y, z); 

//}

//d) wynik= true, x=1 , y=3 , z=4
//{
//    int x = 1, y = 3, z = 4;
//    bool wynik = (x == 1 || y++ > 2 || ++z > 0);
//    Console.WriteLine("Wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
//    //program sprawdzi tylko pierwszy warunek
//}

//e) wynik= true, x=1 , y=4 , z=4
//{
//    int x = 1, y = 3, z = 4;
//    bool wynik = (x == 1 | y++ > 2 || ++z > 0);
//    Console.WriteLine("Wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
//}

//f) wynik= true , x=1 , y=4 , z=5
//{
//    int x = 1, y = 3, z = 4;
//    bool wynik = (x == 1 | y++ > 2 | ++z > 0);
//    Console.WriteLine("Wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
//}

//Zad. 2.10/ str. 56
// Program zwróci 0, ponieważ zaokrągli wynik do liczby całkowitej (int), czyli 10/100=0,1 zaokrągli do 0.
//// Żeby "naprawić" program trzeba zmienić typ przynajmniej jednej zmiennej
//{
//    double powierzchnia = 100;
//    int osoby = 10;
//    double gestoscZaludnienia = osoby / powierzchnia;
//    Console.WriteLine(gestoscZaludnienia);
//}

