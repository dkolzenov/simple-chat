namespace SimpleChat.Mappers.ApiProfile
{
    using AutoMapper;

    using SimpleChat.Data.Entities.Message;
    using SimpleChat.Data.Entities.User;
    using SimpleChat.Data.Entities.Correspondence;
    using SimpleChat.Models.Message;
    using SimpleChat.Models.User;
    using SimpleChat.Models.Correspondence;

    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            #region Entities to Models

            CreateMap<MessageEntity, MessageModel>();
            CreateMap<UserEntity, UserModel>();
            CreateMap<CorrespondenceEntity, CorrespondenceModel>();

            #endregion

            #region Models to Entities

            CreateMap<MessageModel, MessageEntity>();
            CreateMap<UserModel, UserEntity>();
            CreateMap<CorrespondenceModel, CorrespondenceEntity>();

            #endregion
        }
    }
}
