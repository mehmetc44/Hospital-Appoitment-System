using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Randevu_API.Dtos.RandevuDtos;
using Randevu_API.Repositories.RandevuRepositories;

namespace Randevu_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandevuControllers : ControllerBase
    {
        public readonly IRandevuRepo _randevuRepo;

        public RandevuControllers(IRandevuRepo randevuRepo)
        {
            _randevuRepo = randevuRepo;
        }

        [HttpGet("/RandevuControllers/Iller")]
        public async Task<IActionResult> GetIller()
        {
            try
            {
                // Şehir verilerini al
                var result = await _randevuRepo.Iller();

                // Her bir IllerDto nesnesi üzerinde döngü yap ve bilgileri konsola yazdır
                foreach (var illerDto in result)
                {
                    Console.WriteLine($"ID: {illerDto.Id}, Name: {illerDto.SehirAd}");
                }

                // Şehir verilerini JSON formatında döndür
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Hata durumunda uygun bir yanıt döndür
                // Loglama yapabilir ve uygun hata mesajını döndürebilirsiniz
                // Burada basit bir hata yanıtı döndürülüyor
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

     [HttpGet("/RandevuControllers/Hastaneler")]
        public async Task<IActionResult> GetHastaneler(string SehirIsmi)
        {
            // Hastane verilerini al
            var result = await _randevuRepo.Hastaneler(SehirIsmi);

            // Her bir HastaneDto nesnesi üzerinde döngü yap ve bilgileri konsola yazdır
            foreach (var hastaneDto in result)
            {
                Console.WriteLine($"ID: {hastaneDto.Id}, Name: {hastaneDto.hastane}");
            }

            // Hastane verilerini JSON formatında döndür
            return Ok(result);
        }

        [HttpGet("/RandevuControllers/Klinikler")]
        public async Task<IActionResult> GetKlinikler()
        {
            var result = await _randevuRepo.Klinikler();
            return Ok(result);
        }
        [HttpGet("/RandevuControllers/Doktorlar")]
        public async Task<IActionResult> GetDoktorlar(int hastaneId, int bolumId)
        {
            var result = await _randevuRepo.Doktorlar( hastaneId,  bolumId);
            return Ok(result);
        }

        [HttpPost("/RandevuControllers/RandevuOluştur")]
        public async Task<IActionResult> CreateRandevu(RandevuOlusturDto randevuOlusturDto)
        {
            var result = await _randevuRepo.RandevuOluştur(randevuOlusturDto);
            return Ok(result);  
        }

        [HttpGet("/RandevuControllers/RandevularıGetir")]
        public async Task<IActionResult> GetRandevu(string TcNumara)
        {
            var result = await _randevuRepo.RandevularıGetirme(TcNumara);
            return Ok(result);
        }
        [HttpPost("/RandevuControllers/RandevuTalep")]
        public async Task<IActionResult> RandevuTalep(RandevuOlusturDto randevuOlusturDto)
        {
            var result = await _randevuRepo.RandevuTalebiOluştur(randevuOlusturDto);
            return Ok(result);
        }
        [HttpDelete("/RandevuControllers/RandevuIptal/{id}")]
        public async Task<IActionResult> RandevuIptal(int id)
        {
            var result = await _randevuRepo.RandevuIptalEt(id);
            return Ok(result);
        }
    }
}
