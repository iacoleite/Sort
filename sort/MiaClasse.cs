public class MiaClasse {
    public int puntiVita;
    public int puntiAttachi;

    public void incrementaPuntiVitaTemporareo(int puntiVita) {
        this.puntiVita += 20;
        Console.WriteLine("Il personaggio ha utilizzato la pozione magica, e il suo punti di vita ora sono: " + puntiVita + " però, forse la pozione era finta... deve controllare i suoi punti di vita nuovamente!");
    }

    public int incrementaPuntiVitaLivelo (int puntiVita) {
        this.puntiVita += 20;
        Console.WriteLine("Il personaggio ha un nuovo livelo! Il suo punti di vita ora sono: " + puntiVita + " questa sembra buona! verifica i punti di vita per confermare!");

        return this.puntiVita;
    }
}


// ritirato del main perchè non faceva più senso... 

        // Console.WriteLine();
        // Console.WriteLine("Cambiamo argumenti!");
        // Console.WriteLine();

        // MiaClasse personaggio1 = new MiaClasse();
        // personaggio1.puntiVita = 100;
        // personaggio1.puntiAttachi = 10;
        // Console.WriteLine("Ok, abbiamo creato un personaggio di MiaClasse, lui ha ricevuto " + personaggio1.puntiVita + " punti di vita e " + personaggio1.puntiAttachi + " di attachi");
        // Console.WriteLine("Il personaggio ha trovato una pozione magica nella foresta, però è un po' strana:");
        // personaggio1.incrementaPuntiVitaTemporareo(personaggio1.puntiVita);
        // Console.WriteLine("Il personaggio prova di capire che cosa è successo, lui ha " + personaggio1.puntiVita + " punti di vita e " + personaggio1.puntiAttachi + " di attachi");
        // Console.WriteLine("Dopo la deluzione lui era arrabiato e ha lutato contra tanti mostri!!");
        // personaggio1.incrementaPuntiVitaLivelo(personaggio1.puntiVita);

        // Console.WriteLine("Con paura di essere una cosa finta, facciamo il controllo ancora");
        // Console.WriteLine("Il personaggio prova di capire che cosa è successo, lui ha " + personaggio1.puntiVita + " punti di vita e " + personaggio1.puntiAttachi + " di attachi");


