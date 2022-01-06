using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Presentation.Models.Pessoa
{
    public class GetPessoaModel
    {
        public int PessoaId { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public float RendaMensal { get; set; }
    }
}
