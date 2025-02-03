using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ShopNow.StoresManagement.Stores;
using System;

namespace ShopNow.StoresManagement.Dtos
{
    [AutoMapFrom(typeof(Store))]
    public class GetStoreDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
