namespace Facade_DesignPattern.Services
{
    public class PurchaseOrder
    {
        public bool CreateOrder(ShoppingBasket basket, string customerInfo)
        {

            //Check Stock In Inventory
            bool isAvailable = true;
            Inventory inventory = new Inventory();
            foreach (var item in basket.GetItems())//Loop On Items In Basket And Check If It available Or Not At Inventory
            {
                if (!inventory.CheckItemQuantity(item.ItemID, item.Quantity))
                    isAvailable = false;
            }
            //If All Items In Basket Are Available At Inventory So Continue Your Cycle
            if (isAvailable)
            {
                //Create Inventory Order
                InventoryOrder inventoryOrder = new InventoryOrder();
                inventoryOrder.CreateOrder(basket, "123");

                //Create Invoice
                PurchaseInvoice purchaseInvoice = new PurchaseInvoice();
                var invoice = purchaseInvoice.CreateInvoice(basket, customerInfo);

                //Payment
                PaymentProcessor payment = new PaymentProcessor();
                payment.HandlePayment(invoice.netTotal, "acc=1234512");
                //Send Sms
                SmsNotifications sms = new SmsNotifications();
                sms.SendSms("123", "Invoice Created");

                return true;

            }
            return false;

        }
    }
}
