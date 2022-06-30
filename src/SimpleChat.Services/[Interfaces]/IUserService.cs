namespace SimpleChat.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using SimpleChat.Models.User;

    public interface IUserService
    {
        Task<List<UserModel>> GetAllUsers();

        void Connect(UserModel userModel);

        void Disconnect(UserModel userModel);
    }
}
