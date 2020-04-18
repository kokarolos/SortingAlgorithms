using System;
using System.Collections.Generic;

namespace StrategyAssignment
{
	public class BucketSort :SortingMethod
	{
		public override void Sort(TShirt[] tShirts, Func<TShirt, TShirt, bool> IsSwappable)
		{
			SortColorAsc(tShirts);
		}

		public  static void SortColorAsc(TShirt[] tShirts)
		{
			var minValue = tShirts[0].Color;
			var maxValue = tShirts[0].Color;

			for (int i = 1; i < tShirts.Length; i++)
			{
				if (tShirts[i].Color > maxValue)
					maxValue = tShirts[i].Color;
				if (tShirts[i].Color < minValue)
					minValue = tShirts[i].Color;
			}
			List<TShirt>[] bucket = new List<TShirt>[maxValue - minValue + 1];
			for (int i = 0; i < bucket.Length; i++)
			{
				bucket[i] = new List<TShirt>();
			}

			for (int i = 0; i < tShirts.Length; i++)
			{
				bucket[tShirts[i].Color - minValue].Add(tShirts[i]);
			}

			int k = 0;
			for (int i = 0; i < bucket.Length; i++)
			{
				if (bucket[i].Count > 0)
				{
					for (int j = 0; j < bucket[i].Count; j++)
					{
						tShirts[k] = bucket[i][j];
						k++;
					}
				}
			}
		}
	}
}
