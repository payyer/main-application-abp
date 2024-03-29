﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ModuleTopic6.Orders
{
    public partial interface IOrderAppService : IApplicationService
    {
        Task<List<OrderDto>> GetListOrderAsync();
        Task<OrderDto> GetOrderByIdAsync(Guid orderId);
        Task<OrderDto> CreateOrderAsync(OrderDto orderDto);
        Task<OrderDto> UpdateOrderByIdAsync(Guid orderId,OrderDto orderDto);
        Task DeleteOrderByIdAsync(Guid orderId );
    }
}
