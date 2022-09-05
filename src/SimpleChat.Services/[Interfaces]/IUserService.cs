namespace SimpleChat.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using SimpleChat.Models.User;

    public interface IUserService
    {
        Task<List<UserModel>> GetAllUsersAsync();

        Task<UserModel> AddUserAsync(UserModel userModel);

        Task<UserModel> RemoveUserAsync(UserModel userModel);
    }
}
