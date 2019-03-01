using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Teste.Domain.Arguments.Usuario;
using Teste.Domain.Services;
using Teste.Infra.Transactions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteApi.Controllers
{
    public class CategoriaController : ControllerBase
    {
        // GET: /<controller>/

        private readonly IServiceCategoria _serviceCategoria;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CategoriaController(IHttpContextAccessor httpContextAccessor, IUnitOfWork unityOfWork, IServiceCategoria serviceCategoria) : base(unityOfWork)
        {
            _httpContextAccessor = httpContextAccessor;
            _serviceCategoria = serviceCategoria;
        }

        [HttpGet]
        [Route("api/v1/Categoria/Listar")]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var response = _serviceCategoria.Listar();

                return await ResponseAsync(response);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);

            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/v1/Categoria/ListarPorNome")]
        public async Task<IActionResult> ListarPorNome(string name)
        {
            try
            {
                //Protected [Authotize]
                //string usuario = _httpContextAccessor.HttpContext.User.FindFirst("Usuario").Value;
                //AutenticarUsuarioResponse usuarioResponse = JsonConvert.DeserializeObject<AutenticarUsuarioResponse>(usuario);

                var response = _serviceCategoria.ObterPorDescricao(name);

                return await ResponseAsync(response);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);

            }
        }
        //[AllowAnonymous]
        //[HttpGet]
        //[Route("api/v1/Categoria/ListarPorTipo")]
        //public async Task<IActionResult> ListarPorTipo(int types)
        //{
        //    try
        //    {
        //        //string usuario = _httpContextAccessor.HttpContext.User.FindFirst("Usuario").Value;
        //        //AutenticarUsuarioResponse usuarioResponse = JsonConvert.DeserializeObject<AutenticarUsuarioResponse>(usuario);

        //        var response = _serviceCategoria.ListarPorTipo(types);

        //        return await ResponseAsync(response);
        //    }
        //    catch (Exception ex)
        //    {
        //        return await ResponseExceptionAsync(ex);

        //    }
        //}
    }
}
