namespace TyperProject.Auth
{
    public static class AuthEndopointsExtension
    {
        public static void MapAuthEndpoints(this WebApplication app)
        {
            app.MapGet("/login", (string username, string password,
                ApplicationDbContext usersDbContext, ITokenService tokenService) =>
            {
                var user = usersDbContext.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user == null)
                {
                    return Results.Unauthorized();
                }

                string jwtToken = tokenService.GenerateToken(
                    app.Configuration["Authentication:Issuer"],
                    app.Configuration["Authentication:Audience"],
                    app.Configuration["Authentication:SecretKey"],
                    user);

                return Results.Ok(jwtToken);
            });

            app.MapPost("/register", async (string username, string password, ApplicationDbContext applicationDbContext) =>
            {
                var user = applicationDbContext.Users.FirstOrDefault(u => u.Username == username);
                if (user != null)
                {
                    return Results.Conflict();
                }

                user = new User
                {
                    Id = Guid.NewGuid(),
                    Username = username,
                    Password = password
                };
                await applicationDbContext.Users.AddAsync(user);
                await applicationDbContext.SaveChangesAsync();

                return Results.Created("/login", user);
            });
        }
    }
}
