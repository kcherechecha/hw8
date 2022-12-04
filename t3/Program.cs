// порушено принцип підстановки Лісков
class Rectangle 
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public int GetArea()
    {
        return Width * Height;
    }
}
//квадрат наслідується від прямокутника!!! (якщо це не обовʼязково - створюємо інтерфейс і наслідуємо обидва класи від інтерфейсу -> оверрайд метод інтфейсу обчислення площі)
class Square : Rectangle
{
    public override int Width
    {
        get { return base.Width; }
        set { base.Width = value; }
    }
    public override int Height
    {
        get { return base.Height; }
        set { base.Height = value; }
    }
}

class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Width = 5;
            square.Height = 5;
            Console.WriteLine(square.GetArea());
            Console.ReadKey();
        }
    }