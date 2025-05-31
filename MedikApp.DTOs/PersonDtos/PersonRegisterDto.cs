using Microsoft.VisualBasic;

namespace MedikApp.DTO.PersonDtos
{
    public class PersonRegisterDto
    {
        public string TcNumara { get; set; }
        public string Isim { get; set; }
        public string DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }
        public string Sifre { get; set; }
        public string TelefonNo { get; set; }
    }
}
