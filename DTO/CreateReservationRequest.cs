namespace Api.DTO
{
    public class CreateReservationRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Treatment { get; set; }
        public string Design { get; set; }
        public DateTime DateTime { get; set; }
        public string Comment { get; set; }
    }
}
