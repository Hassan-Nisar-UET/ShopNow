using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using ShopNow.ProductsManagement.Products.Dtos;
using System;
using System.Threading.Tasks;

namespace ShopNow.ProductsManagement.Products
{
    public class ProductAppService : AsyncCrudAppService<Product, GetProductDto, Guid, PagedProductResultRequestDto, CreateProductDto, UpdateProductDto>, IProductAppService
    {
        public ProductAppService(IRepository<Product, Guid> repository) : base(repository)
        {
        }

        public override Task<GetProductDto> CreateAsync(CreateProductDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<Guid> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<GetProductDto>> GetAllAsync(PagedProductResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<GetProductDto> GetAsync(EntityDto<Guid> input)
        {
            return base.GetAsync(input);
        }

        public override Task<GetProductDto> UpdateAsync(UpdateProductDto input)
        {
            return base.UpdateAsync(input);
        }

        protected override Task<Product> GetEntityByIdAsync(Guid id)
        {
            return base.GetEntityByIdAsync(id);
        }
    }
}
