//using System;
//namespace BobaShop
//{
//	public class Products
//	{
//		IDictionary<string, int> hotDrinks;
//		IDictionary<string, int> coldDrinks;
//		public Products()
//		{
//			hotDrinks = new Dictionary<string, int>()
//			{ { "MatchaLatte", 4 }, { "TaroBobaTea", 6 }, {"SoyMilkLatte", 5} };

//			coldDrinks = new Dictionary<string, int>()
//			{{"MangoBobaTea", 6}, {"StrawberryMilkShake", 7}, {"PinappleCocoBoba", 8} };
//		}

//		public int getHotDrinkPrice(int drinkChoice)
//		{
//			string name = Enum.GetName(typeof(HotDrinks), drinkChoice);
//			return hotDrinks[name];
//		}

//		public int getColdDrinkPrice(int drinkChoice)
//		{
//			string name = Enum.GetName(typeof(ColdDrinks), drinkChoice);
//			return coldDrinks[name];
//		}

//	}
//}

using System;

namespace BobaShop;

public class Products
{
    public Products() { }

    public Dictionary<string, int> getHotDrinkPrice()
    {
        return new Dictionary<string, int>()
        {
            { "MatchaLatte", 4 }, { "TaroBobaTea", 6 }, {"SoyMilkLatte", 5}
        };
    }

    public Dictionary<string, int> getColdDrinkPrice()
    {
        return new Dictionary<string, int>()
        {
            {"MangoBobaTea", 6}, {"StrawberryMilkShake", 7}, {"PinappleCocoBoba", 8}
        };
    }
}