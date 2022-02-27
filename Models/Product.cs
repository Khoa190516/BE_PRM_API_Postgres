using System.ComponentModel.DataAnnotations;

namespace BE_PRM_API_Postgres.Models
{
    public class Product
    {
        [Key]
        [Required]
        public String id { get; set; }
        public String title { get; set; }
        public String description { get; set; }
        public float price { get; set; }
        public String imageUrl  { get; set; }
        public String productCategoryName { get; set; }
        public String brand { get; set; }
        public int quantity { get; set; }
        public Boolean isFavorite { get; set; }
        public Boolean isPopular { get; set; }

    }
}
