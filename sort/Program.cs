using System.Security.Cryptography.X509Certificates;

namespace AlgoritimiOrdinamento;

// See https://aka.ms/new-console-template for more information

public class Program {
    
    public static void Main(string[] args) {

    int[] ordinaVettoriNum(int[] num)
    {
        for (int i = 0; i < num.Count(); i++)
        {
            for (int j = i + 1; j <= num.Count() - 1; j++)
            {
                if (num[j] < num[i])
                {
                    var temp = num[i];
                    num[i] = num[j];
                    num[j] = temp;
                }
            }
        }
        return num;
    }

    void ordinaVettoriNumVoid(int[] num)
    {
        for (int i = 0; i < num.Count(); i++)
        {
            for (int j = i + 1; j <= num.Count() - 1; j++)
            {
                if (num[j] < num[i])
                {
                    var temp = num[i];
                    num[i] = num[j];
                    num[j] = temp;
                }
            }
        }
        // Console.WriteLine(num.stampaStringa());
    }

        int[] teste = [54,5643,34,345,465,764,235,142,21,234,3456,4675,3456,423,432,213,123,321,5342,543,4576,5687,5,4756,534,5432,2134,234,7465,867,6798,5867,678,5678,7465];
        
        // int[] perche = [0,1,2,3,5,64,46,56,5,67];
        Console.WriteLine("Senza ordine:");
        Console.WriteLine(teste.stampaStringa());
        
        Console.WriteLine("Con Select Sort (return int[]):");
        int[] sortedArray = ordinaVettoriNum(teste);
        Console.WriteLine(sortedArray.stampaStringa());


        teste = [54,5643,34,345,465,764,235,142,21,234,3456,4675,3456,423,432,213,123,321,5342,543,4576,5687,5,4756,534,5432,2134,234,7465,867,6798,5867,678,5678,7465];
        Console.WriteLine("Senza ordine:");
        Console.WriteLine(teste.stampaStringa());
        Console.WriteLine("Con Select Sort VOID:");
        ordinaVettoriNumVoid(teste);
        Console.WriteLine(teste.stampaStringa());

        


        // Console.WriteLine("Con Bubble Sort:");
        // int[] sortedArray1 = teste.bubbleSort();
        // Console.WriteLine(sortedArray1.stampaStringa());

        // Console.WriteLine("Con Insert Sort:");
        // int[] sortedArray2 = teste.insertSort();
        // Console.WriteLine(sortedArray2.stampaStringa());
        
        // Console.WriteLine("Con QuickSort:");
        // int[] sortedArray3 = teste.quickSort(0, teste.Length-1);
        // Console.WriteLine(sortedArray3.stampaStringa());


        // Console.WriteLine(new []{3,4,456,45,4235,234,435,6534,8,53,23,56,97,79,980}.ordinaVettoriNum().stampaStringa());
        
        Console.WriteLine("Nuovo vettore, senza ordine:");
        int []vett = [3212,524,5567,657,335,2,5,75,8,9,89,56,43,24,323];
        Console.WriteLine(vett.stampaStringa());

        Console.WriteLine("Chiama metodo ordinaVettoriNumVoid, lui stampa da solo il vettore in ordine:");
        ordinaVettoriNumVoid(vett);

        Console.WriteLine("Stampo il vettore che ho appena ordinato con ordinaVettoriNumVoid, il vettore è in ordine perchè array è un tipo referenziato:");
        Console.WriteLine(vett.stampaStringa());



        int x = 10;
        void incrementaNumero(int x) {
            x++;
            Console.WriteLine(x);

        }
        
        incrementaNumero(x);

        Console.WriteLine(x);




    }
}

