// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;

// funzioni utili


List<Evento>eventi = new List<Evento>();
List<ProgrammaEventi> programmi = new List<ProgrammaEventi>();
double controlloNumerodouble(){
    double scelta = 0;
    try
    {
        scelta = Convert.ToDouble(Console.ReadLine());
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
bool siOno()
{
    bool scelta = false;

    string selezione = Console.ReadLine();


    if(selezione == "si"|| selezione == "yes" || selezione == "y"|| selezione == "s")
    {
        scelta = true;
    }

    return scelta;
}


void menu()
{
    Console.WriteLine("--------------------------------------------------------------------------------------");
    Console.WriteLine("menu iniziale scegli l'operazione");
    Console.WriteLine("/////////////////////////////////");
    Console.WriteLine("1. nuovo evento e modifica evento");
    Console.WriteLine("2. nuovo programma eventi e modifica evento e modifica programma eventi");
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
        case 2:
            ProgrammaEventi? p_eventi = null;
            menu2(p_eventi);
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
        Console.WriteLine("4 crea una conferenza");
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
        case 4:
        case 1:
            ProgrammaEventi p_eventi = null;
            creazioneEvento(p_eventi, scelta, false );
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

void menu2(ProgrammaEventi p_eventi)
{
    int scelta;
    Console.WriteLine("--------------------------------------------------------------------------------------");
    Console.WriteLine("menu nuovo programma eventi");
    Console.WriteLine("/////////////////////////////////");

    if (p_eventi == null)
    {
        Console.WriteLine("0. torna al menu iniziale");
        Console.WriteLine("1. crea nuovo programma eventi");
        Console.WriteLine("2 crea file csv");
        scelta = controlloNumero();

    }
    else
    {

        Console.WriteLine("1 stampa numero eventi nel programma");
        Console.WriteLine("2 stampa eventi nel programma");
        Console.WriteLine("3 stampa eventi per una data");
        Console.WriteLine("4 elimina tutti gli eventi dal programma");
        Console.WriteLine("5 mostra dettagli del programma e tutti gli eventi");
        Console.WriteLine("6 esporta csv del programma");
        Console.WriteLine("7 importa csv nel programma" );
        Console.WriteLine("8 torna al menu iniziale");
        scelta = controlloNumero() + 2;

    }
    Console.WriteLine("--------------------------------------------------------------------------------------");
    switch (scelta)
    {
        case 0:
        case 10:
            menu();
            break;
        case 1:
            nuovoProgrammaEventi();
            break;
        case 2:
            StreamWriter altroStream = File.CreateText("C:\\Users\\diome\\Desktop\\corso c#\\csharp-gestore-eventi\\nuovodata.csv");
            altroStream.Close();
            menu2(p_eventi); ;
            break;
        case 3:
            int even = p_eventi.EventiAttuali();
            Console.WriteLine("il numero di eventi in questo programma è "+ even);
            menu2(p_eventi);
            break;
        case 4:
            ProgrammaEventi.listaEventi(p_eventi);
            menu2(p_eventi);
            break;
        case 5:
            Console.WriteLine("inserire data  esempio = anno,mese,giorno");
            string data = Console.ReadLine();

             ProgrammaEventi.ListaEventiPerData(p_eventi, data);

            menu2(p_eventi);
            break;
        case 6:
            p_eventi.cancellaLista();
            menu2(p_eventi);
            break;
        case 7:
            p_eventi.TitoloProgramma();
            break;
        case 8:
            p_eventi.svriviVsc();
            menu2(p_eventi);
            break;
        case 9:

            menu2(p_eventi);
            break;
        default:
            menu();
            break;

    }
}


void creazioneEvento(ProgrammaEventi p_eventi , int scelta, bool inCreazioneProgramma)
{
    Console.WriteLine("inserire titolo evento");

    string titolo = Console.ReadLine();
    Console.WriteLine("inserire capienza massima evento");
    int capienzaMassima = controlloNumero();
    double prezzo;
    string relatore;






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

        if (scelta == 4)
        {
            Console.WriteLine("inserire il prezzo");
            prezzo = controlloNumerodouble();
            Console.WriteLine("inserire relatore");
            relatore = Console.ReadLine();

            Conferenza conferenza = new Conferenza( relatore,prezzo, titolo, data, capienzaMassima);
            if (p_eventi != null)
            {
                p_eventi.aggiungiEvento(conferenza);
            }
            else
            {
                Console.WriteLine("l'evento fa parte di un programma eventi?");

                if (siOno())
                {
                    Console.WriteLine("indica ilprogramma");

                    ricercaP_eventi().aggiungiEvento(conferenza);

                }
                else
                {

                }

            }
            menu1(conferenza);
        }
        else
        {
            Evento evento = new Evento(titolo, data, capienzaMassima);
            eventi.Add(evento);
            if (p_eventi != null)
            {
                p_eventi.aggiungiEvento(evento);
            }
            else
            {
                Console.WriteLine("l'evento fa parte di un programma eventi?");

                if (siOno())
                {
                    Console.WriteLine("indica ilprogramma");

                    ricercaP_eventi().aggiungiEvento(evento);


                }
                else
                {

                }

            }
            if (inCreazioneProgramma == false)
            {
                menu1(evento);
            }
        }
        
    }
    else
    {
        Console.WriteLine("la data non può essere precedente alla data attuale");
       if (inCreazioneProgramma == false) 
        {
         creazioneEvento( p_eventi,scelta, false);
        }
        
    }
    



    

}

ProgrammaEventi ricercaP_eventi()
{
    int i = 1;
    foreach (var item in programmi)
    {
        Console.WriteLine( i + ". " + item.Titolo );
    }

    return programmi[controlloNumero() - 1];
}

void quantiEventi(ProgrammaEventi p_eventi)
{

    Console.WriteLine("quanti eventi vuoi creare in questo programma?");
    int eve = controlloNumero();

    for (int i = 0; i < eve; i++)
    {
        int scelta = 0;
        creazioneEvento(p_eventi,scelta, true );
    }
    //Chiedete poi al vostro utente quanti eventi vuole aggiungere, e fategli inserire ad uno ad uno
    //tutti gli eventi necessari chiedendo man mano tutte le informazioni richieste all’utente.

    //Attenzione: qui si gestite eventuali eccezioni lanciate dagli eventi creati, in questo caso il
    //programma informa l’utente dell’errore e non aggiunge l’evento al programma eventi(o
    //meglio alla lista di Eventi del programmaEventi), ma comunque chiederà in continuazione
    //all’utente di inserire eventi fintanto che non raggiunge il numero di eventi specificato
    //inizialmente dall’utente.

    Console.WriteLine("creare un nuovo programma eventi?");
    //AGG- nuovoProgrammaEventi()
    if (siOno())
    {
        nuovoProgrammaEventi();
    }

    Console.WriteLine("tornare al menu programma eventi?");
    if(siOno())
    {
        menu2(p_eventi);
    }

    //Agg- menuPostNuovoProgrammaEventi()
}


void nuovoProgrammaEventi()
{
//    creare un nuovo programma di Eventi che l’utente vuole organizzare,
    //chiedendogli qual è il titolo del suo programma eventi.

    Console.WriteLine("creazione di un programma di eventi");
    Console.WriteLine("inserire titolo");
    string titolo = Console.ReadLine();



    ProgrammaEventi p_eventi = new ProgrammaEventi(titolo);
    

    

    Console.WriteLine("inserire eventi ?");
    if (siOno())
    {
      
        quantiEventi(p_eventi);
    }

    Console.WriteLine("entrare nel menu del programma evento?");
    if (siOno())
    {
        menu2(p_eventi);
    }
    else
    {
        menu();
    }
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