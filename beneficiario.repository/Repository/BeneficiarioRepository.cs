using beneficiario.domain.Commands;
using beneficiario.domain.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beneficiario.repository.Repository
{
    public class BeneficiarioRepository : IBeneficiarioRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Beneficiario;Trusted_Connection=True;MultipleActiveResultSets=true";

        public Task GetAsync(BeneficiarioCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<string> PostAsyn(BeneficiarioCommand command)
        {
            string queryInsertDoador = @"
            INSERT INTO BENEFICIARIO(BeneficiarioId, Nome, Cidade, Estado,Cep,Email,Telefone)
            VALUES(@BeneficiarioId, @Nome, @Cidade, @Estado, @Cep,@Email,@Telefone)
            ";

            using (SqlConnection con = new SqlConnection(conexao))
            {
                con.Execute(queryInsertDoador, new
                {
                    BeneficiarioId = command.BeneficiarioId,
                    Nome = command.Nome,
                    Cidade = command.Cidade,
                    Estado = command.Estado,
                    Cep = command.Cep,
                    Email = command.Email,
                    Telefone = command.Telefone
                });

                return Task.FromResult("Cadastro realizado com sucesso");
            }


        }

        public Task<string> PostAsync(BeneficiarioCommand command)
        {
            throw new NotImplementedException();
        }
    }
