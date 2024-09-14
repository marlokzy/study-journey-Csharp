# Tipos de operadores:

### De Atribuição

- = --> Operador de atribuição (ex: int a = 10);
- += --> Operador de atribuição com soma (int a += 10);
- -= --> Operador de atribuição com subtração (int a -= 10);
- *= --> Operador de atribuição com multiplicação (int a *= 10);
- /= --> Operador de atribuição com divisão (int a /= 10).

**Cast ou Casting --> Processo de conversão de um tipo para outro**
Existem duas formas de fazer isso:
1- Usando a classe Convert e seus métodos (ex: int a = Convert.ToInt32("5")); // 32 bits = int, 64 bits = long
2- Usando a classe do tipo da variável e o método Parse (ex: int a = int.Parse("5"));

**Diferença do Convert para o Parse**
A diferença principal entre eles é o tratamento de números nulos (null)
- Com o Convert ao colocar um valor nulo a ser convertido ele dará 0;
- Já o Parse ao colocar um valor nulo a ser convertido ele dará erro; // ele não aceita nulo

_**O mais usado e recomendado é o Convert**_

_Não existe o Parse para conversão de números para string_

**Boas práticas e recomendações**
- Para converter de número para string: use o .ToString();
- Para converter de string para número: use o Convert.ToInt32();

**//Pesquisar mais sobre conversão segura com Convert.TryParse!!!**

### Condicionais

- if, else e else if;
- switch e case.

### Lógicos

- Operador OR/OU (Pipe, || );
- Operador AND/E (&&);
- Operador NOT (!).

---

Toda conversão de valores há um risco de uma exceção, pois muitas vezes não podemos prever o tipo de dado que está vindo. Para realizar uma conversão segura, ou seja, em que há a possibilidade de falhar e não queremos que nosso código seja interrompido, podemos usar:
R:  TryParse