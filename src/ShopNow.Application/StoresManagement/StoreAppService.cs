using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using ShopNow.StoresManagement.Dtos;
using ShopNow.StoresManagement.Stores;
using System;
using System.Threading.Tasks;

namespace ShopNow.StoresManagement
{
    internal class StoreAppService : AsyncCrudAppService<Store, GetStoreDto, Guid, PagedStoreResultRequestDto, CreateStoreDto, UpdateStoreDto>, IStoreAppService
    {
        public StoreAppService(IRepository<Store, Guid> repository) : base(repository)
        {
        }

        public override Task<GetStoreDto> CreateAsync(CreateStoreDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<Guid> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<GetStoreDto>> GetAllAsync(PagedStoreResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<GetStoreDto> GetAsync(EntityDto<Guid> input)
        {
            return base.GetAsync(input);
        }

        public override Task<GetStoreDto> UpdateAsync(UpdateStoreDto input)
        {
            return base.UpdateAsync(input);
        }

        protected override Task<Store> GetEntityByIdAsync(Guid id)
        {
            return base.GetEntityByIdAsync(id);
        }
    }
}
