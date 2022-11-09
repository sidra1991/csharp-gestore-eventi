// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;

// funzioni utili

int ScelteMenuINT()
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
    Console.WriteLine("menu iniziale scegli l'operazione");
    Console.WriteLine("1. nuovo evento");


    int scelta = ScelteMenuINT();

        switch (scelta)
    {
        case 0:
            menu();
            break;
        case 1:
            menu1();
            break;
    }


}

void menu1()
{
    Console.WriteLine("menu nuovo evento");
    Console.WriteLine("1. crea nuovo evento");
    //AGG- prenotazioni()
    //AGG- stampaPosti()
    //AGG- disdiciPrenotazioni()

    //chiedete all’utente di inserire un
    //nuovo evento con tutti i parametri richiesti dal costruttore
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

void prenotazioni()
{
    //    2.Dopo che l’evento è stato istanziato, chiedete all’utente se e quante prenotazioni
    //vuole fare e provare ad effettuarle.
}

void stampaPosti()
{
    //3. Stampare a video il numero di posti prenotati e quelli disponibili
}

void disdiciPrenotazioni()
{
    //    4.Ora chiedere all’utente fintanto che lo desidera, se e quanti posti vuole disdire. Ogni
    //volta che disdice dei posti, stampare i posti residui e quelli prenotati. 
}




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