using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
namespace ModuleTopic6.OrderLists
{
    public partial interface IOrderListAppService : IApplicationService
    {
        Task<OrderListDto> CreateOrderListAsync(OrderListDto orderListDto);
        Task DeleteOrderList(Guid orderId);

        Task DeleteOrderListById(Guid orderListId);

        Task<OrderListDto> GetOrderListByIdAsync(Guid orderListId);
        Task<List<OrderListDto>> GetOrderListsAsync(Guid orderId);
        Task<OrderListDto> UpdateOrderListAsync(Guid orderListId, OrderListDto orderListDto);
    }
}
