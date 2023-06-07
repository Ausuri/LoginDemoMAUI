using LoginDemoMAUI.Shared;

namespace LoginDemoMAUI.DAL
{
    public interface IDataAccess
    {
        Task<string> LoginRequest(UserLogin user);
        Task<bool> IsUserAuthenticated();
    }
}