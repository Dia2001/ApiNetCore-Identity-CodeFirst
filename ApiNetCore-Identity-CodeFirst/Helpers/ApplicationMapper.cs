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
            CreateMap<Book, BookModel>().ReverseMap();
        }
    }
}
