using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Requests
{
    public class RequestPetRegisterJson
    {
        public string Name { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        public PetType Type { get; set; }
    }
}
