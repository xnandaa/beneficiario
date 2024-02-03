using beneficiario.domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beneficiario.domain.Interfaces
{
    public interface IBeneficiarioService
    {
        Task<string> PostAsync(BeneficiarioCommand command);
        Task GetAsync(BeneficiarioCommand command);
    }
}
