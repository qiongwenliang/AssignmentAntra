using System;
namespace BobaShop;

public class Dashboard
{
	Menu menu;
	OrderFactory of;

	public Dashboard()
	{
		menu = new Menu();
		of = new OrderFactory();
    }

	public void run()
	{
		int categoryChoice = menu.printMenu();
        Order o = of.CategoryChoice(categoryChoice);
        o.orderDrinks();
        int drinkChoice = menu.printMenu(categoryChoice);
		Order o1 = of.DetailChoice(drinkChoice);
		o1.orderDrinks(drinkChoice);
		//here printMenu and orderDrinks are using Polymorphism method overloading

	}
}


