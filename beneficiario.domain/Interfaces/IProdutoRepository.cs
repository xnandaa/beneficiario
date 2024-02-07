using beneficiario.domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beneficiario.domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<string> PostAsync(ProdutoCommand command);
        void PostAsync();
        void GetAsync();


}   }
