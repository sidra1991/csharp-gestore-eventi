// See https://aka.ms/new-console-template for more information
class Evento
{


    public string Titolo { get;  set; }
    public DateTime Tipo { get; set; }

    public int CapienzaMassima { get; set; }//set privato ma per il momento da errore
    public int PostiPrenotati { get; }

    public Evento(string titolo, DateTime tipo, int capienzaMassima)
    {
        //e inizializza gli opportuni attributi facendo uso dei metodi e controlli già fatti. Per l’attributo
        //posti prenotati invece si occupa di inizializzarlo lui a 0.
        Titolo = titolo;
        Tipo = tipo;
        CapienzaMassima = capienzaMassima;
        PostiPrenotati = 0;
    }

    public void prenotaPosti()
    {
        //1.PrenotaPosti: aggiunge i posti passati come parametro ai posti prenotati. Se
        //l’evento è già passato o non ha posti o non ha più posti disponibili deve sollevare
        //un’eccezione.
    }

    public void riduciPosti()
    {

    }

    public override string ToString()
    {

        //3. l’override del metodo ToString() in modo che venga restituita una stringa
        //contenente: data formattata – titolo
        //Per formattare la data correttamente usate
        //nomeVariabile.ToString("dd/MM/yyyy"); applicata alla vostra variabile
        //DateTime.
        return base.ToString();
    }

}




//consigli e TODO
//Vi ricordo che man mano che andrete avanti con le altre milestones, potrete aggiungere più
//avanti altri eventuali metodi (public e private) che vi aiutino a svolgere le funzioni richieste se
//ritenete necessari!

//A questo punto provate ad aggiungere al vostro programma oltre che dei semplici
//eventi anche delle e vere e proprie conferenze (potete fare a meno di svuotare la lista
//precedentemente creata, commentando il metodo svuota Lista di Eventi).