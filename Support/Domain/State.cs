namespace Support.Domain
{
    public class Country
    {
        public int cantidad { get; set; }
        public int inicio { get; set; }
        public Parametros parametros { get; set; }
        public Provincia[] provincias { get; set; }
        public int total { get; set; }
    }

    public class Parametros
    {
        public string nombre { get; set; }
    }

    public class Provincia
    {
        public Centroide centroide { get; set; }
        public string id { get; set; }
        public string nombre { get; set; }
    }

    public class Centroide
    {
        public float lat { get; set; }
        public float lon { get; set; }
    }

}
