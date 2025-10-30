// OrderFacade.cs - Implementación del patrón FACADE
public class OrderFacade
{
    private readonly InventoryService _inventoryService;
    private readonly PaymentService _paymentService;
    private readonly ShippingService _shippingService;

    public OrderFacade()
    {
        _inventoryService = new InventoryService();
        _paymentService = new PaymentService();
        _shippingService = new ShippingService();
    }

    public void ProcessOrder(string productId, string customerId, decimal amount, string address)
    {
        if (_inventoryService.CheckStock(productId) && _paymentService.ProcessPayment(customerId, amount))
        {
            _shippingService.ShipProduct(productId, address);
        }
    }
}