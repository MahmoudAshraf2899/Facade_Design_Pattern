namespace Facade_DesignPattern.Services
{
    public class Inventory
    {
        public bool CheckItemQuantity(string itemID, double quantity)
        {
            return quantity < 100;
        }
    }
}
