// See https://aka.ms/new-console-template for more information
using System.Collections;

class ProgrammaEventi
{

    public string Titolo { get; set; }
    public List<Evento> Eventi { get; set; }

    public ProgrammaEventi(string titolo)
    {
        Titolo = titolo;
        Eventi = new List<Evento>();
    }

    public void aggiungiEvento(Evento evento)
    {

        Eventi.Add(evento);
        //● un metodo che aggiunge alla lista del programma eventi un Evento, passato come
        //parametro al metodo.
    }

    public static void ListaEventiPerData(ProgrammaEventi p_eventi, string data)
    {
        List<Evento> listaTrovati = new List<Evento>();
        DateTime dataUsing = new DateTime(2000,1,1);
        try
        {
           dataUsing = DateTime.Parse(data);
        }
        catch (Exception)
        {
            Console.WriteLine("data non valida");
        }

        foreach (var item in p_eventi.Eventi)
        {
            if (item.Data.ToString("D") == dataUsing.ToString("D"))
            {
                listaTrovati.Add(item);
            }
        }

        Console.WriteLine("stampa degli eventi trovati");
        int i = 1;
        foreach (var item in listaTrovati)
        {
            Console.WriteLine(" elemento " + i + item.Titolo);
        }

        //● un metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa
        //data.
    }

    public static void listaEventi(ProgrammaEventi p_eventi )
    {
        int i = 1;
        foreach (var item in p_eventi.Eventi)
        {
            Console.WriteLine("evento "+ i + item.Titolo );
        }

        //● un metodo statico che si occupa, presa una lista di eventi, di stamparla in Console, o
        //ancora meglio vi restituisca la rappresentazione in stringa della vostra lista di eventi.
    }

    public int EventiAttuali()
    {
        int ev = Eventi.Count;

        //● un metodo che restituisce quanti eventi sono presenti nel programma eventi
        //attualmente.

        return ev;
    }

    public void cancellaLista()
    {

      Eventi.Clear();

        //● un metodo che svuota la lista di eventi.
    }

    public void TitoloProgramma() 
    {

        Console.WriteLine(Titolo);
        foreach (var item in Eventi)
        {
            item.ToString();
        }

        //● un metodo che restituisce una stringa che mostra il titolo del programma e tutti gli
        //eventi aggiunti alla lista. Come nell’esempio qui sotto:
        //Nome programma evento:
        //data1 - titolo1
        //data2 - titolo2
        //data3 - titolo3
    }

    public void svriviVsc()
    {
        StreamWriter altroStream = new StreamWriter("C:\\Users\\diome\\Desktop\\corso c#\\csharp-gestore-eventi\\nuovodata.csv");
        foreach (var item in Eventi)
        {
            altroStream.WriteLine( Titolo , item.Titolo, item.Data.ToString("D"), item.CapienzaMassima, item.PostiPrenotati );
        }    


        altroStream.Close();
    }

}




//consigli e TODO
//Vi ricordo che man mano che andrete avanti con le altre milestones, potrete aggiungere più
//avanti altri eventuali metodi (public e private) che vi aiutino a svolgere le funzioni richieste se
//ritenete necessari!

//A questo punto provate ad aggiungere al vostro programma oltre che dei semplici
//eventi anche delle e vere e proprie conferenze (potete fare a meno di svuotare la lista
//precedentemente creata, commentando il metodo svuota Lista di Eventi).