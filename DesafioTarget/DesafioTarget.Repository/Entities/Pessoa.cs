using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioTarget.Repository.Entities
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string DataCadastro { get; set; }
        public float RendaMensal { get; set; }

        #region Relacionamentos
        public List<Endereco> Enderecos  { get; set; }
        public PlanoVip PlanoVip { get; set; }
        #endregion

    }
}
