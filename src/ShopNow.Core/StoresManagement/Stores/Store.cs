using Abp.Domain.Entities.Auditing;
using ShopNow.ProductsManagement.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopNow.StoresManagement.Stores
{
    [Table("stores" , Schema = "Store")]
    public class Store : FullAuditedEntity<Guid>
    {
        public string Name {  get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
