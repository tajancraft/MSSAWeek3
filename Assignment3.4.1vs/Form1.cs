using System.ComponentModel;

namespace Assignment3._4._1vs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Coffee> coffee = new List<Coffee>();
            coffee.Add(item: new Coffee() { Id = "1", Name = "Starbucks", Price = "9.99", Size = "32" });
            coffee.Add(item: new Coffee() { Id = "2", Name = "Seattle's Best", Price = "8.99", Size = "32" });
            coffee.Add(item: new Coffee() { Id = "3", Name = "Dunkin", Price = "7.99", Size = "32" });

            var bindingList = new BindingList<Coffee>(coffee);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
    }
}

abstract class Beverage
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
    public string Size { get; set; }

    public abstract string GetDescription();

}
class Coffee : Beverage
{
    public bool Milk { get; set; }
    public override string GetDescription()
    {
        return $"I love my coffee with 2% milk";
    }
}