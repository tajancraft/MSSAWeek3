/*
Create an abstract base class to represent “Beverage” and inherit “Coffee” class from it. 
Create a list ( you may use List class) of coffees. 
Design windows form application to display the list of coffees in grid and perform add/ delete.

Keep some base properties in Beverage class which can be inherited in Coffee. 
Inherited class can have more specific properties. Properties are customizable as needed.
*/

abstract class Beverage
{
    public int Id {get; set;}
    public string Name {get; set;}
    public decimal Price {get; set;}
    public int Size {get; set;}

    public abstract string GetDescription();
    
}
class Coffee : Beverage
{
    public bool Milk {get; set;}
    public override string GetDescription()
    {
        return $"I love my coffee with 2% milk";
    }
}
