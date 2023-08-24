namespace RPTS_sistema.Service.IService
{
    public interface IJwtService
    {
        string GetJwtToken(int userId, string role);
    }
}
