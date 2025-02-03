using Abp.AutoMapper;
using ShopNow.StoresManagement.Stores;

namespace ShopNow.StoresManagement.Dtos
{
    [AutoMapTo(typeof(Store))]
    public class CreateStoreDto
    {
        public string Name { get; set; }
    }
}
