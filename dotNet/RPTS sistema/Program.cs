using Microsoft.EntityFrameworkCore;
using RPTS_sistema.Controllers;
using RPTS_sistema.Database;
using RPTS_sistema.Repository.IRepository;
using RPTS_sistema.Repository;
using RPTS_sistema.Service.IService;
using RPTS_sistema.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<RptsContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("RptsConnectionString"));
});

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IPasswordService, PasswordService>();
builder.Services.AddScoped<IJwtService, JwtService>();
builder.Services.AddScoped<IUserAdapter, UserAdapter>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<ICompanyAdapter, CompanyAdapter>();
builder.Services.AddScoped<IInvestigationRepository, InvestigationRepository>();
builder.Services.AddScoped<IConclusionRepository, ConclusionRepository>();
builder.Services.AddScoped<IConclusionAdapter, ConclusionAdapter>();
builder.Services.AddScoped<IInvestigationAdapter, InvestigationAdapter>();
builder.Services.AddScoped<IAdministrativeInspectionRepository, AdministrativeInspectionRepository>();
builder.Services.AddScoped<IAdministrativeInspectionAdapter, AdministrativeInspectionAdapter>();
builder.Services.AddScoped<IComplainAdapter, ComplainAdapter>();
builder.Services.AddScoped<IComplainRepository, ComplainRepository>();
builder.Services.AddHttpContextAccessor();

var key = builder.Configuration.GetValue<string>("ApiSettings:Secret");

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
                .AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

builder.Services.AddSwaggerGen(option =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    option.IncludeXmlComments(xmlPath);

    // This is added to show JWT UI part in Swagger
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Description =
            "JWT Authorization header is using Bearer scheme. \r\n\r\n" +
            "Enter 'Bearer' and token separated by a space. \r\n\r\n" +
            "Example: \"Bearer d5f41g85d1f52a\"",
        Name = "Authorization", // Header key name
        In = ParameterLocation.Header,
        Scheme = "Bearer",
        BearerFormat = "JWT"
    });

    option.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme()
                        {
                            Reference = new OpenApiReference()
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header
                        },
                        new List<string>()
                    }
                });
});



builder.Services.AddControllers()
    .AddNewtonsoftJson()
    .AddJsonOptions(option => option.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();


app.Run();
