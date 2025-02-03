using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ShopNow.StoresManagement.Stores;
using System;

namespace ShopNow.StoresManagement.Dtos
{
    [AutoMapTo(typeof(Store))]
    public class UpdateStoreDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
