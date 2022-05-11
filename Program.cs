using System;           //riferimento alla libreria di base
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {
            ////for (char paperino='a'; paperino <= 'z'; paperino++)
            ////    Console.WriteLine(paperino);
            ////var a = "aaaa"; //Utilizzo var <nome> per dichiarare una variabile 
            ////assegnandogli il tipo dell'oggetto che gli sto dando come valore
            //int n = 0;
            //for (int i = 0; i < 512; i++)
            //{
            //    if (n == 16)
            //    {
            //        Console.WriteLine();
            //        n = 0;
            //    }
            //    n++;
            //    //Console.Write("{0} ", Convert.ToChar(i));
            //    Console.Write("{0} ", (char)i);  //casting
            //}
            //for (char paperino = 'a'; paperino <= 'z'; paperino++)
            //    Console.WriteLine((long)paperino);
            /*
             * Un semplice calcolatore
             * Realizzare un programma che chiede all'utente che tipo di operazione intende svolgere
             * (0-somma, 1-prodotto, 2-divisione, 3-sottrazione, 4-quadrato, 5-media)
             * e poi se somma, prodotto, divisione o sottrazione chiede due valori,  
             * se quadrato chiede un solo valore e se media chiede 10 valori.
             * Utilizzare un vettore di interi o reali (a vostra scelta) per archiviare i valori di input.
             * Opzionale: implementare l'operazione di elevamento a potenza superiore al 2.
             * */
            //foreach (string s in "alfa beta gamma delta".Split(' '))
            //{
            //    Console.WriteLine("<{0}>", s);
            //}
            //foreach (string s in "alfa ; ;  beta gamma delta".Split(new char[] { ' ', ';' })) //creo un vettore e gli assegno dei valori
            //    Console.WriteLine("<{0}>", s);
            //bool finito = false;
            //while (!finito)
            //{
            string[] comandi = new string[] { "Somma", "Prodotto", "Divisione", "Sottrazione", "Quadrato", "Media" };
            Console.Write("Comando [0-add, 1-mul, 2-div, 3-sub, 4-square, 5-avg, 9-end]: ");
            string cmd = Console.ReadLine();
            switch (cmd)
            {
                case "0":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);

                        Console.Write("Inserisci due numeri, separati da uno spazio: ");
                        string sNum = Console.ReadLine();

                        string[] svect = sNum.Split(' ');
                        double sum = 0.0;

                        foreach (string snum in svect)
                        {
                            double num;
                            if (double.TryParse(snum, out num))
                            {
                                sum += num;
                            }
                        }

                        Console.WriteLine("La somma dei numeri forniti è: {0}", sum);


                        break;
                    }
                case "1":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);


                        Console.Write("Inserisci due numeri, separati da uno spazio: ");
                        string sNumb = Console.ReadLine();

                        string[] svects = sNumb.Split(' ');
                        double mul = 0.0;

                        double num1 = Convert.ToDouble(svects[0]);
                        double num2 = Convert.ToDouble(svects[1]);

                        mul = num1 * num2;

                        Console.WriteLine("Il prodotto dei numeri forniti è: {0}", mul);
                        break;

                    }
                case "2":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);


                        Console.Write("Inserisci due numeri, separati da uno spazio: ");
                        string sNumber = Console.ReadLine();

                        string[] svector = sNumber.Split(' ');
                        double div = 0.0;

                        double dNum1 = Convert.ToDouble(svector[0]);
                        double dNum2 = Convert.ToDouble(svector[1]);

                        div = dNum1 / dNum2;

                        Console.WriteLine("Il quoziente dei numeri forniti è: {0}", div);
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);

                        Console.Write("Inserisci due numeri, separati da uno spazio: ");
                        string sNumbers = Console.ReadLine();

                        string[] svectors = sNumbers.Split(' ');
                        double sub = 0.0;

                        double num1 = Convert.ToDouble(svectors[0]);
                        double num2 = Convert.ToDouble(svectors[1]);

                        sub = num1 - num2;

                        Console.WriteLine("La differenza dei numeri forniti è: {0}", sub);

                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);

                        Console.Write("Inserirci il numero di cui vuoi fare il quadrato: ");
                        string choise = Console.ReadLine();

                        double square = 0.0;
                        double num = 0;
                        if (double.TryParse(choise, out num))
                        {
                            square = num * num;
                        }

                        Console.WriteLine("Il quadrato è: {0}", square);
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.Write("Inserisci l'elenco dei numeri di cui calcolare la media, separati da spazi, tutti sulla stessa riga: ");
                        string sNumeri = Console.ReadLine();
                        if (sNumeri == null)
                        {
                            Console.WriteLine("Non hai fornito numeri!");
                            Environment.Exit(0);
                        }
                        string[] svect = sNumeri.Split(' ');
                        double media = 0.0;
                        int quanti = 0;
                        foreach (string snum in svect)
                        {
                            double num;
                            if (double.TryParse(snum, out num))
                            {
                                media += num;
                                quanti++;
                            }
                        }
                        media /= quanti;  //media = media / quanti
                        Console.WriteLine("La media dei numeri forniti è: {0}", media);

                        break;
                    }
                default:
                    Console.WriteLine("Richiesta comando non esistente: {0}.", cmd);
                    break;
            }
        }
        //int v1, v2, v3;
        //v1 = 10;
        //v2 = 20;
        //NuovoMetodo(v1, ref v2, out v3);
        //Console.WriteLine("{0}, {1}, {2}", v1, v2, v3);
        //bool bret;
        //int iret;
        //(bret, iret) = ValoriMultipli(3, 4);
        //if (bret)
        //    Console.WriteLine("La somma è andata a buon fine e ha ritornato: {0}", iret);
    }
    //static int NuovoMetodo(int n1, ref int n2, out int n3)
    //{
    //    //n1 passato per valore. Anche se lo modifico, la modifica non si propaga al chiamante
    //    n1 = 1000;
    //    //n2 passato by reference. Quando lo modifico, il suo valora cambia anche nel chiamante
    //    n2 = 2000;
    //    //n3, passato solo come out, non interessa il suo valore in ingresso.  
    //    //Sono obbligata ad assegnargli un valore in uscita
    //    n3 = 3000;
    //    return 0;
    //}

    //Questo metodo torna due valori, un bool e un int
    //static (bool, int) ValoriMultipli(int a, int b)
    //{
    //    //mettendo i valori tra parentesi tonde, si costruisce un valore di ritorno multiplo
    //    return (true, a + b);
    //}
    //}
}