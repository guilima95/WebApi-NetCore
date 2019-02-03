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
    public class EmpresaController : ControllerBase
    {
        // GET: /<controller>/

        private readonly IServiceEmpresa _serviceEmpresa;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EmpresaController(IHttpContextAccessor httpContextAccessor, IUnitOfWork unityOfWork, IServiceEmpresa serviceEmpresa) : base(unityOfWork)
        {
            _httpContextAccessor = httpContextAccessor;
            _serviceEmpresa = serviceEmpresa;
        }

        [HttpGet]
        [Route("api/v1/Empresa/Listar")]
        public async Task<IActionResult> Listar()
        {
            try
            {
                //string usuario = _httpContextAccessor.HttpContext.User.FindFirst("Usuario").Value;
                //AutenticarUsuarioResponse usuarioResponse = JsonConvert.DeserializeObject<AutenticarUsuarioResponse>(usuario);

                var response = _serviceEmpresa.Listar();

                return await ResponseAsync(response, _serviceEmpresa);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);

            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/v1/Empresa/ListarPorNome")]
        public async Task<IActionResult> ListarPorNome(string name)
        {
            try
            {
                //Protected [Authotize]
                //string usuario = _httpContextAccessor.HttpContext.User.FindFirst("Usuario").Value;
                //AutenticarUsuarioResponse usuarioResponse = JsonConvert.DeserializeObject<AutenticarUsuarioResponse>(usuario);

                var response = _serviceEmpresa.ObterPorNome(name);

                return await ResponseAsync(response, _serviceEmpresa);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);

            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("api/v1/Empresa/ListarPorTipo")]
        public async Task<IActionResult> ListarPorTipo(int types)
        {
            try
            {
                //string usuario = _httpContextAccessor.HttpContext.User.FindFirst("Usuario").Value;
                //AutenticarUsuarioResponse usuarioResponse = JsonConvert.DeserializeObject<AutenticarUsuarioResponse>(usuario);

                var response = _serviceEmpresa.ListarPorTipo(types);

                return await ResponseAsync(response, _serviceEmpresa);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);

            }
        }
    }
}
