using System;
namespace ProiectPSSC.Domain.Models
{
	public class Quantity
	{
		public float OrderQuantity { get; }
		public Quantity(float quantity)
		{
			if (IsValid(quantity))
			{
				OrderQuantity = quantity;
			}
			else
				throw new InvalidatedOrder("");
		}

		public static Quantity operator +(Quantity a, Quantity b) => new Quantity((a.OrderQuantity + b.OrderQuantity));

		private static bool IsValid(float x) => x > 0 && x < 50;

	}
}

