using System.Reflection.Metadata;

public class Estoque
{

    Quadro[] quadros = new Quadro[0];

    public void Adicionar(Quadro quadro)
    {
        Quadro[] novoVetor = new Quadro[quadros.Length + 1];
        for (int pos = 0; pos < quadros.Length; pos++)
        {
            Quadro item = quadros[pos];
            novoVetor[pos] = item;

        }
        novoVetor[novoVetor.Length - 1] = quadro;

        quadros = novoVetor;
    }

    public void Listar()
    {
        int cont = 1;
        foreach (Quadro item in quadros)
        {
            Console.WriteLine($"{cont}. {item.Nome} (R$ {item.Preco}) - {item.Estoque} no estoque");
            cont++;
        }
    }
    public void Entrada(int pos, int qnt)
    {
        if (pos >= 1 && pos <= quadros.Length)
        {
        Quadro quadro = quadros[pos - 1];
        quadro.Estoque += qnt;
        Console.WriteLine("Adcionado com sucesso.");
         }
         else
    {
        Console.WriteLine("Posição inválida.");
    }

    }

    public void Saida(int pos,int qnt)
    {
        if (pos >= 1 && pos <= quadros.Length)
        {
        Quadro quadro = quadros[pos - 1];
        quadro.Estoque -= qnt;
        Console.WriteLine("Dado saída com sucesso.");
    
        }
         else
    {
        Console.WriteLine("Posição inválida.");
    }

    }

    public void Remover(int pos)
    {
    
    if (pos >= 1 && pos <= quadros.Length)
    {
        Quadro[] novoVetor = new Quadro[quadros.Length - 1];

        for (int posOriginal = 0, posNovo = 0; posOriginal < quadros.Length; posOriginal++)
        {
            if (posOriginal != pos - 1)
            {
                novoVetor[posNovo] = quadros[posOriginal];
                posNovo++;
            }
        }

        quadros = novoVetor;

        Console.WriteLine("Quadro removido com sucesso.");
    }
    else
    {
        Console.WriteLine("Posição inválida.");
    }
}
    }



