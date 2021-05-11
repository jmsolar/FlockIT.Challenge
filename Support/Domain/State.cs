namespace Support.Domain
{
    public class Centroide { 
        public string latitude { get; set; }

        public string length { get; set; }
    }

    public class State : BaseEntity
    {
        public string name { get; set; }

        public Centroide centroide { get; set; }
    }
}
