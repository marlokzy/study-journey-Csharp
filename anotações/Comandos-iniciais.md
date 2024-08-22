### Entendendo a estrutura de um projeto

Como estou utilizando o Visual Studio Code a maioria das coisas são feitas por meio de CLI (terminal)

# O que é CLI?
CLI é a sigla de Command-Line Interface, que traduzido significa “Interface de Linha de Comando”. As CLIs são uma forma de interação do usuário com o computador, que é feita através de comandos de texto. O que possibilita a execução de várias tarefas.

O funcionamento das CLIs é baseado em texto, dessa forma elas não possuem elementos visuais como diferentes janelas, ícones e botões. A representação visual das CLIs são as famosas telas pretas repletas de textos em outra cor, que comumente chamamos de terminal.

Comandos:

- dotnet new console -> cria um programa de console para ser executado (Ao criar o programa ele virá com o arquivo .cs, aonde ficará o código principal, virá com um arquivo .csproj, aonde ficará as configs do programa e virá com duas pastas, bin e obj, aonde ficará toda config de compilação e tudo mais...)
- dotnet build -> caso apague essas pastas sem querer só usar dotnet build que restaurará 
- dotnet run -> executa o programa

Segue a documentação da CLI do .NET:
https://learn.microsoft.com/pt-br/dotnet/core/tools/

