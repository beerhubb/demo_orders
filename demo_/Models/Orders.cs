using Microsoft.AspNetCore.Mvc.Rendering;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace demo_.Models
{
    public class Orders
    {

        [BsonId]
        [Display(Name = "Order ID")]
        public string Orders_ID { get; set; }

        [Required]
        [EnumDataType(typeof(Customers))]
        [Display(Name = "Customer")]
        public string Customers { get; set; }

        [Required]
        [Display(Name = "Order Date")]
        public DateTime Orderdate { get; set; }
    }

    public enum Customers
    {
        Customer_ID = 1,
        Company_Name = 2,
        Contact_Name = 3
    }
}
