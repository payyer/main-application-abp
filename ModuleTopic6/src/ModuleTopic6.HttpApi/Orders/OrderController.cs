using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace ModuleTopic6.Orders
{
    [Area(ModuleTopic6RemoteServiceConsts.ModuleName)]
    //[RemoteService(Name = ModuleTopic6RemoteServiceConsts.RemoteServiceName)]
    [RemoteService(Name = "ModuleTopic6")]
    [Route("api/order/")]
    public class OrderController : AbpController
    {
        private readonly IOrderAppService _orderAppService;
        public OrderController(IOrderAppService orderAppService)
        {
            _orderAppService = orderAppService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<OrderDto> CreateOrderAsync(OrderDto orderDto)
        {
            return await _orderAppService.CreateOrderAsync(orderDto);
        }

        [HttpDelete]
        [Route("delete/{orderId}")]
        public async Task DeleteOrderByIdAsync(Guid orderId)
        {
            await _orderAppService.DeleteOrderByIdAsync(orderId);
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<OrderDto>> GetListOrderAsync()
        {
            return await _orderAppService.GetListOrderAsync();
        }

        [HttpGet]
        [Route("{orderId}")]
        public async Task<OrderDto> GetOrderByIdAsync(Guid orderId)
        {
           return await _orderAppService.GetOrderByIdAsync(orderId);
        }

        [HttpPut]
        [Route("update/{orderId}")]
        public async Task<OrderDto> UpdateOrderByIdAsync(Guid orderId, OrderDto orderDto)
        {
            return await _orderAppService.UpdateOrderByIdAsync(orderId, orderDto);
        }
    }
}
