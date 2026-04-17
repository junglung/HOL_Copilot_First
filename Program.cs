// 使用 Fruit 類別來計算水果折扣後的價格
Fruit apple = new Fruit { Name = "蘋果", Price = 35, Discount = 0.1 };
Console.WriteLine(apple.Name + "折扣後價格是：" + apple.CalculateDiscountedPrice());

Fruit banana = new Fruit { Name = "香蕉", Price = 20, Discount = 0.2 };
Console.WriteLine(banana.Name + "折扣後價格是：" + banana.CalculateDiscountedPrice());

Fruit orange = new Fruit { Name = "橘子", Price = 25, Discount = 0.15 };
Console.WriteLine(orange.Name + "折扣後價格是：" + orange.CalculateDiscountedPrice());

Fruit watermelon = new Fruit { Name = "西瓜", Price = 50, Discount = 0.25 };
Console.WriteLine(watermelon.Name + "折扣後價格是：" + watermelon.CalculateDiscountedPrice());

//建立一個計算折扣後價格的類別，具有水果名稱、單價、折扣這三個屬性，以及一個計算折扣後價格的方法
class Fruit
{
    public required string Name { get; set; } // 水果名稱
    public required double Price { get; set; } // 單價
    public required double Discount { get; set; } // 折扣

    public double CalculateDiscountedPrice() // 計算折扣後價格的方法
    {
        return Price * (1 - Discount);
    }
}