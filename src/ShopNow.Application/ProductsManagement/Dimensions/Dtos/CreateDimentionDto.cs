using Abp.AutoMapper;
using ShopNow.ProductsManagement.Dimentions;

namespace ShopNow.ProductsManagement.Dimensions.Dtos
{
    [AutoMapTo(typeof(Dimention))]
    public class CreateDimentionDto
    {
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
    }
}
