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
