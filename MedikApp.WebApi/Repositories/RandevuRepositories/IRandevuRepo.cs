using Randevu_API.Dtos.RandevuDtos;
using System.Xml.Linq;

namespace Randevu_API.Repositories.RandevuRepositories
{
    public interface IRandevuRepo
    {
        Task<List<IllerDto>> Iller();
        Task<List<HastaneDto>> Hastaneler(string SehirAdi);
        Task<List<KliniklerDto>> Klinikler();
        Task<List<DoktorDto>> Doktorlar(int hastaneId, int bolumId);
        Task<bool> RandevuOluştur(RandevuOlusturDto randevuOlusturDto);
        Task<bool> RandevuTalebiOluştur(RandevuOlusturDto randevuOlusturDto);
        Task<List<RandevuyuGetirDto>> RandevularıGetirme(string TcNumara);
        Task<bool> RandevuIptalEt(int id);
    }
}
