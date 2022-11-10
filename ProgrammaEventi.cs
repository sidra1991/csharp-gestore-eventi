// See https://aka.ms/new-console-template for more information
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
        //● un metodo che aggiunge alla lista del programma eventi un Evento, passato come
        //parametro al metodo.
    }

    public static void ListaEventiPerData()
    {
        //● un metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa
        //data.
    }

    public static void listaEventi()
    {
        //● un metodo statico che si occupa, presa una lista di eventi, di stamparla in Console, o
        //ancora meglio vi restituisca la rappresentazione in stringa della vostra lista di eventi.
    }

    public void EventiAttuali()
    {
        //● un metodo che restituisce quanti eventi sono presenti nel programma eventi
        //attualmente.
    }

    public void cancellaLista()
    {
        //● un metodo che svuota la lista di eventi.
    }

    public void TitoloProgramma() 
    {
        //● un metodo che restituisce una stringa che mostra il titolo del programma e tutti gli
        //eventi aggiunti alla lista. Come nell’esempio qui sotto:
        //Nome programma evento:
        //data1 - titolo1
        //data2 - titolo2
        //data3 - titolo3
    }

}




//consigli e TODO
//Vi ricordo che man mano che andrete avanti con le altre milestones, potrete aggiungere più
//avanti altri eventuali metodi (public e private) che vi aiutino a svolgere le funzioni richieste se
//ritenete necessari!

//A questo punto provate ad aggiungere al vostro programma oltre che dei semplici
//eventi anche delle e vere e proprie conferenze (potete fare a meno di svuotare la lista
//precedentemente creata, commentando il metodo svuota Lista di Eventi).