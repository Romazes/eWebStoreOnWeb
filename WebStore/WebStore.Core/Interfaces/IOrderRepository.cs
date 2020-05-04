using WebStore.Core.Entities;

namespace WebStore.Core.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
