using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Randevu_API.Dtos.KisilerDtos;
using Randevu_API.Dtos.PersonDtos;
using Randevu_API.Repositories.PersonRepositories;

namespace Randevu_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonControllers : ControllerBase
    {
        private readonly IPersonRepo _personRepo;

        public PersonControllers(IPersonRepo personRepo)
        {
            _personRepo = personRepo;
        }

        [HttpPost("Kullanici/Login")]
        public async Task<IActionResult> PersonLogin(PersonLoginDto personLoginDto)
        {
            var result = await _personRepo.PersonLogin(personLoginDto);

            return Ok(result);
        }

        [HttpPost("Kullanici/Register")]
        public async Task<IActionResult> PersonRegister(PersonRegisterDto personRegisterDto)
        {
            var result = await _personRepo.PersonRegister(personRegisterDto);
            Console.Write(result);
            return Ok(new{ result.message,result.status});
        }
        [HttpPut("Kullanici/BilgileriGuncelle")]
        public async Task<IActionResult> UpdatePerson(UpdateInfoPersonDto updateInfoPersonDto)
        {
            var result = await _personRepo.UpdateInfoPerson(updateInfoPersonDto);
            return Ok(new {result.message,result.status});
        }

        [HttpPut("Kullanici/SifreDegistir")]
        public async Task<IActionResult> ChangePassword(ChangePasswordDto changePasswordDto)
        {
            var result = await _personRepo.ChangePassword(changePasswordDto);
            return Ok(result);
        }
        [HttpGet("Kullanici/KullaniciBilgileri")]
        public async Task<IActionResult> PersonInfo(string TcNumara)
        {
            var result = await _personRepo.GetPersonInfo(TcNumara);
            return Ok(result);
        }
    }
}
