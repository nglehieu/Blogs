using Core.Applications.Exceptions;
using Infrastructure.Persistence.Context;
using Infrastructure.Shared.IServices;
using Infrastructure.Shared.ViewModel;
using System.Threading.Tasks;

namespace Core.Applications.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        public readonly ApplicationDbContext _dbContext;

        public AuthenticateService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<LoginResponseDto> CheckLoginAsync(LoginViewModel loginDto)
        {
            throw new System.NotImplementedException();
        }

        public Task<RegisterReponseDto> CheckRegister(RegisterViewModel registerDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
