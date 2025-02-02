using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopNow.CategoriesManagement.Categories
{
    [Table("Categories",Schema = "Category")]
    public class Category : FullAuditedEntity<Guid>
    {
        public string Name {  get; set; }
        public string Description { get; set; }
    }
}
