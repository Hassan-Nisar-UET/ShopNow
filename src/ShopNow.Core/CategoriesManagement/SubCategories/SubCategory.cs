using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopNow.CategoriesManagement.SubCategories
{
    [Table("SubCategories" , Schema = "SubCategory")]
    public class SubCategory : FullAuditedEntity<Guid>
    {
        public string Name {  get; set; }
        public string Description { get; set; }
    }
}
