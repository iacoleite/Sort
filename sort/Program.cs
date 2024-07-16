// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Text;

public class Program {
    public static void Main(string[] args) {

        int[] teste = [54,5643,34,345,465,764,235,142,21,234,3456,4675,3456,423,432,213,123,321,5342,543,4576,5687,5,4756,534,5432,2134,234,7465,867,6798,5867,678,5678,7465];
        
        static int[] ordinaVettoriNum(int []num) {
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

        int [] sortedArray = ordinaVettoriNum(teste);

        // int lunghezza = sortedArray.Count();
        // for (int i = 0; i < lunghezza; i++){
        //     Console.WriteLine(ordinaVettoriNum(teste)[i]);
        // }

        StringBuilder resultBuilder = new StringBuilder();

        foreach (int element in sortedArray) {
            resultBuilder.Append(element + ", ");
        }

        Console.WriteLine(resultBuilder);
        
    }
}
