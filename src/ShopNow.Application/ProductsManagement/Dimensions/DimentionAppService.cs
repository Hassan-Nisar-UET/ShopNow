using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using ShopNow.ProductsManagement.Dimensions.Dtos;
using ShopNow.ProductsManagement.Dimentions;
using System;
using System.Threading.Tasks;

namespace ShopNow.ProductsManagement.Dimensions
{
    internal class DimentionAppService : AsyncCrudAppService<Dimention, GetDimentionDto, Guid, PagedDimentionResultRequestDto, CreateDimentionDto, UpdateDimentionDto>, IDimentionAppService
    {
        public DimentionAppService(IRepository<Dimention, Guid> repository) : base(repository)
        {
        }

        public override Task<GetDimentionDto> CreateAsync(CreateDimentionDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<Guid> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<GetDimentionDto>> GetAllAsync(PagedDimentionResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<GetDimentionDto> GetAsync(EntityDto<Guid> input)
        {
            return base.GetAsync(input);
        }

        public override Task<GetDimentionDto> UpdateAsync(UpdateDimentionDto input)
        {
            return base.UpdateAsync(input);
        }

        protected override Task<Dimention> GetEntityByIdAsync(Guid id)
        {
            return base.GetEntityByIdAsync(id);
        }
    }
}
