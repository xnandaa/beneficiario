﻿using beneficiario.domain.Commands;
using beneficiario.domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace beneficiario.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        [HttpPost]
        [Route("CadastrarProduto")]
        public async Task<IActionResult> PostAsync(ProdutoCommand command)
        {
            return Ok(await _produtoService.PostAsync(command));
        }



    }
}
