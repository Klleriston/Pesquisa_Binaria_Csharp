# Pesquisa Binaria

A pesquisa ou busca binária é um algoritmo de busca em vetores que segue o paradigma de divisão e conquista. Ela parte do pressuposto de que o vetor está ordenado e realiza sucessivas divisões do espaço de busca comparando o elemento buscado com o elemento no meio do vetor.

## Logica pesquisa binaria:

```Csharp
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
```

## Contributing

Algoritmo realizado para fins educativos e inspirado no livro "Entendendo Algoritmosde Aditya Y. Bhargava.
