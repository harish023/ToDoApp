namespace Todo.Infrastructure.Entities
{
    public class User
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string Email { get; set; }

    }
}
