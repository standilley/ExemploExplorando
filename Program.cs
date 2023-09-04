using System.Globalization;
using System.Runtime.Serialization;
using ExemploExplorando.Models;

string dataString = "2023-09-01 18:00";

bool sucesso = DateTime.TryParseExact(dataString,
                        "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}

















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

