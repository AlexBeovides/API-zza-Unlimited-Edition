using System;

public class Order
{
    public int OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public List<Pizza> Pizzas { get; set; }
    public decimal TotalAmount { get; set; }
    
}
