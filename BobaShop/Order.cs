using System;
using System.Xml.Linq;

namespace BobaShop
{
	public abstract class Order
	{
        public int subChoice { get; set; }
        public int ItemNum { get; set; }
        public Products p;
        public abstract void orderDrinks();
        public abstract void orderDrinks(int choice);
        //Abstraction
    }

    public class HotDrinksOrderDetail : Order
    {
        public HotDrinksOrderDetail() { }

        public HotDrinksOrderDetail(int itemnum, Products p)
        { 
            ItemNum = itemnum;
            p = new Products();
        }

        public override void orderDrinks()
        {
            Console.WriteLine("Now you're entering hot drinks menu...");
        }

        public override void orderDrinks(int subchoice)
        {
            p = new Products();

            Console.WriteLine("Please enter how many drinks? ");
            ItemNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your total Price is {ItemNum * p.getHotDrinkPrice()[Enum.GetName(typeof(HotDrinks),subchoice)]}");

            Console.WriteLine("Thank you for shopping with us :)");
        }

    }


    public class ColdDrinksOrderDetail : Order
    {
        public ColdDrinksOrderDetail() { }

        public ColdDrinksOrderDetail(int itemnum, Products p)
        {
            ItemNum = itemnum;
            p = new Products();
        }

        public override void orderDrinks()
        {
            Console.WriteLine("Now you're entering cold drinks menu...");
        }

        public override void orderDrinks(int subchoice)
        {
            p = new Products();

            Console.WriteLine("Please enter how many drinks? ");
            ItemNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your total Price is {ItemNum * p.getColdDrinkPrice()[Enum.GetName(typeof(ColdDrinks),subchoice)]}");

            Console.WriteLine("Thank you for shopping with us :)");
        }
    }
}

