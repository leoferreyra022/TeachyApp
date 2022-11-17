using GraphQL;
using Teachy;
using Teachy.DataAccess.Data;
using Teachy.DataAccess.DBAccess;
using Teachy.GraphQL;
using Teachy.GraphQL.Query;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer()
    .AddSwaggerGen()
    .AddSingleton<ISqlDataAccess, SqlDataAccess>()
    .AddSingleton<IUserData, UserData>()
    .AddScoped<TeachySchema>()
    .AddGraphQL(builder => builder
        .AddSystemTextJson()
        .AddErrorInfoProvider( options =>
        {
            options.ExposeExceptionDetails = true;
        })
        .AddGraphTypes(typeof(TeachyQuery).Assembly));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseGraphQL<TeachySchema>();
app.UseGraphQLPlayground();

app.ConfigureUserEndpoints();

app.Run();