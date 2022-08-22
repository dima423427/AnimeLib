namespace AnimeLib.Domain.Entities
{
    public abstract class EntityBase
    {
        [Required]
        public Guid Id { get; set; } 
    }
}
