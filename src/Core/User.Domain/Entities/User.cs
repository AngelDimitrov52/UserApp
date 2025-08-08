using src.Core.Domain.Enums;

namespace src.Core.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        
        public string Password { get; set; }
        
        public string Email { get; set; }
        
        
        public UserType? Type { get; set; }
        
        public DateTime Created { get; set; }
        
        public DateTime? Updated { get; set; }
    }
}
