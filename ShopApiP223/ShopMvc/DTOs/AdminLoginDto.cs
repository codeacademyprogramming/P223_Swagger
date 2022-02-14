using System.ComponentModel.DataAnnotations;

namespace ShopMvc.DTOs
{
    public class AdminLoginDto
    {
        [StringLength(maximumLength: 20,MinimumLength =4)]
        public string UserName { get; set;}
        [StringLength(maximumLength: 20, MinimumLength = 8)]
        public string Password { get; set;}
    }
}
