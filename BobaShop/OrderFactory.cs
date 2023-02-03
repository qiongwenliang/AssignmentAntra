using System;
namespace BobaShop
{
	public class OrderFactory
	{
		public OrderFactory()
		{
		}

		public Order CategoryChoice(int cateChoice)
		{
            switch (cateChoice)
            {
                case (int)MenuEnum.HotDrinks:
                    return new HotDrinksOrderDetail();
                case (int)MenuEnum.ColdDrinks:
                    return new ColdDrinksOrderDetail();
            }
            return null;
        }

        public Order DetailChoice(int subChoice)
        {
            switch (subChoice)
            {
                case (int)HotDrinks.MatchaLatte:
                    return new HotDrinksOrderDetail();
                case (int)HotDrinks.SoyMilkLatte:
                    return new HotDrinksOrderDetail();
                case (int)HotDrinks.TaroBobaTea:
                    return new HotDrinksOrderDetail();
                case (int)ColdDrinks.MangoBobaTea:
                    return new ColdDrinksOrderDetail();
                case (int)ColdDrinks.PinappleCocoBoba:
                    return new ColdDrinksOrderDetail();
                case (int)ColdDrinks.StrawberryMilkShake:
                    return new ColdDrinksOrderDetail();
            }
            return null;
        }
	}
}

