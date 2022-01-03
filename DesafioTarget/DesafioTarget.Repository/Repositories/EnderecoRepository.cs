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
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly string _connectionString;

        public EnderecoRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public void Insert(Endereco obj)
        {
            var query = "INSERT INTO ENDERECO(LOGRADOURO, CEP, CIDADE, UF, COMPLEMENTO,PESSOA_ID" +
                "VALUES (@LOGRADOURO, @CEP, @CIDADE, @UF, @COMPLEMENTO ,@PESSOA_ID)";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, obj);

            }
        }
        public void Update(Endereco obj)
        {
            var query = "UPDATE ENDERECO SET LOGRADOURO = @LOGRADOURO, CEP =@CEP, UF = @UF, COMPLEMENTO =@COMPLEMENTO, PESSOA_ID =@ PESSOA=ID" +
                "WHERE ENDERECO_ID = @ENDERECO_ID";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, obj);

            }
        }

        public void Excluir(Endereco obj)
        {
            var query = "DELETE FROM PESSOA WHERE ENDERECO_ID =@ENDERECO_ID";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, obj);

            }
        }

        public List<Endereco> GetAll()
        {
            var query = "SELECT * FROM ENDERECO";
            using (var connection = new SqlConnection(_connectionString))
            {
                 return  connection.Query<Endereco>(query).ToList();

            }
        }

        public Endereco GetById(int id)
        {
            var query = "SELECT * FROM ENDERECO WHERE ENDERECO_ID = @ENDERECO_ID";
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Endereco>(query,new { EnderecoID = id})
                    .FirstOrDefault();

            }
        }
    }
}
