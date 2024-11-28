using back_end.Infrastructure.Data;
using Microsoft.AspNetCore.Authentication;
using back_end.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configura��o de CORS
builder.Services.AddCors(options =>
{
    // Op��o 1: Permitir todas as origens (para desenvolvimento)
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });

    // Op��o 2: Permitir URLs din�micas espec�ficas com base no padr�o (localhost:9000-9005)
    options.AddPolicy("AllowDynamicLocalhost",
        policy =>
        {
            policy.SetIsOriginAllowed(origin =>
                origin.StartsWith("http://localhost:") &&
                int.TryParse(origin.Split(':').Last(), out int port) &&
                port >= 9000 && port <= 9010
            )
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

// Add services to the container.
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });

// Configura��o do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "back-end", Version = "v1" });

    // Adicionando suporte para autentica��o b�sica
    c.AddSecurityDefinition("Basic", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Insira o nome do usu�rio e n�mero da cota cadastrada.",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Basic"
                }
            },
            new string[] {}
        }
    });
});

// Configura��o do DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Configurar autentica��o
builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Use a pol�tica de CORS escolhida
// Descomente uma das linhas abaixo de acordo com a necessidade:

// Para permitir todas as origens (apenas para desenvolvimento):
// app.UseCors("AllowAll");

// Para permitir apenas URLs din�micas espec�ficas (localhost:9000 a 9005):
app.UseCors("AllowDynamicLocalhost");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
