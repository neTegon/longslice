# longslice
In questo esercizio, data una stringa formata solo da cifre, calcola il prodotto più grande per una sua sottostringa contigua di cifre di lunghezza N.
Per certe condizioni ho usato il throw new ArgumentException() perchè non sarebbero state valide, ecco l'elenco:
-la lunghezza N è maggiore della lunghezzza della stringa
-se N è minore di 0
- se ci sono dei caratteri diversi dalle cifre
### N maggiore della lunghezza della stringa e minore di zero
Per questi due punti ho fatto un unico if in cui se si verificava almeno una delle due condizioni lo considerava con un'eccezione, qui sotto c'è il codice che ho utilizzato.
if (span>len || span<0)
{
    throw new ArgumentException();
}
Per controllare se ci sono dei caratteri diversi dalle cifre ho fatto un for che scorre il vettore con dentro un if con condizione !char.IsDigit(vet[i]), qui sotto c'è il pezzo di codice che ho fatto
for(int i=0; i<vet.Length;i++)
{
    if(!char.IsDigit(vet[i]))
    {
        throw new ArgumentException();
    }
}
