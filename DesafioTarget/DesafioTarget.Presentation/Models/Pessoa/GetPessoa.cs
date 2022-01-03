using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Presentation.Models.Pessoa
{
    public class GetPessoa
    {
        public int PessoaId { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string DataCadastro { get; set; }
        public float RendaMensal { get; set; }
    }
}
