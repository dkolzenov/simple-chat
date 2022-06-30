namespace SimpleChat.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using SimpleChat.Models.User;

    public interface IUserService
    {
        Task<List<UserModel>> GetAllUsers();

        Task<bool> Connect(UserModel userModel);

        Task<bool> Disconnect(UserModel userModel);
    }
}
