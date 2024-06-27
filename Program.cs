

// ------------ Exercicio 1 -----------------
// Console.WriteLine("Informe o valor do salario");

// double salario = double.Parse(Console.ReadLine());

// double valorAumento = salario * 0.25; 

// double salarioAjustado = salario + valorAumento;

// Console.WriteLine($"Novo salario com o ajuste, é de {salarioAjustado}.");


// -------------Exercicio 2 -----------------
// Console.WriteLine("Informe o valor do salario");

// double salario = double.Parse(Console.ReadLine());

// Console.WriteLine("Informe o valor de percentual que deseja aplicar");

// double valorPercentualAdicionado = double.Parse(Console.ReadLine());

// double salarioAjustado = salario * (1 + valorPercentualAdicionado/100);

// Console.WriteLine($"O valor do salario após o ajuste percentual de {valorPercentualAdicionado}% é de {salarioAjustado}.");

// ------------------ Exercicio 3 -------------
// Console.WriteLine("Informe o ano do seu nascimento");

// int anoNascimento = int.Parse(Console.ReadLine());
// int anoAtual = 2024;

// int idadeEmAnos = anoAtual - anoNascimento;

// int idadeEmMeses = idadeEmAnos * 12; //multiplicando a idade pela quantidade de meses do ano

// int idadeEmSemanas = idadeEmAnos * 52; // multiplicando idade por 52 semanas (levando em conta que o ano tem 52 semanas)

// int idadeEmDias = idadeEmAnos * 365; // multiplicando idade pela quantidade de dias que o ano possui

// Console.WriteLine($"Atualmente voce possui {idadeEmAnos} anos, {idadeEmMeses} meses, {idadeEmSemanas} semanas e {idadeEmDias} dias de idade" );

// ----- Exercicio 8 ---------

Console.WriteLine( "Informe a cotação do dolar na data de hoje" );
double cotacaoDolar = double.Parse(Console.ReadLine());

Console.WriteLine( "Informe o valor que deseja converter para reais" );
double valorParaConversao = double.Parse(Console.ReadLine());

double valorConvertido = Math.Round(valorParaConversao / cotacaoDolar, 2); //documentação informa que math.round aredonda o valor e temos a opção de inserir quantas casas decimais queremos após a virgula.

Console.WriteLine($"O valor da cotação atual do dolar é de {cotacaoDolar}, desta forma com base no valor informado de {valorParaConversao} dolares, após a conversão para reais, o total é de {valorConvertido} reais" );




