using System;
namespace ProiectPSSC.Domain.Models
{
	public class Price
	{
		public float OrderPrice { get; }
		public Price(float price)
		{
			if (IsValid(price))
			{
				OrderPrice = price;
			}
			else
				throw new InvalidatedOrder("");
		}

		public static Price operator *(Price a, Quantity b) => new Price((a.OrderPrice * b.OrderQuantity));

		private static bool IsValid(float x) => x > 0;
	}
}

