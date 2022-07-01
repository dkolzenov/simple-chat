namespace SimpleChat.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using SimpleChat.Models.User;

    public interface IUserService
    {
        Task<List<UserModel>> GetAllUsersAsync();

        Task<bool> ConnectAsync(UserModel userModel);

        Task<bool> DisconnectAsync(UserModel userModel);
    }
}
