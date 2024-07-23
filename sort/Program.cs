namespace AlgoritimiOrdinamento;

// See https://aka.ms/new-console-template for more information

public class Program {
    
    public static int[] ordinaVettoriNum(int[] num)
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
    public static void Main(string[] args) {


        int[] teste = [54,5643,34,345,465,764,235,142,21,234,3456,4675,3456,423,432,213,123,321,5342,543,4576,5687,5,4756,534,5432,2134,234,7465,867,6798,5867,678,5678,7465];
        
        // int[] perche = [0,1,2,3,5,64,46,56,5,67];

        Console.WriteLine(teste);
        
        int[] sortedArray = ordinaVettoriNum(teste);
        Console.WriteLine(sortedArray.stampaStringa());

        int[] sortedArray1 = teste.bubbleSort();
        Console.WriteLine(sortedArray1.stampaStringa());

        int[] sortedArray2 = teste.insertSort();
        Console.WriteLine(sortedArray2.stampaStringa());
        
        int[] sortedArray3 = teste.quickSort(0, teste.Length-1);
        Console.WriteLine(sortedArray3.stampaStringa());

        // Console.WriteLine(new []{3,4,456,45,4235,234,435,6534,8,53,23,56,97,79,980}.ordinaVettoriNum().stampaStringa());

        int []vett = [32,54,56,67,345,23,54,765,87,98,89,56,453,24,323];
        
        Console.WriteLine(ordinaVettoriNum(vett).stampaStringa());
        // Console.WriteLine(perche.stampaStringa());

        MiaClasse personaggio1 = new MiaClasse();
        personaggio1.puntiVita = 100;
        personaggio1.puntiAttachi = 10;

        Console.WriteLine(personaggio1.puntiVita);

    }
}

