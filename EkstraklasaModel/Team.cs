namespace EkstraklasaModel
{
    public class Team
    {
        public string Name { get; private set; }
        public string City { get; private set; }

        public Team(string name, string city)
        {
            this.Name = name;
            this.City = city;
        }
    }
}