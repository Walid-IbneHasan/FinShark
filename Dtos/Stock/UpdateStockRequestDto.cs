using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MinLength(1, ErrorMessage = "Symbol must be at least 1 characters long")]
        [MaxLength(10, ErrorMessage = "Symbol must be at most 10 characters long")]
        public string Symbol { get; set; }=string.Empty;
        [Required]
        [MinLength(1, ErrorMessage = "Company Name must be at least 1 characters long")]
        [MaxLength(10, ErrorMessage = "Company Name must be at most 10 characters long")]
        public string CompanyName { get; set; }=string.Empty;
        [Required]
        [Range(1,1000000000)]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001,100)]    
        public decimal LastDiv { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "Industry Name must be at least 1 characters long")]
        [MaxLength(10, ErrorMessage = "Industry Name must be at most 10 characters long")]
        public string Industry { get; set; }=string.Empty;
        [Range(1,5000000000)]
        public long MarketCap { get; set; }
    }
}