using NWind.Models;

public class RepositoryOrders
{
    public NorthwindContext _context;
    public RepositoryOrders(NorthwindContext context)
    {
        _context = context;
    }
    public List<int> GetOrders()
    {
        List<int> OrdfersIds = (from o in _context.Orders select o.OrderId).ToList();
        return OrdfersIds;
    }
    public Order PutOrder(int id)
    {
        Console.WriteLine($"searching id: {id}");
        Order order = _context.Orders.Find(id);
        return order;
    }
    public List<OrderDetail> FindOrderByOrderId(int id)
    {
        Order order = _context.Orders.Find(id);
        return order.OrderDetails.ToList();
    }
}
