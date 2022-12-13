namespace P04_EF_Applying_To_API.Services.IService
{
    public interface IJwtService
    {
        string GetJwtToken(int userId, string role);
    }
}
