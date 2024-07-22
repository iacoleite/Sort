// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq.Expressions;
using System.Net;
using System.Text;

public class Program {
    public static void Main(string[] args) {

        int[] teste = [54,5643,34,345,465,764,235,142,21,234,3456,4675,3456,423,432,213,123,321,5342,543,4576,5687,5,4756,534,5432,2134,234,7465,867,6798,5867,678,5678,7465];

        int[] sortedArray = teste.ordinaVettoriNum();
        Console.WriteLine(sortedArray.stampaStringa());

        int[] sortedArray1 = teste.bubbleSort();
        Console.WriteLine(sortedArray1.stampaStringa());

        int[] sortedArray2 = teste.insertSort();
        Console.WriteLine(sortedArray2.stampaStringa());
        
        int[] sortedArray3 = teste.quickSort(0, teste.Length-1);
        Console.WriteLine(sortedArray3.stampaStringa());



    }
}

public static class newArrayMethods  {
    public static string stampaStringa (this int[]num) {
        StringBuilder resultBuilder = new StringBuilder();
        // build the string with builder
        foreach (int element in num) {
            resultBuilder.Append(element + ", ");
        }
        //cast as string and return with the last two chars (", ")
        string resultado = resultBuilder.ToString();
        return resultado.Remove(resultado.Length-2);
    }
        public static int[] ordinaVettoriNum(this int []num) {
            for(int i = 0; i < num.Count(); i++) {
                for (int j = i + 1; j < num.Count() - 1; j++) {
                    if (num[j] < num[i]) {
                        var temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            return num;
        }

        public static int[] insertSort(this int[] num) {
        // dal secondo in poi
        for (int i = 1; i < num.Length; i++) {
            int numeroVerificando =  i;
            // while non ho verificato tutti i elementi del array E il numero anterior al numero verificando -> SWAP!
            while (numeroVerificando > 0 && num[numeroVerificando-1] > num[numeroVerificando]) {
                var temp = num[numeroVerificando];
                num[numeroVerificando] = num[numeroVerificando-1];
                num[numeroVerificando -1] = temp;
                numeroVerificando--;
            }
        }

        return num;
    }

    public static int[] bubbleSort (this int[] num) {
        for (int i = 0; i < num.Count()-1; i++) {
            for (int j = 0; j < num.Count()-i-1; j++) {
                int a = j;
                int b = j + 1;
                if (num[a] > num[b]) {
                    int temporania = num[a];
                    num[a] = num[b];
                    num[b] = temporania;
                }

            }
            
        }
        return num;
    }


    public static int[] quickSort(this int [] nums, int inizio, int fine) {
            
        if (inizio <= fine) {
        //prende il pivot di questo array e chiama due quickSort (recursione) utillizando il pivot come il centro tra i due array oggetti dei nuovi quickSort
            int pivot = partition(nums, inizio, fine);
            quickSort(nums, inizio, pivot - 1); // ordina la prima metà
            quickSort(nums, pivot + 1 , fine); // ordina la seconda metà
            // Console.WriteLine(nums.stampaStringa());
        }
        return nums;
    }


    public static int partition (int[] num, int inizio, int fine) {
        int pivot = num[fine];
        int i = inizio -1;

        for (int j = inizio; j < fine; j++) {
            if (num[j] < pivot) {
                i++;
                int temporania = num[i];
                num[i] = num[j];
                num[j] = temporania;
            }
        }
        // i++;
        int temp1 = num[i+1];
        num[i+1] = num[fine];
        num[fine] = temp1;
        return i+1; // localizazione del pivot
    }
}

public static class insertSortAlg {

}

public static class quickSortAlg {

}

public static class Bubbly {

}
