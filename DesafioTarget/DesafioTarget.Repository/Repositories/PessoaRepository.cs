using Dapper;
using DesafioTarget.Repository.Contracts;
using DesafioTarget.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DesafioTarget.Repository.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly string _connectionString;

        public PessoaRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public void Insert(Pessoa obj)
        {
            var query = "INSERT  INTO PESSOA(NOME_COMPLETO, CPF, DATA_NASCIMENTO," +
                "DATA_CADASTRO, RENDA_MENSAL)" +
                "VALUES (@NOME_COMPLETO, @CPF, @DATA_NASCIMENTO," +
                "@DATA_CADASTRO, @RENDA_MENSAL)";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, obj);
            }

        }

        public void Update(Pessoa obj)
        {
            var query = "UPDATE PESSOA SET NOME = @NOME, CPF = @CPF," +
                " DATA_NASCIMENTO = @DATA_NASCIMENTO, DATA_CADASTRO = @DATA_CADASTRO" +
                "RENDA_MENSAL = @RENDA_MENSAL WHERE PESSOA_ID = @PESSOA_ID";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Excluir(Pessoa obj)
        {
            var query = "DELETE FROM PESSOA WHERE PESSOA_ID = @PESSOA_ID";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public List<Pessoa> GetAll()
        {
            var query = "SELECT * FROM PESSOA";
            using (var connection = new SqlConnection(_connectionString))
            {
                 return connection.Query<Pessoa>(query).ToList();
            }
        }

        public Pessoa GetById(int id)
        {
            var query = "SELECT * FROM PESSOA WHERE PESSOA_ID = @PESSOA_ID";
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Pessoa>(query, new { PesssoaID = id })
                    .FirstOrDefault();
            }
        }
    }
}
