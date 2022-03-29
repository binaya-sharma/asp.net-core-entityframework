using System.ComponentModel.DataAnnotations;

namespace ThePage.Models
{
    public class Shop
    {
        [Key]
        public int Shop_Id { get; set; }
        public string Shop_Name { get; set; }

        public int Shop_Price { get; set; }

       
    }
}
