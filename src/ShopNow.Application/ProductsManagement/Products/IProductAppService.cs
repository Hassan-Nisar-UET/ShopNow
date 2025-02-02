using Abp.Application.Services;
using ShopNow.ProductsManagement.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.ProductsManagement.Products
{
    public interface IProductAppService : IAsyncCrudAppService<GetProductDto, Guid, PagedProductResultRequestDto, CreateProductDto, UpdateProductDto>
    {
    }
}
