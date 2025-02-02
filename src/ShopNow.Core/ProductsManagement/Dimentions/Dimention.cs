using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopNow.ProductsManagement.Dimentions
{
    [Table("Dimentions", Schema = "Dimention")]
    public class Dimention : FullAuditedEntity<Guid>
    {
        public string Length {  get; set; }
        public string Width {  get; set; }
        public string Height { get; set; }
    }
}
