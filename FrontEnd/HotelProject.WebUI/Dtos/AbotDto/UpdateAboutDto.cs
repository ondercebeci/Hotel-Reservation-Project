namespace HotelProject.WebUI.Dtos.AbotDto
{
    public class UpdateAboutDto
    {
        public int AboutID { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Content { get; set; }
        public int RoomCount { get; set; }
        public int staffCount { get; set; }
        public int CostumerCount { get; set; }
    }
}
