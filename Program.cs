//In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programma principale.
//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:


//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:

//Stampare l’array di numeri fornito a video
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
//Stampare la somma di tutti i numeri
//Stampare la somma di tutti i numeri elevati al quadrati
//BONUS: Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.
//Rieseguire il programma con l’input preso esternamente dall’utente.


int[] arrayProva = { 2, 6, 7, 5, 3, 9 };


//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.
void StampaArray(int[] array)
{
	int i;
	Console.Write("[ ");
	for ( i = 0; i < array.Length - 1; i++)
	{
		Console.Write(array[i] + ", ");
	}
    Console.Write(array[i] + " ]");
}



//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

int Quadrato(int numero)
{
	int quadrato;
	quadrato = numero * numero;
	return quadrato;
}


//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
//Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)

int[] ElevaArrayAlQuadrato(int[] array)
{
	int[] arrayAlQuadrato = new int[array.Length];


	for (int i = 0; i < arrayAlQuadrato.Length; i++)
	{
		arrayAlQuadrato[i] = Quadrato(array[i]);
	}
	return arrayAlQuadrato;
}

//StampaArray(ElevaArrayAlQuadrato(arrayProva));




//int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

int sommaElementiArray(int[] array)
{
	int somma = 0;

	foreach (var item in array)
	{
		somma += item;
	}

	return somma;
}

//Console.WriteLine(sommaElementiArray(arrayProva));



Console.WriteLine("Stampare l’array di numeri fornito a video");
StampaArray(arrayProva);
Console.WriteLine("");
Console.WriteLine("Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato. " +
    "(Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])");
Console.WriteLine("");
Console.WriteLine("Array al quadrato");

StampaArray(ElevaArrayAlQuadrato(arrayProva));
Console.WriteLine("");

Console.WriteLine("Array originale");
StampaArray(arrayProva);

Console.WriteLine("");
Console.WriteLine("Stampare la somma di tutti i numeri");
Console.WriteLine(sommaElementiArray(arrayProva));
Console.WriteLine("");
Console.WriteLine("Stampare la somma di tutti i numeri elevati al quadrati");
Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(arrayProva)));
Console.WriteLine("");





//BONUS

Console.WriteLine("Quanti numeri vuoi inserire?");
int N = Convert.ToInt32(Console.ReadLine());
int[] arrayUtente = new int[N];
for (int i = 0; i < N - 1; i++)
{
	arrayUtente[i] = Convert.ToInt32(Console.ReadLine());
}




Console.WriteLine("Stampare l’array di numeri fornito a video");
StampaArray(arrayUtente);
Console.WriteLine("");
Console.WriteLine("Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato. " +
    "(Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])");
Console.WriteLine("");
Console.WriteLine("Array al quadrato");

StampaArray(ElevaArrayAlQuadrato(arrayUtente));
Console.WriteLine("");

Console.WriteLine("Array originale");
StampaArray(arrayUtente);

Console.WriteLine("");
Console.WriteLine("Stampare la somma di tutti i numeri");
Console.WriteLine(sommaElementiArray(arrayUtente));
Console.WriteLine("");
Console.WriteLine("Stampare la somma di tutti i numeri elevati al quadrati");
Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(arrayUtente)));
Console.WriteLine("");