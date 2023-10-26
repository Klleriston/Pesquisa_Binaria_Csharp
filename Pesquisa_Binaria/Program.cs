int[] listaBinaria = new int[5] { 1, 2, 3, 4, 5 };

static void PesquisaBinaria(int[] listaBinaria, int item)
{
    int baixo = 0;
    int alto = listaBinaria.Length - 1;

    while (baixo <= alto) 
    {
        int meioDaLista = (baixo + alto) / 2; 
        int chute = listaBinaria[meioDaLista];
        
        if (chute == item) 
        {
            Console.WriteLine($"O numero é {chute}");
        } 
        if (chute > item) 
        {
            alto = meioDaLista - 1;
        }
        else
        {
            baixo = meioDaLista + 1;
        }
    }
    return;
}

PesquisaBinaria(listaBinaria, 3);