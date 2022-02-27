using System.ComponentModel.DataAnnotations;

namespace BE_PRM_API_Postgres.Models
{
    public class User
    {
        [Key]
        [Required]
        public String uid { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public String joinedAt  { get; set; }
        public int phoneNumber { get; set; }
        public String userImageUrl { get; set; }
        public String password { get; set; }  

    }
}
