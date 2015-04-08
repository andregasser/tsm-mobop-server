namespace TsmMobOpService.Models
{
    public class NuclearPowerPlant
    {
        public NuclearPowerPlant(int id, string name, string description, float latitude, float longitude)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float Longitude { get; set; }

        public float Latitude { get; set; }
    }
}