namespace DotNetFmsProj.Model
{
    public class Day
    {
        public int DayId { get; set; }
        public string? PersonName { get; set; }
        public long DayTypeId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Birthdate { get; set; }
        public long RelationId { get; set; } 
        public string? MobileNumber { get; set; }
        public string? ContactNumber { get; set; }
        public string? EmailId { get; set; }
        public string? Address { get; set; }
        public long? AssetId { get; set; }

        //public File Image { get; set }
        //public IFormFile? Image { get; set; }

    }
}
