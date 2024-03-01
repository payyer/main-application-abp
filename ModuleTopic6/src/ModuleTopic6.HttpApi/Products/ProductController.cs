using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace ModuleTopic6.Products
{
    [Area(ModuleTopic6RemoteServiceConsts.ModuleName)]
    [RemoteService(Name = "ModuleTopic6")]
    [Route("api/product/")]
    public class ProductController : AbpController
    {
        private readonly IProductAppService _productAppService;
        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [Route("create")]
        [HttpPost]
        public async Task<ProductDto> CreateProductAsync(ProductDto productDto)
        {
            return await _productAppService.CreateProductAsync(productDto);
        }

        [Route("delete/{productId}")]
        [HttpDelete]
        public async Task DeleteProductAsync(Guid productId)
        {
            await _productAppService.DeleteProductAsync(productId);
        }

        [Route("detail/{productId}")]
        [HttpGet]
        public async Task<ProductDto> GetProductByIdAsync(Guid productId)
        {
            return await _productAppService.GetProductByIdAsync(productId);
        }

        [Route("list")]
        [HttpGet]
        public async Task<List<ProductDto>> GetProductListAsync()
        {
            return await _productAppService.GetProductListAsync();
        }

        [Route("update/{productId}")]
        [HttpPut]
        public async Task<ProductDto> UpdateProductAsync(Guid productId, ProductDto productDto)
        {
            return await _productAppService.UpdateProductAsync(productId, productDto);
        }
    }
}
