### Quais são os tipos de dados que existem no C#?

- string: Uma série de caractéres;

- char: Um único caracter;

- object

- bool: Verdadeiro ou falso;

- byte: Variação do int (0 to 255);

- decimal: Serve para representar um valor com 28-29 casas decimais (recomendado para representar valores monetários)

- double

- int: É um valor que representa o número sem casas decimais (-2,147,483,648 to 2,147,483,647);

- float

- long: Variação do int (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807);

- uint: Variação do int (0 to 4,294,967,295) (não representa números negativos);

- short: Variação do int (-32,768 to 32,767);

- ulong: Variação do int (0 to 18,446,744,073,709,551,615).

### Os mais usados
**Numéricos inteiros**
- int
- long

**Strings/caractéres literais**
- string
- char (mas nem tanto)

**Numéricos decimais**
- decimal
- double

**Outros**
- bool

### **Tipo DateTime** ###

- DateTime (recomendado para trabalhar com **datas** e horários)
_exemplo:_

DateTime dataAtual = DateTime.now; --> chamei o objeto DateTime e o método now, que puxa a data e o horário atual do computador.
Console.WriteLine(dataAtual); --> imprimi a variável