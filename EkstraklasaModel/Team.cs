namespace EkstraklasaModel
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public List<Player> Players { get; } = new();

        //public Team(string name, string city)
        //{
        //    this.Name = name;
        //    this.City = city;
        //}
    }
}