using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopNow.CategoriesManagement.SubSubCatogries
{
    [Table("SubSubCategories", Schema = "SubSubCategory")]
    public class SubSubCategory : FullAuditedEntity<Guid>
    {
        public string Name {  get; set; }
        public string Description { get; set; }
    }
}
