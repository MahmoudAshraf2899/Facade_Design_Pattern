
using Facade_DesignPattern.Services;

BasketItem basketItem = new BasketItem();
basketItem.ItemID = "123";
basketItem.ItemPrice = 50;
basketItem.Quantity = 3;


BasketItem basketItem2 = new BasketItem();
basketItem.ItemID = "124";
basketItem.ItemPrice = 60;
basketItem.Quantity = 2;


BasketItem basketItem3 = new BasketItem();
basketItem.ItemID = "125";
basketItem.ItemPrice = 140;
basketItem.Quantity = 1;

ShoppingBasket shoppingBasket = new ShoppingBasket();
shoppingBasket.AddItem(basketItem);
shoppingBasket.AddItem(basketItem2);
shoppingBasket.AddItem(basketItem3);
PurchaseOrder purchaseOrder = new PurchaseOrder();
purchaseOrder.CreateOrder(shoppingBasket, "Mahmoud");