namespace PropertyStop.Dtos.AppUserDtos
{
    public class GetAppUserByProductIDDto
    {
        public int UserID { get; set; }
        public string Name{ get; set; }
        public string Email{ get; set; }
        public string PhoneNumber{ get; set; }
        public string UserImageURL{ get; set; }
    }
}
