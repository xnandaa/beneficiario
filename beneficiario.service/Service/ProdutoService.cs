using beneficiario.domain.Commands;
using beneficiario.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beneficiario.service.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _repository = produtoRepository;
        }

        public Task GetAsync(ProdutoCommand command)
        {
            throw new NotImplementedException();
        }

        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(ProdutoCommand command)
        {
            return await _repository.PostAsync(command);
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }





}
