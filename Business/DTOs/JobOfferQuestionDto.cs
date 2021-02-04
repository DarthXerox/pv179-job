using Newtonsoft.Json;

namespace Business.DTOs
{
    public class JobOfferQuestionDto : BaseDto
    {
        public string? Text { get; set; }

        public int? JobOfferId { get; set; }

        //[JsonIgnore]
        public virtual JobOfferDto? JobOffer { get; set; }
    }
}
