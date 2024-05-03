using ExemplosFundamentos.Models;
using System.Globalization;


Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("CE", "Ceará");
estados.Add("PE", "Pernambuco");
estados.Add("BA", "Bahia");
estados.Add("PI", "Piauí");

System.Console.WriteLine(estados["CE"]);

// foreach(var item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// System.Console.WriteLine("-----------------");

// estados.Remove("PI");
// estados["CE"] = "Ceará - estado mais top";

// foreach(var item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA2";
// System.Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     System.Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     System.Console.WriteLine($"Valor não existente. É seguro adicionar a chave: {chave}");
// }




























// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     System.Console.WriteLine(item);
// }
































// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     System.Console.WriteLine(item);
// }






























// new ExemploExcessao().Metodo1();





























// try
// {
//    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//    foreach(string linha in linhas)
//    {
//       System.Console.WriteLine(linha);
//    }
// } 
// catch(FileNotFoundException ex)
// {
//    System.Console.WriteLine($"Ocorreu um erro de leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// } 
// catch(DirectoryNotFoundException ex)
// {
//    System.Console.WriteLine("Ocorreu um erro de leitura do arquivo. Caminho da pasta não encontrado. " + ex.Message);
// }
// catch(Exception ex)
// {
//    System.Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//    System.Console.WriteLine("Chegou até aqui.");
// }































// public class Example
// {
//    public static void Main()
//    {
//       string[] dateStrings = {"05/01/2009 14:57:32.8", "2009-05-01 14:57:32.8",
//                               "2009-05-01T14:57:32.8375298-04:00", "5/01/2008",
//                               "5/01/2008 14:57:32.80 -07:00",
//                               "1 May 2008 2:57:32.8 PM", "16-05-2009 1:00:32 PM",
//                               "Fri, 15 May 2009 20:10:57 GMT" };
//       DateTime dateValue;

//       Console.WriteLine("Attempting to parse strings using {0} culture.",
//                         CultureInfo.CurrentCulture.Name);
//       foreach (string dateString in dateStrings)
//       {
//          if (DateTime.TryParse(dateString, out dateValue))
//             Console.WriteLine("  Converted '{0}' to {1} ({2}).", dateString,
//                               dateValue, dateValue.Kind);
//          else
//             Console.WriteLine("  Unable to parse '{0}'.", dateString);
//       }
//    }
// }
// The example displays output like the following:
//    Attempting to parse strings using en-US culture.
//      Converted '05/01/2009 14:57:32.8' to 5/1/2009 2:57:32 PM (Unspecified).
//      Converted '2009-05-01 14:57:32.8' to 5/1/2009 2:57:32 PM (Unspecified).
//      Converted '2009-05-01T14:57:32.8375298-04:00' to 5/1/2009 11:57:32 AM (Local).
//
//      Converted '5/01/2008' to 5/1/2008 12:00:00 AM (Unspecified).
//      Converted '5/01/2008 14:57:32.80 -07:00' to 5/1/2008 2:57:32 PM (Local).
//      Converted '1 May 2008 2:57:32.8 PM' to 5/1/2008 2:57:32 PM (Unspecified).
//      Unable to parse '16-05-2009 1:00:32 PM'.
//      Converted 'Fri, 15 May 2009 20:10:57 GMT' to 5/15/2009 1:10:57 PM (Local).





























// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


// decimal valorMonetario = 1582.40M;

// System.Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3423;

// System.Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// System.Console.WriteLine(numero.ToString("##-##-##"));

































// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// System.Console.WriteLine(resultado);
































//Pessoa p1 = new Pessoa(nome: "Jacques", sobrenome: "Galdino" );

//Pessoa p2 = new Pessoa(nome: "Cleide", sobrenome: "Galdino" );


//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Ingles";
//cursoDeIngles.Alunos = new List<Pessoa>();

//cursoDeIngles.AdicionarAluno(p1);
//cursoDeIngles.AdicionarAluno(p2);
//cursoDeIngles.ListarAlunos();