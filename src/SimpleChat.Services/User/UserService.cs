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
                List<UserEntity> result = await _userRepository
                    .GetAllAsync();

                var users = _mapper.Map<List<UserModel>>(result);

                return users;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<UserModel>>(ex);
            }
        }

        public async Task<UserModel> AddUserAsync(UserModel userModel)
        {
            try
            {
                var userEntity = _mapper.Map<UserEntity>(userModel);

                UserEntity result = await _userRepository
                    .AddAsync(userEntity);

                var addedUser = _mapper.Map<UserModel>(result);

                return addedUser;
            }
            catch (Exception ex)
            {
                return await Task.FromException<UserModel>(ex);
            }
        }

        public async Task<UserModel> RemoveUserAsync(UserModel userModel)
        {
            try
            {
                var userEntity = _mapper.Map<UserEntity>(userModel);

                UserEntity result = await _userRepository
                    .RemoveAsync(userEntity);

                var removedTask = _mapper.Map<UserModel>(result);

                return removedTask;
            }
            catch (Exception ex)
            {
                return await Task.FromException<UserModel>(ex);
            }
        }
    }
}
