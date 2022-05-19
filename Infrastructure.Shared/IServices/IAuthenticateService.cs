using Infrastructure.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Shared.IServices
{
    public interface IAuthenticateService
    {
        Task<LoginResponseDto> CheckLoginAsync(LoginViewModel loginDto);
        Task<RegisterReponseDto> CheckRegister(RegisterViewModel registerDto);
    }
}
