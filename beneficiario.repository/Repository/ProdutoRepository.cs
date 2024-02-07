using beneficiario.domain.Commands;
using beneficiario.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beneficiario.repository.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Beneficiario;Trusted_Connection=True;MultipleActiveResultSets=true";

        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(ProdutoCommand command)
        {
            string queryInsert = @"
            INSERT INTO Produto(IdProduto, NomeProduto, Descricao, Categoria, DisponibilidadeAdocao)
            VALUES(@IdProduto,@NomeProduto , @Descricao, @Categoria, @DisponibilidadeAdocao)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {
                    IdProduto = command.IdProduto,
                    NomeProduto = command.NomeProduto,
                    Descricao = command.Descricao,
                    Categoria = command.Categoria,
                    DisponibilidadeAdocao = command.DisponibilidadeAdocao
                });

                return "Produto Cadastrato com Sucesso";
            }
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }

    }




}
