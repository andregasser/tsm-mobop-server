namespace TsmMobOpService.Models
{
    public class MotorwayRamp
    {
        public MotorwayRamp(int id, string name, string motorway, float longitude, float latitude)
        {
            this.Id = id;
            this.Name = name;
            this.Motorway = motorway;
            this.Longitude = longitude;
            this.Latitude = latitude;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Motorway { get; set; }

        public float Longitude { get; set; }

        public float Latitude { get; set; }
    }
}