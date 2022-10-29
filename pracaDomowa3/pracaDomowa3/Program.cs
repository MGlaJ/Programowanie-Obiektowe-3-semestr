//4.1
//{
//    int n;
//    Console.Write("Prosze podac liczbe elementow tablicy: ");
//    n = int.Parse(Console.ReadLine());
//    int[] liczby = new int[n];

//    for (int i = 0; i < n; i++)
//    {
//        Console.Write("Prosze podac {0} liczbe: ", i+1);
//        liczby[i] = int.Parse(Console.ReadLine());
//    }
//    for (int i = 0; i < n; i++)
//    {
//        Console.Write(liczby[i] + ", ");
//    }
//    Console.ReadKey();
//}

//4.2

//{
//    int[] tab1 = { 1, -2, 3, -4, 5, 6, -7, 8, 9, -10 };
//    int[] tab2 = new int[10];

//    for (int i = 0; i < tab1.Length; i++)
//    {
//        if (tab1[i] > 0)
//            tab2[i] = tab1[i];
//    }

//    for (int i = 0; i < tab2.Length; i++)
//    {
//        Console.Write(tab2[i] + " ,");
//    }

//    Console.ReadKey();
//}

//4.3
//using System.Diagnostics.CodeAnalysis;
//{
//    int n;
//    Console.Write("Prosze podac liczbe elementow tablicy: ");
//    n = int.Parse(Console.ReadLine());
//    int[] tab = new int[n];
//    {
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("Prosze podac {0} liczbe do wpisania do tablicy: ", i + 1);
//            tab[i] = int.Parse(Console.ReadLine());
//        }

//        int max = tab[0];
//        int x = 0; 
//        for (int i = 1; i < n; i++)
//        {

//            if (tab[i] > max)
//            {
//                max = tab[i];
//                x = i;
//            }

//        }
//       Console.WriteLine("Wartosc maksymalna wynosi: {0}, ma ona indeks {1}", max, x);

//        int min = tab[0];
//        int y = 0;
//        for(int j = 1; j < n; j++)
//        {
//            if (tab[j]<min)
//            {
//                min = tab[j];
//                y = j;
//            }
//        }
//        Console.WriteLine("Wartosc minimalna wynosi: {0}, ma ona index {1}", min, y);

//        double suma = 0.0;
//        for (int k = 0; k < n; k++)
//        {
//            suma = suma + tab[k];
//        }
//        double srednia = (suma / n);
//        Console.WriteLine("Srednia podanych liczb wynosi {0}", srednia);

//        int ile = 0;
//        for (int l = 0; l<n; l++)
//            if (tab[l] > 0)
//                ile = ile + 1;

//        Console.WriteLine("Podano {0} liczby dodatnie", ile);


//    }



//}

//4.4
//{
//    int[] tab4 = new int[100];
//    int pierwsze =0;

//    Random rand = new Random();
//    for (int i = 0; i < tab4.Length; i++)
//        tab4[i] = rand.Next(1, 1000);


//    for (int i = 0; i < tab4.Length; i++)
//        for (int j = 2; j <= Math.Sqrt(tab4[i]); j++)
//            if (tab4[i] % j == 0)
//            pierwsze++;


//    Console.WriteLine("Liczb pierwszych jest: {0}", pierwsze);

//}

//    // liczby pierwsze dzielą się przez 1 i przez samą siebie
//    // nie dzielą się przez inne liczby

//}

////{
////    int[] tab4 = {1, 2, 25, 12, 13};
////    int pierwsze = 0;



////    for (int i = 0; i < 5; i++)
////        for (int j = 2; j <= Math.Sqrt(tab4[i]); j++)
////            if (tab4[i] % j == 0)
////                pierwsze = pierwsze+1;


////    Console.WriteLine("Liczby pierwszych jest: {0}", pierwsze );

////}


//{
//    int[] tab4 = new int[100];
//    int pierwsze = 0;


//    Random rand = new Random();
//    for (int i = 0; i < 100; i++)
//        tab4[i] = rand.Next(1, 1000);




//    for (int i = 0; i < 100; i++)

//        for (int j = 1; j <= tab4[i]; j++)
//        {
//            int dzielniki = 0;
//            if (tab4[i] % j == 0)
//            {
//                dzielniki++;
//            }
//            if (dzielniki == 2)
//                pierwsze++;


//        }


//    Console.WriteLine(pierwsze);


//}

//4.5
//using System.Runtime.InteropServices;
/////
//{
//    int n;
//    int[] tab1 = new int[n];
//    int[] tab2 = new int[n];

//    // tab2[0] = tab1[n]

//    // tab2[1] = tab1[0]
//    // tab2[2] = tab1[1]
//    //....
//    // tab2[n] = tab1[n-1]
//    tab2[0] = tab1[n];
//    for (int i = 1; i < n; i++)
//        tab2[i] = tab1[i - 1];

//}

//spr.
//{

//    int[] tab1 = {0, 1, 2, 3, 4, 5};
//    int[] tab2 = new int[6];

//    // tab2[0] = tab1[n]

//    // tab2[1] = tab1[0]
//    // tab2[2] = tab1[1]
//    //....
//    // tab2[n] = tab1[n-1]
//    tab2[0] = tab1[5];

//    for (int i = 1; i <=5; i++)
//        tab2[i] = tab1[i - 1];

//    for (int i = 0; i <=5; i++)
//        Console.WriteLine(tab2[i]);

//}

//4.6
//{
//    int suma = 0;
//    int[,] dwu = new int[5, 5];
//    Random rand = new Random();
//    for (int i = 0; i < 5; i++)
//        for (int j = 0; j < 5; j++)
//            dwu[i, j] = rand.Next(1, 150);

//    for (int i = 0; i < 5; i++)
//    {
//        for (int j = 0; j < 5; j++)
//        {
//            Console.Write("{0,11}", dwu[i, j]);
//        }
//        Console.WriteLine();

//    }
//    for (int i = 0; i < 5; i++)

//        for (int j = 0; j < 5; j++)
//            if (i == j)
//                suma= suma+ dwu[i, j];  

//Console.WriteLine(suma);
//}

//4.7
//{
//    int [,] tab1 = { { 2, 3, 5 }, { 1, 4, 8 } };
//    int [,]tab2 = { { 4, 5, 8 }, { 10, 2, 6 } };
//    int [,]tab3 = new int[2, 3];

//    for (int i = 0; i < 2; i++)
//        for (int j = 0; j < 3; j++)
//            tab3[i, j] = tab1[i, j] + tab2[i, j];


//    for (int i = 0; i < 2; i++)
//    {
//        for (int j = 0; j < 3; j++)
//        {
//            Console.Write("{0,11}", tab3[i, j]);
//        }
//        Console.WriteLine();

//    }


//}

//4.8
{
    string[,] dniTygodnia;
    dniTygodnia = new string[7, 3];
    dniTygodnia[0, 0] = "Poniedzialek";
    dniTygodnia[0, 1] = "Monday";
    dniTygodnia[0, 2] = "Montag";
    dniTygodnia[1, 0] = "Wtorek";
    dniTygodnia[1, 1] = "Tuesday";
    dniTygodnia[1, 2] = "Dienstag";
    dniTygodnia[2, 0] = "Sroda";
    dniTygodnia[2, 1] = "Wednesday";
    dniTygodnia[2, 2] = "Mittwoch";
    dniTygodnia[3, 0] = "Czwartek";
    dniTygodnia[3, 1] = "Thursday";
    dniTygodnia[3, 2] = "Donnerstag";
    dniTygodnia[4, 0] = "Piatek";
    dniTygodnia[4, 1] = "Friday";
    dniTygodnia[4, 2] = "Freitag";
    dniTygodnia[5, 0] = "Sobota";
    dniTygodnia[5, 1] = "Saturday";
    dniTygodnia[5, 2] = "Samstag";
    dniTygodnia[6, 0] = "Niedziela";
    dniTygodnia[6, 1] = "Sunday";
    dniTygodnia[6, 2] = "Sonntag";
}