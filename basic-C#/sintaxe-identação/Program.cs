using System.Data;
using System.Data.Common;
using basic_C_.Models; // importamos tudo que estiver na pasta Models

// Tipos de dados na prática

// string apresentacao = "Olá, seja muito bem-vindo!";
// int quantidade = 1;
// double altura = 1.80; // sairá 1.8, mas se quisermos todas as casas decimais podemos definir com o método ToString("0.00") ----> altura.ToString("0.00")
// decimal preco = 1.80m; // colocamos o m pois quando já definimos um valor é necessário para funcionar
// bool condicao = true;
// Console.WriteLine(apresentacao);
// Console.WriteLine($"O valor da variável quantidade é: {quantidade}");
// Console.WriteLine($"O valor da variável altura é: {altura.ToString("0.00")}");
// Console.WriteLine($"O valor da variável preco é: {preco}");
// Console.WriteLine($"O valor da variável condicao é: {condicao}");

// Tipo DateTime

DateTime dataAtual = DateTime.Now; // puxa a data e o horário atual do computador
Console.WriteLine(dataAtual);
DateTime dataAtualMais5Dias = DateTime.Now.AddDays(5); // pegou a data atual e acrescentou mais 5 dias 
Console.WriteLine(dataAtualMais5Dias);
// E se eu quiser só a data? sem o horário
DateTime apenasData = DateTime.Now; 
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy")); // utilizamos o método ToString
// ToString("dd/MM/yyyy HH:mm") -> para representar o horário só com horas e minutos


// Classe e método

// Pessoa pessoa1 = new Pessoa(); // instanciamos a classe pessoa, para usarmos nesse arquivo
// pessoa1.Nome = "Marlon"; // chamamos a nova instancia criada e definimos uma ação para ela
// pessoa1.Idade = 21;
// pessoa1.Apresentar(); // chamamos a nova instancia criada e usamos o método