namespace Randevu_API.Dtos.RandevuDtos
{
    public class RandevuyuGetirDto
    {

        public int Id { get; set; }
        public string TcNumara { get; set; }
        public string Isim { get; set; }
        public string TelNo { get; set; }
        public string Tarih { get; set; }
        public string DoktorIsim { get; set; }
        public int BolumId { get; set; }
        public string hastane {  get; set; }
        public string il {  get; set; }
    }
}
