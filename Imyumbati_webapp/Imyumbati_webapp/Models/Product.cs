using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Imyumbati_webapp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ExpiredTime { get; set; }
        public int Quantity { get; set; }

    }
}