using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Idade { get; set; }
        public Aluno(int id, string name, string email, int idade)
        {
            Id = id;
            Nome = name;
            Email = email;
            Idade = idade;
        }
        public Aluno() { }
    }
}
