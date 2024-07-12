//aula 212

using SerializacaoXML;
using System.Xml.Serialization;

Console.WriteLine("Serialização XML\n");

Aluno aluno1 = new Aluno(101, "Maria", "maria@yahoo.com", 17);

string caminhoArquivo = @"c:\dados\Serializados\AlunoSerializado.xml";

XmlSerializer serializer = new XmlSerializer(typeof(Aluno));

using (StreamWriter writer = new StreamWriter(caminhoArquivo))
{
    serializer.Serialize(writer, aluno1);
}
Console.WriteLine("Objeto serializado para XML com sucesso!");
Console.ReadKey();