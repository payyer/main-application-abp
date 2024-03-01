using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace ModuleTopic6.OrderLists
{
    [Area(ModuleTopic6RemoteServiceConsts.ModuleName)]
    [RemoteService(Name = "ModuleTopic6")]
    [Route("api/orderlist/")]
    public class OrderListController : AbpController
    {
        private readonly IOrderListAppService _orderListAppService;
        public OrderListController(IOrderListAppService orderListAppService)
        {
            _orderListAppService = orderListAppService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<OrderListDto> CreateOrderListAsync(OrderListDto orderListDto)
        {
            return await _orderListAppService.CreateOrderListAsync(orderListDto);
        }
        [HttpDelete]
        [Route("delete-by-orderId/{orderId}")]
        public async Task DeleteOrderList(Guid orderId)
        {
            await _orderListAppService.DeleteOrderList(orderId);
        }

        [HttpDelete]
        [Route("delete-by-orderListId{orderListId}")]
        public async Task DeleteOrderListById(Guid orderListId)
        {
            await _orderListAppService.DeleteOrderListById(orderListId);
        }

        [HttpGet]
        [Route("get-by-orderListId/{orderListId}")]
        public async Task<OrderListDto> GetOrderListByIdAsync(Guid orderListId)
        {
            return await _orderListAppService.GetOrderListByIdAsync(orderListId);
        }
        [HttpGet]
        [Route("get-by-orderId/{orderId}")]
        public async Task<List<OrderListDto>> GetOrderListsAsync(Guid orderId)
        {
            return await _orderListAppService.GetOrderListsAsync(orderId);
        }
        [HttpPut]
        [Route("update/{orderListId}")]
        public async Task<OrderListDto> UpdateOrderListAsync(Guid orderListId, OrderListDto orderListDto)
        {
            return await _orderListAppService.UpdateOrderListAsync(orderListId, orderListDto);
        }
    }
}
