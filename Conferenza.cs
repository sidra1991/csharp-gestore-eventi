// See https://aka.ms/new-console-template for more information
class Conferenza : Evento
{

    public string Relatore { get; set; }
    public double Prezzo { get; set; }

    public Conferenza(string relatore, double prezzo, string titolo, DateTime data, int capienzaMassima) : base(titolo, data, capienzaMassima)
    {
        base.Data = data;
        base.Titolo= titolo;
        base.CapienzaMassima= capienzaMassima;
        Relatore = relatore;
        Prezzo = prezzo;
        //Titolo = titolo;
        //Data = data;
        //CapienzaMassima = capienzaMassima;
    }

    public override string ToString()
    {


        Console.WriteLine(Data + Titolo + Relatore + Prezzo + "€");
        //Fate l’override del metodo ToString() in modo che venga restituita una stringa del
        //tipo: data - titolo - relatore - prezzo formattato.
        return base.ToString();
    }

    public void FormattaData()
    {


        //Aggiungere i metodi per restituire data e ora formattata e prezzo formattato (##,##
        //euro). Per farlo vi suggerisco di usare il metodo prezzo.ToString("0.00").
    }
}




//consigli e TODO
//Vi ricordo che man mano che andrete avanti con le altre milestones, potrete aggiungere più
//avanti altri eventuali metodi (public e private) che vi aiutino a svolgere le funzioni richieste se
//ritenete necessari!

//A questo punto provate ad aggiungere al vostro programma oltre che dei semplici
//eventi anche delle e vere e proprie conferenze (potete fare a meno di svuotare la lista
//precedentemente creata, commentando il metodo svuota Lista di Eventi).