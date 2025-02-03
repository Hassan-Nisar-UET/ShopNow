using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ShopNow.ProductsManagement.Dimentions;
using System;

namespace ShopNow.ProductsManagement.Dimensions.Dtos
{
    [AutoMapFrom(typeof(Dimention))]
    public class GetDimentionDto : EntityDto<Guid>
    {
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
    }
}
