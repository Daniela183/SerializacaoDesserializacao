using System.Text.Json;
using System.Xml.Serialization;
using Exercicio;

Console.WriteLine("Exercício Serialização JSON/XML\n");

List<Aluno> alunos = new()
{
    new Aluno { Id=1, Nome="Maria", Email= "maria@email.com", Idade=16},
    new Aluno { Id=2, Nome="Carlos", Email= "carlos@email.com", Idade=17},
    new Aluno { Id=3, Nome="Silvia", Email= "silvia@email.com", Idade=15},
};
Console.WriteLine("Serialização JSON\n");

var options = new JsonSerializerOptions
{
    WriteIndented = true
};
string lista = JsonSerializer.Serialize(alunos, options);
Console.WriteLine(lista);
var caminhoArquivo = @"c:\dados\Serializados\listaAlunos.json";
using (FileStream stream = new FileStream(caminhoArquivo,
FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(stream, alunos);
}
Console.WriteLine("\nSerialização XML\n");

var caminhoArquivox = @"c:\dados\Serializados\listaAlunos.xml";
var listaSerializer = new XmlSerializer(typeof(List<Aluno>));
using (var writer = new StreamWriter(caminhoArquivox))
{
    listaSerializer.Serialize(writer, alunos);
}

Console.WriteLine("Serializações concluída!");
Console.ReadKey();
