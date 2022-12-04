//порушено принцип розділення інтерфейсу
interface IApplyDiscount
{
    void ApplyDiscount(string discount);
    void ApplyPromocode(string promocode);
}
interface ISetPrice
{
    void SetPrice(double price);
}

interface ISetDescription
{
    void SetColor(byte color);
    void SetSize(byte size);
}

class Book
{
    double BookPrice;
    string BookDiscount;
    string BookPromocode;
    
    void Price(ISetPrice price)
    {
        price.SetPrice(BookPrice);
    }
    void Discount(IApplyDiscount discount)
    {
        discount.ApplyDiscount(BookDiscount);
    }
    void Promocode(IApplyDiscount promocode)
    {
        promocode.ApplyPromocode(BookPromocode);
    }
}

class Clothes
{
    byte ClothesSize;
    byte ClothesColor;
    private string ClothesDiscount;
    string ClothesPromocode;
    
    void Size(ISetDescription size)
    {
        size.SetSize(ClothesSize);
    }
    void Color(ISetDescription color)
    {
        color.SetColor(ClothesColor);
    }
    void Discount(IApplyDiscount discount)
    {
        discount.ApplyDiscount(ClothesDiscount);
    }
    void Promocode(IApplyDiscount promocode)
    {
        promocode.ApplyPromocode(ClothesPromocode);
    }
}