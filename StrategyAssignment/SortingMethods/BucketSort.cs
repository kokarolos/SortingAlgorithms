using System;
using System.Collections.Generic;

namespace StrategyAssignment
{
	public class BucketSort :SortingMethod
	{
		public override void Sort(TShirt[] tShirts, Func<TShirt, TShirt, bool> IsSwappable)
		{
			//TODO
			throw new NotImplementedException();
		}

		public static void Sorting(TShirt[] data)
		{
			int minValue = (int)data[0].Color;
			int maxValue = (int)data[0].Color;

			for (int i = 1; i < data.Length; i++)
			{
				if ((int)data[i].Color > maxValue)
					maxValue = (int)data[i].Color;
				if ((int)data[i].Color < minValue)
					minValue = (int)data[i].Color;
			}

			List<TShirt>[] bucket = new List<TShirt>[maxValue - minValue + 1];

			for (int i = 0; i < bucket.Length; i++)
			{
				bucket[i] = new List<TShirt>();
			}

			for (int i = 0; i < data.Length; i++)
			{
				bucket[(int)data[i].Color - minValue].Add(data[i]);
			}

			int k = 0;
			for (int i = 0; i < bucket.Length; i++)
			{
				if (bucket[i].Count > 0)
				{
					for (int j = 0; j < bucket[i].Count; j++)
					{
						data[k] = bucket[i][j];
						k++;
					}
				}
			}
		}


	}
}
