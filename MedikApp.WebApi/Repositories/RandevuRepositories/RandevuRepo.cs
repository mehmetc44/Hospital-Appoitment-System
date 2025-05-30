using Dapper;
using Randevu_API.Dtos.RandevuDtos;
using Randevu_API.Model.DbContext;
using System.Collections.Generic;  // IEnumerable<T> için gerekli

namespace Randevu_API.Repositories.RandevuRepositories
{
    public class RandevuRepo : IRandevuRepo
    {
        private readonly Context _context;

        public RandevuRepo(Context context)
        {
            _context = context;
        }

        public async Task<List<HastaneDto>> Hastaneler(string SehirAdi)
        {
            var getHastanelerQuery = "SELECT * FROM hastane WHERE il = @il";
            var parameters = new DynamicParameters();
            parameters.Add("@il", SehirAdi);

            using (var connection = _context.CreateConnection())
            {
                // QueryAsync ile sonuçları HastaneDto tipinde al
                var result = await connection.QueryAsync<HastaneDto>(getHastanelerQuery, parameters);
                // Sonuçları bir listeye dönüştür
                return result.ToList();
            }
        }

        public async Task<List<DoktorDto>> Doktorlar(int hastaneId, int bolumId)
        {
            var getDoktorlarQuery = "SELECT Id, DoktorIsim FROM doktor WHERE HastaneId = @hastaneId AND BolumId = @bolumId";
            var parameters = new DynamicParameters();
            parameters.Add("@hastaneId", hastaneId);
            parameters.Add("@bolumId", bolumId);

            using (var connection = _context.CreateConnection())
            {
                // Asenkron olarak sorguyu çalıştır ve sonuçları DoktorDto tipinde al
                var result = await connection.QueryAsync<DoktorDto>(getDoktorlarQuery, parameters);

                // Sonuçları liste olarak döndür
                return result.ToList();
            }
        }

        public async Task<List<IllerDto>> Iller()
        {
            var getIllerQuery = "SELECT Id, SehirAd FROM sehirler";

            using (var connection = _context.CreateConnection())
            {
                // Sorguyu çalıştır ve (int, string) tuple'larını al
                var result = await connection.QueryAsync<IllerDto>(getIllerQuery);

                // Tuple'lardan IllerDto nesnelerine dönüştür ve liste olarak döndür
                return result.ToList();
            }
        }
      
        async Task<List<KliniklerDto>> IRandevuRepo.Klinikler()
        {
            var getKliniklerQuery = "SELECT Id,KlinikAdi FROM klinik";

            using (var connection = _context.CreateConnection())
            {
                // `QueryAsync<string>` kullanarak şehir isimlerini içeren bir koleksiyon döndür
                var result = await connection.QueryAsync<KliniklerDto>(getKliniklerQuery);

                // Sonuçları `string[]` türüne dönüştür
                return result.ToList();
            }
        }

        
        public async Task<bool> RandevuIptalEt(int id)
        {
            var query = "DELETE FROM randevu WHERE Id = @id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            try
            {
                using (var connection = _context.CreateConnection())
                {
                    var affectedRows = await connection.ExecuteAsync(query, parameters);
                  
                    if(affectedRows > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public async Task<List<RandevuyuGetirDto>> RandevularıGetirme(string TcNumara)
        {
            var query = "SELECT randevu.Id , tcNumara , isim , telNo , tarih , doktorIsim, BolumId, hastane.hastane, hastane.il FROM kisiler " +
                "INNER JOIN randevu ON kisiler.TcNumara = randevu.KullaniciId INNER JOIN doktor ON doktor.Id = randevu.DoktorId INNER JOIN hastane ON hastane.Id = doktor.HastaneId" +
                " WHERE TcNumara = @id ;";
            var parameters = new DynamicParameters();
            parameters.Add("@id", TcNumara);

            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<RandevuyuGetirDto>(query, parameters);
           
                return result.ToList();
            }
        }


        public async Task<bool> RandevuOluştur(RandevuOlusturDto randevuOlusturDto)
        {
            var RandevuQuery = "INSERT INTO randevu (KullaniciID, DoktorID, Tarih) VALUES (@kID, @dID, @Tarih)";
            var parameters = new DynamicParameters();
            parameters.Add("@kID", randevuOlusturDto.TcNumarası);
            parameters.Add("@dID", randevuOlusturDto.DoktorId);
            parameters.Add("@Tarih", randevuOlusturDto.Tarih);

            try
            {
                using (var connection = _context.CreateConnection())
                {
                    var rowsAffected = await connection.ExecuteAsync(RandevuQuery, parameters);
                    return rowsAffected > 0; 
                }
            }
            catch (Exception ex)
            {
                return false; 
            }
        }

        public async Task<bool> RandevuTalebiOluştur(RandevuOlusturDto randevuOlusturDto)
        {
            var query = "INSERT INTO talep (KullaniciId,DoktorId,TalepTarihi) Values(@KullaniciId,@DoktorId,@Tarih)";
            var parameters = new DynamicParameters();
            parameters.Add("@KullaniciId", randevuOlusturDto.TcNumarası);
            parameters.Add("@DoktorId", randevuOlusturDto.DoktorId);
            parameters.Add("@Tarih", randevuOlusturDto.Tarih);

            using (var connection = _context.CreateConnection())
            {
                var result = await connection.ExecuteAsync(query, parameters);
                if(result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        
    }
}
