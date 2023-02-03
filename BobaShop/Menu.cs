using System;
namespace BobaShop
{
	public class Menu
	{
		public Menu()
		{
		}

		public int printMenu()
		{
			int[] drinkCategoryId = (int[])Enum.GetValues(typeof(MenuEnum));
			string[] drinkNames = Enum.GetNames(typeof(MenuEnum));

			int n = drinkCategoryId.Length;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Please press {drinkCategoryId[i]} for {drinkNames[i]}");
            }

            Console.WriteLine("Please enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

		public int printMenu(int chosenDrinkCategory)
		{
			int choice = 0;

			if (chosenDrinkCategory == (int)MenuEnum.HotDrinks)
			{
				int[] hotDrinksId = (int[])Enum.GetValues(typeof(HotDrinks));
				string[] hotDrinksNames = Enum.GetNames(typeof(HotDrinks));

				int x = hotDrinksId.Length;

				for (int i = 0; i < x; i++)
				{
					Console.WriteLine($"Please press {hotDrinksId[i]} for {hotDrinksNames[i]}");
				}

				Console.WriteLine("Please enter your choice: ");
			}

			else if (chosenDrinkCategory == (int)MenuEnum.ColdDrinks)
			{
				int[] coldDrinksId = (int[])Enum.GetValues(typeof(ColdDrinks));
				string[] coldDrinksName = Enum.GetNames(typeof(ColdDrinks));

				int y = coldDrinksId.Length;

				for (int i = 0; i < y; i++)
				{
					Console.WriteLine($"Please press {coldDrinksId[i]} for {coldDrinksName[i]}");
				}

				Console.WriteLine("Please enter your choice: ");
			}

			choice = Convert.ToInt32(Console.ReadLine());
            return choice;
		}
	}
}

