namespace Randevu_API.Dtos.PersonDtos
{
    public class ChangePasswordDto
    {
        public string TcNumara { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
