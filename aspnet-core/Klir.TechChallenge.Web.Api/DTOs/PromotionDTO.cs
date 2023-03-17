namespace Klir.TechChallenge.Web.Api.DTOs
{
    public class PromotionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PromotionDTO()
        {

        }

        public PromotionDTO(string name)
        {
            Name = name;
        }
    }
}
