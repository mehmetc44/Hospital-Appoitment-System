using Microsoft.AspNetCore.Http;
using Randevu_API.Dtos.KisilerDtos;
using Randevu_API.Dtos.PersonDtos;

namespace Randevu_API.Repositories.PersonRepositories
{
    public interface IPersonRepo
    {
        Task<bool> PersonLogin(PersonLoginDto personLoginDto);
        Task<(string message, bool status)> PersonRegister(PersonRegisterDto personRegisterDto);
        Task<(string message, bool status)> UpdateInfoPerson(UpdateInfoPersonDto updateInfoPersonDto);
        Task<bool> ChangePassword(ChangePasswordDto changePasswordDto);
        Task<PersonInfoDto> GetPersonInfo(string TcNumara);
    }
}
