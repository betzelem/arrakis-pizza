namespace new_pizza_delivery.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; }
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Anchovies { get; set; }
        public bool Mushrooms { get; set; }
        public bool Pineapple { get; set; }
        public bool Beef { get; set;}
        public float FinalPrice { get; set; }
    }
}