//порушено принцип єдиного обовʼязку
class Item
{

}
class ItemsStorage
{
    private List<Item> itemList;
    internal List<Item> ItemList
    {
        get
        {
            return itemList;
        }
        set
        {
            itemList = value;
        }
    }

    public void AddItem(Item item) {/*...*/}
    public void DeleteItem(Item item) {/*...*/}
}

class GetItemsInfo
{
    public void GetItems(ItemsStorage items) {/*...*/}
    public void GetItemCount(ItemsStorage items) {/*...*/}
}

class CalculateOrderTotalSum
{
    public void CalculateTotalSum(ItemsStorage items) {/*...*/}
}

class DeleteOrder
{
    public void Delete() {/*...*/}
}

class UpdateOrder
{
    public void Update() {/*...*/}
}

class ShowTheOrder
{
    public void ShowOrder() {/*...*/}
}

class PrintTheOrder
{
    public void PrintOrder() {/*...*/}
}

class OrderManager
{
    public void Load() {/*...*/}
    public void Save() {/*...*/}
}