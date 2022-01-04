using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioTarget.Repository.Entities
{
    public class Pessoa
    {
        public int Pessoa_Id { get; set; }
        public string Nome_Completo { get; set; }
        public string Cpf { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public float Renda_Mensal { get; set; }

        #region Relacionamentos
        public List<Endereco> Enderecos  { get; set; }
        public PlanoVip PlanoVip { get; set; }
        #endregion

    }
}
