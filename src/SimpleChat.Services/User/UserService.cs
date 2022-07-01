namespace SimpleChat.Services.User
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using SimpleChat.Services.Interfaces;
    using SimpleChat.Data.Repositories.Interfaces;
    using SimpleChat.Data.Entities.User;
    using SimpleChat.Models.User;

    public class UserService : IUserService
    {
        private readonly IMapper _mapper;

        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<List<UserModel>> GetAllUsersAsync()
        {
            try
            {
                var users = _mapper.Map<List<UserModel>>(
                    await _userRepository.GetAllAsync());

                return users;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<UserModel>>(ex);
            }
        }

        public async Task<bool> ConnectAsync(UserModel userModel)
        {
            try
            {
                var result = await _userRepository.AddAsync(
                    _mapper.Map<UserEntity>(userModel));

                return result;
            }
            catch (Exception ex)
            {
                return await Task.FromException<bool>(ex);
            }
        }

        public async Task<bool> DisconnectAsync(UserModel userModel)
        {
            try
            {
                var result = await _userRepository.RemoveAsync(
                    _mapper.Map<UserEntity>(userModel));

                return result;
            }
            catch (Exception ex)
            {
                return await Task.FromException<bool>(ex);
            }
        }
    }
}
