﻿

namespace Sales.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public bool IsAvaible { get; set; }
        public DateTime PublishOn { get; set; }
    }
}
