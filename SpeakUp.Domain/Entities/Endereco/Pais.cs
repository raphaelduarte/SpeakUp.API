namespace SpeakUp.Domain.Entities
{
    public class Pais : Entity
    {
        public Pais(string paisName)
        {
            PaisName = paisName;
        }
        private string PaisName { get; set; }
    }
}
