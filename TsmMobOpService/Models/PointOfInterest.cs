namespace TsmMobOpService.Models
{
    public class PointOfInterest
    {
        public PointOfInterest(int id, string name, string description, int position)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Position = position;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Position { get; set; }
    }
}