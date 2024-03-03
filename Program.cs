using System.Linq.Expressions;

namespace PTI_CONTROLE_ESTOQUE;

class Program
{
    static void Main(string[] args)
    {
       Estoque estoque = new Estoque();

       int menu = 0;
       do 
       {
        Console.WriteLine("");
        Console.WriteLine("[1] Novo");	
        Console.WriteLine("[2] Listar Produtos");
        Console.WriteLine("[3] Remover Produtos");
        Console.WriteLine("[4] Entrada Estoque");
        Console.WriteLine("[5] Saída Estoque");
        Console.WriteLine("[0] Sair");
        
        menu = Convert.ToInt32(Console.ReadLine());

        if (menu == 1)
        {
            Quadro novoQuadro = new Quadro();

            Console.WriteLine("Digite o nome do quadro: ");
            novoQuadro.Nome = Console.ReadLine();

            Console.WriteLine("Digite o Preço: ");
            novoQuadro.Preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o tamanho: ");
            novoQuadro.Tamanho = Console.ReadLine();

            Console.WriteLine("Digite a cor: ");
            novoQuadro.Cor = Console.ReadLine();

            Console.WriteLine("Digite o tipo: ");
            novoQuadro.Tipo = Console.ReadLine();

            estoque.Adicionar(novoQuadro);

        }

        else if (menu == 2){
            Console.WriteLine("\nItens no Estoque:");
            estoque.Listar();

        }
         else if (menu == 3){

            Console.WriteLine("Itens no Estoque:");
            estoque.Listar();

            Console.WriteLine("Qual a posição do quadro que deseja remover? ");
            int pos = Convert.ToInt32(Console.ReadLine());

            estoque.Remover(pos);

            
        }
         else if (menu == 4){

            Console.WriteLine("Itens no Estoque:");
            estoque.Listar();

            Console.WriteLine("Qual a posição do quadro? ");
            int pos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a quantidade que deseja adcionar? ");
            int qnt = Convert.ToInt32(Console.ReadLine());

            estoque.Entrada(pos, qnt);

        }
         else if (menu == 5){
            Console.WriteLine("Itens no Estoque:");
            estoque.Listar();

            Console.WriteLine("Qual a posição do quadro? ");
            int pos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a quantidade que deseja dar saída? ");
            int qnt = Convert.ToInt32(Console.ReadLine());

            estoque.Saida(pos, qnt);

           
        }

       }
        while (menu != 0);
   }
}
