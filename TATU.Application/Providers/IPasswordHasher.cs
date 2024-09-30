namespace TATU.Application.Providers
{
    public interface IPasswordHasher
    {
        string Generate(string password);
        bool Verefy(string password, string heshedPassword);
    }
}
