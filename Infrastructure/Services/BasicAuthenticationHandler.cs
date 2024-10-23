using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text;
using back_end.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;

namespace back_end.Infrastructure.Services
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly AppDbContext _context;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            AppDbContext context)
            : base(options, logger, encoder)
        {
            _context = context;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            // Obtém as credenciais do cabeçalho de autorização
            var authHeader = Request.Headers["Authorization"].ToString();

            if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Basic "))
            {
                return AuthenticateResult.Fail("Credenciais inválidas.");
            }

            var credentials = Encoding.UTF8.GetString(Convert.FromBase64String(authHeader.Substring("Basic ".Length))).Split(':', 2);

            var username = credentials[0];
            var numeroCotaInformado = credentials[1];

            // Verifica se o cadastro existe
            var validCadastro = await _context.Cadastros
                .FirstOrDefaultAsync(c => c.NomeUsuario == username && c.NumeroCota.ToString() == numeroCotaInformado);

            // Se o cadastro não existir, falha na autenticação
            if (validCadastro == null)
            {
                if (Request.Method == "GET" && Request.Path.StartsWithSegments("/api/Cadastro"))
                {
                    Response.OnStarting(() =>
                    {
                        Response.StatusCode = StatusCodes.Status401Unauthorized;
                        Response.ContentType = "application/json";
                        return Response.WriteAsync("{\"error\":\"Esse usuário não possui cadastro nessa cota.\"}");
                    });
                }

                return AuthenticateResult.Fail("Esse usuário não possui cadastro nessa cota.");
            }

            // Cria os claims para o usuário autenticado
            var claims = new[] { new Claim(ClaimTypes.Name, username) };
            var identity = new ClaimsIdentity(claims, nameof(BasicAuthenticationHandler));
            var ticket = new AuthenticationTicket(new ClaimsPrincipal(identity), this.Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}
