using GraphQL.MicrosoftDI;
using GraphQL.Model.Context;
using GraphQL.Model.Repository;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using Web.GraphQL.Model.GraphQl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MovieContext>(options =>
       options.UseSqlServer(
           connString
       ));

builder.Services.AddScoped<IMovieRepository, MovieRepository>();


// Add services to the container.
// add notes schema
builder.Services.AddScoped<ISchema, MovieSchema>(services => new MovieSchema(new SelfActivatingServiceProvider(services)));
// register graphQL
builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = true;
})
                .AddSystemTextJson();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // add altair UI to development only
    app.UseGraphQLAltair();

}

app.UseHttpsRedirection();

app.UseAuthorization();
 
app.MapControllers();
app.UseGraphQL<ISchema>();
app.Run();
