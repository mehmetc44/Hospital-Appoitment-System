using MedikApp.DTO.PersonDtos;
using Microsoft.AspNetCore.Http;

namespace MedikApp.WebApi.Repositories.PersonRepositories
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
