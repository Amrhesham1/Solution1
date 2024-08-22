
using AutoMapper;
using OFlow_Api.Data;
using OFlow_Api.Models.Author;
using OFlow_Api.Models.Users;
using OFlow_Api.Data;
using OFlow_Api.Models.Author;
using OFlow_Api.Models.Users;

namespace OFlow_Api.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
          //  CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();
           // CreateMap<AuthorDetailsDto, Author>().ReverseMap();
            CreateMap<AuthorCreateDtocs, Author>().ReverseMap();
            //CreateMap<AuthorUpdateDto, Author>().ReverseMap();

            
           

            CreateMap<ApiUser, UserDto>().ReverseMap();
        }
    }
}