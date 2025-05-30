using Microsoft.VisualBasic;

namespace Randevu_API.Dtos.PersonDtos
{
    public class PersonRegisterDto
    {
        public string TcNumara { get; set; }
        public string Isim { get; set; }
        public string DogumTarihi { get; set; }
        public bool Cinsiyet {  get; set; }
        public string Sifre {  get; set; }
        public string TelefonNo { get; set; }
    }
}
