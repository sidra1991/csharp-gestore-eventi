// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;

// funzioni utili

int controlloNumero()
{
    int scelta = 0;
    try
    {
        scelta = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("la scelta effettuata non è un numero");
    }
    catch (OverflowException)
    {
        Console.WriteLine("il numero è troppo grande");
    }

    return scelta;

}


void menu()
{
    Console.WriteLine("--------------------------------------------------------------------------------------");
    Console.WriteLine("menu iniziale scegli l'operazione");
    Console.WriteLine("/////////////////////////////////");
    Console.WriteLine("1. nuovo evento e modifica evento");
    Console.WriteLine("--------------------------------------------------------------------------------------");


    int scelta = controlloNumero();

        switch (scelta)
    {
        case 0:
            menu();
            break;
        case 1:

            Evento? evento = null;
            menu1(evento);
            break;
    }


}

void menu1(Evento evento)
{
    Evento? evento1 = evento;
    int scelta;
    Console.WriteLine("--------------------------------------------------------------------------------------");
    Console.WriteLine("menu nuovo evento");
    Console.WriteLine("/////////////////////////////////");

    if (evento1 == null)
    {
        Console.WriteLine("0. torna al menu precedente");
        Console.WriteLine("1. crea nuovo evento");
        scelta = controlloNumero();

    }else
    {
        Console.WriteLine("0. torna al menu precedente");
        Console.WriteLine("1 aggiungi prenotazioni");
        Console.WriteLine("2 stampa posti disponibili");
        Console.WriteLine("3 cancella prenotazioni");
        scelta = controlloNumero() + 1;

    }
    Console.WriteLine("--------------------------------------------------------------------------------------");



    //AGG- prenotazioni()
    //AGG- stampaPosti()
    //AGG- disdiciPrenotazioni()

    //chiedete all’utente di inserire un
    //nuovo evento con tutti i parametri richiesti dal costruttore


    switch (scelta)
    {
        case 0:
            menu();
            break;
        case 1:
            creazioneEvento();
            break;
        case 2:
            prenotazioni(evento);
            break;
        case 3:
            stampaPosti(evento);
            break;
        default:
            menu1(evento);
            break;
    }
}

void creazioneEvento(){
    Console.WriteLine("inserire titolo evento");

    string titolo = Console.ReadLine();
    Console.WriteLine("inserire capienza massima evento");
    int capienzaMassima = controlloNumero();

    
    Console.WriteLine("inserire data evento");


    //TODO cambiare sistema di inserimento data con uno meno macchinoso
    Console.WriteLine("inserire anno");
    int anno = controlloNumero();
    Console.WriteLine("inserire mese");
    int mese = controlloNumero();
    Console.WriteLine("inserire giorno");
    int giorno = controlloNumero();
    Console.WriteLine("ora \"0 - 24\"");
    int ora = controlloNumero();
    Console.WriteLine("inserire minuti");
    int minuti = controlloNumero();

    DateTime data = new DateTime( anno,mese,giorno,ora,minuti,00 );
    DateTime comparazione = DateTime.Now;

    if (DateTime.Compare(data, comparazione) == 1)
    {
        Evento evento = new Evento(titolo, data, capienzaMassima);
        menu1(evento);
    }
    else
    {
        Console.WriteLine("la data non può essere precedente alla data attuale");
         creazioneEvento();
    }
    



    

}

void quantiProgrammaEventi()
{
    //Chiedete poi al vostro utente quanti eventi vuole aggiungere, e fategli inserire ad uno ad uno
    //tutti gli eventi necessari chiedendo man mano tutte le informazioni richieste all’utente.

    //Attenzione: qui si gestite eventuali eccezioni lanciate dagli eventi creati, in questo caso il
    //programma informa l’utente dell’errore e non aggiunge l’evento al programma eventi(o
    //meglio alla lista di Eventi del programmaEventi), ma comunque chiederà in continuazione
    //all’utente di inserire eventi fintanto che non raggiunge il numero di eventi specificato
    //inizialmente dall’utente.

    //AGG- nuovoProgrammaEventi()

    //    1.Stampate il numero di eventi presenti nel vostro programma eventi
    //2.Stampate la lista di eventi inseriti nel vostro programma usando il metodo già fatto

    //Agg- menuPostNuovoProgrammaEventi()
}

void menuPostNuovoProgrammaEventi()
{
    //3.Chiedere all’utente una data e stampate tutti gli eventi in quella data. Usate il metodo
    //che vi restituisce una lista di eventi in una data dichiarata e create un metodo statico
    //che si occupa di stampare una lista di eventi che gli arriva. Passate dunque la lista di
    //eventi in data al metodo statico, per poterla stampare.
    //4.Eliminate tutti gli eventi dal vostro programma.
}

void nuovoProgrammaEventi()
{
    //    creare un nuovo programma di Eventi che l’utente vuole organizzare,
    //chiedendogli qual è il titolo del suo programma eventi.
}

void prenotazioni(Evento evento)
{

    Console.WriteLine("quanti posti vuoi prenotare ?");
    int posti = controlloNumero();

    if (evento.CapienzaMassima - evento.PostiPrenotati > posti)
    {
        for (int i = 0; i < posti; i++)
        {
            evento.prenotaPosti();
        }
    }
    else
    {
        Console.WriteLine("non ci sono posti liberi a sufficienza");
    }

    menu1(evento);
    //    2.Dopo che l’evento è stato istanziato, chiedete all’utente se e quante prenotazioni
    //vuole fare e provare ad effettuarle.
}

void stampaPosti(Evento evento)
{
    int liberi = evento.CapienzaMassima - evento.PostiPrenotati;

    Console.WriteLine("sono occupati {0} posti e sono disponibili {1} posti", evento.PostiPrenotati, liberi );
    menu1(evento);
    //3. Stampare a video il numero di posti prenotati e quelli disponibili
}

void disdiciPrenotazioni(Evento evento)
{
    Console.WriteLine("quante prenotazioni bisogna disdire?");
    int posti = controlloNumero();

    if(evento.PostiPrenotati > 0)
    {
        evento.riduciPosti();
    }else
    {
        Console.WriteLine("non ci sono prenotazioni");
    }

    menu1(evento);
    //    4.Ora chiedere all’utente fintanto che lo desidera, se e quanti posti vuole disdire. Ogni
    //volta che disdice dei posti, stampare i posti residui e quelli prenotati. 
}

menu();


//consigli e TODO
//Vi ricordo che man mano che andrete avanti con le altre milestones, potrete aggiungere più
//avanti altri eventuali metodi (public e private) che vi aiutino a svolgere le funzioni richieste se
//ritenete necessari!

//A questo punto provate ad aggiungere al vostro programma oltre che dei semplici
//eventi anche delle e vere e proprie conferenze (potete fare a meno di svuotare la lista
//precedentemente creata, commentando il metodo svuota Lista di Eventi).

//ai setters inserire gli opportuni controlli in modo che la data non sia già passata, che il titolo
//non sia vuoto e che la capienza massima di posti sia un numero positivo. In caso contrario
//sollevare opportune eccezioni.


//Le eccezioni possono essere generiche (Exception) o usate quelle già messe a
//disposizione da C#, ma aggiungete un eventuale messaggio chiaro per
//comunicare che cosa è successo.