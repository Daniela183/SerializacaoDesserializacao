//aula 213
using DesserializacaoXML;
using System.Xml.Serialization;

Console.WriteLine("Desserialização XML\n");
string caminhoArquivo = @"c:\dados\Serializados\AlunoSerializado.xml";

XmlSerializer serializer = new XmlSerializer(typeof(Aluno));

using (StreamReader reader = new StreamReader(caminhoArquivo))
{
    var aluno = (Aluno)serializer.Deserialize(reader);

    Console.WriteLine($"Aluno XML desserializado - Id: {aluno.Id}, Nome: {aluno.Name}, " +
                      $"Email: {aluno.Email}, Idade: {aluno.Idade}");
}

Console.ReadKey();