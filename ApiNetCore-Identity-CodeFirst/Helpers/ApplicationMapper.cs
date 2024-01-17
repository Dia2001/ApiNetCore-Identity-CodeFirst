using ApiNetCore_Identity_CodeFirst.Data;
using ApiNetCore_Identity_CodeFirst.Models;
using AutoMapper;

namespace ApiNetCore_Identity_CodeFirst.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            // ReverseMap: to map both ways
            CreateMap<Book, BookModel>()
                .ForMember(dest => dest.Author, otp => otp.MapFrom(src => src.AuthorE));

            CreateMap<AuthorE, Author>()
                .ForMember(dest => dest.name, otp => otp.MapFrom(src => src.nameE))
                .ForMember(dest => dest.email, otp => otp.MapFrom(src => src.emailE));
        }
    }
}
