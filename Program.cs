using System.Runtime.Serialization;
using exemplo_explorer.Models;
using System.Globalization;
using System.Data.Common;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;


//Deserialização
string conteudoArquivo = File.ReadAllText("Arquivos/venda.json");
List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo)!;

foreach (Venda venda in listaVendas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}



//Serialização
// DateTime dataAtual = DateTime.Now;
// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Notebook", 4500M, dataAtual);
// Venda v2 = new Venda(2, "Mouse", 150M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/venda.json", serializado);
// Console.WriteLine(serializado);



// int numero = 20;
// bool ehPar = false;

// //if ternario
// ehPar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é {(ehPar ? "par" : "ímpar")}");

// //if simples
// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} não é par");
// }




// //Desconstructor
// Pessoa p1 = new Pessoa(nome: "Cleber", sobrenome: "Santos");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");


// //Tupla com método e descarte
// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
//     foreach (var linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }




// //Tupla
// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Cleber", "Santos", 1.69M);
// ValueTuple<int, string, string, decimal> outroExeploTupla = (2, "Ana", "Silva", 1.65M);
// var terceiroExemploTupla = Tuple.Create(3, "Maria", "Oliveira", 1.70M);

// Console.WriteLine($"ID: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");

// //Dictionary
// Dictionary<string, string> estados = new Dictionary<string, string>();


// estados.Add("PE", "Pernambuco");
// estados.Add("SP", "São Paulo");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["PE"]);

// foreach (var intem in estados)
// {
//     Console.WriteLine($"Chave: {intem.Key}, Valor: {intem.Value}");
// }
// Console.WriteLine("------------------");

// estados.Remove("MG");
// estados["SP"] = "São Paulo - Atualizado";
// foreach (var intem in estados)
// {
//     Console.WriteLine($"Chave: {intem.Key}, Valor: {intem.Value}");
// }

// Console.WriteLine("------------------");

// string chave = "PE1";
// Console.WriteLine($"Verificando a chave {chave}");
// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {estados[chave]}");
// }
// else
// {
//     Console.WriteLine($"Chave {chave} não existe no dicionário");
// }




// //------------------------------------------



// //Pilha
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo da pilha: {pilha.Pop()}");

// pilha.Push(12);
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo da pilha: {pilha.Pop()}");








// //Fila
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);
// Console.WriteLine($"Adicionando elemento: 10");

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");




// //Exceções
// new ExemploExcecao().Metodo1();




// //Leitura de arquivo com tratamento de exceções
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
//     Console.WriteLine($"Ocorreu uma exceção do tipo FileNotFoundException. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção do tipo DirectoryNotFoundException. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou ao fim do programa");
// }






// // Conversão de data com tratamento de exceção
// string dataString = "2022-00-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (!sucesso)
// {
//     Console.WriteLine("Não foi possível converter a data");
//     return;
// }
// else
// {
//     Console.WriteLine($"Conversão realizada com sucesso. Data: {data}");
// }

// Console.WriteLine(data);










// // Formatação de números
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 82029.40M;

// Console.WriteLine($"{valorMonetario.ToString("C2")}");

// double porcentagem = .3421;

// Console.WriteLine($"{porcentagem.ToString("P2")}");


// int numero = 123456789;
// Console.WriteLine($"{numero.ToString("##-##-##-##-##")}");

// //Classes e objetos
// Pessoa p1 = new Pessoa(nome:"Cleber", sobrenome:"Santos");
// Pessoa p2 = new Pessoa(nome:"Ana", sobrenome:"Silva");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();
