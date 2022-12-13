namespace ApiMokymai.Services.IServices
{
    public interface IJwtService
    {
        string GetJwtToken(int userId, string role);

    }
}