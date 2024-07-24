using AlgoritimiOrdinamento;
using MiaClass;
using Calcola;


public class Program
{

    public static void Main(string[] args)
    {

//         int[] ordinaVettoriNum(int[] num)
//         {
//             for (int i = 0; i < num.Count(); i++)
//             {
//                 for (int j = i + 1; j <= num.Count() - 1; j++)
//                 {
//                     if (num[j] < num[i])
//                     {
//                         var temp = num[i];
//                         num[i] = num[j];
//                         num[j] = temp;
//                     }
//                 }
//             }
//             return num;
//         }

//         void ordinaVettoriNumVoid(int[] num)
//         {
//             // num = [012, 31, 13 ,3];
//             // Console.WriteLine(num.stampaStringa());
//             for (int i = 0; i < num.Count(); i++)
//             {
//                 for (int j = i + 1; j <= num.Count() - 1; j++)
//                 {
//                     if (num[j] < num[i])
//                     {
//                         var temp = num[i];
//                         num[i] = num[j];
//                         num[j] = temp;
//                     }
//                 }
//             }
//             // Console.WriteLine(num.stampaStringa());
//         }

//         int[] teste = [54, 5643, 34, 345, 465, 764, 235, 142, 21, 234, 3456, 4675, 3456, 423, 432, 213, 123, 321, 5342, 543, 4576, 5687, 5, 4756, 534, 5432, 2134, 234, 7465, 867, 6798, 5867, 678, 5678, 7465];

//         // int[] perche = [0,1,2,3,5,64,46,56,5,67];
//         Console.WriteLine("Senza ordine:");
//         Console.WriteLine(teste.stampaStringa());

//         Console.WriteLine("Con Select Sort (return int[]):");
//         int[] sortedArray = ordinaVettoriNum(teste);
//         Console.WriteLine(sortedArray.stampaStringa());

//         teste = [54, 5643, 34, 345, 465, 764, 235, 142, 21, 234, 3456, 4675, 3456, 423, 432, 213, 123, 321, 5342, 543, 4576, 5687, 5, 4756, 534, 5432, 2134, 234, 7465, 867, 6798, 5867, 678, 5678, 7465];
//         Console.WriteLine("Senza ordine:");
//         Console.WriteLine(teste.stampaStringa());
//         Console.WriteLine("Con Select Sort VOID:");
//         ordinaVettoriNumVoid(teste);
//         Console.WriteLine(teste.stampaStringa());

//         // Console.WriteLine("Con Bubble Sort:");
//         // int[] sortedArray1 = teste.bubbleSort();
//         // Console.WriteLine(sortedArray1.stampaStringa());

//         // Console.WriteLine("Con Insert Sort:");
//         // int[] sortedArray2 = teste.insertSort();
//         // Console.WriteLine(sortedArray2.stampaStringa());

//         // Console.WriteLine("Con QuickSort:");
//         // int[] sortedArray3 = teste.quickSort(0, teste.Length-1);
//         // Console.WriteLine(sortedArray3.stampaStringa());

//         // Console.WriteLine(new []{3,4,456,45,4235,234,435,6534,8,53,23,56,97,79,980}.ordinaVettoriNum().stampaStringa());

//         Console.WriteLine("Nuovo vettore, senza ordine:");
//         int[] vett = [3212, 524, 5567, 657, 335, 2, 5, 75, 8, 9, 89, 56, 43, 24, 323];
//         Console.WriteLine(vett.stampaStringa());

//         Console.WriteLine("Chiama metodo ordinaVettoriNumVoid");
//         ordinaVettoriNumVoid(vett);

//         Console.WriteLine("Stampa il vettore che ho appena ordinato con ordinaVettoriNumVoid, il vettore è in ordine perchè array è un tipo referenziato:");
//         Console.WriteLine(vett.stampaStringa());

//         Console.WriteLine("-=-=---=-=-=-=-=-===-=-=-=-=-");
//         int x = 10;
//         Console.WriteLine("Questo è il valore di x che abbiamo dichiarato: " + x);
//         void incrementaNumero(int x)
//         {
//             x++;
//             Console.WriteLine("Questo è il valore di x dentro del metodo 'incrementaNumero': " + x);
//         }

//         incrementaNumero(x);

//         Console.WriteLine("Questo è il valore di x DOPO però fuori del metodo 'incrementaNumero': " + x);

       

// // Console.WriteLine();
// // Console.WriteLine("Cambiamo argumenti!");
// // Console.WriteLine();

// // MiaClasse personaggio1 = new MiaClasse();
// // personaggio1.puntiVita = 100;
// // personaggio1.puntiAttachi = 10;
// // Console.WriteLine("Ok, abbiamo creato un personaggio di MiaClasse, lui ha ricevuto " + personaggio1.puntiVita + " punti di vita e " + personaggio1.puntiAttachi + " di attachi");
// // Console.WriteLine("Il personaggio ha trovato una pozione magica nella foresta, però è un po' strana:");
// // personaggio1.incrementaPuntiVitaTemporareo(personaggio1.puntiVita);
// // Console.WriteLine("Il personaggio prova di capire che cosa è successo, lui ha " + personaggio1.puntiVita + " punti di vita e " + personaggio1.puntiAttachi + " di attachi");
// // Console.WriteLine("Dopo la deluzione lui era arrabiato e ha lutato contra tanti mostri!!");
// // personaggio1.incrementaPuntiVitaLivelo(personaggio1.puntiVita);


// // Console.WriteLine("Con paura di essere una cosa finta, facciamo il controllo ancora");
// // Console.WriteLine("Il personaggio prova di capire che cosa è successo, lui ha " + personaggio1.puntiVita + " punti di vita e " + personaggio1.puntiAttachi + " di attachi");

//         // MiaClasse personaggio2 = new MiaClasse(100, 20);


        Calcolatore c = new Calcolatore(3400);
        Calcolatore cd = new Calcolatore();
        Console.WriteLine(c.getNumber1());
        cd.setNumber1(-1);
        
        c.setNumber1(cd.getNumber1());
        Console.WriteLine(c.getNumber1());
        Console.WriteLine(cd.getNumber1());
        c=-c;
        Console.WriteLine(c.getNumber1());
        
        Console.WriteLine("Calcolo opposto di c " + c.ToString() + " " + c.getNumber1());
        
        Calcolatore c1 = new Calcolatore(3400);
        Console.WriteLine("c è uguale a c1: " + c.Equals(c1));

        Calcolatore c2 = new Calcolatore(3400);
        Console.WriteLine("c1 è uguale a c2: " + c1.Equals(c2));
    }
}

