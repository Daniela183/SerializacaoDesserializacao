// aula 215
using DesserializacaoJSON;
using System.Text.Json;

Console.WriteLine("Desserialização JSON\n");

var caminhoArquivo = @"c:\dados\Serializados\AlunoSerializado.json";

// Lê todo o conteúdo do arquivo JSON
string jsonContent = File.ReadAllText(caminhoArquivo);
//Desserializa o arquivo json e retorna para
var aluno = JsonSerializer.Deserialize<Aluno>(jsonContent);

Console.WriteLine($"Aluno desserializado - ID: {aluno.Id}, Nome: {aluno.Name}, " +
                  $"Email: {aluno.Email}, Idade: {aluno.Idade}");

Console.ReadKey();