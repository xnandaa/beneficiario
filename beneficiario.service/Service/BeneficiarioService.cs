using beneficiario.domain.Commands;
using beneficiario.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static beneficiario.service.Service.BeneficiarioService;

namespace beneficiario.service.Service
{
    public class BeneficiarioService : IBeneficiarioService
    {
        private readonly IBeneficiarioRepository _repository;
        public BeneficiarioService(IBeneficiarioRepository beneficiarioRepository)
        {
            _repository = beneficiarioRepository;
        }

        public Task GetAsync(BeneficiarioCommand command)
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(BeneficiarioCommand command)
        {
            return await _repository.PostAsync(command);
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }

    }

}     
            