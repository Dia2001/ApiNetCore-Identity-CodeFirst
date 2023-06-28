using ApiNetCore_Identity_CodeFirst.Models;
using Microsoft.AspNetCore.Identity;

namespace ApiNetCore_Identity_CodeFirst.Repositories
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel model);
        public Task<string> SignInAsync(SignInModel model);
    }
}
