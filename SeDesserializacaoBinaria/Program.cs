using System.Runtime.Serialization.Formatters.Binary;

namespace SeDesserializacaoBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serialização Desserialização Binária\n");
            Aluno aluno1 = new Aluno(101, "Maria", "maria@yahoo.com", 17);
            var caminhoArquivo = @"c:\dados\Serializados\AlunoSerializado.bin";

            using (FileStream stream = new FileStream(caminhoArquivo,
                                            FileMode.OpenOrCreate,
                                            FileAccess.ReadWrite))
            {
                //serialização
#pragma warning disable SYSLIB0011
                var bf = new BinaryFormatter();
                bf.Serialize(stream, aluno1);
                Console.WriteLine("Serialização concluída");

                //desserialização
#pragma warning disable SYSLIB0011
                Console.WriteLine("\nTecle enter para realizar a Desserialização");
                Console.ReadKey();
                stream.Seek(0, SeekOrigin.Begin);
                var alunoDesserializado = (Aluno)bf.Deserialize(stream);
                Console.WriteLine(alunoDesserializado.Name);
            }

             Console.WriteLine("\nSerialização binária concluída");
            Console.ReadKey();
        }
    }
}
 