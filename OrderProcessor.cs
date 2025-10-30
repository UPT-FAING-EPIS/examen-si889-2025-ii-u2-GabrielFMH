// OrderProcessor.cs - Refactorizado con patrón FACADE
public class OrderProcessor
{
    private readonly OrderFacade _orderFacade;

    public OrderProcessor()
    {
        _orderFacade = new OrderFacade();
    }

    public void ProcessOrder(string productId, string customerId, decimal amount, string address)
    {
        _orderFacade.ProcessOrder(productId, customerId, amount, address);
    }
}