using ASPLesson.Domain.Enum;

namespace ASPLesson.Domain.Entity
{
    public class User
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }

        public string Password { get; set; }
        
        public Role Role { get; set; }
        
        public bool IsActive { get; set; }
        
        public decimal Balance { get; set; }
    }
}
