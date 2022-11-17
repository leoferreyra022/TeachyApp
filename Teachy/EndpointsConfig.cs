using System.Runtime.CompilerServices;
using Teachy.DataAccess.Data;

namespace Teachy;

public static class EndpointsConfig
{
    public static void ConfigureUserEndpoints(this WebApplication app)
    {
        app.MapGet("/users", GetUsers);
        app.MapGet("/user/{id}", GetUsers);

    }

    private static async Task<IResult> GetUsers(IUserData userData)
    {
        try
        {
            return Results.Ok(await userData.GetUsers());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetUser(IUserData userData, int userId)
    {
        try
        {
            var result = await userData.GetUser(userId);
            return result is null ? Results.NotFound() : Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
