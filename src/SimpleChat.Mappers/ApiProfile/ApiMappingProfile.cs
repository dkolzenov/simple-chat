namespace SimpleChat.Mappers.ApiProfile
{
    using AutoMapper;

    using SimpleChat.Data.Entities.Message;
    using SimpleChat.Data.Entities.User;
    using SimpleChat.Models.Message;
    using SimpleChat.Models.User;

    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            #region Entities to Models

            CreateMap<MessageEntity, MessageModel>();
            CreateMap<UserEntity, UserModel>();

            #endregion

            #region Models to Entities

            CreateMap<MessageModel, MessageEntity>();
            CreateMap<UserModel, UserEntity>();

            #endregion
        }
    }
}
