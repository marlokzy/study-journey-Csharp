public class TiposDeOperadores
{
    public static void Main()
    {   // Operadores de Atribuição

        // int a = 10;
        // int b = 20;
        // int c = a + b;
        // c = c + 5;  // --> pode ser tbm: c += 5
        // Console.WriteLine(c);

        // Cast ou Casting 

        // Com Convert
        // Convertendo string em número
        // int a = Convert.ToInt32("5");
        // Console.WriteLine(a);
        // Convertendo número em string
        // string b = Convert.ToString(5);
        // Console.WriteLine(b);

        // Com Parse
        // Convertendo string em número
        // int a = int.Parse("5");
        // Console.WriteLine(a);
        // // Convertendo número em string
        // // string b = string.Parse(5); --> vai dar erro pq a classe string não funciona com o Parse
        // // Console.WriteLine(b);
        // string b = 5.ToString(); --> mas você pode fazer assim tbm, que dá certo (add método .ToString())
        // Console.WriteLine(b);

        //Conversão segura - TryParse
        // string a = "15-"; // coloquei um - na string justamente para forçar um erro
        // int b = 0;
        // int.TryParse(a, out b);
        // Console.WriteLine(b);

        // Operadores condicionais

        //if e else
        // int quantidadeEmEstoque = 10;
        // int quantidadeCompra = 5;
        // bool possívelVenda = quantidadeEmEstoque >= quantidadeCompra;
        // Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
        // Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
        // Console.WriteLine($"É possível realizar a venda? {possívelVenda}");
        // if (possívelVenda)
        // {
        //     Console.WriteLine("\nVenda realizada com sucesso!");
        // } else {
        //     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque!");
        // }

        

    }
}