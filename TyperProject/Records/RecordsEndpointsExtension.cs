using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace TyperProject.Records
{
    public static class RecordsEndpointsExtension
    {
        public static void MapRecordsEndpoints(this WebApplication app)
        {
            app.MapGet("/records", async (HttpContext httpContext, ApplicationDbContext applicationDbContext) =>
            {
                var claimsIdentity = httpContext.User.Identity as ClaimsIdentity;
                Guid userId = new Guid(claimsIdentity.FindFirst("UserId").Value);
                var records = await applicationDbContext.Records.Where(record => record.UserId == userId).ToListAsync();
                return Results.Ok(records);
            }).RequireAuthorization();

            app.MapPost("/records", async ([FromBody] Record record, ApplicationDbContext applicationDbContext) =>
            {
                await applicationDbContext.Records.AddAsync(record);
                await applicationDbContext.SaveChangesAsync();
                return Results.Created($"records/{record.Id}", record);
            }).RequireAuthorization();
        }
    }
}
