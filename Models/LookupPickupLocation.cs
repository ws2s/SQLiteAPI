namespace SQLiteAPI.Models
{
    public class LookupPickupLocation
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Building { get; set; }
        public string RoomFloor { get; set; }
        public string StreetAddress { get; set; }
        public string CityZip { get; set; }
    }
}
