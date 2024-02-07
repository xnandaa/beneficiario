using beneficiario.domain.Commands;
using beneficiario.domain.Interfaces;


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

        public Task<object?> PostAsync(object beneficiarioCommand, BeneficiarioCommand command)
        {
            throw new NotImplementedException();
        }
    }

}     
            