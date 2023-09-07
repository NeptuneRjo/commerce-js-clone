﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CommerceApi.DTO.DTOS
{
    public class ProductToAddDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Brand { get; set; }

        [JsonPropertyName("quantity")]
        public int StockQuantity { get; set; }

        [JsonPropertyName("in_stock")]
        public bool InStock { get; set; }

        public string Currency { get; set; }

    }
}
