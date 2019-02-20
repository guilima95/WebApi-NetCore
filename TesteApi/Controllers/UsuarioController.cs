using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MySql.Data.MySqlClient.Memcached;
using Newtonsoft.Json;
using Teste.Domain.Arguments.Usuario;
using Teste.Domain.Services;
using Teste.Infra.Transactions;
using TesteApi.Security;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteApi.Controllers
{
    public class UsuarioController : ControllerBase
    {
        private readonly IServiceUsuario _serviceUsuario;
        // GET: /<controller>/
        public UsuarioController(IUnitOfWork unitOfWork, IServiceUsuario serviceUsuario) : base(unitOfWork)
        {
            _serviceUsuario = serviceUsuario;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/v1/Usuario/Autenticar")]
        public object Autenticar([FromBody]AutenticarUsuarioRequest request, [FromServices]SigningConfigurations signingConfigurations, [FromServices]TokenConfigurations tokenConfigurations)
        {
            bool credenciaisValidas = false;
            AutenticarUsuarioResponse response = _serviceUsuario.AutenticarUsuario(request);

            credenciaisValidas = response != null;

            if (credenciaisValidas)
            {
                ClaimsIdentity identity = new ClaimsIdentity(new GenericIdentity(response.Id.ToString(), "Id"),
                    new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        //new Claim(JwtRegisteredClaimNames.UniqueName, response.Usuario)
                        new Claim("Usuario", JsonConvert.SerializeObject(response))
                    }
                );

                DateTime dataCriacao = DateTime.Now;
                DateTime dataExpiracao = dataCriacao + TimeSpan.FromSeconds(tokenConfigurations.Seconds);

                var handler = new JwtSecurityTokenHandler();
                var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                {
                    Issuer = tokenConfigurations.Issuer,
                    Audience = tokenConfigurations.Audience,
                    SigningCredentials = signingConfigurations.SigningCredentials,
                    Subject = identity,
                    NotBefore = dataCriacao,
                    Expires = dataExpiracao,

                });
                var token = handler.WriteToken(securityToken);

                return new
                {
                    authenticated = true,
                    //created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                    //expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                    accessToken = token,
                    message = "OK",
                    Email = response.email,
                    Password = response.email

                };
            }
            else
            {
                return new
                {
                    authenticated = false,
                    BadRequestObjectResult = BadRequest("Erro ao autenticar usuário.")

                };
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/v1/Usuario/Adicionar")]
        public async Task<IActionResult> Adicionar([FromBody]AdicionarUsuarioRequest request)
        {
            try
            {
                var response = _serviceUsuario.AdicionarUsuario(request);
                return await ResponseAsync(response);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }




    }
}
