namespace TyperProject.Auth
{
    public interface ITokenService
    {
        string GenerateToken(string issuer, string audience, string key, User user);
    }
}
