internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-------- DADOS PARA PAGAMENTO --------");

        Console.Write("Nome do usuário: ");
        string usuario = Console.ReadLine();
        Console.Write("Sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        Console.Write("Nome do produto que deseja: ");
        string produto = Console.ReadLine();
        Console.Write("Valor do produto: R$");
        float valor = float.Parse(Console.ReadLine());
        Console.ReadKey();
        Console.WriteLine();

        Console.WriteLine("-------- CONFIRMAÇÃO DOS DADOS DE COMPRA  --------");
        Console.WriteLine();

        Console.WriteLine(usuario);
        Console.WriteLine(idade);
        Console.WriteLine(produto);
        Console.WriteLine(valor);

        Console.ReadKey();
    }
}