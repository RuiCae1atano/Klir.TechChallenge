namespace Klir.TechChallenge.Application.DTOs
{
    public class PromotionDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public PromotionDTO(string name)
        {
            Name = name;
        }
    }
}
