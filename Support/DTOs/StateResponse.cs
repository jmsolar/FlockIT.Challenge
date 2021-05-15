namespace Support.DTOs
{
    public class StateResponse
    {
        public float lat { get; set; }
        public float lon { get; set; }

        public StateResponse() { }

        public StateResponse(float latitud, float longitud) {
            lat = latitud;
            lon = longitud;
        }
    }
}
