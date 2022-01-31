namespace DataStorage.EF.Entities
{
    public class ExpectedObject
    {
        public Guid Id { get; set; }
        public string ObjectId { get; set; }
        public long Size { get; set; }
        public string Repository { get; set; }
    }
}
