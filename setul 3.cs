// set 3 ex 1
/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti valoarea vectorului");

        int n = Convert.ToInt32(Console.ReadLine());

        int[] vector = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Introduceti elementul {i + 1}");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        int suma = 0;
        for(int i = 0;i < n; i++)
        {
            suma += vector[i];
        }

        Console.WriteLine($"Suma vectorilor este: {suma}");
    }
}*/


/*// set 3 ex 2
using System;

class Prgram
{
    static void Main()
    {
        int[] vector = { 1, 3, 2, 5, 7, 4 };
        int k = 1;

        int pozitie = Array.IndexOf(vector, k);

        if (pozitie != -1)
        {
            Console.WriteLine($"Valoarea {k} apare prima data pe pozitia {pozitie} in vector");
        }
        else
        {
            Console.WriteLine($"Valoarea {k} nu apare in vector.");
        }
    }
}*/

/*//setul 3 ex 3

using System;
class Program
{
    static void Main()
    {
        int[] vector = { 1, 2, 3, 4, 5 };
        int minPozitie, maxPozitie;
        GasesteMinSiMax(vector, out minPozitie, out maxPozitie);

        Console.WriteLine($"Cel mai mic element se afla pe pozitia {minPozitie}");
        Console.WriteLine($"Cel mai mare element se afla pe pozitia {maxPozitie}");
    }

    static void GasesteMinSiMax(int[] vector, out int minPozitie, out int maxPozitie)
    {
        if(vector.Length == 0)
        {
            minPozitie = -1;
            maxPozitie = -1;
            return;
        }
        minPozitie = 0; 
        maxPozitie = 0;

        for(int i =1; i < vector.Length; i++)
        {
            if (vector[i] < vector[minPozitie])
            {
                minPozitie = i;
            }
            else if(vector[i] > vector[maxPozitie])
            {
                maxPozitie = i;
            }
        }
    }
}*/

//setul 3 ex4




/*class Program
{
    static void Main()
    {
      
        int[] vector = { 5, 2, 8, 2, 9, 1, 5, 6, 3, 5 };

        CalculateMinMaxAndFrequency(vector, out int minValue, out int maxValue, out int minFrequency, out int maxFrequency);

      
        Console.WriteLine($"Cea mai mica valoare: {minValue}, aceasta apare de: {minFrequency}");
        Console.WriteLine($"Cea mai mare valoare: {maxValue}, aceasta apre de: {maxFrequency}");
    }

    static void CalculateMinMaxAndFrequency(int[] vector, out int minValue, out int maxValue, out int minFrequency, out int maxFrequency)
    {
        minValue = vector.Min();
        maxValue = vector.Max();

        minFrequency = vector.Count(value => value == minValue);
        maxFrequency = vector.Count(value => value == maxValue);
    }
}*/

/*//setul 3 ex 5
using System;
class Program
{
    static void Main()
    {
        int[] vector = { 1, 2, 3, 4, 5 };
        int valoare = 5;
        int pozitie = 3;

        if (pozitie >= 0 && pozitie <= vector.Length)
        {
            Array.Resize(ref vector, vector.Length + 1);
            for (int i = vector.Length - 2; i >= pozitie; i--)
            {
                vector[i + 1] = vector[i];
            }
            vector[pozitie] = valoare;

            Console.WriteLine("Vectorul rezultat:");
            foreach (var element in vector)
            {
                Console.Write(element + " ");
            }
        }
        else
        {
            Console.WriteLine("Poziție invalidă!");
        }
    }
}*/
/*
//setul3 ex6

using System;
class Program
{
    static void Main()
    {
        int[] vector = { 1, 2, 3, 4, 5 };
        int pozitie = 2;
        if (pozitie >= 0 && pozitie < vector.Length)
        {
            // Stergeți elementul de la poziția specificată
            for (int i = pozitie; i < vector.Length - 1; i++)
            {
                vector[i] = vector[i + 1];
            }

            // Redimensionați vectorul pentru a elimina ultimul element (care acum se află la sfârșit)
            Array.Resize(ref vector, vector.Length - 1);

            // Afisați vectorul rezultat
            Console.WriteLine("Vectorul rezultat:");
            foreach (var element in vector)
            {
                Console.Write(element + " ");
            }
        }
        else
        {
            Console.WriteLine("Poziție invalidă!");
        }
    }
}
*/
/*
//setul3 ex7
using System;

class Program
{
    static void Main()
    {
        int[] vector = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Vectorul inainte de inversare:");
        AfisareVector(vector);

        Array.Reverse(vector);

        Console.WriteLine("\nVectorul dupa inversare:");
        AfisareVector(vector);
    }

    static void AfisareVector(int[] vector)
    {
        foreach (var element in vector)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
*/

/*//set3 ex8
using System;

class Program
{
    static void Main()
    {
        // Exemplu de vector
        int[] vector = { 1, 2, 3, 4, 5 };

        int pozitiiRotire = 1;

        RotireSpreStanga(vector, pozitiiRotire);

        Console.WriteLine("Vectorul după rotirea spre stânga:");
        AfisareVector(vector);
    }

    static void RotireSpreStanga(int[] vector, int pozitii)
    {
        int lungime = vector.Length;

        pozitii = pozitii % lungime;

        int[] temp = new int[pozitii];

        Array.Copy(vector, temp, pozitii);

        Array.Copy(vector, pozitii, vector, 0, lungime - pozitii);

        Array.Copy(temp, 0, vector, lungime - pozitii, pozitii);
    }

    static void AfisareVector(int[] vector)
    {
        foreach (var element in vector)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
*/

/*//set 3 ex 9
using System;

class Program
{
    static void Main()
    {
        int[] vector = { 1, 2, 3, 4, 5 };
        int k = 2;

        RotateLeft(vector, k);

        Console.WriteLine("Vectorul după rotirea spre stânga cu {0} poziții:", k);
        DisplayVector(vector);
    }

    static void RotateLeft(int[] vector, int k)
    {
        k = k % vector.Length;
        int[] temp = new int[k];
        Array.Copy(vector, temp, k);
        Array.Copy(vector, k, vector, 0, vector.Length - k);
        Array.Copy(temp, 0, vector, vector.Length - k, k);
    }

    static void DisplayVector(int[] vector)
    {
        foreach (var element in vector)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
*/

//set3 ex 10
using System;

class Program
{
    static void Main()
    {
        int[] vector = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int k = 7;

        int result = BinarySearch(vector, k);

        Console.WriteLine("Pozitia lui {0} in vector este: {1}", k, result);
    }

    static int BinarySearch(int[] vector, int k)
    {
        int left = 0;
        int right = vector.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (vector[mid] == k)
                return mid;

            if (vector[mid] < k)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}

/*//setul3 ex 11
using System;

class Program
{
    static void Main()
    {
        int n = 30;

        bool[] primes = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            if (!primes[i])
            {
                Console.Write(i + " ");
                for (int j = i * 2; j <= n; j += i)
                {
                    primes[j] = true;
                }
            }
        }
    }
}
*/

/*//set3 ex 12
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 64, 25, 12, 22, 11 };
        SelectionSort(arr);
        Console.WriteLine("Vectorul sortat: ");
        DisplayArray(arr);
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void DisplayArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}*/

/*//set3 ex 14
using System;

class Program
{
    static void Main()
    {
        int[] vector = { 3, 0, 2, 0, 0, 1, 4, 0, 5 };

        MoveZerosToEnd(vector);

        Console.WriteLine("Vectorul cu zerouri la sfârșit:");
        DisplayArray(vector);
    }

    static void MoveZerosToEnd(int[] arr)
    {
        int n = arr.Length;
        int nonZeroIndex = 0;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] != 0)
            {
                // Interschimb elementul non-zero cu primul zero găsit (dacă există)
                int temp = arr[i];
                arr[i] = arr[nonZeroIndex];
                arr[nonZeroIndex] = temp;

                nonZeroIndex++;
            }
        }
    }

    static void DisplayArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

*/

/*//set3 ex 15
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] vector = { 1, 2, 3, 2, 4, 5, 6, 5, 7 };

        RemoveDuplicates(vector);

        Console.WriteLine("Vectorul după eliminarea elementelor duplicate:");
        DisplayArray(vector);
    }

    static void RemoveDuplicates(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    // Mutăm ultimul element în locul elementului duplicat și scurtăm vectorul
                    for (int k = j; k < n - 1; k++)
                    {
                        arr[k] = arr[k + 1];
                    }
                    n--;
                    j--;
                }
            }
        }
    }

    static void DisplayArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
*/

/*//set3 ex 16
using System;

class Program
{
    // Funcție pentru calcularea CMMD folosind algoritmul lui Euclid
    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Funcție pentru calcularea CMMD al unui vector de numere
    static int CalculateVectorGCD(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Vectorul nu poate fi null sau gol.");
        }

        int gcd = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            gcd = CalculateGCD(gcd, numbers[i]);

            // Dacă gcd devine 1, nu mai este nevoie să continuăm
            if (gcd == 1)
            {
                break;
            }
        }

        return gcd;
    }

    static void Main()
    {
        // Exemplu de utilizare
        int[] vector = { 12, 18, 24, 36 };
        int result = CalculateVectorGCD(vector);

        Console.WriteLine("Cel mai mare divizor comun al elementelor vectorului este: " + result);
    }
}
*/

/*//set3 ex18
using System;

class Program

{
    static double EvaluatePolynomial(double[] coefficients, double x)
    {
        double result = 0;
        double powerOfX = 1;

        for (int i = 0; i < coefficients.Length; i++)
        {
            result += coefficients[i] * powerOfX;
            powerOfX *= x;
        }

        return result;
    }

    static void Main()
    {
        double[] coefficients = { 1, 2, 3 }; // Exemplu: polinomul x^2 + 2x + 3
        double x = 2; // Punctul în care se evaluează polinomul

        double result = EvaluatePolynomial(coefficients, x);

        Console.WriteLine($"Valoarea polinomului în punctul {x} este: {result}");
    }
}
*/

//set3 ex 19



/*class Program
{
    static int CountOccurrences(int[] s, int[] p)
    {
        int count = 0;

        for (int i = 0; i <= s.Length - p.Length; i++)
        {
            if (s.Skip(i).Take(p.Length).SequenceEqual(p))
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        int[] s = { 1, 2, 1, 2, 1, 3, 1, 2, 1 };
        int[] p = { 1, 2, 1 };

        int occurrences = CountOccurrences(s, p);

        Console.WriteLine($"Numărul de apariții ale vectorului p în vectorul s este: {occurrences}");
    }
}
*/

/*//set3 ex21
using System;

class Program
{
    static void Main()
    {
        // Definirea a doi vectori
        char[] vector1 = { 'a', 'b', 'c' };
        char[] vector2 = { 'a', 'b', 'd' };

        // Compararea lexicografică a celor doi vectori
        int comparatie = ComparareLexicografica(vector1, vector2);

        // Afișarea rezultatului
        if (comparatie < 0)
        {
            Console.WriteLine("Vectorul 1 apare primul în ordine lexicografică.");
        }
        else if (comparatie > 0)
        {
            Console.WriteLine("Vectorul 2 apare primul în ordine lexicografică.");
        }
        else
        {
            Console.WriteLine("Vectorii sunt egali în ordine lexicografică.");
        }
    }

    // Funcția pentru compararea lexicografică a doi vectori de caractere
    static int ComparareLexicografica(char[] vector1, char[] vector2)
    {
        for (int i = 0; i < Math.Min(vector1.Length, vector2.Length); i++)
        {
            if (vector1[i] < vector2[i])
            {
                return -1; // Vectorul 1 apare înaintea vectorului 2
            }
            else if (vector1[i] > vector2[i])
            {
                return 1; // Vectorul 2 apare înaintea vectorului 1
            }
        }

        // Dacă vectorii sunt identici până la lungimea minimă, cel cu lungime mai mică apare primul
        return vector1.Length.CompareTo(vector2.Length);
    }
}
*/

/*//set3 ex 22
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Definirea a doi vectori (multimi)
        int[] v1 = { 1, 2, 3, 4, 5 };
        int[] v2 = { 3, 4, 5, 6, 7 };

        // Intersectie
        var intersectie = Intersectie(v1, v2);
        Console.WriteLine("Intersectia: {" + string.Join(", ", intersectie) + "}");

        // Reuniune
        var reuniune = Reuniune(v1, v2);
        Console.WriteLine("Reuniunea: {" + string.Join(", ", reuniune) + "}");

        // Diferenta v1 - v2
        var diferenta1 = Diferenta(v1, v2);
        Console.WriteLine("Diferenta v1 - v2: {" + string.Join(", ", diferenta1) + "}");

        // Diferenta v2 - v1
        var diferenta2 = Diferenta(v2, v1);
        Console.WriteLine("Diferenta v2 - v1: {" + string.Join(", ", diferenta2) + "}");
    }

    // Functia pentru intersectie
    static T[] Intersectie<T>(T[] v1, T[] v2)
    {
        return v1.Intersect(v2).ToArray();
    }

    // Functia pentru reuniune
    static T[] Reuniune<T>(T[] v1, T[] v2)
    {
        return v1.Union(v2).ToArray();
    }

    // Functia pentru diferenta
    static T[] Diferenta<T>(T[] v1, T[] v2)
    {
        return v1.Except(v2).ToArray();
    }
}*/

/*//set 3 ex 28
using System;

class Program
{
    static void Main()
    {
        // Exemplu de vector nesortat
        int[] vector = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };

        // Apelul funcției Quicksort pentru sortare
        Quicksort(vector, 0, vector.Length - 1);

        // Afișarea vectorului sortat
        Console.WriteLine("Vector sortat: " + string.Join(", ", vector));
    }

    // Funcție Quicksort
    static void Quicksort(int[] arr, int stanga, int dreapta)
    {
        if (stanga < dreapta)
        {
            // Alegerea pivotului și obținerea poziției pivotului în vector
            int pivotIndex = Partitie(arr, stanga, dreapta);

            // Sortarea recursivă a subvectorului din stânga și din dreapta pivotului
            Quicksort(arr, stanga, pivotIndex - 1);
            Quicksort(arr, pivotIndex + 1, dreapta);
        }
    }

    // Funcție pentru partitie
    static int Partitie(int[] arr, int stanga, int dreapta)
    {
        int pivot = arr[dreapta];
        int i = stanga - 1;

        for (int j = stanga; j < dreapta; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                Schimba(arr, i, j);
            }
        }

        Schimba(arr, i + 1, dreapta);
        return i + 1;
    }

    // Funcție pentru schimbare elemente
    static void Schimba(int[] arr, int index1, int index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    }
}
*/

/*//set3 ex29
using System;

class Program
{
    static void Main()
    {
        // Exemplu de vector nesortat
        int[] vector = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };

        // Apelul funcției MergeSort pentru sortare
        MergeSort(vector, 0, vector.Length - 1);

        // Afișarea vectorului sortat
        Console.WriteLine("Vector sortat: " + string.Join(", ", vector));
    }

    // Funcție MergeSort
    static void MergeSort(int[] arr, int stanga, int dreapta)
    {
        if (stanga < dreapta)
        {
            int mijloc = (stanga + dreapta) / 2;

            // Sortarea recursivă a subvectorului din stânga și din dreapta mijlocului
            MergeSort(arr, stanga, mijloc);
            MergeSort(arr, mijloc + 1, dreapta);

            // Combinația celor două subvectori sortați
            Combina(arr, stanga, mijloc, dreapta);
        }
    }

    // Funcție pentru combinare
    static void Combina(int[] arr, int stanga, int mijloc, int dreapta)
    {
        int n1 = mijloc - stanga + 1;
        int n2 = dreapta - mijloc;

        int[] stangaArr = new int[n1];
        int[] dreaptaArr = new int[n2];

        // Copierea datelor în subvectorii temporari
        for (int i = 0; i < n1; i++)
            stangaArr[i] = arr[stanga + i];

        for (int j = 0; j < n2; j++)
            dreaptaArr[j] = arr[mijloc + 1 + j];

        // Combinația subvectorilor temporari
        int x = 0, y = 0;
        int k = stanga;

        while (x < n1 && y < n2)
        {
            if (stangaArr[x] <= dreaptaArr[y])
            {
                arr[k] = stangaArr[x];
                x++;
            }
            else
            {
                arr[k] = dreaptaArr[y];
                y++;
            }
            k++;
        }

        // Copierea elementelor rămase din stangaArr, dacă există
        while (x < n1)
        {
            arr[k] = stangaArr[x];
            x++;
            k++;
        }

        // Copierea elementelor rămase din dreaptaArr, dacă există
        while (y < n2)
        {
            arr[k] = dreaptaArr[y];
            y++;
            k++;
        }
    }
}

*/