using System.Collections;
using System.Globalization;
using System.Runtime.Intrinsics;
using System.Runtime.Serialization;
using ExemploExplorando.Models;
using Newtonsoft.Json;

Pessoa p1 = new Pessoa(nome: "Tandy", sobrenome: "Oliveira");
Pessoa p2 = new Pessoa(nome: "Aldilane", sobrenome: "Oliveira");

Console.WriteLine($"Nome da pessoa p1: {p1.NomeCompleto}");
Console.WriteLine($"Nome da pessoa p2: {p2.NomeCompleto}");
p1.Idade = 5;
p1.Apresentar();




























// int numero = 21;
// bool par = false;

// par = numero.EhPar();

// string mensagem = $"O Numero {numero} é {(par ? "par" : "impar")}";
// Console.WriteLine(mensagem);

// int teste = 2;
// teste.EhPar();


// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(10);

// Console.WriteLine(arrayInteiro[0]);

// MeuArray<string> arrayString = new MeuArray<string>();
// arrayString.AdicionarElementoArray("Tandy");
// Console.WriteLine(arrayString[0]);


































// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, valor: {variavelDinamica}");


// variavelDinamica = "texto";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, valor: {variavelDinamica}");













// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);


// var listaAnonimo = listaVendas.Select(x => new {x.Produto, x.Preco });

// foreach (var anonimo in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {anonimo.Produto} , Preço: {anonimo.Preco}");
// }










// foreach (Venda venda in listaVendas)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//                     $"Preço: {venda.Preco}, Data: {venda.DataVenda}, " +
//                     $"{(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }



// var valorAnonimo = new {Nome = "Tandy", Sobrenome = "Oliveira", Altura = 1.92 };

// Console.WriteLine($"Nome: {valorAnonimo.Nome}");
// Console.WriteLine($"Sobrenome: {valorAnonimo.Sobrenome}");
// Console.WriteLine($"Altura: {valorAnonimo.Altura}");























// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(15,"Material de construção", 40.00M, dataAtual);
// Venda v2 = new Venda(12,"Licença de construção", 100.00M, dataAtual);
// Venda v3 = new Venda(10,"Aquitetura da construção", 90.00M, dataAtual);


// listaVendas.Add(v1);
// listaVendas.Add(v2);
// listaVendas.Add(v3);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/Vendas.json", serializado);

// Console.WriteLine(serializado);



















// int numero = 10;
// bool ehPar = numero % 2 == 0;

// Console.WriteLine($"O numero {numero} é " + (ehPar ? "par" : "impar"));


// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O numero {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O numero {numero} é impar");

// }














// Pessoa p1 = new Pessoa("Standilley", "Oliveira");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");

















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quandidadeLinhas) = arquivo.LerArquivo("Arquivos/ArquivoLeitura.txt");

// if (sucesso)
// {
    
//     Console.WriteLine("Quantidade linhas do Arquivo: " + quandidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else 
// {
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }






// (int ID, string Nome, string Sobrenome, decimal Altura) tupla = (2, "Tandy", "Oliveira", 1.92M);

// Console.WriteLine($"ID: {tupla.ID}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");
// Console.WriteLine($"------------------------------");

// ValueTuple<int, string, string, decimal> outraSintaxeTupla = (5, "Aldilane", "Oliveira", 1.75M);

// Console.WriteLine($"ID: {outraSintaxeTupla.Item1}");
// Console.WriteLine($"Nome: {outraSintaxeTupla.Item2}");
// Console.WriteLine($"Sobrenome: {outraSintaxeTupla.Item3}");
// Console.WriteLine($"Altura: {outraSintaxeTupla.Item4}");
// Console.WriteLine($"--------------------------------");

// var outroExemploTuplaCreate = Tuple.Create(4,"Scarlat","Oliveira", 1.77M);
// Console.WriteLine($"ID: {outroExemploTuplaCreate.Item1}");
// Console.WriteLine($"Nome: {outroExemploTuplaCreate.Item2}");
// Console.WriteLine($"Sobrenome: {outroExemploTuplaCreate.Item3}");
// Console.WriteLine($"Altura: {outroExemploTuplaCreate.Item4}");

















// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove("BA");
// estados["SP"] = "São_Paulo";
// Console.WriteLine("--------------------------------");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";

// Console.WriteLine($"Verificar a chave: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor Existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor inexistente, É seguro adicionar a chave: {chave}");
// }

// Console.WriteLine(estados["SP"]);







// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removento o Elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }


// Queue<int> fila = new Queue<int>();

// fila.Enqueue(5);
// fila.Enqueue(2);
// fila.Enqueue(10);
// fila.Enqueue(4);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);
// fila.Enqueue(50);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


















// new ExemploExcecao().Metodo1()








// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine("Ocorreu um erro na leitura do arquivo," +
//     $" Arquivo não encontrado {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine("Ocorreu um erro na leitura do arquivo," +
//     $" Caminho da pasta não encontrado {ex.Message}");
// }
// catch (PathTooLongException ex)
// {
//     Console.WriteLine("Ocorreu um erro na leitura do arquivo," +
//     $" Caminho muito longo  {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma Exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }




























// string dataString = "2023-09-01 18:00";

// bool sucesso = DateTime.TryParseExact(dataString,
//                         "yyyy-MM-dd HH:mm",
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }

















// using System.Globalization;
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("N6"));


// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P2"));


// int numero = 123456;
// Console.WriteLine(numero.ToString("##-###-#"));












// Pessoa p1 = new Pessoa(nome: "tandy", sobrenome: "oliveira");
// Pessoa p2 = new Pessoa(nome: "aldilane", sobrenome: "oliveira");
// Pessoa p3 = new Pessoa("scarlat", "oliveira");

// Pessoa p4 = new Pessoa();
// p4.Name = "josé hélio";
// p4.Sobrenome = "maciel dos santos";

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.AdicionarAluno(p3);
// cursoDeIngles.AdicionarAluno(p4);
// cursoDeIngles.ListarAlunos();

